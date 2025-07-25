using System;
using System.Windows.Forms;

namespace GestãoEscolar
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void imgSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = FormLogin.NomeUsuario;

            ConfigurarPermissoes();

            tmrDataHora.Start();
        }

        private void ConfigurarPermissoes()
        {
            imgUsuario.Enabled = false;
            lblCadUsuario.Enabled = false;
            imgEstatistica.Enabled = false;
            imgLogoff.Enabled = false;
            imgRelatorio.Enabled = false;
            imgSenha.Enabled = false;
            lblRelatorio.Enabled = false;
            lblEstatistica.Enabled = false;
            lblLogoff.Enabled = false;
            lblSenha.Enabled = false;

            switch (FormLogin.TipoUsuario)
            {
                case "T1":
                    imgUsuario.Enabled = true;
                    lblCadUsuario.Enabled = true;
                    imgEstatistica.Enabled = true;
                    imgLogoff.Enabled = true;
                    imgRelatorio.Enabled = true;
                    imgSenha.Enabled = true;
                    lblRelatorio.Enabled = true;
                    lblEstatistica.Enabled = true;
                    lblLogoff.Enabled = true;
                    lblSenha.Enabled = true;
                    break;

                case "T2":
                    imgEstatistica.Enabled = true;
                    imgLogoff.Enabled = true;
                    lblRelatorio.Enabled = true;
                    lblEstatistica.Enabled = true;
                    break;

                case "T3":
                    imgRelatorio.Enabled = true;
                    imgSenha.Enabled = true;
                    lblLogoff.Enabled = true;
                    lblSenha.Enabled = true;
                    break;
            }
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblHora2.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void imgUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario f = new FormUsuario();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void imgAluno_Click(object sender, EventArgs e)
        {
            FormAluno f = new FormAluno();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void lblAluno_Click(object sender, EventArgs e)
        {
            FormAluno f = new FormAluno();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}