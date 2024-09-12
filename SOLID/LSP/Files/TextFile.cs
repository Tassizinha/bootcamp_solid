using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Files
{
    public class TextFile : Files
    {
        public override string Open()
        {
            return "Arquivo de texto aberto.";
        }

        public override string Close()
        {
            return "Arquivo de texto fechado.";
        }
    }
}
