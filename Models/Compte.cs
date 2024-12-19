public abstract class Compte : IEntity
{
    private static int next = 1;

    // Attributs privés
    protected int id;
    protected string numeroCompte;
    protected decimal solde;
    protected Client client;
    public int Id
    {
        get
        {
            return id;  
        }
    }
    public string NumeroCompte => numeroCompte;
    public decimal Solde
    {
        get { return solde; }
        set { solde = value; }
    }
    public Client Client
    {
        get { return client; }
        set { client = value; }
    }

    public Compte(Client client)
    {
        id = next++;
        this.client = client;
        numeroCompte = "000" + id.ToString() + client.Tel;
        solde = 0m; // Solde initialisé à zéro
    }
}
