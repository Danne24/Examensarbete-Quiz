namespace Examensarbete_Quiz.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUser { get; }
        User GetUserByID(int userId);
        void EditUser(User user);
        void CreateNewUser(User user);
        void RemoveUser(int id);
    }
}
