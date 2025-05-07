using System.Drawing.Text;

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
            "�toile", "mer", "rivi�re", "montagne", "colline", "for�t", "jardin", "parc", "ville", "village",
            "campagne", "route", "chemin", "pont", "rue", "avenue", "boulevard", "place", "march�", "magasin",
            "supermarch�", "boulangerie", "p�tisserie", "fromagerie", "boucherie", "poissonnerie", "pharmacie",
            "h�pital", "�glise", "mosqu�e", "synagogue", "temple", "mairie", "�cole", "coll�ge", "lyc�e", "universit�",
            "biblioth�que", "mus�e", "th��tre", "cin�ma", "stade", "parc", "jardin", "plage", "port", "gare",
            "a�roport", "station", "m�tro", "bus", "taxi", "v�lo", "moto", "camion", "bateau", "avion", "train",
            "pomme", "poire", "banane", "orange", "fraise", "cerise", "raisin", "past�que", "melon", "p�che",
            "abricot", "prune", "kiwi", "mangue", "ananas", "citron", "pamplemousse", "framboise", "m�re", "myrtille",
            "pain", "baguette", "croissant", "brioche", "tarte", "g�teau", "chocolat", "bonbon", "glace", "cr�pe",
            "omelette", "pizza", "p�tes", "riz", "couscous", "soupe", "salade", "steak", "poulet", "poisson",
            "viande", "jambon", "fromage", "lait", "beurre", "yaourt", "cr�me", "�uf", "farine", "sucre", "sel",
            "poivre", "huile", "vinaigre", "moutarde", "ketchup", "mayonnaise", "th�", "caf�", "chocolat", "eau",
            "lait", "jus", "soda", "bi�re", "vin", "champagne", "whisky", "vodka", "rhum", "tequila", "gin",
            "ordinateur", "clavier", "souris", "�cran", "imprimante", "scanner", "t�l�phone", "tablette", "appareil",
            "photo", "cam�ra", "t�l�vision", "radio", "enceinte", "casque", "micro", "montre", "bracelet", "collier",
            "bague", "boucles", "cheveux", "yeux", "nez", "bouche", "oreille", "bras", "jambe", "pied", "main",
            "doigt", "genou", "coude", "poignet", "cheville", "�paule", "ventre", "dos", "t�te", "c�ur", "poumon",
            "foie", "estomac", "intestin", "rein", "os", "muscle", "peau", "cheveu", "ongle", "dent", "langue",
            "�cole", "travail", "bureau", "atelier", "usine", "chantier", "entreprise", "commerce", "service", "police",
            "pompiers", "arm�e", "justice", "banque", "assurance", "administration", "�nergie", "transport", "tourisme",
            "art", "culture", "loisir", "sport", "musique", "danse", "th��tre", "cin�ma", "litt�rature", "peinture",
            "sculpture", "photographie", "cin�ma", "mode", "gastronomie", "cuisine", "vin", "fromage", "chocolat",
            "pain", "dessert", "recette", "c�r�monie", "f�te", "anniversaire", "mariage", "bapt�me", "enterrement",
            "f�te", "vacances", "voyage", "randonn�e", "ski", "plong�e", "natation", "course", "marche", "danse",
            "chant", "musique", "peinture", "dessin", "sculpture", "photographie", "cin�ma", "th��tre", "lecture",
            "�criture", "po�sie", "roman", "nouvelle", "essai", "biographie", "journal", "magazine", "revue"
        };

        private void Form1_Load(object sender, EventArgs e)
        {

            Random random = new Random();
            int index = random.Next(words.Count);

            loadSecretWord(words[index]);
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

            return lettersIsShow;
        }


    }
}
