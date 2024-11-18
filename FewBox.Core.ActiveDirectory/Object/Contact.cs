using FewBox.Core.ActiveDirectory.Attribute;
using FewBox.Core.ActiveDirectory.Attribute.ValueAdapter;
using FewBox.Core.ActiveDirectory.Query;
using FewBox.Core.ActiveDirectory.Query.Filter;
using System.Collections.Generic;
using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public class Contact : PersonObject
    {
        internal Contact(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }

        /// <summary>
        /// Find one contact object by common name.
        /// </summary>
        /// <param name="cn">The common name.</param>
        /// <returns>One contact object.</returns>
        public static Contact FindOneByCN(string cn)
        {
            return FindOne(new Is(AttributeNames.CN, cn));
        }

        /// <summary>
        /// Find all contact directory entry by filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>All contact directory entry by filter.</returns>
        public static new IList<Contact> FindAll(IFilter filter)
        {
            return ActiveDirectoryQuery.FindAllByFilter<Contact>(new And(new IsContact(), filter));
        }

        /// <summary>
        /// Find one contact directory entry by filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>All contact directory entry by filter.</returns>
        public static new Contact FindOne(IFilter filter)
        {
            return ActiveDirectoryQuery.FindOneByFilter<Contact>(new And(new IsContact(), filter));
        }
    }
}
