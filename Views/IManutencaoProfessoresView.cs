using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;

namespace TrabalhoFinalPOO.Views
{
    public interface IManutencaoProfessoresView
    {
        void SetController(ProfessorController controller);
        string Codigo { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
        Button BotaoCadastrar { get; set; }
        Button BotaoBuscar { get; set; }
        Button BotaoExcluir { get; set; }
        TextBox TextBoxCodigo { get; set; }
        TextBox TextBoxNome { get; set; }
        TextBox TextBoxCPF { get; set; }
        TextBox TextBoxEmail { get; set; }
    }
}
