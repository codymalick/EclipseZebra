using Com.SharpZebra;
using System.Collections.Generic;
using Com.SharpZebra.Commands;
using Com.SharpZebra.Printing;
using EclipseZebra.Model;
using System.Linq;

public class RawPrinterHelper
{
    public static void print(Patient patient, string printer_name)
    {
        Com.SharpZebra.Printing.PrinterSettings ps = new Com.SharpZebra.Printing.PrinterSettings();
        ps.PrinterName = printer_name;
        ps.Width = 203 * 4;
        ps.Length = 203 * 1;
        ps.Darkness = 30;

        int start_write = ps.Width / 5;
        int location = 25;

        List<byte> page = new List<byte>();
        page.AddRange(EPLCommands.ClearPrinter(ps));
        page.AddRange(EPLCommands.TextWrite(start_write, location, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, (patient.firstName + " " + patient.lastName), ps));

        //Increment location to start printing appointments
        location += 30;

        for(int i = 0; i <= patient.appointments.Count; i++)
        {
            if(patient.appointments.Count-1 >= i)
                page.AddRange(EPLCommands.TextWrite(start_write, location, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[i].ToShortDateString() + " @ " + patient.appointments[i].ToShortTimeString(), ps));
            
            //increment location by 30
            location += 25;

            //check for 0 to prevent incorrect spacing
            if ((i+1) % 5 == 0 && i != 0)
                location += 80;
        }

        switch (patient.appointments.Count % 5) {

            case 4:
                location += 60;
                break;
            case 0:
                location += 35;
                break;
            default:
                break;
        }

        //if(patient.appointments.Count % 3 == 1)
        //{
        //    location += 60;
        //}
        //decrement location to fit patient reminder
        location -= 25;

        //Print patient reminder
        //Increment by 25
        page.AddRange(EPLCommands.TextWrite(start_write, location, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "Please call if you are", ps));
        page.AddRange(EPLCommands.TextWrite(start_write, location+22, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "unable to make your", ps));
        page.AddRange(EPLCommands.TextWrite(start_write, location+44, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "appointments", ps));

        page.AddRange(EPLCommands.PrintBuffer(1));
        new SpoolPrinter(ps).Print(page.ToArray());
    }
}