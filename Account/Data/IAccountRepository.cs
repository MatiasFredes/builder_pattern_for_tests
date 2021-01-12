using Domain;

namespace DataAccess
{
    public interface IAccountRepository
    {
        Account GetByName(string name);
    }
}
