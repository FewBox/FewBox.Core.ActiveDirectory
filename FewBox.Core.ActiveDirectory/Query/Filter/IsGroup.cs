using FewBox.Core.ActiveDirectory.Attribute;

namespace FewBox.Core.ActiveDirectory.Query.Filter
{
    /// <summary>
    /// Is group filter (Eg: (objectClass=group)).
    /// </summary>
    public class IsGroup : IFilter
    {
        /// <summary>
        /// Build the AD filter string (Eg: (objectClass=group)).
        /// </summary>
        /// <returns>The filter string.</returns>
        public string BuildFilter()
        {
            IFilter filter = new Is(AttributeNames.ObjectClass, GroupAttributeValues.Group);
            return filter.BuildFilter();
        }
    }
}
