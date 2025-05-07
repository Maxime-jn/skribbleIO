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
            "chat", "chien", "maison", "école", "voiture", "arbre", "fleur", "ciel", "soleil", "lune",
            "étoile", "mer", "rivière", "montagne", "colline", "forêt", "jardin", "parc", "ville", "village",
            "campagne", "route", "chemin", "pont", "rue", "avenue", "boulevard", "place", "marché", "magasin",
            "supermarché", "boulangerie", "pâtisserie", "fromagerie", "boucherie", "poissonnerie", "pharmacie",
            "hôpital", "église", "mosquée", "synagogue", "temple", "mairie", "école", "collège", "lycée", "université",
            "bibliothèque", "musée", "théâtre", "cinéma", "stade", "parc", "jardin", "plage", "port", "gare",
            "aéroport", "station", "métro", "bus", "taxi", "vélo", "moto", "camion", "bateau", "avion", "train",
            "pomme", "poire", "banane", "orange", "fraise", "cerise", "raisin", "pastèque", "melon", "pêche",
            "abricot", "prune", "kiwi", "mangue", "ananas", "citron", "pamplemousse", "framboise", "mûre", "myrtille",
            "pain", "baguette", "croissant", "brioche", "tarte", "gâteau", "chocolat", "bonbon", "glace", "crêpe",
            "omelette", "pizza", "pâtes", "riz", "couscous", "soupe", "salade", "steak", "poulet", "poisson",
            "viande", "jambon", "fromage", "lait", "beurre", "yaourt", "crème", "œuf", "farine", "sucre", "sel",
            "poivre", "huile", "vinaigre", "moutarde", "ketchup", "mayonnaise", "thé", "café", "chocolat", "eau",
            "lait", "jus", "soda", "bière", "vin", "champagne", "whisky", "vodka", "rhum", "tequila", "gin",
            "ordinateur", "clavier", "souris", "écran", "imprimante", "scanner", "téléphone", "tablette", "appareil",
            "photo", "caméra", "télévision", "radio", "enceinte", "casque", "micro", "montre", "bracelet", "collier",
            "bague", "boucles", "cheveux", "yeux", "nez", "bouche", "oreille", "bras", "jambe", "pied", "main",
            "doigt", "genou", "coude", "poignet", "cheville", "épaule", "ventre", "dos", "tête", "cœur", "poumon",
            "foie", "estomac", "intestin", "rein", "os", "muscle", "peau", "cheveu", "ongle", "dent", "langue",
            "école", "travail", "bureau", "atelier", "usine", "chantier", "entreprise", "commerce", "service", "police",
            "pompiers", "armée", "justice", "banque", "assurance", "administration", "énergie", "transport", "tourisme",
            "art", "culture", "loisir", "sport", "musique", "danse", "théâtre", "cinéma", "littérature", "peinture",
            "sculpture", "photographie", "cinéma", "mode", "gastronomie", "cuisine", "vin", "fromage", "chocolat",
            "pain", "dessert", "recette", "cérémonie", "fête", "anniversaire", "mariage", "baptême", "enterrement",
            "fête", "vacances", "voyage", "randonnée", "ski", "plongée", "natation", "course", "marche", "danse",
            "chant", "musique", "peinture", "dessin", "sculpture", "photographie", "cinéma", "théâtre", "lecture",
            "écriture", "poésie", "roman", "nouvelle", "essai", "biographie", "journal", "magazine", "revue"
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
