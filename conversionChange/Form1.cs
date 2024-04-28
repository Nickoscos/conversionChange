using System.Reflection.Metadata;
using RestSharp;
using Newtonsoft;
using ClassExchangeAPI;
using Newtonsoft.Json;


namespace conversionChange
{
    public partial class Form1 : Form
    {
        string monnaie = "euro";

        //Variable Globale
        ExchangeConnection.Rootobject result; //Enregistre les donn�es de l'API

        public Form1()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            //Appel de l'API
            //Utilisation de RestSharp
            //Source https://cdn.taux.live/api/ecb.json

            var client = new RestClient("https://cdn.taux.live/api/");
            var request = new RestRequest("ecb.json"); //Last bit of the request
            var response = client.Execute(request); //Requete ex�cution

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                //conversion des donn�es
                result = JsonConvert.DeserializeObject<ExchangeConnection.Rootobject>(rawResponse);

                if (result != null ) //si des donn�es ont �t� re�ues
                {
                    foreach (var obj in result.rates)
                    {
                        label1.Text = obj.ToString();
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != ",")
            {
                //Si le caract�re saisi n'est pas la virgule alors on r�cup�re le caract�re saisi
                montant.Text = montant.Text + ((Button)sender).Text;
            }
            else
            {
                //Si le caract�re saisi est la virgule alors on v�rifie si le nombre poss�de d�j� une virgule
                if (montant.Text.Contains(",") == false)
                {
                    if (montant.Text.Length > 0)
                    {
                        //Si ce nombre ne poss�de pas de virgule alors on ajoute la virgule
                        montant.Text = montant.Text + ((Button)sender).Text;
                    }
                    else
                    {
                        //Si ce nombre ne poss�de pas de virgule alors on ajoute la virgule
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
            //si aucune saisie alors c'est �quivalent au chiffre 0
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
            //si aucune saisie alors c'est �quivalent au chiffre 0
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
            //si aucune saisie alors c'est �quivalent au chiffre 0
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
