namespace GestãoEscolar
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.imgSair = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbInsercao = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbBusca = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).BeginInit();
            this.grbInsercao.SuspendLayout();
            this.grbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Red;
            this.pnlCabecalho.Controls.Add(this.imgSair);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.ForeColor = System.Drawing.Color.Black;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(800, 100);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // imgSair
            // 
            this.imgSair.Image = global::GestãoEscolar.Properties.Resources.Cancel_icon_icons_com_73703;
            this.imgSair.Location = new System.Drawing.Point(746, 12);
            this.imgSair.Name = "imgSair";
            this.imgSair.Size = new System.Drawing.Size(42, 30);
            this.imgSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSair.TabIndex = 9;
            this.imgSair.TabStop = false;
            this.imgSair.Click += new System.EventHandler(this.imgSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(303, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 26);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Cadastro de usuarios";
            // 
            // grbInsercao
            // 
            this.grbInsercao.Controls.Add(this.cmbTipo);
            this.grbInsercao.Controls.Add(this.txtNome);
            this.grbInsercao.Controls.Add(this.txtSenha);
            this.grbInsercao.Controls.Add(this.lblTipo);
            this.grbInsercao.Controls.Add(this.lblNome);
            this.grbInsercao.Controls.Add(this.lblSenha);
            this.grbInsercao.Controls.Add(this.txtId);
            this.grbInsercao.Controls.Add(this.lblId);
            this.grbInsercao.Location = new System.Drawing.Point(26, 120);
            this.grbInsercao.Name = "grbInsercao";
            this.grbInsercao.Size = new System.Drawing.Size(748, 116);
            this.grbInsercao.TabIndex = 1;
            this.grbInsercao.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(57, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(176, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(417, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(417, 74);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 77);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(376, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(376, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtId.Location = new System.Drawing.Point(57, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Red;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(338, 242);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 43);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(465, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Excluir";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(213, 242);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 43);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.txtBusca);
            this.grbBusca.Controls.Add(this.lblBuscar);
            this.grbBusca.Location = new System.Drawing.Point(26, 304);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(748, 45);
            this.grbBusca.TabIndex = 6;
            this.grbBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(57, 19);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(176, 20);
            this.txtBusca.TabIndex = 9;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(16, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(26, 355);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(748, 150);
            this.dgvListaUsuarios.TabIndex = 7;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.grbBusca);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.grbInsercao);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).EndInit();
            this.grbInsercao.ResumeLayout(false);
            this.grbInsercao.PerformLayout();
            this.grbBusca.ResumeLayout(false);
            this.grbBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.GroupBox grbInsercao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.PictureBox imgSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}