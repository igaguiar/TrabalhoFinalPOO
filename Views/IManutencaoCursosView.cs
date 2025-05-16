using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;

namespace TrabalhoFinalPOO.Views
{
    public interface IManutencaoCursosView
    {
        void SetController(CursoController controller);
        string Codigo { get; set; }
        string Nome { get; set; }
        string CargaHoraria { get; set; }
        Button BotaoCadastrar { get; set; }
        Button BotaoBuscar { get; set; }
        Button BotaoExcluir { get; set; }
        TextBox TextBoxCodigo { get; set; }
        TextBox TextBoxNome { get; set; }
        TextBox TextBoxCargaHoraria { get; set; }
    }
}
