using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class Printer : ActiveDirectoryObject
    {
        internal Printer(DirectoryEntry directoryEntry) : base(directoryEntry)
        {
        }
    }
}
