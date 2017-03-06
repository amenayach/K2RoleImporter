using System;

namespace K2RoleImporter.ObjectModel
{
    public class RoleAddedEventArgs : EventArgs
    {

        /// <summary>
        /// Gets or sets the role adding status
        /// </summary>
        public string Status { get; set; }

    }
}