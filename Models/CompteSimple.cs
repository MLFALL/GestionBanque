public class CompteSimple : Compte
{
    private decimal tauxDecouvert;

    public decimal TauxDecouvert
    {
        get { return tauxDecouvert; }
        set { tauxDecouvert = value; }
    }

    public CompteSimple(Client client, decimal tauxDecouvert)
        : base(client)
    {
        this.tauxDecouvert = tauxDecouvert;
    }
}
