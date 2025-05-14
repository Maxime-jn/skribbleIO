using System.Windows.Forms;
using System.Drawing.Text;
using System;

namespace SkribbleIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> words = new List<string>
        {
            "chat", "chien", "maison", "école", "voiture", "arbre", "fleur", "ciel", "soleil", "lune",
            "étoile", "mer", "rivière", "montagne", "colline", "forêt", "jardin", "parc", "ville", "village",
            "campagne", "route", "chemin", "pont", "rue", "avenue", "boulevard", "place", "marché", "magasin",
            "supermarché", "boulangerie", "pâtisserie", "fromagerie", "boucherie", "poissonnerie", "pharmacie",
            "hôpital", "mosquée", "synagogue", "temple", "mairie", "collège", "lycée", "université",
            "bibliothèque", "musée", "théâtre", "cinéma", "stade", "plage", "port", "gare",
            "aéroport", "station", "métro", "bus", "taxi", "vélo", "moto", "camion", "bateau", "avion", "train",
            "pomme", "poire", "banane", "orange", "fraise", "cerise", "raisin", "pastèque", "melon", "pêche",
            "abricot", "prune", "kiwi", "mangue", "ananas", "citron", "pamplemousse", "framboise", "mûre", "myrtille",
            "pain", "baguette", "croissant", "brioche", "tarte", "gâteau", "chocolat", "bonbon", "glace", "crêpe",
            "omelette", "pizza", "pâtes", "riz", "couscous", "soupe", "salade", "steak", "poulet", "poisson",
            "viande", "jambon", "fromage", "lait", "beurre", "yaourt", "crème", "œuf", "farine", "sucre", "sel",
            "poivre", "huile", "vinaigre", "moutarde", "ketchup", "mayonnaise", "thé", "café", "eau",
            "jus", "soda", "bière", "vin", "champagne", "whisky", "vodka", "rhum", "tequila", "gin",
            "ordinateur", "clavier", "souris", "écran", "imprimante", "scanner", "téléphone", "tablette", "appareil",
            "photo", "caméra", "télévision", "radio", "enceinte", "casque", "micro", "montre", "bracelet", "collier",
            "bague", "boucles", "cheveux", "yeux", "nez", "bouche", "oreille", "bras", "jambe", "pied", "main",
            "doigt", "genou", "coude", "poignet", "cheville", "épaule", "ventre", "dos", "tête", "cœur", "poumon",
            "foie", "estomac", "intestin", "rein", "os", "muscle", "peau", "cheveu", "ongle", "dent", "langue",
            "travail", "bureau", "atelier", "usine", "chantier", "entreprise", "commerce", "service", "police",
            "pompiers", "armée", "justice", "banque", "assurance", "administration", "énergie", "transport", "tourisme",
            "art", "culture", "loisir", "sport", "musique", "danse", "littérature", "peinture",
            "sculpture", "photographie", "mode", "gastronomie", "cuisine", "dessert", "recette", "cérémonie", "fête",
            "anniversaire", "mariage", "baptême", "enterrement", "vacances", "voyage", "randonnée", "ski", "plongée",
            "natation", "course", "marche", "chant", "dessin", "écriture", "poésie", "roman", "nouvelle", "essai",
            "biographie", "journal", "magazine", "revue"
        };

        List<string> players = new List<string>
        {
            "Joueur1","Joueur2","Joueur3","Joueur4"
        };

        private int time = 0;
        const int maxTime = 80;
        const int firstHintTime = 30;
        const int secondtHintTime = 60;

        private Dictionary<char, bool> lettersIsShow = new Dictionary<char, bool>();
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = random.Next(words.Count);

            lettersIsShow = loadSecretWord(words[index]);


            loadSecretWord(words[index]);
            string secretWord = words[index];

            lblClock.Text = maxTime.ToString() + "s";

            tmrClock.Start();
            chooseDrawer();
            colorBtnSelected = btnBlack;
        }

        private bool isDrawing = false;
        private bool canDraw = false;
        private Point lastPoint = Point.Empty;
        private Color selectedColor = Color.Black;
        private int selectedWidth = 5;
        private string? selectedTool = null;
        private Button? colorBtnSelected = null;
        private void ChangeColor(string color)
        {
            if (colorBtnSelected != null)
            {
                colorBtnSelected.FlatAppearance.BorderSize = 0;
            }
            switch (color)
            {
                case "black":
                    if (colorBtnSelected == btnBlack) { btnBlack.FlatAppearance.BorderSize = 3; return; }
                    selectedColor = Color.Black;
                    btnBlack.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnBlack;
                    break;
                case "red":
                    if (colorBtnSelected == btnRed)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Red;
                    btnRed.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnRed;
                    break;
                case "green":
                    if (colorBtnSelected == btnGreen)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Green;
                    btnGreen.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnGreen;
                    break;
                case "blue":
                    if (colorBtnSelected == btnBlue)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Blue;
                    btnBlue.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnBlue;
                    break;
                case "gold":
                    if (colorBtnSelected == btnGold)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Gold;
                    btnGold.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnGold;
                    break;
                case "magenta":
                    if (colorBtnSelected == btnMagenta)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Magenta;
                    btnMagenta.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnMagenta;
                    break;
                case "cyan":
                    if (colorBtnSelected == btnCyan)
                    {
                        colorBtnSelected.FlatAppearance.BorderSize = 0;
                        colorBtnSelected = null;
                        ChangeColor("black");
                        return;
                    }
                    selectedColor = Color.Cyan;
                    btnCyan.FlatAppearance.BorderSize = 3;
                    colorBtnSelected = btnCyan;
                    break;
                case "white":
                    if (btnEraser.BackColor == Color.DodgerBlue)
                    {
                        colorBtnSelected.PerformClick();
                        colorBtnSelected = null;
                        return;
                    }
                    selectedColor = Color.White;
                    break;
            }
        }

        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && pbxCanvas.Image != null)
            {
                Bitmap bmp = (Bitmap)pbxCanvas.Image;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (Pen p = new Pen(selectedColor, selectedWidth))
                    using (Brush b = new SolidBrush(selectedColor))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.DrawLine(p, lastPoint, e.Location);

                        // Remplit les trous entre les points en dessinant un petit cercle � l'arriv�e
                        int radius = selectedWidth / 2; // rayon du cercle (� ajuster selon l'�paisseur)
                        g.FillEllipse(b, e.X - radius, e.Y - radius, radius * 2, radius * 2);
                    }
                }

                pbxCanvas.Invalidate();
                lastPoint = e.Location;
            }
        }
        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                // Handle mouse down event
                if (e.Button == MouseButtons.Left)
                {
                    isDrawing = true;
                    lastPoint = e.Location;
                }
            }

        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Handle mouse up event
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            if (canDraw)
            {
                if (btnEraser.BackColor == Color.DodgerBlue)
                {
                    // selectionner avec déselection
                    btnEraser.BackColor = Color.White;
                }
                if (btnPen.BackColor == Color.DodgerBlue)
                {
                    // deselectionner la gomme
                    canDraw = false;
                    btnPen.BackColor = Color.White;
                }
                else
                {
                    canDraw = true;
                    btnPen.BackColor = Color.DodgerBlue;
                    ChangeColor("black");
                }
            }
            else
            {
                // selectionner sans rien deselectionner
                canDraw = true;
                btnPen.BackColor = Color.DodgerBlue;
                ChangeColor("black");
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            if (canDraw)
            {
                if (btnPen.BackColor == Color.DodgerBlue)
                {
                    // selectionner avec déselection
                    btnPen.BackColor = Color.White;
                }
                if (btnEraser.BackColor == Color.DodgerBlue)
                {
                    // deselectionner la gomme
                    canDraw = false;
                    ChangeColor("white");
                    btnEraser.BackColor = Color.White;
                }
                else
                {
                    canDraw = true;
                    ChangeColor("white");
                    btnEraser.BackColor = Color.DodgerBlue;

                }
            }
            else
            {
                // selectionner sans rien deselectionner
                canDraw = true;
                ChangeColor("white");
                btnEraser.BackColor = Color.DodgerBlue;

            }
            trbWidth.Value = 50;
        }

        private void trbWidth_Scroll(object sender, EventArgs e)
        {
            selectedWidth = trbWidth.Value;
        }





        private Dictionary<char, bool> loadSecretWord(string secretWord)
        {
            Dictionary<char, bool> lettersIsShow = new Dictionary<char, bool>();

            char[] letters = secretWord.ToCharArray();

            foreach (var letter in letters)
            {
                lettersIsShow[letter] = false;
            }

            lblSecretWord.Text = ""; // Réinitialise le texte avant de le remplir  

            foreach (var letter in letters)
            {
                if (lettersIsShow[letter] == false)
                {
                    lblSecretWord.Text += "_ ";
                }
                else
                {
                    lblSecretWord.Text += letter + " ";
                }
            }

            return lettersIsShow;
        }


        private Dictionary<char, bool> showLetters(Dictionary<char, bool> lettersIsShow, char[] letters)
        {
            Random random = new Random();
            int index;

            // Ensure we find a letter that hasn't been revealed yet  
            do
            {
                index = random.Next(letters.Length);
            } while (lettersIsShow[letters[index]]);

            // Reveal the selected letter  
            lettersIsShow[letters[index]] = true;

            // Clear the label text before updating it  
            lblSecretWord.Text = "";

            // Update the label with the current state of the word  
            foreach (var item in letters)
            {
                if (lettersIsShow[item])
                {
                    lblSecretWord.Text += item + " ";
                }
                else
                {
                    lblSecretWord.Text += "_ ";
                }
            }

            return lettersIsShow;
        }




        private void tmrClock_Tick(object sender, EventArgs e)
        {
            if (time >= maxTime)
            {
                tmrClock.Stop();
                MessageBox.Show("Le temps est écoulé !", "Fin du jeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            time++;
            lblClock.Text = (maxTime - time).ToString() + "s";


            if (time == firstHintTime || time == secondtHintTime)
            {
                if (lettersIsShow != null && words.Count > 0)
                {
                    string currentWord = new string(lettersIsShow.Keys.ToArray());
                    showLetters(lettersIsShow, currentWord.ToCharArray());
                }
            }
        }



        private void chooseDrawer()
        {
            Random random = new Random();
            int index = random.Next(0, players.Count);
            string drawer = players[index];
            // Afficher le nom du dessinateur dans une boîte de message
            MessageBox.Show($"Le dessinateur est : {drawer}", "Dessinateur Choisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ChangeColor("black");
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ChangeColor("red");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ChangeColor("blue");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ChangeColor("green");
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            ChangeColor("gold");
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            ChangeColor("magenta");
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            ChangeColor("cyan");
        }

    }
}
