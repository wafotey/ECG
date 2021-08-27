using ECG.Models;

namespace ECG.Services
{
    public class LoginService : ILoginService
    {
        public Login GetLogin()
        {
            return new Login();
        }
    }
}
