using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class SharedFolder : ActiveDirectoryObject
    {
        internal SharedFolder(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
