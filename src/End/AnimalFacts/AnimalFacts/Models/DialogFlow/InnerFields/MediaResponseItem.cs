using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields
{
    /// <summary>
    /// Google assistant response using media.
    /// Check out https://developers.google.com/actions/assistant/responses#media_responses
    /// for reference
    /// </summary>
    public class MediaResponseItem : ResponseItem
    {
        public string MediaType { get; set; }
        public IList<MediaObject> MediaObjects { get; set; }
    }
}
