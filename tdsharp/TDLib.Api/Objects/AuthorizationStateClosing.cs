using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// TDLib is closing, all subsequent queries will be answered with the error 500. Note that closing TDLib can take a while. All resources will be freed only after authorizationStateClosed has been received
        /// </summary>
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// TDLib is closing, all subsequent queries will be answered with the error 500. Note that closing TDLib can take a while. All resources will be freed only after authorizationStateClosed has been received
            /// </summary>
            public class AuthorizationStateClosing : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateClosing";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}