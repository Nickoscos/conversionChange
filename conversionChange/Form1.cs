using System.Reflection.Metadata;

namespace conversionChange
{
    public partial class Form1 : Form
    {
        string monnaie = "euro";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != ",")
            {
                //Si le caractère saisi n'est pas la virgule alors on récupère le caractère saisi
                montant.Text = montant.Text + ((Button)sender).Text;
            }
            else
            {
                //Si le caractère saisi est la virgule alors on vérifie si le nombre posséde déjà une virgule
                if (montant.Text.Contains(",") == false)
                {
                    if (montant.Text.Length > 0)
                    {
                        //Si ce nombre ne possède pas de virgule alors on ajoute la virgule
                        montant.Text = montant.Text + ((Button)sender).Text;
                    }
                    else
                    {
                        //Si ce nombre ne possède pas de virgule alors on ajoute la virgule
                        montant.Text = "0" + ((Button)sender).Text;
                        monnaie = "euro";
                    }

                }
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            montant.Text = ""; 
        }

        private void buttonDUS_Click(object sender, EventArgs e)
        {
            //si aucune saisie alors c'est équivalent au chiffre 0
            if (montant.Text == "") 
            {
                montant.Text = "0";
            }
            //Conversion euro => Dollar US
            if (monnaie == "euro")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 1.06,2).ToString();
            }
            //Conversion Dollar CAN => Dollar US
            else if (monnaie == "dollars CAN")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 1.46,2).ToString();
            }
            monnaie = "dollars US";
        }

        private void buttonDCAN_Click(object sender, EventArgs e)
        {
            //si aucune saisie alors c'est équivalent au chiffre 0
            if (montant.Text == "")
            {
                montant.Text = "0";
            }
            //Conversion euro => Dollar CAN
            if (monnaie == "euro")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 1.47,2).ToString();
            }
            //Conversion Dollar US => Dollar CAN
            else if (monnaie == "dollars US")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 0.73,2).ToString();
            }
            monnaie = "dollars CAN";
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            //si aucune saisie alors c'est équivalent au chiffre 0
            if (montant.Text == "")
            {
                montant.Text = "0";
            }
            //Conversion Dollar US => euro
            if (monnaie == "dollars US")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 0.94,2).ToString();
            }
            //Conversion Dollar CAN => euro
            else if (monnaie == "dollars CAN")
            {
                montant.Text = Math.Round(float.Parse(montant.Text) * 0.68,2).ToString();
            }
            monnaie = "euro";
        }
    }
}
