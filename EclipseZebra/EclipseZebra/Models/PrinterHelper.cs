using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
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

        List<byte> page = new List<byte>();
        page.AddRange(EPLCommands.ClearPrinter(ps));
        page.AddRange(EPLCommands.TextWrite(start_write, 10, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, (patient.firstName + " " + patient.lastName), ps));
        if(patient.appointments.Count-1 >= 0)
            page.AddRange(EPLCommands.TextWrite(start_write, 40, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[0].ToShortDateString() + " @ " + patient.appointments[0].ToShortTimeString(), ps));

        if(patient.appointments.Count-1 >= 1)
            page.AddRange(EPLCommands.TextWrite(start_write, 65, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[1].ToShortDateString() + " @ " + patient.appointments[1].ToShortTimeString(), ps));

        if(patient.appointments.Count-1 >= 2)
            page.AddRange(EPLCommands.TextWrite(start_write, 90, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[2].ToShortDateString() + " @ " + patient.appointments[2].ToShortTimeString(), ps));

        page.AddRange(EPLCommands.TextWrite(start_write, 115, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "Please call if you are", ps));
        page.AddRange(EPLCommands.TextWrite(start_write, 140, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "unable to make your", ps));
        page.AddRange(EPLCommands.TextWrite(start_write, 165, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "appointments", ps));

        page.AddRange(EPLCommands.PrintBuffer(1));
        new SpoolPrinter(ps).Print(page.ToArray());
    }
}