public interface IAgenceCRUD
{
    void AjouterAgence(Agence agence);
    Agence ObtenirAgence(int id);
    void ModifierAgence(Agence agence);
    void SupprimerAgence(int id);
}
