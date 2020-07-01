using System;
using System.Threading.Tasks;


namespace PartlyNewsy.Core
{
    public class AuthenticationService
    {
        public string AccessToken { get; set; }

        public async Task<bool> Login()
        {
            return await Task.FromResult(true);
        }

        public bool Logout()
        {            
            return true;
        }
    }
}
