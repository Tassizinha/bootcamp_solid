using SOLID.LSP.Files;
using SOLID.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile textFile = new TextFile();
            FileImg imageFile = new FileImg();

            ManageFiles.Manage(textFile);
            ManageFiles.Manage(imageFile);
            Console.ReadLine();
        }       
    }
}
