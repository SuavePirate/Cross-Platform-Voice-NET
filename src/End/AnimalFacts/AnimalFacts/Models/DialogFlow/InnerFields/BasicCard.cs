using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    public class BasicCard : FulfillmentMessage
    {
        public string FormattedText { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public CardImage Image { get; set; }
        public string ImageDisplayOptions { get; set; } = "CROPPED"; // default to cropped
        // TODO: add other fields for things like buttons if we get around to supporting them
    }
}
