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
        TurmaController _turmaController;
        TurmaModel _turmaModel;
        public FrmPrincipal()
        {
            InitializeComponent();

            // Inicialize primeiro os modelos compartilhados
            _alunoModel = new AlunoModel();
            _professorModel = new ProfessorModel();
            _cursoModel = new CursoModel();
            _turmaModel = new TurmaModel(); // <-- ANTES de usar no controller

            // Inicialize as views
            _frmManutencaoAlunos = new FrmManutencaoAlunos();
            _frmManutencaoProfessores = new FrmManutencaoProfessores();
            _frmManutencaoCursos = new FrmManutencaoCursos();
            _frmManutencaoTurmas = new FrmManutencaoTurmas();

            // Agora sim, passe os modelos para os controllers
            _alunoController = new AlunoController(_frmManutencaoAlunos, _alunoModel, _turmaModel);
            _professorController = new ProfessorController(_frmManutencaoProfessores, _professorModel, _turmaModel);
            _cursoController = new CursoController(_frmManutencaoCursos, _cursoModel, _turmaModel);
            _turmaController = new TurmaController(_frmManutencaoTurmas, _turmaModel, _cursoModel, _professorModel, _alunoModel);

            AdicionarDadosIniciais();
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
        public void AdicionarDadosIniciais()
        {
            // Adicionar Alunos
            _alunoModel.Adicionar(new Aluno { Id = 1, Nome = "João Silva", CPF = "111.111.111-11", Email = "joao@gmail.com" });
            _alunoModel.Adicionar(new Aluno { Id = 2, Nome = "Maria Souza", CPF = "222.222.222-22", Email = "maria@gmail.com" });
            _alunoModel.Adicionar(new Aluno { Id = 3, Nome = "Pedro Santos", CPF = "333.333.333-33", Email = "pedro@gmail.com" });
            _alunoModel.Adicionar(new Aluno { Id = 4, Nome = "Ana Lima", CPF = "444.444.444-44", Email = "ana@gmail.com" });
            _alunoModel.Adicionar(new Aluno { Id = 5, Nome = "Lucas Oliveira", CPF = "555.555.555-55", Email = "lucas@gmail.com" });

            // Adicionar Professores
            _professorModel.Adicionar(new Professor { Id = 1, Nome = "Carlos Mendes", CPF = "666.666.666-66", Email = "carlos@gmail.com" });
            _professorModel.Adicionar(new Professor { Id = 2, Nome = "Fernanda Costa", CPF = "777.777.777-77", Email = "fernanda@gmail.com" });
            _professorModel.Adicionar(new Professor { Id = 3, Nome = "Renato Gomes", CPF = "888.888.888-88", Email = "renato@gmail.com" });
            _professorModel.Adicionar(new Professor { Id = 4, Nome = "Clara Martins", CPF = "999.999.999-99", Email = "clara@gmail.com" });
            _professorModel.Adicionar(new Professor { Id = 5, Nome = "Juliana Ribeiro", CPF = "000.000.000-00", Email = "juliana@gmail.com" });

            // Adicionar Cursos
            _cursoModel.Adicionar(new Curso { Id = 1, Nome = "Matemática", CargaHoraria = 60 });
            _cursoModel.Adicionar(new Curso { Id = 2, Nome = "Português", CargaHoraria = 45 });
            _cursoModel.Adicionar(new Curso { Id = 3, Nome = "História", CargaHoraria = 50 });
            _cursoModel.Adicionar(new Curso { Id = 4, Nome = "Geografia", CargaHoraria = 40 });
            _cursoModel.Adicionar(new Curso { Id = 5, Nome = "Física", CargaHoraria = 55 });

            // Adicionar Turmas
            _turmaModel.Adicionar(new Turma { Id = 1, Nome = "Turma A", Ano = 2025, Semestre = 1, QuantidadeAlunos = 2, Curso = _cursoModel.Cursos[0], Professor = _professorModel.Professores[0], Alunos = new List<Aluno> { _alunoModel.Alunos[0], _alunoModel.Alunos[1] } });
            _turmaModel.Adicionar(new Turma { Id = 2, Nome = "Turma B", Ano = 2025, Semestre = 1, QuantidadeAlunos = 2, Curso = _cursoModel.Cursos[1], Professor = _professorModel.Professores[1], Alunos = new List<Aluno> { _alunoModel.Alunos[2], _alunoModel.Alunos[3] } });
            _turmaModel.Adicionar(new Turma { Id = 3, Nome = "Turma C", Ano = 2025, Semestre = 1, QuantidadeAlunos = 1, Curso = _cursoModel.Cursos[2], Professor = _professorModel.Professores[2], Alunos = new List<Aluno> { _alunoModel.Alunos[4] } });
            _turmaModel.Adicionar(new Turma { Id = 4, Nome = "Turma D", Ano = 2025, Semestre = 2, QuantidadeAlunos = 2, Curso = _cursoModel.Cursos[3], Professor = _professorModel.Professores[3], Alunos = new List<Aluno> { _alunoModel.Alunos[0], _alunoModel.Alunos[2] } });
            _turmaModel.Adicionar(new Turma { Id = 5, Nome = "Turma E", Ano = 2025, Semestre = 2, QuantidadeAlunos = 2, Curso = _cursoModel.Cursos[4], Professor = _professorModel.Professores[4], Alunos = new List<Aluno> { _alunoModel.Alunos[3], _alunoModel.Alunos[4] } });
        }

        private void alunosPorTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlunosPorTurma frmAlunosPorTurma = new FrmAlunosPorTurma(_turmaController);
            frmAlunosPorTurma.ShowDialog();
        }

        private void turmasPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurmasPorCurso frmTurmasPorCurso = new FrmTurmasPorCurso();
            frmTurmasPorCurso.SetController(_turmaController);
            frmTurmasPorCurso.CarregarCursos(_cursoModel.Cursos);
            frmTurmasPorCurso.ShowDialog();
        }
    }
}
