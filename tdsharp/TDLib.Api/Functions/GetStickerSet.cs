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
        /// Returns information about a sticker set by its identifier 
        /// </summary>
        public class GetStickerSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStickerSet";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("set_id")]
            public Int64 SetId { get; set; }
        }


        /// <summary>
        /// Returns information about a sticker set by its identifier 
        /// </summary>
        public static Task<StickerSet> GetStickerSetAsync(this Client client,
            Int64 setId = default(Int64))
        {
            return client.ExecuteAsync(new GetStickerSet
            {
                SetId = setId,
            });
        }
    }
}