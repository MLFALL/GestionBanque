public class Client : IEntity
{
    private static int next = 1;

    // Attributs privés
    private int id;
    private string prenom;
    private string nom;
    private string tel;
    private Agence agence;

   
    public int Id
    {
        get
        {
            return id;  
        }
    }
    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public string Tel
    {
        get { return tel; }
        set { tel = value; }
    }
    public Agence Agence
    {
        get { return agence; }
        set { agence = value; }
    }

    public Client(string prenom, string nom, string tel, Agence agence)
    {
        id = next++;
        this.prenom = prenom;
        this.nom = nom;
        this.tel = tel;
        this.agence = agence;
    }
}
