using System;
using System.Windows.Forms;

namespace PdfViewer_HelloWorld
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormBuildPassedPdfDocument());
            Application.Run(new Form1());
        }
    }
}
