﻿using System.DirectoryServices;

namespace UserCreator.Backend.UserManagement
{
    internal class WinUsersManagement
    {
        private static string? _localMachineEnvironement;

        public WinUsersManagement(string localMachineEnvironment)
        {
            _localMachineEnvironement = localMachineEnvironment;
        }
        public static void CreateNewUser(string username, string password, bool admin, string description = null!)
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

        public static void UpdateUser()
        {
            using (DirectoryEntry localMachine = new(_localMachineEnvironement))
            {
                // Code goes here
            }
        }

        public static void DeleteUser(string username)
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
