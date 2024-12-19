public class Agence : IEntity
{
    private static int next = 1;

    // Attributs privés
    private int id;
    private string code;
    private string libelle;

    public int Id
    {
        get
        {
            return id;  
        }
    }
    public string Code
    {
        get { return code; }
        set { code = value; }
    }
    public string Libelle
    {
        get { return libelle; }
        private set { libelle = value; }
    }

    public Agence(string code)
    {
        id = next++;
        this.code = code;
        Libelle = id.ToString() + code.Substring(0, 3); 
    }
}
