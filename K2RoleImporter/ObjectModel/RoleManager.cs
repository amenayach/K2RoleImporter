using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.Hosting.Client.BaseAPI;
using SourceCode.Security.UserRoleManager.Management;

namespace K2RoleImporter.ObjectModel
{

    public class RoleManager
    {

        public event EventHandler<RoleAddedEventArgs> RoleAdded;

        /// <summary>
        /// Creates a K2 role
        /// </summary>
        public void CreateRoles(string testUser, SCConnectionStringBuilder connectionStringBuilder, List<K2Role> roles)
        {
            var roleManager = new UserRoleManager();

            try
            {

                roleManager.CreateConnection();
                roleManager.Connection.Open(connectionStringBuilder.ToString());

                if (roles != null && roles.Count > 0)
                {
                    roles.ForEach(m =>
                    {
                        try
                        {

                            var role = new Role
                            {
                                Name = m.Name,
                                Description = m.Name,
                                IsDynamic = true
                            };

                            role.Include.Add(new UserItem(string.Format("{0}\\{1}", connectionStringBuilder.WindowsDomain, testUser)));

                            roleManager.CreateRole(role);

                            OnRoleAdded(new RoleAddedEventArgs() { Status = string.Format("{0} added", m.Name) });

                        }
                        catch (Exception ex)
                        {
                            OnRoleAdded(new RoleAddedEventArgs() { Status = ex.Message });
                        }
                    });
                }

                roleManager.Connection.Close();
            }
            catch (Exception ex)
            {
                OnRoleAdded(new RoleAddedEventArgs() { Status = ex.Message });
            }
            finally
            {
                if (roleManager.Connection.IsConnected)
                {
                    roleManager.Connection.Close();
                }
            }

        }

        /// <summary>
        /// Triggers the add event 
        /// </summary>
        protected virtual void OnRoleAdded(RoleAddedEventArgs e)
        {
            if (RoleAdded != null)
            {
                RoleAdded.Invoke(this, e);
            }
        }
    }
}
