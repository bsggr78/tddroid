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
        /// An animation 
        /// </summary>
        public partial class PageBlock : Object
        {
            /// <summary>
            /// An animation 
            /// </summary>
            public class PageBlockAnimation : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockAnimation";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Animation file; may be null 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("animation")]
                public Animation Animation { get; set; }

                /// <summary>
                /// Animation caption 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public PageBlockCaption Caption { get; set; }

                /// <summary>
                /// True, if the animation should be played automatically
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_autoplay")]
                public bool NeedAutoplay { get; set; }
            }
        }
    }
}