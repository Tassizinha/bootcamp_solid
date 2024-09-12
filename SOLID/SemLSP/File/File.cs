using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SemLSP.File
{
    public class File
    {
        public virtual string Open()
        {
            return "Arquivo aberto.";
        }

        public virtual string Close()
        {
            return "Arquivo fechado.";
        }
    }
}