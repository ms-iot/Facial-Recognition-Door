// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face
{
    using System;

    /// <summary>
    /// Container of ClientError and Error Entity.
    /// </summary>
    public class ClientError
    {
        /// <summary>
        /// Gets or sets error code in error entity.
        /// </summary>
        /// <value>
        /// The code of client error.
        /// </value>
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public Guid RequestId
        {
            get;
            set;
        }
    }
}