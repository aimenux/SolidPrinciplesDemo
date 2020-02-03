using App.Srp.Good.Notifiers;
using App.Srp.Good.Repositories;
using App.Srp.Good.Validators;

namespace App.Srp.Good.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IUserValidator _userValidator;
        private readonly IUserRepository _userRepository;
        private readonly IUserNotifier _userNotifier;

        public RegisterService(IUserValidator userValidator, IUserRepository userRepository, IUserNotifier userNotifier)
        {
            _userValidator = userValidator;
            _userRepository = userRepository;
            _userNotifier = userNotifier;
        }

        public void RegisterUser(string userName, string userEmail)
        {
            _userValidator.ValidateUserName(userName);
            _userValidator.ValidateUserEmail(userEmail);
            _userRepository.SaveUser(userName, userEmail);
            _userNotifier.NotifyUser(userName, userEmail);
        }
    }
}
