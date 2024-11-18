using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class MSMQQueueAlias : ActiveDirectoryObject
    {
        internal MSMQQueueAlias(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
