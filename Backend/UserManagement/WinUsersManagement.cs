using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal class WinUsersManagement
    {
        private string _localMachineEnvironement = $"WinNT://{Environment.MachineName},computer";
        private Regex _lowercaseMatch = new(@"[a-z]");

        private string? _username;
        private string? _password;
        private bool _enableAdmin;
        private string? _description;

        public string Username
        {
            get => _username!;
            set
            {
                if (_lowercaseMatch.IsMatch(value[0].ToString()))
                {
                    string updatedBegginningCharacter = value[0].ToString().ToUpper();
                    value = value.Replace(value[0], Convert.ToChar(updatedBegginningCharacter));
                }
                _username = value;
            }
        }

        public string Password
        {
            get => _password!;
            set => _password = value;
        }

        public bool EnableAdmin
        {
            get => _enableAdmin;
            set => _enableAdmin = value;
        }

        public string Description
        {
            get => _description!;
            set
            {
                if (_lowercaseMatch.IsMatch(value[0].ToString()))
                {
                    string updatedBegginningLetter = value[0].ToString().ToUpper();
                    value = value.Replace(value[0], char.Parse(updatedBegginningLetter));
                    if (!value.EndsWith("."))
                    {
                        value += ".";
                    }
                }
                _description = value;
            }
        }

        public WinUsersManagement() { }

        public void CreateNewUser()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry newUser = localMachine.Children.Add(Username, "user"))
                {
                    try
                    {
                        if (Description == null || string.IsNullOrWhiteSpace(Description))
                        {
                            newUser.Invoke("SetPassword", new object[] { Password });
                            newUser.Invoke("Put", new object[] { "Description", "New Local User" });
                            newUser.CommitChanges();
                        }
                        else
                        {
                            newUser.Invoke("SetPassword", new object[] { Password });
                            newUser.Invoke("Put", new object[] { "Description", Description });
                            newUser.CommitChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }

                if (EnableAdmin)
                {
                    using (DirectoryEntry adminGroup = localMachine.Children.Find("Administrators", "group"))
                    {
                        try
                        {
                            adminGroup.Invoke("Add", new object[] { $"{localMachine.Path}/{Username}" });
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

        public void UpdateDescription()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry userToUpdate = localMachine.Children.Find(Username))
                {
                    if (userToUpdate != null)
                    {
                        userToUpdate.Properties["Description"].Value = Description;
                        userToUpdate.CommitChanges();
                    }
                }
            }
        }

        public void DeleteUser()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry userToDelete = localMachine.Children.Find(Username))
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