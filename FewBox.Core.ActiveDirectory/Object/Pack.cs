using FewBox.Core.ActiveDirectory.Attribute;
using FewBox.Core.ActiveDirectory.Query.Filter;
using System.Collections.Generic;
using System.DirectoryServices;

namespace FewBox.Core.ActiveDirectory.Object
{
    public abstract class Pack : PackContainer
    {
        #region AD Attributes

        private IList<OrganizationalUnit> organizationalUnits;

        /// <summary>
        /// The child organizational units.
        /// </summary>
        public IList<OrganizationalUnit> OrganizationalUnits
        {
            get
            {
                if (this.organizationalUnits == null)
                {
                    this.organizationalUnits = new List<OrganizationalUnit>();
                    foreach (DirectoryEntry child in this.DirectoryEntry.Children)
                    {
                        using (child)
                        {
                            var organizationalUnit = FindOne(new And(
                                    new Is(AttributeNames.DistinguishedName, child.Properties[AttributeNames.DistinguishedName].Value.ToString()),
                                    new IsOrganizationalUnit())) as OrganizationalUnit;
                            if (organizationalUnit != null)
                            {
                                this.organizationalUnits.Add(organizationalUnit);
                            }
                        }
                    }
                }
                return this.organizationalUnits;
            }
        }

        #endregion

        public Pack(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
