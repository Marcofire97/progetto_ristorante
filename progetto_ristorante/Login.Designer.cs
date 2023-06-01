namespace progetto_ristorante
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			btnAccedi = new Button();
			pcbNuovoUtente = new PictureBox();
			lblLoggaticon = new Label();
			panel3 = new Panel();
			txbPassword = new TextBox();
			pcbPasswordLogin = new PictureBox();
			panel2 = new Panel();
			txbEmail = new TextBox();
			pcbEmailLogin = new PictureBox();
			pcbLogoLogin = new PictureBox();
			cmbPasswordLogin = new CheckBox();
			((System.ComponentModel.ISupportInitialize)pcbNuovoUtente).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbPasswordLogin).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbEmailLogin).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbLogoLogin).BeginInit();
			SuspendLayout();
			// 
			// btnAccedi
			// 
			btnAccedi.BackColor = Color.FromArgb(78, 184, 206);
			btnAccedi.FlatStyle = FlatStyle.Flat;
			btnAccedi.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnAccedi.ForeColor = Color.FromArgb(34, 36, 49);
			btnAccedi.Location = new Point(70, 311);
			btnAccedi.Name = "btnAccedi";
			btnAccedi.Size = new Size(197, 54);
			btnAccedi.TabIndex = 25;
			btnAccedi.Text = "Accedi";
			btnAccedi.UseVisualStyleBackColor = false;
			btnAccedi.Click += btnAccedi_Click;
			// 
			// pcbNuovoUtente
			// 
			pcbNuovoUtente.Image = (Image)resources.GetObject("pcbNuovoUtente.Image");
			pcbNuovoUtente.Location = new Point(138, 406);
			pcbNuovoUtente.Margin = new Padding(3, 4, 3, 4);
			pcbNuovoUtente.Name = "pcbNuovoUtente";
			pcbNuovoUtente.Size = new Size(56, 53);
			pcbNuovoUtente.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbNuovoUtente.TabIndex = 24;
			pcbNuovoUtente.TabStop = false;
			pcbNuovoUtente.Click += pcbNuovoUtente_Click;
			// 
			// lblLoggaticon
			// 
			lblLoggaticon.AutoSize = true;
			lblLoggaticon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblLoggaticon.ForeColor = Color.White;
			lblLoggaticon.Location = new Point(82, 379);
			lblLoggaticon.Name = "lblLoggaticon";
			lblLoggaticon.Size = new Size(170, 23);
			lblLoggaticon.TabIndex = 23;
			lblLoggaticon.Text = "Non hai un account?";
			// 
			// panel3
			// 
			panel3.BackColor = Color.WhiteSmoke;
			panel3.Location = new Point(35, 262);
			panel3.Margin = new Padding(3, 4, 3, 4);
			panel3.Name = "panel3";
			panel3.Size = new Size(286, 1);
			panel3.TabIndex = 22;
			// 
			// txbPassword
			// 
			txbPassword.BackColor = Color.FromArgb(34, 36, 49);
			txbPassword.BorderStyle = BorderStyle.None;
			txbPassword.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			txbPassword.ForeColor = Color.WhiteSmoke;
			txbPassword.Location = new Point(71, 227);
			txbPassword.Name = "txbPassword";
			txbPassword.PasswordChar = '*';
			txbPassword.Size = new Size(251, 22);
			txbPassword.TabIndex = 21;
			txbPassword.TextChanged += txbPassword_TextChanged;
			// 
			// pcbPasswordLogin
			// 
			pcbPasswordLogin.Image = (Image)resources.GetObject("pcbPasswordLogin.Image");
			pcbPasswordLogin.Location = new Point(35, 219);
			pcbPasswordLogin.Name = "pcbPasswordLogin";
			pcbPasswordLogin.Size = new Size(29, 33);
			pcbPasswordLogin.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbPasswordLogin.TabIndex = 20;
			pcbPasswordLogin.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.WhiteSmoke;
			panel2.Location = new Point(35, 178);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(286, 1);
			panel2.TabIndex = 19;
			// 
			// txbEmail
			// 
			txbEmail.BackColor = Color.FromArgb(34, 36, 49);
			txbEmail.BorderStyle = BorderStyle.None;
			txbEmail.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			txbEmail.ForeColor = Color.WhiteSmoke;
			txbEmail.Location = new Point(71, 143);
			txbEmail.Name = "txbEmail";
			txbEmail.Size = new Size(250, 22);
			txbEmail.TabIndex = 18;
			// 
			// pcbEmailLogin
			// 
			pcbEmailLogin.Image = (Image)resources.GetObject("pcbEmailLogin.Image");
			pcbEmailLogin.Location = new Point(35, 135);
			pcbEmailLogin.Name = "pcbEmailLogin";
			pcbEmailLogin.Size = new Size(29, 33);
			pcbEmailLogin.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbEmailLogin.TabIndex = 17;
			pcbEmailLogin.TabStop = false;
			pcbEmailLogin.Click += pictureBox3_Click;
			// 
			// pcbLogoLogin
			// 
			pcbLogoLogin.Image = (Image)resources.GetObject("pcbLogoLogin.Image");
			pcbLogoLogin.Location = new Point(139, 12);
			pcbLogoLogin.Name = "pcbLogoLogin";
			pcbLogoLogin.Size = new Size(79, 84);
			pcbLogoLogin.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbLogoLogin.TabIndex = 13;
			pcbLogoLogin.TabStop = false;
			// 
			// cmbPasswordLogin
			// 
			cmbPasswordLogin.AutoSize = true;
			cmbPasswordLogin.Cursor = Cursors.Hand;
			cmbPasswordLogin.FlatStyle = FlatStyle.Flat;
			cmbPasswordLogin.ForeColor = Color.WhiteSmoke;
			cmbPasswordLogin.Location = new Point(35, 272);
			cmbPasswordLogin.Name = "cmbPasswordLogin";
			cmbPasswordLogin.Size = new Size(138, 24);
			cmbPasswordLogin.TabIndex = 26;
			cmbPasswordLogin.Text = "Mostra Password";
			cmbPasswordLogin.UseVisualStyleBackColor = true;
			cmbPasswordLogin.CheckedChanged += cmbPasswordLogin_CheckedChanged;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(34, 36, 49);
			ClientSize = new Size(360, 499);
			Controls.Add(txbPassword);
			Controls.Add(cmbPasswordLogin);
			Controls.Add(btnAccedi);
			Controls.Add(pcbNuovoUtente);
			Controls.Add(lblLoggaticon);
			Controls.Add(panel3);
			Controls.Add(pcbPasswordLogin);
			Controls.Add(panel2);
			Controls.Add(txbEmail);
			Controls.Add(pcbEmailLogin);
			Controls.Add(pcbLogoLogin);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pcbNuovoUtente).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbPasswordLogin).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbEmailLogin).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbLogoLogin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAccedi;
		private PictureBox pcbNuovoUtente;
		private Label lblLoggaticon;
		private Panel panel3;
		private TextBox txbPassword;
		private PictureBox pcbPasswordLogin;
		private Panel panel2;
		private TextBox txbEmail;
		private PictureBox pcbEmailLogin;
		private PictureBox pcbLogoLogin;
		private CheckBox cmbPasswordLogin;
	}
}