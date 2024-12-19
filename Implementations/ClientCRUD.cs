public class ClientCRUD : IClientCRUD
{
    private List<Client> clients = new List<Client>();

    public void AjouterClient(Client client)
    {
        clients.Add(client);
    }

    public Client ObtenirClient(int id)
{
    foreach (var client in clients)
    {
        if (client.Id == id)
        {
            return client;  // Si l'client avec cet ID est trouvée, on la retourne
        }
    }
    return null;  // Si aucune client n'a été trouvée, on retourne null
}


    public void ModifierClient(Client client)
    {
        var cl = ObtenirClient(client.Id);
        if (cl != null)
        {
            cl.Prenom = client.Prenom;
            cl.Nom = client.Nom;
            cl.Tel = client.Tel;
            cl.client = client.client;  // Mise à jour de l'client associée
        }
    }

    public void SupprimerClient(int id)
    {
        var client = ObtenirClient(id);
        if (client != null)
        {
            clients.Remove(client);
        }
    }
}
