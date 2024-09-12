using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.SemLSP.File;
using MyFile = SOLID.LSP.Files.Files;

namespace SOLID.SemLSP
{
    public class ManageFiles
    {
        public static void Manage(MyFile file)
        {
            try
            {
                Console.WriteLine(file.Open());
                Console.WriteLine(file.Close());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}