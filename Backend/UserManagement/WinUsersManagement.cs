using System.DirectoryServices.AccountManagement;
using System.Text.RegularExpressions;

namespace UserCreator.Backend.UserManagement
{
    internal partial class WinUsersManagement
    {
        private readonly Regex _lowercase = LowercaseRegex();

        private string? _description;
        private List<string> _accountsToHide = new() { "DefaultAccount", "Guest", "Administrator", "WDAGUtilityAccount" };

        public string? Username { get; set; }

        public string? Password { get; set; }

        public bool EnableAdmin { get; set; } = false;

        public string? Description { get; set; }

        public DateTime AccountExpirationLength { get; set; }

        public List<string>? LocalUsers { get; set; }

        public async Task CreateUser()
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
            await Task.Run(newUser.Save);

            if (EnableAdmin)
            {
                using GroupPrincipal groupPrincipal = GroupPrincipal.FindByIdentity(context, "Administrators");
                groupPrincipal.Members.Add(newUser);
                await Task.Run(groupPrincipal.Save);
            }
            else
            {
                using GroupPrincipal usersGroupPrinciple = GroupPrincipal.FindByIdentity(context, "Users");
                usersGroupPrinciple.Members.Add(newUser);
                await Task.Run(usersGroupPrinciple.Save);
            }
        }

        public async Task UpdatePassword()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userPasswordUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userPasswordUpdate != null)
            {
                if (!string.IsNullOrWhiteSpace(Password))
                {
                    userPasswordUpdate.SetPassword(Password);
                    await Task.Run(userPasswordUpdate.Save);
                }
            }
        }

        public async Task UpdateDescription()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userDescriptionUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userDescriptionUpdate != null)
            {
                if (!string.IsNullOrWhiteSpace(Description))
                {
                    userDescriptionUpdate.Description = Description;
                    await Task.Run(userDescriptionUpdate.Save);
                }
            }
        }

        public async Task UpdateAccountExpireDate()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userExpireDateUpdate = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            if (userExpireDateUpdate != null)
            {
                if (AccountExpirationLength != default && AccountExpirationLength != DateTime.Today)
                {
                    userExpireDateUpdate.AccountExpirationDate = AccountExpirationLength;
                    await Task.Run(userExpireDateUpdate.Save);
                }
            }
        }

        public async Task DeleteUser()
        {
            using PrincipalContext context = new(ContextType.Machine);
            UserPrincipal userToDelete = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, Username);
            await Task.Run(userToDelete.Delete);
        }

        public void GetLocalWindowsUsers()
        {
            LocalUsers = new List<string>();
            using (PrincipalContext context = new(ContextType.Machine))
            {
                UserPrincipal userSearch = new(context);
                PrincipalSearcher searcher = new(userSearch);
                foreach (UserPrincipal user in searcher.FindAll().Cast<UserPrincipal>())
                {
                    if (!_accountsToHide.Contains(user.SamAccountName))
                    {
                        LocalUsers?.Add(user.SamAccountName);
                    }
                }
            }
        }

        [GeneratedRegex("[a-z]")]
        private static partial Regex LowercaseRegex();
    }
}