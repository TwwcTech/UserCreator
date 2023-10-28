using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal partial class WinUsersManagement
    {
        private readonly string _localMachineEnvironement = $"WinNT://{Environment.MachineName},computer";
        private readonly Regex _lowercase = MyRegex();

        private string? _username;
        private string? _password;
        private bool _enableAdmin = false;
        private string? _description;
        private int _maxBadPassword;
        private DateTime _accountExpirationDate;

        public string Username
        {
            get => _username!;
            set
            {
                _username = _lowercase.IsMatch(value[0].ToString()) ? value.Replace(value[0].ToString(), value[0].ToString().ToUpper()) : null;
                _username ??= string.Empty;
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
                if (_lowercase.IsMatch(value[0].ToString()))
                {
                    string updatedBegginningLetter = value[0].ToString().ToUpper();
                    value = value.Replace(value[0], Convert.ToChar(updatedBegginningLetter));
                    value += !value.EndsWith(".") ? "." : string.Empty;
                }
                _description = value.Trim();
            }
        }

        public int MaxBadPassword
        {
            get => _maxBadPassword;
            set => _maxBadPassword = value;
        }

        public DateTime AccountExpirationLength
        {
            get => _accountExpirationDate;
            set => _accountExpirationDate = value;
        }

        public WinUsersManagement() { }

        public void CreateUser()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry newUser = localMachine.Children.Add(Username, "user"))
                {
                    try
                    {
                        newUser.Invoke("SetPassword", new object[] { Password });

                        if (!string.IsNullOrWhiteSpace(Description))
                        {
                            newUser.Invoke("Put", new object[] { "Description", Description });
                        }

                        //newUser.Properties[nameof(Description)].Value = !string.IsNullOrWhiteSpace(Description) ? Description : string.Empty;

                        if (!int.IsNegative(MaxBadPassword) || MaxBadPassword != default)
                        {
                            newUser.Properties["LockoutThreshold"].Value = MaxBadPassword;
                        }

                        if (AccountExpirationLength != default || AccountExpirationLength != DateTime.Today)
                        {
                            const long maxDate = 0x7FFFFFFFFFFFFFFF;
                            newUser.Properties["AccountExpires"].Value = AccountExpirationLength.ToFileTime() > DateTime.MaxValue.ToFileTime() - maxDate ? maxDate : AccountExpirationLength.ToFileTime();
                        }

                        newUser.CommitChanges();
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

        public void UpdatePassword()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry userPasswordUpdate = localMachine.Children.Find(Username))
                {
                    if (userPasswordUpdate != null)
                    {
                        userPasswordUpdate.Invoke("SetPassword", new object[] { Password });
                        userPasswordUpdate.CommitChanges();
                    }
                }
            }
        }

        public void UpdateDescription()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry userDescriptionUpdate = localMachine.Children.Find(Username))
                {
                    if (userDescriptionUpdate != null)
                    {
                        userDescriptionUpdate.Properties["Description"].Value = Description;
                        userDescriptionUpdate.CommitChanges();
                    }
                }
            }
        }

        public void UpdateMaxBadPasswords()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry maxBadPassUpdate = localMachine.Children.Find(Username))
                {
                    if (maxBadPassUpdate != null)
                    {
                        maxBadPassUpdate.Properties["LockoutThreshold"].Value = MaxBadPassword;
                        maxBadPassUpdate.CommitChanges();
                    }
                }
            }
        }

        public void UpdateAccountExpirationDate()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                using (DirectoryEntry accountExpirationUpdate = localMachine.Children.Find(Username))
                {
                    if (accountExpirationUpdate != null)
                    {
                        const long maxDate = 0x7FFFFFFFFFFFFFFF;
                        accountExpirationUpdate.Properties["AccountExpires"].Value = AccountExpirationLength.ToFileTime() > DateTime.MaxValue.ToFileTime() - maxDate ? maxDate : AccountExpirationLength.ToFileTime();
                        accountExpirationUpdate.CommitChanges();
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

        [GeneratedRegex("[a-z]")]
        private static partial Regex MyRegex();
    }
}