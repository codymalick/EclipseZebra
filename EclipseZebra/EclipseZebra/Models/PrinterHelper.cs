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

public class RawPrinterHelper
{
    public static void print(Patient patient, string printer_name)
    {
        Com.SharpZebra.Printing.PrinterSettings ps = new Com.SharpZebra.Printing.PrinterSettings();
        ps.PrinterName = printer_name;
        ps.Width = 203 * 4;
        ps.Length = 203 * 2;
        ps.Darkness = 30;

        List<byte> page = new List<byte>();
        page.AddRange(EPLCommands.ClearPrinter(ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 4, 10, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, (patient.firstName + " " + patient.lastName), ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 4, 50, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[0].ToShortDateString() + " @ " + patient.appointments[0].TimeOfDay.ToString(), ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 4, 90, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[1].ToShortDateString() + " @ " + patient.appointments[1].TimeOfDay.ToString(), ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 4, 130, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient.appointments[2].ToShortDateString() + " @ " + patient.appointments[2].TimeOfDay.ToString(), ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 4, 170, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "Please call if you are unable to make your appointments", ps));
        //page.AddRange(EPLCommands.TextWrite(10, 10, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_NORMAL, 30, 30, false, "Hello World!", ps));


        page.AddRange(EPLCommands.PrintBuffer(1));
        new SpoolPrinter(ps).Print(page.ToArray());
    }
}