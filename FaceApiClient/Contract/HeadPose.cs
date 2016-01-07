// *********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
// *********************************************************

namespace Microsoft.ProjectOxford.Face.Contract
{
    /// <summary>
    /// The head pose entity.
    /// </summary>
    public class HeadPose
    {
        /// <summary>
        /// Gets or sets the roll.
        /// </summary>
        /// <value>
        /// The roll of the face pose.
        /// </value>
        public float Roll { get; set; }

        /// <summary>
        /// Gets or sets the yaw.
        /// </summary>
        /// <value>
        /// The yaw of the face pose.
        /// </value>
        public float Yaw { get; set; }

        /// <summary>
        /// Gets or sets the pitch.
        /// </summary>
        /// <value>
        /// The pitch of the face pose.
        /// </value>
        public float Pitch { get; set; }
    }
}