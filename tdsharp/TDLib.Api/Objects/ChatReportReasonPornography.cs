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
        /// The chat contains pornographic messages
        /// </summary>
        public partial class ChatReportReason : Object
        {
            /// <summary>
            /// The chat contains pornographic messages
            /// </summary>
            public class ChatReportReasonPornography : ChatReportReason
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatReportReasonPornography";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}