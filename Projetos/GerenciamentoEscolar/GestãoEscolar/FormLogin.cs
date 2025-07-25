using System;
using System.Data;
using System.Windows.Forms;
using Models;
using Business;

namespace GestãoEscolar
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _negocio = new UsuarioService();
        private readonly FormPrincipal _principalForm = new FormPrincipal();

        public static string NomeUsuario { get; private set; }
        public static string TipoUsuario { get; private set; }
        public static int CodigoUsuario { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUsuario;
        }

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = new Usuario
                {
                    nome = txtUsuario.Text,
                    senha = txtSenha.Text
                };

                DataTable resultado = _negocio.N_Login(usuario);

                if (resultado.Rows.Count > 0)
                {
                    DataRow row = resultado.Rows[0];
                    NomeUsuario = row["nome"].ToString();
                    TipoUsuario = row["id_tipo"].ToString();
                    CodigoUsuario = Convert.ToInt32(row["id"]);

                    MessageBox.Show($"Bem-vindo, {NomeUsuario}!", "Login bem-sucedido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    _principalForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Falha no login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar login: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogar.PerformClick();
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}