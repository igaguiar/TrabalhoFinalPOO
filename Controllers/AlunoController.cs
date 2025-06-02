using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;
using TrabalhoFinalPOO.Models;
using TrabalhoFinalPOO.Utilidades;
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO.Controllers
{
    public class AlunoController
    {
        IManutencaoAlunosView _manutencaoAlunosView;
        AlunoModel _alunoModel;
        TurmaModel _turmaModel;

        public AlunoController(IManutencaoAlunosView manutencaoAlunosView, TurmaModel turmaModel)
        {
            _manutencaoAlunosView = manutencaoAlunosView;
            _alunoModel = AlunoModel.Instance;  // usa o Singleton aqui
            _turmaModel = turmaModel;
            manutencaoAlunosView.SetController(this);
        }
        public void CadastrarAluno()
        {
            int codigo = int.Parse(_manutencaoAlunosView.Codigo);
            string nome = _manutencaoAlunosView.Nome;
            string cpf = _manutencaoAlunosView.CPF;
            string email = _manutencaoAlunosView.Email;

            if (!Utilidade.ValidarNome(nome))
            {
                MessageBox.Show("Nome inválido! O nome deve ter no mínimo 3 caracteres.");
                return;
            }

            if (!Utilidade.ValidarCpf(cpf))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            if (!Utilidade.ValidarEmail(email))
            {
                MessageBox.Show("Email inválido!");
                return;
            }

            // Verificar se o CPF já está cadastrado
            var alunoExistente = _alunoModel.BuscaAlunoPorCpf(cpf);
            if (alunoExistente != null)
            {
                MessageBox.Show("Aluno já cadastrado com este CPF!");
                return;
            }

            var aluno = new Aluno
            {
                Id = codigo,
                Nome = nome,
                CPF = cpf,
                Email = email
            };

            _alunoModel.Adicionar(aluno);
            MessageBox.Show("Aluno cadastrado com sucesso!");
            LimparCampos();
            _manutencaoAlunosView.Codigo = _alunoModel.BuscarProximoId().ToString();
        }
        public void BuscarAluno()
        {
            if (!int.TryParse(_manutencaoAlunosView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }

            var aluno = _alunoModel.BuscaAlunoPorId(codigo);

            if (aluno == null)
            {
                MessageBox.Show("Aluno não encontrado.");
                return;
            }

            _manutencaoAlunosView.Nome = aluno.Nome;
            _manutencaoAlunosView.CPF = aluno.CPF;
            _manutencaoAlunosView.Email = aluno.Email;
        }
        public void ExcluirAluno()
        {
            if (!int.TryParse(_manutencaoAlunosView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }
            var aluno = _alunoModel.BuscaAlunoPorId(codigo);
            if (aluno == null)
            {
                MessageBox.Show("Aluno não encontrado.");
                return;
            }

            // Verifica se o aluno está em alguma turma
            bool alunoEmTurma = _turmaModel.ObterTurmas().Any(t => t.Alunos.Any(a => a.Id == aluno.Id));

            if (alunoEmTurma)
            {
                MessageBox.Show("Não é possível excluir o aluno. Ele já está matriculado em uma turma.");
                return;
            }
            _alunoModel.Remover(aluno);
            MessageBox.Show("Aluno excluído com sucesso!");
            LimparCampos();
        }
        public void LimparCampos()
        {
            _manutencaoAlunosView.Codigo = string.Empty;
            _manutencaoAlunosView.Nome = string.Empty;
            _manutencaoAlunosView.CPF = string.Empty;
            _manutencaoAlunosView.Email = string.Empty;
        }

        public void MenuCriarAluno()
        {
            // Carrega codigo com proximo ID
            _manutencaoAlunosView.Codigo = _alunoModel.BuscarProximoId().ToString();

            _manutencaoAlunosView.BotaoExcluir.Visible = false;
            _manutencaoAlunosView.BotaoCadastrar.Visible = true;
            _manutencaoAlunosView.BotaoBuscar.Visible = false;

            _manutencaoAlunosView.TextBoxCodigo.Enabled = false;
            _manutencaoAlunosView.TextBoxCPF.Enabled = true;
            _manutencaoAlunosView.TextBoxNome.Enabled = true;
            _manutencaoAlunosView.TextBoxEmail.Enabled = true;
        }
        public void MenuExcluirAluno()
        {
            _manutencaoAlunosView.BotaoExcluir.Visible = true;
            _manutencaoAlunosView.BotaoCadastrar.Visible = false;
            _manutencaoAlunosView.BotaoBuscar.Visible = true;

            _manutencaoAlunosView.TextBoxCodigo.Enabled = true;
            _manutencaoAlunosView.TextBoxCPF.Enabled = false;
            _manutencaoAlunosView.TextBoxNome.Enabled = false;
            _manutencaoAlunosView.TextBoxEmail.Enabled = false;
        }
    }
}
