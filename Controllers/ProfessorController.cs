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
    public class ProfessorController
    {
        IManutencaoProfessoresView _manutencaoProfessoresView;
        ProfessorModel _professorModel;
        TurmaModel _turmaModel;
        public ProfessorController(IManutencaoProfessoresView manutencaoProfessoresView, ProfessorModel professorModel, TurmaModel turmaModel)
        {
            _manutencaoProfessoresView = manutencaoProfessoresView;
            _professorModel = professorModel;
            _turmaModel = turmaModel;
            manutencaoProfessoresView.SetController(this);
        }
        public void CadastrarProfessor()
        {
            int codigo = int.Parse(_manutencaoProfessoresView.Codigo);
            string nome = _manutencaoProfessoresView.Nome;
            string cpf = _manutencaoProfessoresView.CPF;
            string email = _manutencaoProfessoresView.Email;

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
            var professorExistente = _professorModel.BuscaProfessorPorCpf(cpf);
            if (professorExistente != null)
            {
                MessageBox.Show("Professor já cadastrado com este CPF!");
                return;
            }

            var professor = new Professor
            {
                Id = codigo,
                Nome = nome,
                CPF = cpf,
                Email = email
            };

            _professorModel.Adicionar(professor);
            MessageBox.Show("Professor cadastrado com sucesso!");
            LimparCampos();
            _manutencaoProfessoresView.Codigo = _professorModel.BuscarProximoId().ToString();
        }
        public void BuscarProfessor()
        {
            if (!int.TryParse(_manutencaoProfessoresView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }

            var professor = _professorModel.BuscaProfessorPorId(codigo);

            if (professor == null)
            {
                MessageBox.Show("Professor não encontrado.");
                return;
            }

            _manutencaoProfessoresView.Nome = professor.Nome;
            _manutencaoProfessoresView.CPF = professor.CPF;
            _manutencaoProfessoresView.Email = professor.Email;
        }
        public void ExcluirProfessor()
        {
            if (!int.TryParse(_manutencaoProfessoresView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }

            var professor = _professorModel.BuscaProfessorPorId(codigo);
            if (professor == null)
            {
                MessageBox.Show("Professor não encontrado.");
                return;
            }

            // VERIFICA SE ESTÁ EM ALGUMA TURMA
            bool professorEmTurma = _turmaModel.ObterTurmas().Any(t => t.Professor != null && t.Professor.Id == professor.Id);
            if (professorEmTurma)
            {
                MessageBox.Show("Este professor está vinculado a uma turma e não pode ser excluído.");
                return;
            }

            _professorModel.Remover(professor);
            MessageBox.Show("Professor excluído com sucesso!");
            LimparCampos();
        }
        public void LimparCampos()
        {
            _manutencaoProfessoresView.Codigo = string.Empty;
            _manutencaoProfessoresView.Nome = string.Empty;
            _manutencaoProfessoresView.CPF = string.Empty;
            _manutencaoProfessoresView.Email = string.Empty;
        }

        public void MenuCriarProfessor()
        {
            // Carrega codigo com proximo ID
            _manutencaoProfessoresView.Codigo = _professorModel.BuscarProximoId().ToString();

            _manutencaoProfessoresView.BotaoExcluir.Visible = false;
            _manutencaoProfessoresView.BotaoCadastrar.Visible = true;
            _manutencaoProfessoresView.BotaoBuscar.Visible = false;

            _manutencaoProfessoresView.TextBoxCodigo.Enabled = false;
            _manutencaoProfessoresView.TextBoxCPF.Enabled = true;
            _manutencaoProfessoresView.TextBoxNome.Enabled = true;
            _manutencaoProfessoresView.TextBoxEmail.Enabled = true;
        }
        public void MenuExcluirProfessor()
        {
            _manutencaoProfessoresView.BotaoExcluir.Visible = true;
            _manutencaoProfessoresView.BotaoCadastrar.Visible = false;
            _manutencaoProfessoresView.BotaoBuscar.Visible = true;

            _manutencaoProfessoresView.TextBoxCodigo.Enabled = true;
            _manutencaoProfessoresView.TextBoxCPF.Enabled = false;
            _manutencaoProfessoresView.TextBoxNome.Enabled = false;
            _manutencaoProfessoresView.TextBoxEmail.Enabled = false;
        }
    }
}
