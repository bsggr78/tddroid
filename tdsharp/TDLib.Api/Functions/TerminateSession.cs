using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Terminates a session of the current user 
        /// </summary>
        public class TerminateSession : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "terminateSession";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Session identifier
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("session_id")]
            public Int64 SessionId { get; set; }
        }


        /// <summary>
        /// Terminates a session of the current user 
        /// </summary>
        public static Task<Ok> TerminateSessionAsync(this Client client,
            Int64 sessionId = default(Int64))
        {
            return client.ExecuteAsync(new TerminateSession
            {
                SessionId = sessionId,
            });
        }
    }
}