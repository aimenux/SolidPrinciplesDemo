namespace App.SRP.Good.Notifiers
{
    public interface IUserNotifier
    {
        void NotifyUser(string userName, string userEmail);
    }
}
