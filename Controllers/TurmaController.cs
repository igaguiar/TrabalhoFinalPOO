using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;
using TrabalhoFinalPOO.Models;
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO.Controllers
{
    public class TurmaController
    {
        IManutencaoTurmasView _manutencaoTurmasView;
        TurmaModel _turmaModel;
        CursoModel _cursoModel;
        ProfessorModel _professorModel;
        AlunoModel _alunoModel;

        private List<Aluno> alunos = new List<Aluno>();
        public TurmaController(IManutencaoTurmasView manutencaoTurmasView, TurmaModel turmaModel, CursoModel cursoModel, ProfessorModel professorModel, AlunoModel alunoModel)
        {
            _manutencaoTurmasView = manutencaoTurmasView;
            _turmaModel = turmaModel;
            _manutencaoTurmasView.SetController(this);

            _cursoModel = cursoModel;
            _professorModel = professorModel;
            _alunoModel = alunoModel;
        }
        public void CadastrarTurma()
        {
            int ano = _manutencaoTurmasView.Ano;
            int semestre = _manutencaoTurmasView.Semestre;
            int quantidadeAlunos = _manutencaoTurmasView.QuantidadeAlunos;
            Curso curso = _manutencaoTurmasView.Curso;
            string nome = curso.Nome + " " + ano + "/" + semestre;
            Professor professor = _manutencaoTurmasView.Professor;

        }
        public void AdicionarAluno()
        {
            Aluno aluno = _manutencaoTurmasView.Aluno;
            DataGridView dgvAlunos = _manutencaoTurmasView.DataGridViewAlunos;
            if (aluno != null)
            {
                // Verifica se as colunas já foram adicionadas
                if (dgvAlunos.Columns.Count == 0)
                {
                    dgvAlunos.Columns.Add("Id", "ID");
                    dgvAlunos.Columns.Add("Nome", "Nome");
                }

                // Verifica se o aluno já está na lista
                if (!alunos.Contains(aluno))
                {
                    alunos.Add(aluno);
                    dgvAlunos.Rows.Add(aluno.Id, aluno.Nome);
                }
                else
                {
                    MessageBox.Show("Aluno já adicionado à turma.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno.");
            }
        }
        public void RemoverAluno()
        {
            DataGridView dgvAlunos = _manutencaoTurmasView.DataGridViewAlunos;

            if (dgvAlunos.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = dgvAlunos.SelectedRows[0].Index;

                // Obtém o ID do aluno na linha selecionada
                int alunoId = Convert.ToInt32(dgvAlunos.Rows[rowIndex].Cells["Id"].Value);

                // Remove o aluno da lista
                Aluno alunoParaRemover = alunos.FirstOrDefault(a => a.Id == alunoId);
                if (alunoParaRemover != null)
                {
                    alunos.Remove(alunoParaRemover);
                }

                // Remove a linha do DataGridView
                dgvAlunos.Rows.RemoveAt(rowIndex);

                MessageBox.Show("Aluno removido com sucesso.");
            }
            else
            {
                MessageBox.Show("Selecione a linha de um aluno para remover.");
            }
        }
        public void Load()
        {
            alunos.Clear();

            _manutencaoTurmasView.ComboSemestre.Items.Clear();
            _manutencaoTurmasView.ComboSemestre.Items.Add("1");
            _manutencaoTurmasView.ComboSemestre.Items.Add("2");

            _manutencaoTurmasView.ComboCurso.DataSource = null; // Reseta o DataSource para evitar problemas
            _manutencaoTurmasView.ComboCurso.DataSource = _cursoModel.Cursos; // Utilizando a propriedade Cursos
            _manutencaoTurmasView.ComboCurso.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboCurso.ValueMember = "Id";

            _manutencaoTurmasView.ComboProfessor.DataSource = null; // Reseta o DataSource para evitar problemas
            _manutencaoTurmasView.ComboProfessor.DataSource = _professorModel.Professores; // Utilizando a propriedade Professores
            _manutencaoTurmasView.ComboProfessor.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboProfessor.ValueMember = "Id";           

            _manutencaoTurmasView.ComboAluno.DataSource = null; // Reseta o DataSource para evitar problemas
            _manutencaoTurmasView.ComboAluno.DataSource = _alunoModel.Alunos; // Utilizando a propriedade Alunos
            _manutencaoTurmasView.ComboAluno.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboAluno.ValueMember = "Id";
        }
    }
}
