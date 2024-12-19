public class CompteCRUD : ICompteCRUD
{
    private List<Compte> comptes = new List<Compte>();

    public void AjouterCompte(Compte compte)
    {
        comptes.Add(compte);
    }

 public Compte ObtenirCompte(int id)
{
    foreach (var compte in comptes)
    {
        if (compte.Id == id)
        {
            return compte;  // Si l'compte avec cet ID est trouvée, on la retourne
        }
    }
    return null;  // Si aucune compte n'a été trouvée, on retourne null
}


    public void ModifierCompte(Compte compte)
    {
        var c = ObtenirCompte(compte.Id);
        if (c != null)
        {
            c.Solde = compte.Solde;  // Modifie le solde du compte
        }
    }

    public void SupprimerCompte(int id)
    {
        var compte = ObtenirCompte(id);
        if (compte != null)
        {
            comptes.Remove(compte);
        }
    }

    public void AfficherComptes()
    {
        foreach (var compte in comptes)
        {
            compte.AfficherDetails();  // Appel de la méthode spécifique à chaque type de compte
        }
    }
}
