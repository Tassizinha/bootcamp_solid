using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SemLSP.File
{
    public class FileCorrupt : File
    {
        public override string Open()
        {
            throw new Exception("Erro: O arquivo está corrompido e não pode ser aberto.");
        }

        public override string Close()
        {
            return "Não é possível fechar um arquivo corrompido.";
        }
    }
}
