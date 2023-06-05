namespace progetto_ristorante
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            pcbFotoProfilo = new PictureBox();
            btnInserisciFotoProfilo = new Button();
            lblProfilo = new Label();
            pcbTornaHomeProfilo = new PictureBox();
            label1 = new Label();
            btnRimuovi = new Button();
            grbDatiSensibili = new GroupBox();
            btnLogOut = new Button();
            lblUsername = new Label();
            label3 = new Label();
            lblEmaill = new Label();
            lblEmail = new Label();
            grbFotoProfilo = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEliminaAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFotoProfilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeProfilo).BeginInit();
            grbDatiSensibili.SuspendLayout();
            grbFotoProfilo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pcbFotoProfilo
            // 
            pcbFotoProfilo.Location = new Point(11, 76);
            pcbFotoProfilo.Name = "pcbFotoProfilo";
            pcbFotoProfilo.Size = new Size(56, 50);
            pcbFotoProfilo.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbFotoProfilo.TabIndex = 0;
            pcbFotoProfilo.TabStop = false;
            // 
            // btnInserisciFotoProfilo
            // 
            btnInserisciFotoProfilo.Location = new Point(80, 88);
            btnInserisciFotoProfilo.Name = "btnInserisciFotoProfilo";
            btnInserisciFotoProfilo.Size = new Size(94, 29);
            btnInserisciFotoProfilo.TabIndex = 1;
            btnInserisciFotoProfilo.Text = "Inserisci";
            btnInserisciFotoProfilo.UseVisualStyleBackColor = true;
            btnInserisciFotoProfilo.Click += btnInserisciFotoProfilo_Click;
            // 
            // lblProfilo
            // 
            lblProfilo.AutoSize = true;
            lblProfilo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfilo.ForeColor = Color.FromArgb(255, 199, 44);
            lblProfilo.ImeMode = ImeMode.NoControl;
            lblProfilo.Location = new Point(452, 13);
            lblProfilo.Name = "lblProfilo";
            lblProfilo.Size = new Size(115, 40);
            lblProfilo.TabIndex = 23;
            lblProfilo.Text = "Profilo";
            // 
            // pcbTornaHomeProfilo
            // 
            pcbTornaHomeProfilo.Cursor = Cursors.Hand;
            pcbTornaHomeProfilo.Image = (Image)resources.GetObject("pcbTornaHomeProfilo.Image");
            pcbTornaHomeProfilo.Location = new Point(936, 13);
            pcbTornaHomeProfilo.Margin = new Padding(3, 4, 3, 4);
            pcbTornaHomeProfilo.Name = "pcbTornaHomeProfilo";
            pcbTornaHomeProfilo.Size = new Size(56, 53);
            pcbTornaHomeProfilo.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbTornaHomeProfilo.TabIndex = 24;
            pcbTornaHomeProfilo.TabStop = false;
            pcbTornaHomeProfilo.Click += pcbTornaHomeProfilo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 40);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 25;
            label1.Text = "Immagine del profilo";
            // 
            // btnRimuovi
            // 
            btnRimuovi.Location = new Point(180, 88);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(94, 29);
            btnRimuovi.TabIndex = 26;
            btnRimuovi.Text = "Rimuovi";
            btnRimuovi.UseVisualStyleBackColor = true;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // grbDatiSensibili
            // 
            grbDatiSensibili.Controls.Add(btnLogOut);
            grbDatiSensibili.Controls.Add(lblUsername);
            grbDatiSensibili.Controls.Add(label3);
            grbDatiSensibili.Controls.Add(lblEmaill);
            grbDatiSensibili.Controls.Add(lblEmail);
            grbDatiSensibili.Location = new Point(674, 111);
            grbDatiSensibili.Name = "grbDatiSensibili";
            grbDatiSensibili.Size = new Size(307, 173);
            grbDatiSensibili.TabIndex = 27;
            grbDatiSensibili.TabStop = false;
            grbDatiSensibili.Text = "Dati privati";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(12, 116);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(103, 79);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // lblEmaill
            // 
            lblEmaill.AutoSize = true;
            lblEmaill.Location = new Point(72, 38);
            lblEmaill.Name = "lblEmaill";
            lblEmaill.Size = new Size(51, 20);
            lblEmaill.TabIndex = 1;
            lblEmaill.Text = "EMAIL";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 36);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // grbFotoProfilo
            // 
            grbFotoProfilo.Controls.Add(btnInserisciFotoProfilo);
            grbFotoProfilo.Controls.Add(pcbFotoProfilo);
            grbFotoProfilo.Controls.Add(btnRimuovi);
            grbFotoProfilo.Controls.Add(label1);
            grbFotoProfilo.Location = new Point(29, 111);
            grbFotoProfilo.Name = "grbFotoProfilo";
            grbFotoProfilo.Size = new Size(314, 173);
            grbFotoProfilo.TabIndex = 28;
            grbFotoProfilo.TabStop = false;
            grbFotoProfilo.Text = "Foto Profilo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnEliminaAccount);
            groupBox1.Location = new Point(362, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 173);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cancella account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 100);
            label2.Name = "label2";
            label2.Size = new Size(170, 40);
            label2.TabIndex = 2;
            label2.Text = "Non premerlo perfavore\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnEliminaAccount
            // 
            btnEliminaAccount.Location = new Point(73, 42);
            btnEliminaAccount.Name = "btnEliminaAccount";
            btnEliminaAccount.Size = new Size(141, 29);
            btnEliminaAccount.TabIndex = 0;
            btnEliminaAccount.Text = "Elimina account";
            btnEliminaAccount.UseVisualStyleBackColor = true;
            btnEliminaAccount.Click += btnEliminaAccount_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 502);
            Controls.Add(groupBox1);
            Controls.Add(grbFotoProfilo);
            Controls.Add(grbDatiSensibili);
            Controls.Add(pcbTornaHomeProfilo);
            Controls.Add(lblProfilo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)pcbFotoProfilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeProfilo).EndInit();
            grbDatiSensibili.ResumeLayout(false);
            grbDatiSensibili.PerformLayout();
            grbFotoProfilo.ResumeLayout(false);
            grbFotoProfilo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFotoProfilo;
        private Button btnInserisciFotoProfilo;
        private Label lblProfilo;
        private PictureBox pcbTornaHomeProfilo;
        private Label label1;
        private Button btnRimuovi;
        private GroupBox grbDatiSensibili;
        private Label lblEmaill;
        private Label lblEmail;
        private Label lblUsername;
        private Label label3;
        private GroupBox grbFotoProfilo;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnEliminaAccount;
        private Label label2;
        private Button btnLogOut;
    }
}