using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal class WinUsersManagement
    {
        private string _localMachineEnvironement = $"WinNT://{Environment.MachineName},computer";

        private string? _username;
        private string? _password;
        private bool _admin = false;
        private string? _description;

        public string Username
        {
            get => _username!;
            set => _username = value;
        }

        public string Password
        {
            get => _password!;
            set
            {
                Regex numberMatch = new("/d");
                Regex symbolMatch = new(@"[-!@#$%^&*()?_,.]");

                if (value.Length >= 8 && numberMatch.IsMatch(value) && symbolMatch.IsMatch(value))
                {
                    _password = value;
                }
                else
                {
                    MessageBox.Show("Password must contain a number, symbol, and must be at least 8 characters in length", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool Admin
        {
            get => _admin;
            set => _admin = value;
        }

        public string Description
        {
            get => _description!;
            set => _description = value;
        }

        public WinUsersManagement()
        {

        }

        public void CreateNewUser(string username, string password, bool admin, string description = null!)
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry newUser = localMachine.Children.Add(username, "user"))
                {
                    try
                    {
                        if (description == null || string.IsNullOrWhiteSpace(description))
                        {
                            newUser.Invoke("SetPassword", new object[] { password });
                            newUser.Invoke("Put", new object[] { "Description", "New Local User" });
                            newUser.CommitChanges();
                        }
                        else
                        {
                            newUser.Invoke("SetPassword", new object[] { password });
                            newUser.Invoke("Put", new object[] { "Description", description });
                            newUser.CommitChanges();
                        }
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
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                // Code goes here
            }
        }

        public void DeleteUser(string username)
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry userToDelete = localMachine.Children.Find(username))
                {
                    if (userToDelete != null)
                    {
                        try
                        {
                            localMachine.Children.Remove(userToDelete);
                            localMachine.CommitChanges();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}
