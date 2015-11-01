// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face.Contract
{
    /// <summary>
    /// The face attribute class that holds Age/Gender/Pose information.
    /// </summary>
    public class FaceAttribute
    {
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age of detected face.
        /// </value>
        public double Age { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the head pose.
        /// </summary>
        /// <value>
        /// The head pose.
        /// </value>
        public HeadPose HeadPose { get; set; }
    }
}