using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class InetOrgPerson : ActiveDirectoryObject
    {
        internal InetOrgPerson(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
