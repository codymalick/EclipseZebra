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

public class RawPrinterHelper
{
    public static void print(string patient_name, string printer_name)
    {
        Com.SharpZebra.Printing.PrinterSettings ps = new Com.SharpZebra.Printing.PrinterSettings();
        ps.PrinterName = printer_name;
        ps.Width = 203 * 4;
        ps.Length = 203 * 1;
        ps.Darkness = 30;

        List<byte> page = new List<byte>();
        page.AddRange(EPLCommands.ClearPrinter(ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 3, 10, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, patient_name, ps));
        page.AddRange(EPLCommands.TextWrite(ps.Width / 3, 50, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_SMALL, 2, 2, false, "test area", ps));
        //page.AddRange(EPLCommands.TextWrite(10, 10, ElementDrawRotation.NO_ROTATION, ZebraFont.STANDARD_NORMAL, 30, 30, false, "Hello World!", ps));


        page.AddRange(EPLCommands.PrintBuffer(1));
        new SpoolPrinter(ps).Print(page.ToArray());
    }
}