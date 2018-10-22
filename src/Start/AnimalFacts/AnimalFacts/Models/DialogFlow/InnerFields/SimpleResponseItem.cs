using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// The most simple response item type
    /// </summary>
    public class SimpleResponseItem : ResponseItem
    {
        public string TextToSpeech { get; set; }
        public string Ssml { get; set; }
        public string DisplayText { get; set; }
    }
}
