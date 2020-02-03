namespace App.SRP.Good.Repositories
{
    public interface IUserRepository
    {
        void SaveUser(string userName, string userEmail);
    }
}
