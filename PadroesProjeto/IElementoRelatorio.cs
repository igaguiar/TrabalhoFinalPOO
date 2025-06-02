using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public interface IElementoRelatorio
    {
        void Escrever(Document doc, int nivel = 0);
    }
}
