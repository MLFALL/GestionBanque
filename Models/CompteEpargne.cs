public class CompteEpargne : Compte
{
    private int duree;

    
    public int Duree
    {
        get { return duree; }
        set { duree = value; }
    }

    public CompteEpargne(Client client, int duree)
        : base(client)
    {
        this.duree = duree;
    }
}
