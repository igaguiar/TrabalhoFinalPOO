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
        }
        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public string Turma
        {
            get { return comboTurma.Text; }
            set { comboTurma.Text = value; }
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
        }
        public Professor Professor
        {
            get { return comboProfessor.SelectedItem as Professor; }
        }
        public string NomeAluno
        {
            get { return txtAluno.Text; }
            set { txtAluno.Text = value; }
        }
        public Aluno Aluno
        {
            get { return comboAluno.SelectedItem as Aluno; }
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

        private void FrmManutencaoTurmas_Load(object sender, EventArgs e)
        {
            _controller.Load();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _controller.CadastrarTurma();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            _controller.AdicionarAluno();
        }
    }
}
