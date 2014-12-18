using System;

namespace DynCon.OSI.Core.AdvancedEvents
{
     /// <summary>
     /// Class GenericEventHolder.
     /// </summary>
     public class GenericEventHolder
    {
    }

     /// <summary>
     /// Class GenericEventHolder.
     /// </summary>
     /// <typeparam name="T"></typeparam>
     public class GenericEventHolder<T> : GenericEventHolder
    {
        /// <summary>
        /// Occurs when [on event].
        /// </summary>
        public event EventHandler<GenericEventArgs<T>> OnEvent;

         /// <summary>
         /// Fires the specified sender.
         /// </summary>
         /// <param name="sender">The sender.</param>
         /// <param name="data">The data.</param>
         public void Fire(object sender, T data)
        {
            EventHandler<GenericEventArgs<T>> shadow = OnEvent;
            if (shadow != null)
                shadow(sender, new GenericEventArgs<T>(data));
        }
    }
}