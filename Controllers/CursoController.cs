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
    public class CursoController
    {
        IManutencaoCursosView _manutencaoCursosView;
        CursoModel _cursoModel;
        TurmaModel _turmaModel;

        public CursoController(IManutencaoCursosView manutencaoCursosView, TurmaModel turmaModel)
        {
            _manutencaoCursosView = manutencaoCursosView;
            _cursoModel = CursoModel.Instance; // Usando Singleton
            _turmaModel = turmaModel;
            manutencaoCursosView.SetController(this);
        }
        public void CadastrarCurso()
        {
            int codigo = int.Parse(_manutencaoCursosView.Codigo);
            string nome = _manutencaoCursosView.Nome;
            int cargaHoraria = int.Parse(_manutencaoCursosView.CargaHoraria);

            if (!Utilidade.ValidarNome(nome))
            {
                MessageBox.Show("Nome inválido! O nome deve ter no mínimo 3 caracteres.");
                return;
            }

            if (!Utilidade.ValidarCargaHoraria(cargaHoraria))
            {
                MessageBox.Show("Carga horária inválida! A carga horária deve ser maior que 0.");
                return;
            }

            var curso = new Curso
            {
                Id = codigo,
                Nome = nome,
                CargaHoraria = cargaHoraria
            };

            _cursoModel.Adicionar(curso);
            MessageBox.Show("Curso cadastrado com sucesso!");
            LimparCampos();
            _manutencaoCursosView.Codigo = _cursoModel.BuscarProximoId().ToString();
        }
        public void BuscarCurso()
        {
            if (!int.TryParse(_manutencaoCursosView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }

            var curso = _cursoModel.BuscaCursoPorId(codigo);

            if (curso == null)
            {
                MessageBox.Show("Curso não encontrado.");
                return;
            }

            _manutencaoCursosView.Nome = curso.Nome;
            _manutencaoCursosView.CargaHoraria = curso.CargaHoraria.ToString();
        }
        public void ExcluirCurso()
        {
            if (!int.TryParse(_manutencaoCursosView.Codigo, out int codigo))
            {
                MessageBox.Show("Código inválido! Por favor, insira um número válido.");
                return;
            }

            var curso = _cursoModel.BuscaCursoPorId(codigo);
            if (curso == null)
            {
                MessageBox.Show("Curso não encontrado.");
                return;
            }

            // VERIFICAÇÃO DE VÍNCULO COM TURMAS
            var turmasVinculadas = _turmaModel.ObterTurmas().Where(t => t.Curso.Id == curso.Id).ToList();
            if (turmasVinculadas.Any())
            {
                MessageBox.Show("Não é possível excluir este curso pois há turmas vinculadas a ele.");
                return;
            }

            _cursoModel.Remover(curso);
            MessageBox.Show("Curso excluído com sucesso!");
            LimparCampos();
        }
        public void LimparCampos()
        {
            _manutencaoCursosView.Codigo = string.Empty;
            _manutencaoCursosView.Nome = string.Empty;
            _manutencaoCursosView.CargaHoraria = string.Empty;
        }

        public void MenuCriarCurso()
        {
            // Carrega codigo com proximo ID
            _manutencaoCursosView.Codigo = _cursoModel.BuscarProximoId().ToString();

            _manutencaoCursosView.BotaoExcluir.Visible = false;
            _manutencaoCursosView.BotaoCadastrar.Visible = true;
            _manutencaoCursosView.BotaoBuscar.Visible = false;

            _manutencaoCursosView.TextBoxCodigo.Enabled = false;
            _manutencaoCursosView.TextBoxCargaHoraria.Enabled = true;
            _manutencaoCursosView.TextBoxNome.Enabled = true;
        }
        public void MenuExcluirCurso()
        {
            _manutencaoCursosView.BotaoExcluir.Visible = true;
            _manutencaoCursosView.BotaoCadastrar.Visible = false;
            _manutencaoCursosView.BotaoBuscar.Visible = true;

            _manutencaoCursosView.TextBoxCodigo.Enabled = true;
            _manutencaoCursosView.TextBoxCargaHoraria.Enabled = false;
            _manutencaoCursosView.TextBoxNome.Enabled = false;
        }
    }
}
