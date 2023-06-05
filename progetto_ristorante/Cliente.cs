namespace progetto_ristorante
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnInserisciFotoProfilo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File immagine|*.jpg;*.jpeg;*.png;*.gif|Tutti i file|*.*";
            openFileDialog.Title = "Seleziona la tua immagine profilo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pcbFotoProfilo.Image = Image.FromFile(imagePath);
            }
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            pcbFotoProfilo.Image = null;
            MessageBox.Show("Immagine rimossa correttamente!");
        }

        private void btnEliminaAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account eliminato correttamente");

            // Torna al login e cancella l'account dal db.
        }

        private void pcbTornaHomeProfilo_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
