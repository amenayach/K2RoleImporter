using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K2RoleImporter.ObjectModel;

namespace K2RoleImporter
{
    public partial class MainForm : Form
    {

        private readonly RoleManager _roleManager;

        public MainForm()
        {

            InitializeComponent();

            _roleManager = new RoleManager();

            _roleManager.RoleAdded += (sender, args) =>
            {
                tbStatus.AppendText(args.Status + Environment.NewLine);
            };

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        tbBrowseRoleFile.Text = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRoles_Click(object sender, EventArgs e)
        {
            try
            {
                var k2Profile = new K2Profile()
                {
                    Host = tbHost.Text,
                    Port = (uint)numPort.Value,
                    WindowsDomain = tbDomain.Text,
                    SecurityLabelName = tbSecurity.Text,
                    UserId = tbUserId.Text,
                    Password = tbPassword.Text
                };

                if (k2Profile.IsValid())
                {
                    if (tbBrowseRoleFile.Text.NotEmpty() && File.Exists(tbBrowseRoleFile.Text.Trim()))
                    {

                        if (tbTestUser.Text.IsEmpty())
                        {
                            throw new Exception("Please fill a test user");
                        }

                        var roles = File.ReadAllLines(tbBrowseRoleFile.Text.Trim()).Select(m => new K2Role() { Name = m }).ToList();

                        if (roles.Count > 0)
                        {
                            _roleManager.CreateRoles(tbTestUser.Text, k2Profile.GetConnectionStringBuilder(), roles);
                        }

                    }
                    else
                    {
                        MessageBox.Show(@"Please select the roles file");
                    }
                }
                else
                {
                    MessageBox.Show(@"Please fill all the K2 fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
