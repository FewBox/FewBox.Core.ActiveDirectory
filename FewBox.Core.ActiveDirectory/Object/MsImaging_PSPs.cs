using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class MsImaging_PSPs : ActiveDirectoryObject
    {
        internal MsImaging_PSPs(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
