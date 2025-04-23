namespace TRANSCONNET
{
    public class Program
    {
        static void Main(string[] args)
        {
           Manager MainManager = new Manager(); // on cree un manager vide 
            AffichageGraphique graphique = new AffichageGraphique(@"employe.csv", @"client.csv", @"distances_villes_france.csv", @"commandes.csv", MainManager);


        }
    }
}