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
        AlunoModel _alunoModel;
        AlunoController _alunoController;

        FrmManutencaoProfessores _frmManutencaoProfessores;
        ProfessorModel _professorModel;
        ProfessorController _professorController;
        public FrmPrincipal()
        {
            InitializeComponent();

            // Estrutura classes aluno
            _alunoModel = new AlunoModel();
            _frmManutencaoAlunos = new FrmManutencaoAlunos();
            _alunoController = new AlunoController(_frmManutencaoAlunos, _alunoModel);

            // Estrutura classes professor
            _professorModel = new ProfessorModel();
            _frmManutencaoProfessores = new FrmManutencaoProfessores();
            _professorController = new ProfessorController(_frmManutencaoProfessores, _professorModel);
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
            _frmManutencaoProfessores.ShowDialog();
        }

        private void excluirProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _professorController.MenuExcluirProfessor();
            _frmManutencaoProfessores.ShowDialog();
        }
    }
}
