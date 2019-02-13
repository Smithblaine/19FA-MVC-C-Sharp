/*
 * Blaine Smith
 * Project walkthrough Due Tuesday, 02-12-2019
 * NONE
 * This program will test the methods created to see if they will provide the correct result.
 */
namespace TestingDemo
{
    public class User
    {
        public string LoginName { get; set; }
    }

    public interface IUserRepository
    {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }

    public class DefaultUserRepository : IUserRepository
    {

        public void Add(User newUser)
        {
            
        }

        public User FetchByLoginName(string loginName)
        {
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges()
        {
           
        }
    }
}