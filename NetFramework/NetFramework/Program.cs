using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalager;

namespace NetFramework
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        internal static UnitOfWork unitOfWork;
        [STAThread]
        static void Main()
        {
            unitOfWork = new UnitOfWork();
            unitOfWork.Reset();
            unitOfWork.Seed();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoggaIn());
        }
    }
}