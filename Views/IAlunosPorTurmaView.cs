using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;

namespace TrabalhoFinalPOO.Views
{
    public interface IAlunosPorTurmaView
    {
        ComboBox ComboTurma { get; }
        DataGridView DataGridViewAlunos { get; }
        void SetController(TurmaController controller);
    }
}
