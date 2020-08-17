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
        /// A thumbnail to be sent along with a file; should be in JPEG or WEBP format for stickers, and less than 200 kB in size 
        /// </summary>
        public class InputThumbnail : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inputThumbnail";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Thumbnail file to send. Sending thumbnails by file_id is currently not supported
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail")]
            public InputFile Thumbnail { get; set; }

            /// <summary>
            /// Thumbnail width, usually shouldn't exceed 320. Use 0 if unknown 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("width")]
            public int Width { get; set; }

            /// <summary>
            /// Thumbnail height, usually shouldn't exceed 320. Use 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("height")]
            public int Height { get; set; }
        }
    }
}