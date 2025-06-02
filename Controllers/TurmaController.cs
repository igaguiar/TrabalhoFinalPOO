using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;
using TrabalhoFinalPOO.Models;
using TrabalhoFinalPOO.PadroesProjeto;
using TrabalhoFinalPOO.Views;


namespace TrabalhoFinalPOO.Controllers
{
    public class TurmaController
    {
        IManutencaoTurmasView _manutencaoTurmasView;
        ITurmasPorCursoView _turmasPorCursoView;
        TurmaModel _turmaModel;
        CursoModel _cursoModel;
        ProfessorModel _professorModel;
        AlunoModel _alunoModel;

        private ITurmaFactory _turmaFactory = new TurmaFactoryPadrao();

        private List<IObserverTurma> observers = new List<IObserverTurma>();
        private List<Aluno> alunosTemp = new List<Aluno>();

        public TurmaController(IManutencaoTurmasView manutencaoTurmasView, CursoModel cursoModel, ProfessorModel professorModel, AlunoModel alunoModel)
        {
            _manutencaoTurmasView = manutencaoTurmasView;
            _turmaModel = TurmaModel.Instance;
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
            Professor professor = _manutencaoTurmasView.Professor;

            if (semestre == null || curso == null || professor == null || quantidadeAlunos <= 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios antes de cadastrar a turma.");
                return;
            }

            string nome = curso.Nome + " " + ano + "/" + semestre;

            int id = _turmaModel.BuscarProximoId();
            Turma turma = _turmaFactory.CriarTurma(id, nome, ano, semestre, quantidadeAlunos, curso, professor, new List<Aluno>(alunosTemp));

            _turmaModel.Adicionar(turma);

            MessageBox.Show("Turma cadastrada com sucesso!");
            alunosTemp.Clear();
            LimparCampos();
        }

        public void RemoverTurma()
        {
            Turma turma = _manutencaoTurmasView.Turma;
            if (turma == null)
            {
                MessageBox.Show("Selecione uma turma para remover.");
                return;
            }
            var confirmResult = MessageBox.Show("Tem certeza que deseja remover a turma selecionada?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _turmaModel.Remover(turma);
                MessageBox.Show("Turma removida com sucesso!");
                Load();
                LimparCampos();
            }
        }

        public void AdicionarAluno()
        {
            Aluno aluno = _manutencaoTurmasView.Aluno;
            DataGridView dgvAlunos = _manutencaoTurmasView.DataGridViewAlunos;

            if (aluno != null)
            {
                // Verifica se já atingiu o limite antes de adicionar
                if (alunosTemp.Count >= _manutencaoTurmasView.QuantidadeAlunos)
                {
                    var turmaTemporaria = new Turma
                    {
                        Nome = _manutencaoTurmasView.Nome,
                        Ano = _manutencaoTurmasView.Ano,
                        Semestre = _manutencaoTurmasView.Semestre,
                        Curso = _manutencaoTurmasView.Curso,
                        QuantidadeAlunos = _manutencaoTurmasView.QuantidadeAlunos,
                        Alunos = new List<Aluno>(alunosTemp)
                    };

                    NotificarExcedenteAlunos(turmaTemporaria);
                    return; // NÃO adiciona o aluno
                }

                if (dgvAlunos.Columns.Count == 0)
                {
                    dgvAlunos.Columns.Add("Id", "ID");
                    dgvAlunos.Columns.Add("Nome", "Nome");
                }

                if (!alunosTemp.Contains(aluno))
                {
                    alunosTemp.Add(aluno);
                    dgvAlunos.Rows.Add(aluno.Id, aluno.Nome);
                }
                else
                {
                    MessageBox.Show("Aluno já adicionado à turma.");
                    return;
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
                int rowIndex = dgvAlunos.SelectedRows[0].Index;
                int alunoId = Convert.ToInt32(dgvAlunos.Rows[rowIndex].Cells["Id"].Value);

                Aluno alunoParaRemover = alunosTemp.FirstOrDefault(a => a.Id == alunoId);
                if (alunoParaRemover != null)
                {
                    alunosTemp.Remove(alunoParaRemover);
                }

                dgvAlunos.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Aluno removido com sucesso.");
            }
            else
            {
                MessageBox.Show("Selecione a linha de um aluno para remover.");
            }
        }
        public void BuscarAlunoPorNome()
        {
            string nomeAluno = _manutencaoTurmasView.NomeAluno.Trim().ToLower();
            if (string.IsNullOrEmpty(nomeAluno))
            {
                MessageBox.Show("Digite o nome do aluno para buscar.");
                return;
            }
            var alunoEncontrado = _alunoModel.Alunos.FirstOrDefault(a => a.Nome.ToLower().Contains(nomeAluno));
            if (alunoEncontrado != null)
            {
                _manutencaoTurmasView.Aluno = alunoEncontrado;
            }
        }
        public void BuscarTurmaPorNome()
        {
            string nomeTurma = _manutencaoTurmasView.Nome.Trim().ToLower();
            if (string.IsNullOrEmpty(nomeTurma))
            {
                MessageBox.Show("Digite o nome da turma para buscar.");
                return;
            }
            var turmaEncontrada = _turmaModel.Turmas.FirstOrDefault(a => a.Nome.ToLower().Contains(nomeTurma));
            if (turmaEncontrada != null)
            {
                _manutencaoTurmasView.Turma = turmaEncontrada;
            }
        }
        public void Load()
        {
            alunosTemp.Clear();

            _manutencaoTurmasView.ComboSemestre.Items.Clear();
            _manutencaoTurmasView.ComboSemestre.Items.Add("1");
            _manutencaoTurmasView.ComboSemestre.Items.Add("2");

            _manutencaoTurmasView.ComboTurma.DataSource = null;
            _manutencaoTurmasView.ComboTurma.DataSource = _turmaModel.Turmas;
            _manutencaoTurmasView.ComboTurma.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboTurma.ValueMember = "Id";

            _manutencaoTurmasView.ComboCurso.DataSource = null;
            _manutencaoTurmasView.ComboCurso.DataSource = _cursoModel.Cursos;
            _manutencaoTurmasView.ComboCurso.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboCurso.ValueMember = "Id";

            _manutencaoTurmasView.ComboProfessor.DataSource = null;
            _manutencaoTurmasView.ComboProfessor.DataSource = _professorModel.Professores;
            _manutencaoTurmasView.ComboProfessor.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboProfessor.ValueMember = "Id";

            _manutencaoTurmasView.ComboAluno.DataSource = null;
            _manutencaoTurmasView.ComboAluno.DataSource = _alunoModel.Alunos;
            _manutencaoTurmasView.ComboAluno.DisplayMember = "Nome";
            _manutencaoTurmasView.ComboAluno.ValueMember = "Id";
        }

        public void LimparCampos()
        {
            _manutencaoTurmasView.Nome = string.Empty;
            _manutencaoTurmasView.Turma = null;
            _manutencaoTurmasView.Ano = 0;
            _manutencaoTurmasView.Semestre = 1;
            _manutencaoTurmasView.QuantidadeAlunos = 0;
            _manutencaoTurmasView.Curso = null;
            _manutencaoTurmasView.Professor = null;
            _manutencaoTurmasView.NomeAluno = string.Empty;
            _manutencaoTurmasView.Aluno = null;
            _manutencaoTurmasView.DataGridViewAlunos.Rows.Clear();
        }

        public void ListarAlunosPorTurma(Turma turmaSelecionada, DataGridView dgv)
        {
            // Garante que o DataGridView tem as colunas necessárias
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("Id", "ID");
                dgv.Columns.Add("Nome", "Nome");
            }

            dgv.Rows.Clear();

            if (turmaSelecionada != null && turmaSelecionada.Alunos.Count > 0)
            {
                foreach (var aluno in turmaSelecionada.Alunos)
                {
                    dgv.Rows.Add(aluno.Id, aluno.Nome);
                }
            }
            else
            {
                MessageBox.Show("Turma sem alunos cadastrados.");
            }
        }

        public List<Turma> GetTurmas()
        {
            return _turmaModel.ObterTurmas();
        }
        public void SetViewTurmasPorCurso(ITurmasPorCursoView view)
        {
            _turmasPorCursoView = view;
            _turmasPorCursoView.SetController(this);

            _turmasPorCursoView.ComboCurso.DataSource = _cursoModel.Cursos;
            _turmasPorCursoView.ComboCurso.DisplayMember = "Nome";
            _turmasPorCursoView.ComboCurso.ValueMember = "Id";
        }
        public void ListarTurmasPorCurso(Curso cursoSelecionado, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("Nome", "Nome");
            dgv.Columns.Add("Ano", "Ano");
            dgv.Columns.Add("Semestre", "Semestre");
            dgv.Columns.Add("QtdAlunos", "Qtd. Alunos");

            var turmas = _turmaModel.ObterTurmas()
                .Where(t => t.Curso != null && t.Curso.Id == cursoSelecionado.Id)
                .ToList();

            if (turmas.Any())
            {
                foreach (var turma in turmas)
                {
                    dgv.Rows.Add(turma.Id, turma.Nome, turma.Ano, turma.Semestre, turma.QuantidadeAlunos);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma turma encontrada para o curso selecionado.");
            }
        }

        public void AdicionarObserver(IObserverTurma observer)
        {
            observers.Add(observer);
        }

        public void RemoverObserver(IObserverTurma observer)
        {
            observers.Remove(observer);
        }

        private void NotificarExcedenteAlunos(Turma turma)
        {
            foreach (var observer in observers)
            {
                observer.NotificarExcedenteAlunos(turma);
            }
        }
        public void GerarRelatorio(IRelatorioAdapter geradorRelatorio)
        {
            var turmas = _turmaModel.ObterTurmas();
            geradorRelatorio.GerarRelatorio(turmas);
        }
        public void MenuCriarTurma()
        {
            _manutencaoTurmasView.TextBoxNome.Enabled = false;
            _manutencaoTurmasView.BuscarNome.Enabled = false;
            _manutencaoTurmasView.ComboTurma.Enabled = false;
            _manutencaoTurmasView.RemoverTurma.Visible = false;

            _manutencaoTurmasView.TextBoxAno.Enabled = true;
            _manutencaoTurmasView.ComboSemestre.Enabled = true;
            _manutencaoTurmasView.NumericQuantidadeAlunos.Enabled = true;
            _manutencaoTurmasView.ComboCurso.Enabled = true;
            _manutencaoTurmasView.ComboProfessor.Enabled = true;
            _manutencaoTurmasView.TextBoxAluno.Enabled = true;
            _manutencaoTurmasView.BuscarAluno.Enabled = true;
            _manutencaoTurmasView.ComboAluno.Enabled = true;
            _manutencaoTurmasView.AdicionarAluno.Enabled = true;
            _manutencaoTurmasView.RemoverAluno.Enabled = true;
            _manutencaoTurmasView.CadastrarTurma.Visible = true;
        }
        public void MenuExcluirTurma()
        {
            _manutencaoTurmasView.TextBoxNome.Enabled = true;
            _manutencaoTurmasView.BuscarNome.Enabled = true;
            _manutencaoTurmasView.ComboTurma.Enabled = true;
            _manutencaoTurmasView.RemoverTurma.Visible = true;

            _manutencaoTurmasView.TextBoxAno.Enabled = false;
            _manutencaoTurmasView.ComboSemestre.Enabled = false;
            _manutencaoTurmasView.NumericQuantidadeAlunos.Enabled = false;
            _manutencaoTurmasView.ComboCurso.Enabled = false;
            _manutencaoTurmasView.ComboProfessor.Enabled = false;
            _manutencaoTurmasView.TextBoxAluno.Enabled = false;
            _manutencaoTurmasView.BuscarAluno.Enabled = false;
            _manutencaoTurmasView.ComboAluno.Enabled = false;
            _manutencaoTurmasView.AdicionarAluno.Enabled = false;
            _manutencaoTurmasView.RemoverAluno.Enabled = false;
            _manutencaoTurmasView.CadastrarTurma.Visible = false;
        }
    }
}
