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
    public partial class FrmManutencaoProfessores : Form, IManutencaoProfessoresView
    {
        ProfessorController _controller;
        public FrmManutencaoProfessores()
        {
            InitializeComponent();
        }
        public void SetController(ProfessorController controller)
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
        public string CPF
        {
            get { return txtCPF.Text; }
            set { txtCPF.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
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
        public TextBox TextBoxCPF
        {
            get { return txtCPF; }
            set { txtCPF = value; }
        }
        public TextBox TextBoxEmail
        {
            get { return txtEmail; }
            set { txtEmail = value; }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _controller.BuscarProfessor();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _controller.CadastrarProfessor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controller.ExcluirProfessor();
        }

        private void FrmManutencaoProfessores_FormClosing(object sender, FormClosingEventArgs e)
        {
            _controller.LimparCampos();
        }
    }
}
