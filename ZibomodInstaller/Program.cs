using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ZibomodInstaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string SevenZipSharp = "ZibomodInstaller.SevenZipSharp.dll";
            string IonicZip = "ZibomodInstaller.Ionic.Zip.dll";
            EmbeddedAssembly.Load(SevenZipSharp, "SevenZipSharp.dll");
            EmbeddedAssembly.Load(IonicZip, "Ionic.Zip.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }

    }
}
