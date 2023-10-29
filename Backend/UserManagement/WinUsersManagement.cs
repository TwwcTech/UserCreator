using System.DirectoryServices.AccountManagement;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal partial class WinUsersManagement
    {
        private readonly Regex _lowercase = MyRegex();

        private string? _username;
        private string? _password;
        private bool _enableAdmin = false;
        private string? _description;
        private DateTime _accountExpirationDate;
        private string[]? _localUsers;

        public string Username
        {
            get => _username!;
            set
            {
                _username = _lowercase.IsMatch(value[0].ToString()) ? value.Replace(value[0].ToString(), value[0].ToString().ToUpper()) : value.Trim();
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
            set => _description = value;
        }

        public DateTime AccountExpirationLength
        {
            get => _accountExpirationDate;
            set => _accountExpirationDate = value;
        }

        public string[] LocalUsers
        {
            get => _localUsers!;
            private set => _localUsers = value;
        }

        public void CreateUser()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal user = new(context)
            {
                SamAccountName = Username,
                Enabled = true,
                Description = !string.IsNullOrWhiteSpace(Description) ? Description : string.Empty,
                AccountExpirationDate = AccountExpirationLength != default || AccountExpirationLength != DateTime.Today ? AccountExpirationLength : null
            };
            user.SetPassword(Password);
            user.Save();

            if (EnableAdmin)
            {
                using GroupPrincipal groupPrincipal = GroupPrincipal.FindByIdentity(context, "Administrators");
                groupPrincipal.Members.Add(user);
                groupPrincipal.Save();
            }
        }

        //public void UpdatePassword()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        using (DirectoryEntry userPasswordUpdate = localMachine.Children.Find(Username))
        //        {
        //            if (userPasswordUpdate != null)
        //            {
        //                userPasswordUpdate.Invoke("SetPassword", new object[] { Password });
        //                userPasswordUpdate.CommitChanges();
        //            }
        //        }
        //    }
        //}

        //public void UpdateDescription()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        using (DirectoryEntry userDescriptionUpdate = localMachine.Children.Find(Username))
        //        {
        //            if (userDescriptionUpdate != null)
        //            {
        //                userDescriptionUpdate.Properties["Description"].Value = Description;
        //                userDescriptionUpdate.CommitChanges();
        //            }
        //        }
        //    }
        //}

        //public void UpdateMaxBadPasswords()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        using (DirectoryEntry maxBadPassUpdate = localMachine.Children.Find(Username))
        //        {
        //            if (maxBadPassUpdate != null)
        //            {
        //                maxBadPassUpdate.Properties["LockoutThreshold"].Value = MaxBadPassword;
        //                maxBadPassUpdate.CommitChanges();
        //            }
        //        }
        //    }
        //}

        //public void UpdateAccountExpirationDate()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        using (DirectoryEntry accountExpirationUpdate = localMachine.Children.Find(Username))
        //        {
        //            if (accountExpirationUpdate != null)
        //            {
        //                const long maxDate = 0x7FFFFFFFFFFFFFFF;
        //                accountExpirationUpdate.Properties["AccountExpires"].Value = AccountExpirationLength.ToFileTime() > DateTime.MaxValue.ToFileTime() - maxDate ? maxDate : AccountExpirationLength.ToFileTime();
        //                accountExpirationUpdate.CommitChanges();
        //            }
        //        }
        //    }
        //}

        //public void DeleteUser()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        using (DirectoryEntry userToDelete = localMachine.Children.Find(Username))
        //        {
        //            if (userToDelete != null)
        //            {
        //                try
        //                {
        //                    localMachine.Children.Remove(userToDelete);
        //                    localMachine.CommitChanges();
        //                }
        //                catch (Exception ex)
        //                {
        //                    throw new Exception(ex.ToString());
        //                }
        //            }
        //        }
        //    }
        //}

        //public void GetLocalWindowsUsers()
        //{
        //    using (DirectoryEntry localMachine = new(_localMachineEnvironement))
        //    {
        //        foreach (DirectoryEntry entry in localMachine.Children)
        //        {
        //            if (entry.SchemaClassName == "User")
        //            {
        //                LocalUsers = new string[] { entry.Name };
        //            }
        //        }
        //    }
        //}

        [GeneratedRegex("[a-z]")]
        private static partial Regex MyRegex();
    }
}