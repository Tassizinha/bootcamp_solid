using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.LSP.Files;
using SOLID.SemLSP.File;
using MyFile = SOLID.LSP.Files.Files;



namespace SOLID.LSP
{
    public class ManageFiles
    {
        public static void Manage(MyFile file)
        {
            Console.WriteLine(file.Open());
            Console.WriteLine(file.Close());
        }

        internal static void Manage(FileCorrupt fileCorrupt)
        {
            throw new NotImplementedException();
        }
    }
}
