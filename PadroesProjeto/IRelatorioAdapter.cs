using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public interface IRelatorioAdapter
    {
        void GerarRelatorio(List<Turma> turmas);
    }
}
