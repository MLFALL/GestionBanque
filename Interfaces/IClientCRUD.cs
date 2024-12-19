public interface IClientCRUD
{
    void AjouterClient(Client client);
    Client ObtenirClient(int id);
    void ModifierClient(Client client);
    void SupprimerClient(int id);
}
