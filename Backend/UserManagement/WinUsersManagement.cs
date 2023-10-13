using System.DirectoryServices;

namespace UserCreator.Backend.UserManagement
{
    internal class WinUsersManagement
    {
        public void CreateNewUser(string username, bool admin)
        {
            using (DirectoryEntry localMachine = new(/* add param */))
            {

            }
        }

        public void UpdateUser()
        {

        }

        public void DeleteUser(string username)
        {

        }
    }
}
