using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Payload property for rich responses
    /// </summary>
    public class RichResponsePayload
    {
        public IList<RichResponseItemContainer> Items { get; set; }
    }
}
