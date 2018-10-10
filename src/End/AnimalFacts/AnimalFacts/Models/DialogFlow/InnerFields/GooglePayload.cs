using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Payload information for google requests
    /// </summary>
    public class GooglePayload
    {
        public bool ExpectUserResponse { get; set; }
        public string Text { get; set; }
        public RichResponsePayload RichResponse { get; set; }

        [JsonProperty("is_ssml")]
        public bool IsSsml { get; set; }
    }
}
