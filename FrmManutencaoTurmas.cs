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
using TrabalhoFinalPOO.PadroesProjeto;
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO
{
    public partial class FrmManutencaoTurmas : Form, IManutencaoTurmasView
    {
        TurmaController _controller;
        public FrmManutencaoTurmas()
        {
            InitializeComponent();
        }
        public void SetController(TurmaController controller)
        {
            _controller = controller;

            _controller.AdicionarObserver(new AlertaQuantidadeAlunosObserver());
        }
        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public Turma Turma
        {
            get { return comboTurma.SelectedItem as Turma; }
            set { comboTurma.SelectedItem = value; }
        }
        public int Ano
        {
            get { return int.Parse(txtAno.Text); }
            set { txtAno.Text = value.ToString(); }
        }
        public int Semestre
        {
            get { return int.Parse(comboSemestre.Text); }
            set { comboSemestre.Text = value.ToString(); }
        }
        public int QuantidadeAlunos
        {
            get { return int.Parse(numericQuantidadeAlunos.Text); }
            set { numericQuantidadeAlunos.Text = value.ToString(); }
        }
        public Curso Curso
        {
            get { return comboCurso.SelectedItem as Curso; }
            set { comboCurso.SelectedItem = value; }
        }
        public Professor Professor
        {
            get { return comboProfessor.SelectedItem as Professor; }
            set { comboProfessor.SelectedItem = value; }
        }
        public string NomeAluno
        {
            get { return txtAluno.Text; }
            set { txtAluno.Text = value; }
        }
        public Aluno Aluno
        {
            get { return comboAluno.SelectedItem as Aluno; }
            set { comboAluno.SelectedItem = value; }
        }
        public ComboBox ComboSemestre
        {
            get { return comboSemestre; }
            set { comboSemestre = value; }
        }
        public ComboBox ComboCurso
        {
            get { return comboCurso; }
            set { comboCurso = value; }
        }
        public ComboBox ComboProfessor
        {
            get { return comboProfessor; }
            set { comboProfessor = value; }
        }
        public ComboBox ComboAluno
        {
            get { return comboAluno; }
            set { comboAluno = value; }
        }
        public DataGridView DataGridViewAlunos
        {
            get { return dgvAlunos; }
            set { dgvAlunos = value; }
        }
        public Button BuscarNome
        {
            get { return btnBuscarNome; }
            set { btnBuscarNome = value; }
        }
        public Button BuscarAluno
        {
            get { return btnBuscarAluno; }
            set { btnBuscarAluno = value; }
        }
        public Button AdicionarAluno
        {
            get { return btnAdicionarAluno; }
            set { btnAdicionarAluno = value; }
        }
        public Button RemoverAluno
        {
            get { return btnRemoverAluno; }
            set { btnRemoverAluno = value; }
        }
        public Button CadastrarTurma
        {
            get { return btnCadastrar; }
            set { btnCadastrar = value; }
        }
        public TextBox TextBoxNome
        {
            get { return txtNome; }
            set { txtNome = value; }
        }
        public TextBox TextBoxAno
        {
            get { return txtAno; }
            set { txtAno = value; }
        }
        public TextBox TextBoxAluno
        {
            get { return txtAluno; }
            set { txtAluno = value; }
        }
        public ComboBox ComboTurma
        {
            get { return comboTurma; }
            set { comboTurma = value; }
        }
        public NumericUpDown NumericQuantidadeAlunos
        {
            get { return numericQuantidadeAlunos; }
            set { numericQuantidadeAlunos = value; }
        }
        public Button RemoverTurma
        {
            get { return btnRemover; }
            set { btnRemover = value; }
        }
        private void FrmManutencaoTurmas_Load(object sender, EventArgs e)
        {
            _controller.Load();
            _controller.LimparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _controller.CadastrarTurma();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            _controller.AdicionarAluno();
        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            _controller.RemoverAluno();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            _controller.BuscarAlunoPorNome();
        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            _controller.BuscarTurmaPorNome();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.RemoverTurma();
        }
    }
}
