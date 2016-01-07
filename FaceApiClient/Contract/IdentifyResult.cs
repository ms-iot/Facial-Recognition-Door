// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face.Contract
{
    using System;

    /// <summary>
    /// The identification result.
    /// </summary>
    public class IdentifyResult
    {
        /// <summary>
        /// Gets or sets the face identifier.
        /// </summary>
        /// <value>
        /// The face identifier.
        /// </value>
        public Guid FaceId { get; set; }

        /// <summary>
        /// Gets or sets the candidates.
        /// </summary>
        /// <value>
        /// The candidates.
        /// </value>
        public Candidate[] Candidates { get; set; }
    }
}