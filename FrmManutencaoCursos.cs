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
using TrabalhoFinalPOO.Views;

namespace TrabalhoFinalPOO
{
    public partial class FrmManutencaoCursos : Form, IManutencaoCursosView
    {
        CursoController _controller;
        public FrmManutencaoCursos()
        {
            InitializeComponent();
        }
        public void SetController(CursoController controller)
        {
            _controller = controller;
        }
        public string Codigo
        {
            get { return txtCodigo.Text; }
            set { txtCodigo.Text = value; }
        }
        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public string CargaHoraria
        {
            get { return txtCargaHoraria.Text; }
            set { txtCargaHoraria.Text = value; }
        }
        public Button BotaoCadastrar
        {
            get { return btnCadastrar; }
            set { btnCadastrar = value; }
        }
        public Button BotaoBuscar
        {
            get { return btnBuscar; }
            set { btnBuscar = value; }
        }
        public Button BotaoExcluir
        {
            get { return btnExcluir; }
            set { btnExcluir = value; }
        }
        public TextBox TextBoxCodigo
        {
            get { return txtCodigo; }
            set { txtCodigo = value; }
        }
        public TextBox TextBoxNome
        {
            get { return txtNome; }
            set { txtNome = value; }
        }
        public TextBox TextBoxCargaHoraria
        {
            get { return txtCargaHoraria; }
            set { txtCargaHoraria = value; }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _controller.CadastrarCurso();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _controller.BuscarCurso();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controller.ExcluirCurso();
        }

        private void FrmManutencaoCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _controller.LimparCampos();
        }
    }
}
