using System.DirectoryServices;

namespace UserCreator.Backend.UserManagement
{
    internal class WinUsersManagement
    {
        private string? _localMachineEnvironement;

        public WinUsersManagement(string localMachineEnvironment)
        {
            _localMachineEnvironement = localMachineEnvironment;
        }
        public void CreateNewUser(string username, string password, bool admin)
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry newUser = localMachine.Children.Add(username, "user"))
                {
                    try
                    {
                        newUser.Invoke("SetPassword", new object[] { password });
                        newUser.Invoke("Put", new object[] { "Description", "New Local User" });
                        newUser.CommitChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }

                if (admin)
                {
                    using (DirectoryEntry adminGroup = localMachine.Children.Find("Administrators", "group"))
                    {
                        try
                        {
                            adminGroup.Invoke("Add", new object[] { $"{localMachine.Path}/{username}" });
                            adminGroup.CommitChanges();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.ToString());
                        }
                    }
                }
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
