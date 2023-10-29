using System.DirectoryServices.AccountManagement;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal partial class WinUsersManagement
    {
        [GeneratedRegex("[a-z]")]
        private static partial Regex LowercaseRegex();
        private readonly Regex _lowercase = LowercaseRegex();

        private string? _username;
        private string? _password;
        private bool _enableAdmin = false;
        private string? _description;
        private DateTime _accountExpirationDate;
        private List<string>? _localUsers = new();
        private List<string> _accountsToHide = new() { "DefaultAccount", "Guest", "Administrator", "WDAGUtilityAccount" };

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

        public List<string> LocalUsers
        {
            get => _localUsers!;
            private set => _localUsers = value;
        }

        public void CreateUser()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal newUser = new(context)
            {
                SamAccountName = Username,
                Enabled = true,
                Description = !string.IsNullOrWhiteSpace(Description) ? Description : string.Empty,
                AccountExpirationDate = AccountExpirationLength != default || AccountExpirationLength != DateTime.Today ? AccountExpirationLength : null
            };
            newUser.SetPassword(Password);
            newUser.Save();
            if (EnableAdmin)
            {
                using GroupPrincipal groupPrincipal = GroupPrincipal.FindByIdentity(context, "Administrators");
                groupPrincipal.Members.Add(newUser);
                groupPrincipal.Save();
            }
        }

        public void UpdatePassword()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                return;
            }

            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userPasswordUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userPasswordUpdate != null)
            {
                if (!string.IsNullOrWhiteSpace(Password))
                {
                    userPasswordUpdate.SetPassword(Password);
                    userPasswordUpdate.Save();
                }
            }
        }

        public void UpdateDescription()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                return;
            }

            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userDescriptionUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userDescriptionUpdate != null)
            {
                if (!string.IsNullOrWhiteSpace(Description))
                {
                    userDescriptionUpdate.Description = Description;
                    userDescriptionUpdate.Save();
                }
            }
        }

        public void UpdateAccountExpireDate()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                return;
            }

            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userExpireDateUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userExpireDateUpdate != null)
            {
                if (AccountExpirationLength != default && AccountExpirationLength != DateTime.Today)
                {
                    userExpireDateUpdate.AccountExpirationDate = AccountExpirationLength;
                    userExpireDateUpdate.Save();
                }
            }
        }

        public void DeleteUser()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                return;
            }

            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userToDelete = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            userToDelete?.Delete(); // if having issues revert back to the if branch
        }

        public void GetLocalWindowsUsers()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userSearch = new(context);
            PrincipalSearcher searcher = new(userSearch);

            foreach (UserPrincipal user in searcher.FindAll().Cast<UserPrincipal>())
            {
                if (!_accountsToHide.Contains(user.SamAccountName))
                {
                    LocalUsers.Add(user.SamAccountName);
                }
            }
        }
    }
}