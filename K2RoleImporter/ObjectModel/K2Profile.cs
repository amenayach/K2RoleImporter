using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.Hosting.Client.BaseAPI;

namespace K2RoleImporter.ObjectModel
{
    public class K2Profile
    {

        public string Host { get; set; }

        public uint Port { get; set; }

        public string SecurityLabelName { get; set; }

        public string WindowsDomain { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public SCConnectionStringBuilder GetConnectionStringBuilder()
        {
            return new SCConnectionStringBuilder()
            {
                Authenticate = true,
                Host = Host,
                Integrated = true,
                IsPrimaryLogin = true,
                Port = Port,
                SecurityLabelName = SecurityLabelName,
                WindowsDomain = WindowsDomain,
                UserID = UserId,
                Password = Password
            };
        }

        public bool IsValid()
        {
            return Host.NotEmpty() && 
                WindowsDomain.NotEmpty() && 
                SecurityLabelName.NotEmpty() && 
                UserId.NotEmpty() &&
                Password.NotEmpty();
        }
    }
}
