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
        /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method 
        /// </summary>
        public class JoinChat : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "joinChat";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }
        }


        /// <summary>
        /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method 
        /// </summary>
        public static Task<Ok> JoinChatAsync(this Client client,
            long chatId = default(long))
        {
            return client.ExecuteAsync(new JoinChat
            {
                ChatId = chatId,
            });
        }
    }
}