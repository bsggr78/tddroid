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
        /// A collage 
        /// </summary>
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A collage 
            /// </summary>
            public class PageBlockCollage : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockCollage";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Collage item contents 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("page_blocks")]
                public PageBlock[] PageBlocks { get; set; }

                /// <summary>
                /// Block caption
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public PageBlockCaption Caption { get; set; }
            }
        }
    }
}