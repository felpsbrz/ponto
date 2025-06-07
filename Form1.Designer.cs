namespace Ponto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Menu = new ContextMenuStrip(components);
            recuperarSenhaToolStripMenuItem = new ToolStripMenuItem();
            painelAdminToolStripMenuItem1 = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            recuperarSenhaToolStripMenuItem1 = new ToolStripMenuItem();
            painelAdminToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem1 = new ToolStripMenuItem();
            Menu.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(208, 371);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 70);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TabStopChanged += textBox1_TabStopChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(445, 65);
            label1.TabIndex = 3;
            label1.Text = "PONTO DE HORAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 109);
            label2.Name = "label2";
            label2.Size = new Size(354, 29);
            label2.TabIndex = 4;
            label2.Text = "“JUNTOS VAMOS MAIS LONGE”";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(414, 303);
            label3.Name = "label3";
            label3.Size = new Size(226, 65);
            label3.TabIndex = 9;
            label3.Text = "CODIGO:";
            label3.Click += label3_Click;
            // 
            // Menu
            // 
            Menu.AutoClose = false;
            Menu.Items.AddRange(new ToolStripItem[] { recuperarSenhaToolStripMenuItem, painelAdminToolStripMenuItem1, fecharToolStripMenuItem });
            Menu.Name = "Menu";
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(163, 70);
            Menu.Text = "Menu";
            // 
            // recuperarSenhaToolStripMenuItem
            // 
            recuperarSenhaToolStripMenuItem.Name = "recuperarSenhaToolStripMenuItem";
            recuperarSenhaToolStripMenuItem.Size = new Size(162, 22);
            recuperarSenhaToolStripMenuItem.Text = "Recuperar Senha";
            // 
            // painelAdminToolStripMenuItem1
            // 
            painelAdminToolStripMenuItem1.Name = "painelAdminToolStripMenuItem1";
            painelAdminToolStripMenuItem1.Size = new Size(162, 22);
            painelAdminToolStripMenuItem1.Text = "Painel Admin";
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(162, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1049, 24);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "Menu";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recuperarSenhaToolStripMenuItem1, painelAdminToolStripMenuItem, fecharToolStripMenuItem1 });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // recuperarSenhaToolStripMenuItem1
            // 
            recuperarSenhaToolStripMenuItem1.Name = "recuperarSenhaToolStripMenuItem1";
            recuperarSenhaToolStripMenuItem1.Size = new Size(180, 22);
            recuperarSenhaToolStripMenuItem1.Text = "Recuperar Senha";
            // 
            // painelAdminToolStripMenuItem
            // 
            painelAdminToolStripMenuItem.Name = "painelAdminToolStripMenuItem";
            painelAdminToolStripMenuItem.Size = new Size(180, 22);
            painelAdminToolStripMenuItem.Text = "Painel Admin";
            painelAdminToolStripMenuItem.Click += painelAdminToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem1
            // 
            fecharToolStripMenuItem1.Name = "fecharToolStripMenuItem1";
            fecharToolStripMenuItem1.Size = new Size(180, 22);
            fecharToolStripMenuItem1.Text = "Fechar";
            fecharToolStripMenuItem1.Click += fecharToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 642);
            Controls.Add(menuStrip);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponto de Horas";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip Menu;
        private ToolStripMenuItem recuperarSenhaToolStripMenuItem;
        private ToolStripMenuItem painelAdminToolStripMenuItem1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem recuperarSenhaToolStripMenuItem1;
        private ToolStripMenuItem painelAdminToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem1;
    }
}
