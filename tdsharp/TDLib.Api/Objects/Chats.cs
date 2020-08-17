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
        /// Represents a list of chats 
        /// </summary>
        public class Chats : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chats";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of chat identifiers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_ids")]
            public long[] ChatIds { get; set; }
        }
    }
}