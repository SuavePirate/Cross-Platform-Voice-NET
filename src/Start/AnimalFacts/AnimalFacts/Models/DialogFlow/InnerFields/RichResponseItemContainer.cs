using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Inner item for a rich response payload
    /// </summary>
    public class RichResponseItemContainer
    {
        public SimpleResponseItem SimpleResponse { get; set; }
        public MediaResponseItem MediaResponse { get; set; }
        public BasicCard BasicCard { get; set; }
    }
}
