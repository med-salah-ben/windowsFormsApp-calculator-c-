namespace windowsFormsAppDotnet
{
    public partial class Calculer_Prix : Form
    {
        public Calculer_Prix()
        {
            InitializeComponent();
        }

        private void Calculer_Prix_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            // Réinitialisez le message d'erreur
            lblErreur.Text = "";

            // Vérifiez les règles une par une

            //Vérification Length
            if(textBox1.Text.Length <1 || textBox2.Text.Length < 1 || textBox1.Text.Length < 1)
            {
                lblErreur.Text = "Champs vides!";
                lblErreur.ForeColor = Color.Red;
                return;
            }

            // Vérification du prix unitaire
            if (!decimal.TryParse(textBox1.Text, out decimal prixUnitaire) || prixUnitaire <= 0)
            {
                lblErreur.Text = "Champ invalides!";
                lblErreur.ForeColor = Color.Red;
                return;
            }

            // Vérification de la quantité
            if (!int.TryParse(textBox2.Text, out int quantite) || quantite <= 0)
            {
                lblErreur.Text = "Champ invalides!";
                lblErreur.ForeColor = Color.Red;
                return;
            }

            // Vérification du taux de TVA
            if (!decimal.TryParse(textBox3.Text, out decimal tauxTVA) || tauxTVA < 0 || tauxTVA > 100)
            {
                lblErreur.Text = "Champ invalides!";
                lblErreur.ForeColor = Color.Red;
                return;
            }

            // Calcul du prix total avec TVA
            decimal montantHT = prixUnitaire * quantite;
            decimal montantTTC = montantHT * (1 + (tauxTVA / 100));

            // Affichage du résultat
            lblResultat.Text = $"Le prix total TTC est : {montantTTC:C}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lblResultat.Text = "";
            lblErreur.Text = "";
        }
    }
}
