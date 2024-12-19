using System;
using System.Linq;

class Program
{
    static IAgenceCRUD agenceCRUD = new AgenceCRUD();
    static IClientCRUD clientCRUD = new ClientCRUD();
    static ICompteCRUD compteCRUD = new CompteCRUD();

    static void Main(string[] args)
    {
        bool continuer = true;
        while (continuer)
        {
            Console.Clear();
            Console.WriteLine("===== Menu Principal =====");
            Console.WriteLine("1) CRUD Agence");
            Console.WriteLine("2) CRUD Client");
            Console.WriteLine("3) CRUD Compte");
            Console.WriteLine("4) Quitter");
            Console.Write("Choisissez une option : ");
            
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    GestionAgence();
                    break;
                case "2":
                    GestionClient();
                    break;
                case "3":
                    GestionCompte();
                    break;
                case "4":
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("Option invalide, veuillez réessayer.");
                    break;
            }
        }
    }

    // Gestion Compte
    static void GestionCompte()
    {
        Console.Clear();
        Console.WriteLine("===== Gestion des Comptes =====");
        Console.WriteLine("1) Ajouter un Compte");
        Console.WriteLine("2) Modifier un Compte");
        Console.WriteLine("3) Supprimer un Compte");
        Console.WriteLine("4) Afficher les Comptes");
        Console.WriteLine("5) Retour au Menu Principal");
        Console.Write("Choisissez une option : ");
        
        string choix = Console.ReadLine();
        switch (choix)
        {
            case "1":
                AjouterCompte();
                break;
            case "2":
                ModifierCompte();
                break;
            case "3":
                SupprimerCompte();
                break;
            case "4":
                AfficherComptes();
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Option invalide, veuillez réessayer.");
                break;
        }
    }

    static void AjouterCompte()
    {
        Console.Write("Entrez l'ID du client : ");
        int clientId = int.Parse(Console.ReadLine());
        Client client = clientCRUD.ObtenirClient(clientId);

        if (client != null)
        {
            Console.WriteLine("1) Compte Simple");
            Console.WriteLine("2) Compte Épargne");
            Console.Write("Choisissez un type de compte : ");
            string typeCompte = Console.ReadLine();

            if (typeCompte == "1")
            {
                Console.Write("Entrez le taux de découvert : ");
                decimal tauxDecouvert = decimal.Parse(Console.ReadLine());
                CompteSimple compteSimple = new CompteSimple(client, tauxDecouvert);
                compteCRUD.AjouterCompte(compteSimple);
                Console.WriteLine("Compte Simple ajouté. Numéro de compte: " + compteSimple.NumeroCompte);
            }
            else if (typeCompte == "2")
            {
                Console.Write("Entrez la durée du compte épargne (en mois) : ");
                int duree = int.Parse(Console.ReadLine());
                CompteEpargne compteEpargne = new CompteEpargne(client, duree);
                compteCRUD.AjouterCompte(compteEpargne);
                Console.WriteLine("Compte Epargne ajouté. Numéro de compte: " + compteEpargne.NumeroCompte);
            }
            else
            {
                Console.WriteLine("Type de compte invalide.");
            }
        }
        else
        {
            Console.WriteLine("Client introuvable.");
        }
        Pause();
    }

    static void ModifierCompte()
    {
        Console.Write("Entrez l'ID du compte à modifier : ");
        int id = int.Parse(Console.ReadLine());
        Compte compte = compteCRUD.ObtenirCompte(id);

        if (compte != null)
        {
            Console.Write("Nouveau solde : ");
            compte.Solde = decimal.Parse(Console.ReadLine());
            compteCRUD.ModifierCompte(compte);
            Console.WriteLine("Compte modifié avec succès.");
        }
        else
        {
            Console.WriteLine("Compte introuvable.");
        }
        Pause();
    }

    static void SupprimerCompte()
    {
        Console.Write("Entrez l'ID du compte à supprimer : ");
        int id = int.Parse(Console.ReadLine());
        Compte compte = compteCRUD.ObtenirCompte(id);

        if (compte != null)
        {
            compteCRUD.SupprimerCompte(id);
            Console.WriteLine("Compte supprimé avec succès.");
        }
        else
        {
            Console.WriteLine("Compte introuvable.");
        }
        Pause();
    }

    static void AfficherComptes()
    {
        compteCRUD.AfficherComptes();
        Pause();
    }

    #endregion

    static void Pause()
    {
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }
}
