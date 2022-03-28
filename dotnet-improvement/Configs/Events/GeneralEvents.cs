using System;

namespace dotnet_improvement.Configs.Events
{
    public static class GeneralEvents
    {
        public delegate void SuccessEvent();

        /// <summary>
        /// Will be raised when a product is added.
        /// </summary>
        /// <param name="source">The object for the raiser class of this event.</param>
        /// <param name="args">
        /// Arguments that is needed for handling this event (for example, email sending & etc).
        /// </param>
        /// Also <see cref="System.EventHandler"/> can be used./>
        public delegate void ProductAddedEventHandler(object source, EventArgs args);
    }
}
