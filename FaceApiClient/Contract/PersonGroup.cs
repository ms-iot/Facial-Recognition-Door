// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face.Contract
{
    /// <summary>
    /// The person group entity.
    /// </summary>
    public class PersonGroup
    {
        /// <summary>
        /// Gets or sets the person group identifier.
        /// </summary>
        /// <value>
        /// The person group identifier.
        /// </value>
        public string PersonGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of the person group.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user data.
        /// </summary>
        /// <value>
        /// The user data.
        /// </value>
        public string UserData { get; set; }
    }
}