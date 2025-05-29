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
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO
{
    public partial class FrmAlunosPorTurma : Form, IAlunosPorTurmaView
    {
        private TurmaController _controller;
        public FrmAlunosPorTurma(TurmaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        public ComboBox ComboTurma => comboTurma;
        public DataGridView DataGridViewAlunos => dgvAlunos;

        public void SetController(TurmaController controller)
        {
            _controller = controller;
        }

        private void FrmAlunosPorTurma_Load(object sender, EventArgs e)
        {
            comboTurma.DataSource = null;
            comboTurma.DataSource = _controller.GetTurmas();
            comboTurma.DisplayMember = "Nome";
            comboTurma.ValueMember = "Id";

            dgvAlunos.Columns.Clear();
            dgvAlunos.Columns.Add("Id", "ID");
            dgvAlunos.Columns.Add("Nome", "Nome");
        }

        private void comboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            var turmaSelecionada = comboTurma.SelectedItem as Turma;
            if (turmaSelecionada != null)
            {
                _controller.ListarAlunosPorTurma(turmaSelecionada, dgvAlunos);
            }
        }

        public interface IAlunosPorTurmaView
        {
            ComboBox ComboTurma { get; }
            DataGridView DataGridViewAlunos { get; }
            void SetController(TurmaController controller);
        }
    }
}
