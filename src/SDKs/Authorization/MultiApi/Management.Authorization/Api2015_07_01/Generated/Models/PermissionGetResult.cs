// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Api2015_07_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Permissions information.
    /// </summary>
    public partial class PermissionGetResult
    {
        /// <summary>
        /// Initializes a new instance of the PermissionGetResult class.
        /// </summary>
        public PermissionGetResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PermissionGetResult class.
        /// </summary>
        /// <param name="value">An array of permissions.</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public PermissionGetResult(IList<Permission> value = default(IList<Permission>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of permissions.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Permission> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}