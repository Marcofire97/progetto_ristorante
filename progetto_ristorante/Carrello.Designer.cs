namespace progetto_ristorante
{
	partial class Carrello
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrello));
			lblCarrello = new Label();
			pcbTornaHomeCarrello = new PictureBox();
			groupBox1 = new GroupBox();
			elementoCarrello1 = new ElementoCarrello();
			((System.ComponentModel.ISupportInitialize)pcbTornaHomeCarrello).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// lblCarrello
			// 
			lblCarrello.AutoSize = true;
			lblCarrello.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblCarrello.ForeColor = Color.FromArgb(255, 199, 44);
			lblCarrello.ImeMode = ImeMode.NoControl;
			lblCarrello.Location = new Point(60, 26);
			lblCarrello.Name = "lblCarrello";
			lblCarrello.Size = new Size(319, 39);
			lblCarrello.TabIndex = 2;
			lblCarrello.Text = "Carrello della spesa";
			// 
			// pcbTornaHomeCarrello
			// 
			pcbTornaHomeCarrello.Cursor = Cursors.Hand;
			pcbTornaHomeCarrello.Image = (Image)resources.GetObject("pcbTornaHomeCarrello.Image");
			pcbTornaHomeCarrello.Location = new Point(958, 13);
			pcbTornaHomeCarrello.Margin = new Padding(3, 4, 3, 4);
			pcbTornaHomeCarrello.Name = "pcbTornaHomeCarrello";
			pcbTornaHomeCarrello.Size = new Size(56, 53);
			pcbTornaHomeCarrello.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbTornaHomeCarrello.TabIndex = 13;
			pcbTornaHomeCarrello.TabStop = false;
			pcbTornaHomeCarrello.Click += pcbTornaHomeCarrello_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(elementoCarrello1);
			groupBox1.Location = new Point(60, 96);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(932, 457);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			// 
			// elementoCarrello1
			// 
			//elementoCarrello1.immagine_prodotto = (Image)resources.GetObject("elementoCarrello1.immagine_prodotto");
			elementoCarrello1.Location = new Point(56, 37);
			elementoCarrello1.Name = "elementoCarrello1";
			// elementoCarrello1.nome_prodotto = "Hamburger di pollo";
			elementoCarrello1.Size = new Size(804, 86);
			elementoCarrello1.TabIndex = 0;
			// 
			// Carrello
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1039, 616);
			Controls.Add(groupBox1);
			Controls.Add(pcbTornaHomeCarrello);
			Controls.Add(lblCarrello);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Carrello";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Carrello";
			((System.ComponentModel.ISupportInitialize)pcbTornaHomeCarrello).EndInit();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblCarrello;
		private PictureBox pcbTornaHomeCarrello;
		private GroupBox groupBox1;
		private ElementoCarrello elementoCarrello1;
	}
}