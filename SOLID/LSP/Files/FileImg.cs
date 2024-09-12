using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Files
{
    public class FileImg : Files
    {
        public override string Open()
        {
            return "Imagem aberta.";
        }

        public override string Close()
        {
            return "Imagem fechada.";
        }
    }
}
