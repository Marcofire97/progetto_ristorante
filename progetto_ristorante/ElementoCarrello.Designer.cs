﻿namespace progetto_ristorante
{
    partial class ElementoCarrello
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementoCarrello));
            pictureBox1 = new PictureBox();
            lblNomeProdotto = new Label();
            lblquantitàprodotto = new Label();
            label3 = new Label();
            lblPrezzoProdotto = new Label();
            btnRimuoviProdotto = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNomeProdotto
            // 
            lblNomeProdotto.AutoSize = true;
            lblNomeProdotto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProdotto.Location = new Point(120, 24);
            lblNomeProdotto.Name = "lblNomeProdotto";
            lblNomeProdotto.Size = new Size(182, 23);
            lblNomeProdotto.TabIndex = 1;
            lblNomeProdotto.Text = "Hamburger di manzo";
            // 
            // lblquantitàprodotto
            // 
            lblquantitàprodotto.AutoSize = true;
            lblquantitàprodotto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblquantitàprodotto.Location = new Point(303, 24);
            lblquantitàprodotto.Name = "lblquantitàprodotto";
            lblquantitàprodotto.Size = new Size(29, 23);
            lblquantitàprodotto.TabIndex = 2;
            lblquantitàprodotto.Text = "(1)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(515, 25);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 3;
            label3.Text = "Prezzo";
            // 
            // lblPrezzoProdotto
            // 
            lblPrezzoProdotto.AutoSize = true;
            lblPrezzoProdotto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrezzoProdotto.Location = new Point(583, 25);
            lblPrezzoProdotto.Name = "lblPrezzoProdotto";
            lblPrezzoProdotto.Size = new Size(37, 23);
            lblPrezzoProdotto.TabIndex = 4;
            lblPrezzoProdotto.Text = "12€";
            // 
            // btnRimuoviProdotto
            // 
            btnRimuoviProdotto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRimuoviProdotto.Location = new Point(638, 22);
            btnRimuoviProdotto.Name = "btnRimuoviProdotto";
            btnRimuoviProdotto.Size = new Size(94, 29);
            btnRimuoviProdotto.TabIndex = 5;
            btnRimuoviProdotto.Text = "Rimuovi";
            btnRimuoviProdotto.UseVisualStyleBackColor = true;
            btnRimuoviProdotto.Click += btnRimuoviProdotto_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(364, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // ElementoCarrello
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(btnRimuoviProdotto);
            Controls.Add(lblPrezzoProdotto);
            Controls.Add(label3);
            Controls.Add(lblquantitàprodotto);
            Controls.Add(lblNomeProdotto);
            Controls.Add(pictureBox1);
            Name = "ElementoCarrello";
            Size = new Size(746, 69);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNomeProdotto;
        private Label lblquantitàprodotto;
        private Label label3;
        private Label lblPrezzoProdotto;
        private Button btnRimuoviProdotto;
        private PictureBox pictureBox2;
    }
}
