﻿using dotnet_improvement.Core.Domain.Args;
using System;

namespace dotnet_improvement.Core.Domain.Events
{
    public static class UserEvents
    {
        /// <summary>
        /// Will be raised when a user registered.
        /// </summary>
        /// <param name="sender">The object for the raiser class of this event.</param>
        /// <param name="args">
        /// Arguments that is needed for handling this event (for example, email sending & etc).
        /// </param>
        /// Also <see cref="UserDataEventArgs"/> can be used./>
        public delegate void UserRegisteredEventHandler(object sender, UserDataEventArgs args);
    }
}
