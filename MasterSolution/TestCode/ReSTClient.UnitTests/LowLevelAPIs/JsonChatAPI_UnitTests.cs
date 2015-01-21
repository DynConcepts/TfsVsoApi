using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonChatAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Gets the messages_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetMessages_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoomMessage>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the rooms_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetRooms_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoom>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the users_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetUsers_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoomMember>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        /// <summary>
        ///     The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>();
    }
}