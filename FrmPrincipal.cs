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
using TrabalhoFinalPOO.Models;

namespace TrabalhoFinalPOO
{
    public partial class FrmPrincipal : Form
    {
        FrmManutencaoAlunos _frmManutencaoAlunos;
        AlunoController _alunoController;
        FrmManutencaoProfessores _formManutencaoProfessores;
        ProfessorModel _professorModel;
        ProfessorController _professorController;
        public FrmPrincipal(FrmManutencaoAlunos frmManutencaoAlunos, AlunoController alunoController)
        {
            InitializeComponent();
            _frmManutencaoAlunos = frmManutencaoAlunos;
            _alunoController = alunoController;
            _professorModel = new ProfessorModel();
            _formManutencaoProfessores = new FrmManutencaoProfessores();
            _formManutencaoProfessores.Visible = false;
            _professorController = new ProfessorController(_formManutencaoProfessores, _professorModel);
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _alunoController.MenuCriarAluno();
            _frmManutencaoAlunos.ShowDialog();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _alunoController.MenuExcluirAluno();
            _frmManutencaoAlunos.ShowDialog();
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _professorController.MenuCriarProfessor();
            _formManutencaoProfessores.ShowDialog();
        }

        private void excluirProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _professorController.MenuExcluirProfessor();
            _formManutencaoProfessores.ShowDialog();
        }
    }
}
