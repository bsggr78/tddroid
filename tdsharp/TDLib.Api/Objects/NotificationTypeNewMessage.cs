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
        /// New message was received 
        /// </summary>
        public partial class NotificationType : Object
        {
            /// <summary>
            /// New message was received 
            /// </summary>
            public class NotificationTypeNewMessage : NotificationType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationTypeNewMessage";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message")]
                public Message Message { get; set; }
            }
        }
    }
}