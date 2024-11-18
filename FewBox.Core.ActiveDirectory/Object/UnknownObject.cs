using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class UnknownObject : ActiveDirectoryObject
    {
        internal UnknownObject(DirectoryEntry directoryEntry) : 
            base(directoryEntry)
        {
        }
    }
}
