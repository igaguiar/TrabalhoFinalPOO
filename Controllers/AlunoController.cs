using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;
using TrabalhoFinalPOO.Models;
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO.Controllers
{
    public class AlunoController
    {
        IManutencaoAlunosView _manutencaoAlunosView;
        AlunoModel _alunoModel;
        public AlunoController(IManutencaoAlunosView manutencaoAlunosView, AlunoModel alunoModel)
        {
            _manutencaoAlunosView = manutencaoAlunosView;
            _alunoModel = alunoModel;
            manutencaoAlunosView.SetController(this);
        }
        public void CadastrarAluno()
        {
            int codigo = int.Parse(_manutencaoAlunosView.Codigo);
            string nome = _manutencaoAlunosView.Nome;
            string cpf = _manutencaoAlunosView.CPF;
            string email = _manutencaoAlunosView.Email;

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

        public void LimparCampos()
        {
            _manutencaoAlunosView.Codigo = string.Empty;
            _manutencaoAlunosView.Nome = string.Empty;
            _manutencaoAlunosView.CPF = string.Empty;
            _manutencaoAlunosView.Email = string.Empty;
        }

        public void MenuCriarAluno()
        {
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
