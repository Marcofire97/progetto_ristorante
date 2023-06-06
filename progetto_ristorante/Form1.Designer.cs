namespace progetto_ristorante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcbLogoRegister = new PictureBox();
            pcbUtenteRegister = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txbEmailRegister = new TextBox();
            pcbEmailRegister = new PictureBox();
            panel3 = new Panel();
            txbPasswordRegister = new TextBox();
            pcbiPasswordRegister = new PictureBox();
            lblLoggaticon = new Label();
            pcbVaialLogin = new PictureBox();
            btnRegistrati = new Button();
            txbUtenteRegister = new TextBox();
            cmbPasswordRegister = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogoRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtenteRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmailRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbiPasswordRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVaialLogin).BeginInit();
            SuspendLayout();
            // 
            // pcbLogoRegister
            // 
            pcbLogoRegister.Image = (Image)resources.GetObject("pcbLogoRegister.Image");
            pcbLogoRegister.Location = new Point(145, 15);
            pcbLogoRegister.Name = "pcbLogoRegister";
            pcbLogoRegister.Size = new Size(79, 84);
            pcbLogoRegister.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbLogoRegister.TabIndex = 0;
            pcbLogoRegister.TabStop = false;
            // 
            // pcbUtenteRegister
            // 
            pcbUtenteRegister.Image = (Image)resources.GetObject("pcbUtenteRegister.Image");
            pcbUtenteRegister.Location = new Point(50, 147);
            pcbUtenteRegister.Name = "pcbUtenteRegister";
            pcbUtenteRegister.Size = new Size(29, 33);
            pcbUtenteRegister.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbUtenteRegister.TabIndex = 1;
            pcbUtenteRegister.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(50, 189);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(50, 276);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 1);
            panel2.TabIndex = 6;
            // 
            // txbEmailRegister
            // 
            txbEmailRegister.BackColor = Color.FromArgb(34, 36, 49);
            txbEmailRegister.BorderStyle = BorderStyle.None;
            txbEmailRegister.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmailRegister.ForeColor = Color.WhiteSmoke;
            txbEmailRegister.Location = new Point(86, 241);
            txbEmailRegister.Name = "txbEmailRegister";
            txbEmailRegister.Size = new Size(250, 22);
            txbEmailRegister.TabIndex = 5;
            txbEmailRegister.TextChanged += txbEmailRegister_TextChanged;
            // 
            // pcbEmailRegister
            // 
            pcbEmailRegister.Image = (Image)resources.GetObject("pcbEmailRegister.Image");
            pcbEmailRegister.Location = new Point(50, 233);
            pcbEmailRegister.Name = "pcbEmailRegister";
            pcbEmailRegister.Size = new Size(29, 33);
            pcbEmailRegister.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbEmailRegister.TabIndex = 4;
            pcbEmailRegister.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(50, 360);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 1);
            panel3.TabIndex = 9;
            // 
            // txbPasswordRegister
            // 
            txbPasswordRegister.BackColor = Color.FromArgb(34, 36, 49);
            txbPasswordRegister.BorderStyle = BorderStyle.None;
            txbPasswordRegister.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbPasswordRegister.ForeColor = Color.WhiteSmoke;
            txbPasswordRegister.Location = new Point(85, 325);
            txbPasswordRegister.Name = "txbPasswordRegister";
            txbPasswordRegister.PasswordChar = '*';
            txbPasswordRegister.Size = new Size(251, 22);
            txbPasswordRegister.TabIndex = 8;
            txbPasswordRegister.TextChanged += txbPasswordRegister_TextChanged;
            // 
            // pcbiPasswordRegister
            // 
            pcbiPasswordRegister.Image = (Image)resources.GetObject("pcbiPasswordRegister.Image");
            pcbiPasswordRegister.Location = new Point(50, 317);
            pcbiPasswordRegister.Name = "pcbiPasswordRegister";
            pcbiPasswordRegister.Size = new Size(29, 33);
            pcbiPasswordRegister.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbiPasswordRegister.TabIndex = 7;
            pcbiPasswordRegister.TabStop = false;
            // 
            // lblLoggaticon
            // 
            lblLoggaticon.AutoSize = true;
            lblLoggaticon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoggaticon.ForeColor = Color.White;
            lblLoggaticon.Location = new Point(102, 471);
            lblLoggaticon.Name = "lblLoggaticon";
            lblLoggaticon.Size = new Size(162, 23);
            lblLoggaticon.TabIndex = 10;
            lblLoggaticon.Text = "Hai già un account?";
            // 
            // pcbVaialLogin
            // 
            pcbVaialLogin.Cursor = Cursors.Hand;
            pcbVaialLogin.Image = (Image)resources.GetObject("pcbVaialLogin.Image");
            pcbVaialLogin.Location = new Point(154, 498);
            pcbVaialLogin.Margin = new Padding(3, 4, 3, 4);
            pcbVaialLogin.Name = "pcbVaialLogin";
            pcbVaialLogin.Size = new Size(56, 53);
            pcbVaialLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbVaialLogin.TabIndex = 11;
            pcbVaialLogin.TabStop = false;
            pcbVaialLogin.Click += pcbVaialLogin_Click;
            // 
            // btnRegistrati
            // 
            btnRegistrati.BackColor = Color.FromArgb(78, 184, 206);
            btnRegistrati.FlatAppearance.MouseDownBackColor = Color.FromArgb(78, 184, 206);
            btnRegistrati.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 184, 206);
            btnRegistrati.FlatStyle = FlatStyle.Flat;
            btnRegistrati.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrati.ForeColor = Color.FromArgb(34, 36, 49);
            btnRegistrati.Location = new Point(85, 403);
            btnRegistrati.Name = "btnRegistrati";
            btnRegistrati.Size = new Size(197, 54);
            btnRegistrati.TabIndex = 12;
            btnRegistrati.Text = "Registrati";
            btnRegistrati.UseVisualStyleBackColor = false;
            btnRegistrati.Click += btnRegistrati_Click;
            // 
            // txbUtenteRegister
            // 
            txbUtenteRegister.BackColor = Color.FromArgb(34, 36, 49);
            txbUtenteRegister.BorderStyle = BorderStyle.None;
            txbUtenteRegister.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbUtenteRegister.ForeColor = Color.WhiteSmoke;
            txbUtenteRegister.Location = new Point(86, 155);
            txbUtenteRegister.Name = "txbUtenteRegister";
            txbUtenteRegister.Size = new Size(250, 22);
            txbUtenteRegister.TabIndex = 2;
            txbUtenteRegister.TextChanged += txbUtenteRegister_TextChanged;
            // 
            // cmbPasswordRegister
            // 
            cmbPasswordRegister.AutoSize = true;
            cmbPasswordRegister.Cursor = Cursors.Hand;
            cmbPasswordRegister.FlatStyle = FlatStyle.Flat;
            cmbPasswordRegister.ForeColor = Color.WhiteSmoke;
            cmbPasswordRegister.Location = new Point(50, 368);
            cmbPasswordRegister.Name = "cmbPasswordRegister";
            cmbPasswordRegister.Size = new Size(138, 24);
            cmbPasswordRegister.TabIndex = 27;
            cmbPasswordRegister.Text = "Mostra Password";
            cmbPasswordRegister.UseVisualStyleBackColor = true;
            cmbPasswordRegister.CheckedChanged += cmbPasswordRegister_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(385, 563);
            Controls.Add(cmbPasswordRegister);
            Controls.Add(btnRegistrati);
            Controls.Add(pcbVaialLogin);
            Controls.Add(lblLoggaticon);
            Controls.Add(panel3);
            Controls.Add(txbPasswordRegister);
            Controls.Add(pcbiPasswordRegister);
            Controls.Add(panel2);
            Controls.Add(txbEmailRegister);
            Controls.Add(pcbEmailRegister);
            Controls.Add(panel1);
            Controls.Add(txbUtenteRegister);
            Controls.Add(pcbUtenteRegister);
            Controls.Add(pcbLogoRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pcbLogoRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtenteRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmailRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbiPasswordRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVaialLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogoRegister;
        private PictureBox pcbUtenteRegister;
        private Panel panel1;
        private Panel panel2;
        private TextBox txbEmailRegister;
        private PictureBox pcbEmailRegister;
        private Panel panel3;
        private TextBox txbPasswordRegister;
        private PictureBox pcbiPasswordRegister;
        private Label lblLoggaticon;
        private PictureBox pcbVaialLogin;
        private Button btnRegistrati;
        private TextBox txbUtenteRegister;
        private CheckBox cmbPasswordRegister;
    }
}