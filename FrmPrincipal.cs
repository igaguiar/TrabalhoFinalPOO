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

        FrmManutencaoCursos _frmManutencaoCursos;
        CursoModel _cursoModel;
        CursoController _cursoController;

        FrmManutencaoTurmas _frmManutencaoTurmas;
        TurmaModel _turmaModel;
        TurmaController _turmaController;
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

            // Estrutura classes curso
            _cursoModel = new CursoModel();
            _frmManutencaoCursos = new FrmManutencaoCursos();
            _cursoController = new CursoController(_frmManutencaoCursos, _cursoModel);

            // Estrutura classes turma
            _turmaModel = new TurmaModel();
            _frmManutencaoTurmas = new FrmManutencaoTurmas();
            _turmaController = new TurmaController(_frmManutencaoTurmas, _turmaModel, _cursoModel, _professorModel, _alunoModel);
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

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cursoController.MenuCriarCurso();
            _frmManutencaoCursos.ShowDialog();
        }

        private void excluirCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cursoController.MenuExcluirCurso();
            _frmManutencaoCursos.ShowDialog();
        }

        private void criarTurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmManutencaoTurmas.ShowDialog();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
