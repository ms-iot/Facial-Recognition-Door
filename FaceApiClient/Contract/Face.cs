// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face.Contract
{
    using System;

    /// <summary>
    /// The detected face entity.
    /// </summary>
    public class Face
    {
        /// <summary>
        /// Gets or sets the face identifier.
        /// </summary>
        /// <value>
        /// The face identifier.
        /// </value>
        public Guid FaceId { get; set; }

        /// <summary>
        /// Gets or sets the face rectangle.
        /// </summary>
        /// <value>
        /// The face rectangle.
        /// </value>
        public FaceRectangle FaceRectangle { get; set; }

        /// <summary>
        /// Gets or sets the face landmarks.
        /// </summary>
        /// <value>
        /// The face landmarks.
        /// </value>
        public FaceLandmarks FaceLandmarks { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public FaceAttribute Attributes { get; set; }
    }
}