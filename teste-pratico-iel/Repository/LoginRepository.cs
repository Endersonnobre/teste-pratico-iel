using teste_pratico_iel.Context;
using teste_pratico_iel.Models;

namespace teste_pratico_iel.Repository
{
    public class LoginRepository
    {
        private readonly IELContext _context;

        public LoginRepository(IELContext context)
        {
            _context = context;
        }   

        public bool IsLogon(string username, string password)
        {
            return _context.Logins.Any(u => u.Username == username && u.Password == password);
        }

        public void CadastrarUsuario(Login login)
        {
            _context.Logins.Add(login);
            _context.SaveChanges();
        }
    }
}
