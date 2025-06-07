namespace Ponto
{
    partial class usuarios
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
            dataGridView1 = new DataGridView();
            Nome = new TextBox();
            Email = new TextBox();
            Codigo = new TextBox();
            Senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cargo = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(872, 296);
            dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.Location = new Point(27, 100);
            Nome.Name = "Nome";
            Nome.Size = new Size(150, 23);
            Nome.TabIndex = 1;
            // 
            // Email
            // 
            Email.Location = new Point(195, 100);
            Email.Name = "Email";
            Email.Size = new Size(154, 23);
            Email.TabIndex = 2;
            // 
            // Codigo
            // 
            Codigo.Location = new Point(365, 100);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(154, 23);
            Codigo.TabIndex = 3;
            // 
            // Senha
            // 
            Senha.Location = new Point(536, 100);
            Senha.Name = "Senha";
            Senha.Size = new Size(154, 23);
            Senha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 82);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "EmaiL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 82);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 82);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // cargo
            // 
            cargo.Location = new Point(703, 100);
            cargo.Name = "cargo";
            cargo.Size = new Size(126, 23);
            cargo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(703, 82);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Cargo:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 130);
            button1.Name = "button1";
            button1.Size = new Size(210, 48);
            button1.TabIndex = 17;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(247, 130);
            button2.Name = "button2";
            button2.Size = new Size(210, 48);
            button2.TabIndex = 18;
            button2.Text = "Novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(463, 129);
            button3.Name = "button3";
            button3.Size = new Size(210, 48);
            button3.TabIndex = 19;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(423, 46);
            label6.Name = "label6";
            label6.Size = new Size(97, 29);
            label6.TabIndex = 21;
            label6.Text = "Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(247, -7);
            label7.Name = "label7";
            label7.Size = new Size(445, 65);
            label7.TabIndex = 20;
            label7.Text = "PONTO DE HORAS";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(679, 130);
            button4.Name = "button4";
            button4.Size = new Size(210, 48);
            button4.TabIndex = 22;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgazul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 492);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(cargo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Senha);
            Controls.Add(Codigo);
            Controls.Add(Email);
            Controls.Add(Nome);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "painel usuarios";
            Load += usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Nome;
        private TextBox Email;
        private TextBox Codigo;
        private TextBox Senha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cargo;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private Label label7;
        private Button button4;
    }
}