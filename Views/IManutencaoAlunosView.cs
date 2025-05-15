using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Controllers;

namespace TrabalhoFinalPOO.Views
{
    public interface IManutencaoAlunosView
    {
        void SetController(AlunoController controller);
        string Codigo { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
    }
}
