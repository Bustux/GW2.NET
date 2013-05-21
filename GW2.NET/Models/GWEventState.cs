﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventState.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the EventState type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.Models
{
    /// <summary>
    /// Enumerates all possible states an event can be.
    /// </summary>
    public enum GWEventState
    {
        /// <summary>
        ///  The event is running now.
        /// </summary>
        Active,

        /// <summary>
        /// The event has succeeded.
        /// </summary>
        Success,

        /// <summary>
        /// The event is inactive, 
        /// and will only become active once certain criteria are met.
        /// </summary>
        Warmup,

        /// <summary>
        /// The criteria for the event to start have been met, 
        /// but certain activities (such as an NPC dialogue) have not completed yet. 
        /// After the activites have been completed, the event will become Active.
        /// </summary>
        Preparation
    }
}