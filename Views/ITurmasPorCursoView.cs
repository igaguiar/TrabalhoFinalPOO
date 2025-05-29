using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;

namespace TrabalhoFinalPOO.Views
{
    public interface ITurmasPorCursoView
    {
        ComboBox ComboCurso { get; }
        DataGridView DataGridViewTurmas { get; }
        void SetController(TurmaController controller);
    }
}
