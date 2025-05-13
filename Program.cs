namespace TRANSCONNET
{
    public class Program
    {
        static void Main(string[] args)
        {
           Manager MainManager = new Manager(); // on cree un manager vide 
            AffichageGraphique graphique = new AffichageGraphique(@"employee.csv", @"client.csv", @"distances", @"commandes.csv", MainManager);
            graphique.fileExplorerDistances.InitialisationGraphe(); //on génère le graphe à partir du fichier "distances.csv"
            graphique.MainAffichage(); // MainLoop de l'affichage. Dispose d'un système anti-erreur et est récursive.

        }
    }
}