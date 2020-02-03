namespace App.SRP.Good.Validators
{
    public interface IUserValidator
    {
        void ValidateUserName(string userName);
        void ValidateUserEmail(string userEmail);
    }
}
