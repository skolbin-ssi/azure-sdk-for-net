// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.MediaComposition
{
    /// <summary> A Teams meeting to be used as an input or output. </summary>
    public partial class TeamsMeeting
    {
        /// <summary> Initializes a new instance of TeamsMeeting. </summary>
        /// <param name="teamsJoinUrl"> The url from Teams to join the meeting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="teamsJoinUrl"/> is null. </exception>
        public TeamsMeeting(string teamsJoinUrl)
        {
            if (teamsJoinUrl == null)
            {
                throw new ArgumentNullException(nameof(teamsJoinUrl));
            }

            TeamsJoinUrl = teamsJoinUrl;
        }

        /// <summary> The url from Teams to join the meeting. </summary>
        public string TeamsJoinUrl { get; set; }
    }
}
