using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Files
{
    public class Files
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
