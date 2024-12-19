public interface ICompteCRUD
{
    void AjouterCompte(Compte compte);
    Compte ObtenirCompte(int id);
    void ModifierCompte(Compte compte);
    void SupprimerCompte(int id);
}
