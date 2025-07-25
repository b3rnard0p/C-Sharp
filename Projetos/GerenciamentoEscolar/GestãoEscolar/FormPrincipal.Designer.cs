namespace GestãoEscolar
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.imgSair = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHora1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEstatistica = new System.Windows.Forms.Label();
            this.lblLogoff = new System.Windows.Forms.Label();
            this.imgEstatistica = new System.Windows.Forms.PictureBox();
            this.imgAluno = new System.Windows.Forms.PictureBox();
            this.imgLogoff = new System.Windows.Forms.PictureBox();
            this.imgSenha = new System.Windows.Forms.PictureBox();
            this.imgSala = new System.Windows.Forms.PictureBox();
            this.imgCurso = new System.Windows.Forms.PictureBox();
            this.imgRelatorio = new System.Windows.Forms.PictureBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).BeginInit();
            this.pnlRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstatistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Red;
            this.pnlCabecalho.Controls.Add(this.imgSair);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(800, 59);
            this.pnlCabecalho.TabIndex = 17;
            // 
            // imgSair
            // 
            this.imgSair.Image = global::GestãoEscolar.Properties.Resources.Cancel_icon_icons_com_73703;
            this.imgSair.Location = new System.Drawing.Point(753, 3);
            this.imgSair.Name = "imgSair";
            this.imgSair.Size = new System.Drawing.Size(44, 36);
            this.imgSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSair.TabIndex = 1;
            this.imgSair.TabStop = false;
            this.imgSair.Click += new System.EventHandler(this.imgSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Red;
            this.lblTitulo.Font = new System.Drawing.Font("Onyx", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(287, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento Escolar";
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlRodape.Controls.Add(this.lblUsuario);
            this.pnlRodape.Controls.Add(this.lblHora1);
            this.pnlRodape.Controls.Add(this.lblData2);
            this.pnlRodape.Controls.Add(this.lblData1);
            this.pnlRodape.Controls.Add(this.lblHora2);
            this.pnlRodape.Controls.Add(this.label2);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.ForeColor = System.Drawing.Color.White;
            this.pnlRodape.Location = new System.Drawing.Point(0, 409);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(800, 41);
            this.pnlRodape.TabIndex = 18;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "lblusuario";
            // 
            // lblHora1
            // 
            this.lblHora1.AutoSize = true;
            this.lblHora1.ForeColor = System.Drawing.Color.White;
            this.lblHora1.Location = new System.Drawing.Point(404, 19);
            this.lblHora1.Name = "lblHora1";
            this.lblHora1.Size = new System.Drawing.Size(33, 13);
            this.lblHora1.TabIndex = 5;
            this.lblHora1.Text = "Hora:";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.ForeColor = System.Drawing.Color.White;
            this.lblData2.Location = new System.Drawing.Point(592, 19);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(65, 13);
            this.lblData2.TabIndex = 4;
            this.lblData2.Text = "00/00/0000";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.ForeColor = System.Drawing.Color.White;
            this.lblData1.Location = new System.Drawing.Point(553, 19);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(33, 13);
            this.lblData1.TabIndex = 3;
            this.lblData1.Text = "Data:";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.ForeColor = System.Drawing.Color.White;
            this.lblHora2.Location = new System.Drawing.Point(445, 19);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(49, 13);
            this.lblHora2.TabIndex = 2;
            this.lblHora2.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAluno.Location = new System.Drawing.Point(128, 202);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(99, 13);
            this.lblAluno.TabIndex = 6;
            this.lblAluno.Text = "Cadastro de Alunos";
            this.imgAluno.Click += new System.EventHandler(this.imgAluno_Click);
            this.lblAluno.Click += new System.EventHandler(this.lblAluno_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSala.Location = new System.Drawing.Point(276, 202);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(93, 13);
            this.lblSala.TabIndex = 19;
            this.lblSala.Text = "Cadastro de Salas";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurso.Location = new System.Drawing.Point(410, 202);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(99, 13);
            this.lblCurso.TabIndex = 20;
            this.lblCurso.Text = "Cadastro de Cursos";
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRelatorio.Location = new System.Drawing.Point(292, 310);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(54, 13);
            this.lblRelatorio.TabIndex = 21;
            this.lblRelatorio.Text = "Relatórios";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadUsuario.Location = new System.Drawing.Point(553, 202);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(108, 13);
            this.lblCadUsuario.TabIndex = 21;
            this.lblCadUsuario.Text = "Cadastro de Usuários";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSenha.Location = new System.Drawing.Point(144, 310);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 13);
            this.lblSenha.TabIndex = 22;
            this.lblSenha.Text = "Alterar Senha";
            // 
            // lblEstatistica
            // 
            this.lblEstatistica.AutoSize = true;
            this.lblEstatistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstatistica.Location = new System.Drawing.Point(432, 310);
            this.lblEstatistica.Name = "lblEstatistica";
            this.lblEstatistica.Size = new System.Drawing.Size(62, 13);
            this.lblEstatistica.TabIndex = 23;
            this.lblEstatistica.Text = "Estatistícas";
            // 
            // lblLogoff
            // 
            this.lblLogoff.AutoSize = true;
            this.lblLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogoff.Location = new System.Drawing.Point(580, 310);
            this.lblLogoff.Name = "lblLogoff";
            this.lblLogoff.Size = new System.Drawing.Size(42, 13);
            this.lblLogoff.TabIndex = 24;
            this.lblLogoff.Text = "Log Off";
            // 
            // imgEstatistica
            // 
            this.imgEstatistica.BackColor = System.Drawing.Color.Silver;
            this.imgEstatistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEstatistica.Image = global::GestãoEscolar.Properties.Resources._1491254488_chartflexibledatestatstatistics_82950;
            this.imgEstatistica.Location = new System.Drawing.Point(394, 234);
            this.imgEstatistica.Name = "imgEstatistica";
            this.imgEstatistica.Size = new System.Drawing.Size(136, 89);
            this.imgEstatistica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgEstatistica.TabIndex = 16;
            this.imgEstatistica.TabStop = false;
            // 
            // imgAluno
            // 
            this.imgAluno.BackColor = System.Drawing.Color.Silver;
            this.imgAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAluno.Image = global::GestãoEscolar.Properties.Resources.student_man_avatar_user_toga_school_university_icon_209294;
            this.imgAluno.Location = new System.Drawing.Point(111, 126);
            this.imgAluno.Name = "imgAluno";
            this.imgAluno.Size = new System.Drawing.Size(136, 89);
            this.imgAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAluno.TabIndex = 14;
            this.imgAluno.TabStop = false;
            this.imgAluno.Click += new System.EventHandler(this.imgAluno_Click);
            // 
            // imgLogoff
            // 
            this.imgLogoff.BackColor = System.Drawing.Color.Silver;
            this.imgLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogoff.Image = global::GestãoEscolar.Properties.Resources.restart_off_icon_136266;
            this.imgLogoff.Location = new System.Drawing.Point(536, 234);
            this.imgLogoff.Name = "imgLogoff";
            this.imgLogoff.Size = new System.Drawing.Size(136, 89);
            this.imgLogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogoff.TabIndex = 12;
            this.imgLogoff.TabStop = false;
            // 
            // imgSenha
            // 
            this.imgSenha.BackColor = System.Drawing.Color.Silver;
            this.imgSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSenha.Image = global::GestãoEscolar.Properties.Resources.key_silhouette_security_tool_interface_symbol_of_password_icon_icons_com_54503;
            this.imgSenha.Location = new System.Drawing.Point(111, 234);
            this.imgSenha.Name = "imgSenha";
            this.imgSenha.Size = new System.Drawing.Size(136, 89);
            this.imgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSenha.TabIndex = 10;
            this.imgSenha.TabStop = false;
            // 
            // imgSala
            // 
            this.imgSala.BackColor = System.Drawing.Color.Silver;
            this.imgSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSala.Image = global::GestãoEscolar.Properties.Resources.google_classroom_icon_138523;
            this.imgSala.Location = new System.Drawing.Point(253, 126);
            this.imgSala.Name = "imgSala";
            this.imgSala.Size = new System.Drawing.Size(136, 89);
            this.imgSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSala.TabIndex = 8;
            this.imgSala.TabStop = false;
            // 
            // imgCurso
            // 
            this.imgCurso.BackColor = System.Drawing.Color.Silver;
            this.imgCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCurso.Image = global::GestãoEscolar.Properties.Resources.courses_48_44531;
            this.imgCurso.Location = new System.Drawing.Point(394, 126);
            this.imgCurso.Name = "imgCurso";
            this.imgCurso.Size = new System.Drawing.Size(136, 89);
            this.imgCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgCurso.TabIndex = 6;
            this.imgCurso.TabStop = false;
            // 
            // imgRelatorio
            // 
            this.imgRelatorio.BackColor = System.Drawing.Color.Silver;
            this.imgRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRelatorio.Image = global::GestãoEscolar.Properties.Resources._4124799_finance_report_graph_analysis_graph_report_sale_report_stock_report_113890;
            this.imgRelatorio.Location = new System.Drawing.Point(253, 234);
            this.imgRelatorio.Name = "imgRelatorio";
            this.imgRelatorio.Size = new System.Drawing.Size(136, 89);
            this.imgRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgRelatorio.TabIndex = 4;
            this.imgRelatorio.TabStop = false;
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackColor = System.Drawing.Color.Silver;
            this.imgUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUsuario.Image = global::GestãoEscolar.Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            this.imgUsuario.Location = new System.Drawing.Point(536, 126);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(136, 89);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgUsuario.TabIndex = 2;
            this.imgUsuario.TabStop = false;
            this.imgUsuario.Click += new System.EventHandler(this.imgUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(536, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 8);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogoff);
            this.Controls.Add(this.lblEstatistica);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblRelatorio);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.imgEstatistica);
            this.Controls.Add(this.imgAluno);
            this.Controls.Add(this.imgLogoff);
            this.Controls.Add(this.imgSenha);
            this.Controls.Add(this.imgSala);
            this.Controls.Add(this.imgCurso);
            this.Controls.Add(this.imgRelatorio);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstatistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgRelatorio;
        private System.Windows.Forms.PictureBox imgCurso;
        private System.Windows.Forms.PictureBox imgSala;
        private System.Windows.Forms.PictureBox imgSenha;
        private System.Windows.Forms.PictureBox imgLogoff;
        private System.Windows.Forms.PictureBox imgAluno;
        private System.Windows.Forms.PictureBox imgEstatistica;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox imgSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblHora1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEstatistica;
        private System.Windows.Forms.Label lblLogoff;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer tmrDataHora;
    }
}