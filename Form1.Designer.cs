namespace ExemploBDInsert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btn_ConfirmarCadastro = new Button();
            btn_MostrarDados = new Button();
            button1 = new Button();
            lbl_Nome = new Label();
            lbl_Email = new Label();
            txt_Nome = new TextBox();
            txt_Email = new TextBox();
            telefone = new Label();
            nacionalidade = new Label();
            txt_telefone = new TextBox();
            txt_nacionalidade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(170, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(503, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btn_ConfirmarCadastro
            // 
            btn_ConfirmarCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_ConfirmarCadastro.Location = new Point(170, 401);
            btn_ConfirmarCadastro.Name = "btn_ConfirmarCadastro";
            btn_ConfirmarCadastro.Size = new Size(503, 56);
            btn_ConfirmarCadastro.TabIndex = 1;
            btn_ConfirmarCadastro.Text = "Confirmar Cadastro";
            btn_ConfirmarCadastro.UseVisualStyleBackColor = true;
            btn_ConfirmarCadastro.Visible = false;
            btn_ConfirmarCadastro.Click += btn_Cadastrar_Click;
            // 
            // btn_MostrarDados
            // 
            btn_MostrarDados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_MostrarDados.Location = new Point(425, 185);
            btn_MostrarDados.Name = "btn_MostrarDados";
            btn_MostrarDados.Size = new Size(248, 56);
            btn_MostrarDados.TabIndex = 2;
            btn_MostrarDados.Text = "Mostrar Dados";
            btn_MostrarDados.UseVisualStyleBackColor = true;
            btn_MostrarDados.Click += btn_MostrarDados_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(170, 185);
            button1.Name = "button1";
            button1.Size = new Size(241, 56);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbl_Nome.Location = new Point(170, 258);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(131, 20);
            lbl_Nome.TabIndex = 4;
            lbl_Nome.Text = "Informe o nome: ";
            lbl_Nome.Visible = false;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbl_Email.Location = new Point(170, 300);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(131, 20);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "Informe o e-mail:";
            lbl_Email.Visible = false;
            // 
            // txt_Nome
            // 
            txt_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_Nome.Location = new Point(324, 258);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(349, 27);
            txt_Nome.TabIndex = 6;
            txt_Nome.Visible = false;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_Email.Location = new Point(324, 300);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(349, 27);
            txt_Email.TabIndex = 7;
            txt_Email.Visible = false;
            // 
            // telefone
            // 
            telefone.AutoSize = true;
            telefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            telefone.Location = new Point(170, 371);
            telefone.Name = "telefone";
            telefone.Size = new Size(145, 20);
            telefone.TabIndex = 8;
            telefone.Text = "Informe o telefone:";
            telefone.Visible = false;
            // 
            // nacionalidade
            // 
            nacionalidade.AutoSize = true;
            nacionalidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nacionalidade.Location = new Point(170, 337);
            nacionalidade.Name = "nacionalidade";
            nacionalidade.Size = new Size(182, 20);
            nacionalidade.TabIndex = 9;
            nacionalidade.Text = "Informe a nacionalidade:";
            nacionalidade.Visible = false;
            nacionalidade.Click += label2_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_telefone.Location = new Point(324, 368);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(349, 27);
            txt_telefone.TabIndex = 10;
            txt_telefone.Visible = false;
            // 
            // txt_nacionalidade
            // 
            txt_nacionalidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_nacionalidade.Location = new Point(358, 333);
            txt_nacionalidade.Name = "txt_nacionalidade";
            txt_nacionalidade.Size = new Size(315, 27);
            txt_nacionalidade.TabIndex = 11;
            txt_nacionalidade.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 462);
            Controls.Add(txt_nacionalidade);
            Controls.Add(txt_telefone);
            Controls.Add(nacionalidade);
            Controls.Add(telefone);
            Controls.Add(txt_Email);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Nome);
            Controls.Add(button1);
            Controls.Add(btn_MostrarDados);
            Controls.Add(btn_ConfirmarCadastro);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_ConfirmarCadastro;
        private Button btn_MostrarDados;
        private Button button1;
        private Label lbl_Nome;
        private Label lbl_Email;
        private TextBox txt_Nome;
        private TextBox txt_Email;
        private Label telefone;
        private Label nacionalidade;
        private TextBox txt_telefone;
        private TextBox txt_nacionalidade;
    }
}
