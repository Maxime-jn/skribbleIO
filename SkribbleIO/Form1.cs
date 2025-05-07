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
            "chat", "chien", "maison", "�cole", "voiture", "arbre", "fleur", "ciel", "soleil", "lune",
            "étoile", "mer", "rivière", "montagne", "colline", "foret", "jardin", "parc", "ville", "village",
            "campagne", "route", "chemin", "pont", "rue", "avenue", "boulevard", "place", "march�", "magasin",
            "supermarch�", "boulangerie", "patisserie", "fromagerie", "boucherie", "poissonnerie", "pharmacie",
            "hopital", "église", "mosquée", "synagogue", "temple", "mairie", "école", "collège", "lycée", "université",
            "bibliothèque", "musée", "théatre", "cinéma", "stade", "parc", "jardin", "plage", "port", "gare",
            "a�roport", "station", "métro", "bus", "taxi", "vélo", "moto", "camion", "bateau", "avion", "train",
            "pomme", "poire", "banane", "orange", "fraise", "cerise", "raisin", "pastèque", "melon", "pèche",
            "abricot", "prune", "kiwi", "mangue", "ananas", "citron", "pamplemousse", "framboise", "mare", "myrtille",
            "pain", "baguette", "croissant", "brioche", "tarte", "gateau", "chocolat", "bonbon", "glace", "crèpe",
            "omelette", "pizza", "pates", "riz", "couscous", "soupe", "salade", "steak", "poulet", "poisson",
            "viande", "jambon", "fromage", "lait", "beurre", "yaourt", "crème", "ouf", "farine", "sucre", "sel",
            "poivre", "huile", "vinaigre", "moutarde", "ketchup", "mayonnaise", "thé", "café", "chocolat", "eau",
            "lait", "jus", "soda", "bière", "vin", "champagne", "whisky", "vodka", "rhum", "tequila", "gin",
            "ordinateur", "clavier", "souris", "écran", "imprimante", "scanner", "téléphone", "tablette", "appareil",
            "photo", "caméra", "télévision", "radio", "enceinte", "casque", "micro", "montre", "bracelet", "collier",
            "bague", "boucles", "cheveux", "yeux", "nez", "bouche", "oreille", "bras", "jambe", "pied", "main",
            "doigt", "genou", "coude", "poignet", "cheville", "épaule", "ventre", "dos", "téte", "cour", "poumon",
            "foie", "estomac", "intestin", "rein", "os", "muscle", "peau", "cheveu", "ongle", "dent", "langue",
            "école", "travail", "bureau", "atelier", "usine", "chantier", "entreprise", "commerce", "service", "police",
            "pompiers", "armée", "justice", "banque", "assurance", "administration", "énergie", "transport", "tourisme",
            "art", "culture", "loisir", "sport", "musique", "danse", "théatre", "cinéma", "littérature", "peinture",
            "sculpture", "photographie", "cinéma", "mode", "gastronomie", "cuisine", "vin", "fromage", "chocolat",
            "pain", "dessert", "recette", "cérémonie", "fete", "anniversaire", "mariage", "baptème", "enterrement",
            "f�te", "vacances", "voyage", "randonn�e", "ski", "plong�e", "natation", "course", "marche", "danse",
            "chant", "musique", "peinture", "dessin", "sculpture", "photographie", "cin�ma", "th��tre", "lecture",
            "�criture", "po�sie", "roman", "nouvelle", "essai", "biographie", "journal", "magazine", "revue"
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
            showLetters(lettersIsShow, words[index].ToCharArray());
        }

        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Color selectedColor = Color.Black;
        private int selectedWidth = 5;
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
            // Handle mouse down event
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
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
            selectedColor = Color.Black;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            selectedColor = Color.White; // Utilise la couleur de fond pour effacer

        }

        private void trbWidth_Scroll(object sender, EventArgs e)
        {
            selectedWidth = trbWidth.Value;
        }


        private Dictionary<char, bool> loadSecretWord(string secretWord)
        {
            Dictionary<char, bool> lettersIsShow = new Dictionary<char, bool>();

            char[] letters = secretWord.ToCharArray();

            foreach (var item in letters)
            {
                lettersIsShow[item] = false;
            }

            Random random = new Random();
            int index = random.Next(lettersIsShow.Count);
            lettersIsShow[letters[index]] = true;

            foreach (var item in lettersIsShow)
            {
                if (item.Value == false)
                {
                    lblSecretWord.Text += "_ ";
                }
                else
                {
                    lblSecretWord.Text += item.Key + " ";
                }
            }


            return lettersIsShow;
        }


        private Dictionary<char, bool> showLetters(Dictionary<char, bool> lettersIsShow, char[] letters)
        {
            Random random = new Random();
            int index = random.Next(lettersIsShow.Count);

            if (lettersIsShow[letters[index]] == true)
            {
                showLetters(lettersIsShow, letters);
            }
            else
            {
                lettersIsShow[letters[index]] = true;
            }

            foreach (var item in lettersIsShow)
            {
                if (item.Value == false)
                {
                    lblSecretWord.Text += "_ ";
                }
                else
                {
                    lblSecretWord.Text += item.Key + " ";
                }
            }

            return lettersIsShow;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            time++;

          


            if (time == firstHintTime || time == secondtHintTime)
            {
                showLetters(lettersIsShow, words[index].ToCharArray());
            }

        }
    }
}
