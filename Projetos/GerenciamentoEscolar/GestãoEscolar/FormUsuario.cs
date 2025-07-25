using System;
using System.Data;
using System.Windows.Forms;
using Models;
using Business;

namespace GestãoEscolar
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        Usuario clsE = new Usuario();
        UsuarioService clsN = new UsuarioService();



        private void imgSair_Click(object sender, EventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            this.Hide();
            f.ShowDialog();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            CarregarDados();
            CarregarTipos();
        }

        private void CarregarDados()
        {
            try
            {
                dgvListaUsuarios.DataSource = clsN.N_ListarUsuario();
                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarTipos()
        {
            try
            {
                cmbTipo.DataSource = clsN.N_ListarTipo();
                cmbTipo.ValueMember = "id_tipo";
                cmbTipo.DisplayMember = "nome_tipo";
                cmbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar tipos de usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvListaUsuarios.Columns.Count > 0)
            {
                dgvListaUsuarios.Columns[0].HeaderText = "ID";
                dgvListaUsuarios.Columns[1].HeaderText = "Nome";
                dgvListaUsuarios.Columns[2].HeaderText = "Tipo";
                dgvListaUsuarios.Columns[3].Visible = false;

                dgvListaUsuarios.Columns[0].Width = 50;
                dgvListaUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvListaUsuarios.Columns[2].Width = 150;
            }
        }

        private void CRUD(string acao)
        {
            try
            {
                clsE.id = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text);
                clsE.nome = txtNome.Text;
                clsE.senha = txtSenha.Text;
                clsE.id_tipo = cmbTipo.SelectedValue.ToString();
                clsE.acao = acao;

                string mensagem = clsN.N_CrudUsuario(clsE);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("ID inválido. Deve ser um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar operação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtId.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            cmbTipo.SelectedIndex = 0;
        }
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = clsN.N_BuscarUsuario(txtBusca.Text);
                dgvListaUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Nome e senha são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja cadastrar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD("1");
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um usuário para alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja alterar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD("2");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um usuário para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CRUD("3");
            }
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListaUsuarios.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                cmbTipo.SelectedValue = row.Cells["id_tipo"].Value.ToString();

                txtSenha.Clear();
            }
        }
    }
}