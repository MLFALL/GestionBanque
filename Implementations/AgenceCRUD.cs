public class AgenceCRUD : IAgenceCRUD
{
    private List<Agence> agences = new List<Agence>();

    public void AjouterAgence(Agence agence)
    {
        agences.Add(agence);
    }

    public Agence ObtenirAgence(int id)
{
    foreach (var agence in agences)
    {
        if (agence.Id == id)
        {
            return agence;  // Si l'agence avec cet ID est trouvée, on la retourne
        }
    }
    return null;  // Si aucune agence n'a été trouvée, on retourne null
}


    public void ModifierAgence(Agence agence)
    {
        var ag = ObtenirAgence(agence.Id);
        if (ag != null)
        {
            ag.Code = agence.Code;  // La propriété "Code" est modifiable
            ag.Libelle = agence.Libelle;  // "Libelle" est généré automatiquement
        }
    }

    public void SupprimerAgence(int id)
    {
        var agence = ObtenirAgence(id);
        if (agence != null)
        {
            agences.Remove(agence);
        }
    }
}
