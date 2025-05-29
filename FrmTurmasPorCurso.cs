using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO
{
    public partial class FrmTurmasPorCurso : Form
    {
        private TurmaController _controller;
        public FrmTurmasPorCurso()
        {
            InitializeComponent();
            comboCurso.SelectedIndexChanged += comboCurso_SelectedIndexChanged;
        }
        public void SetController(TurmaController controller)
        {
            _controller = controller;
        }
        public void CarregarCursos(List<Curso> cursos)
        {
            comboCurso.DataSource = cursos;
            comboCurso.DisplayMember = "Nome"; // Propriedade a ser exibida
            comboCurso.ValueMember = "Id";     // Opcional
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCurso.SelectedItem is Curso cursoSelecionado)
            {
                _controller.ListarTurmasPorCurso(cursoSelecionado, dgvTurmas);
            }
        }
    }
}
