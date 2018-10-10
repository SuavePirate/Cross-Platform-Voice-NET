using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields;
using AnimalFacts.Models.DialogFlow.InnerFields;

namespace AnimalFacts.Models.DialogFlow
{
    /// <summary>
    /// The input model sent from the Google Action DialogFlow.
    /// See details here https://dialogflow.com/docs/fulfillment#v2-api
    /// </summary>
    public class ActionRequest
    {
        public string ResponseId { get; set; }
        public string Session { get; set; }
        public ActionQueryResult QueryResult { get; set; }
        public ActionUser User { get; set; }
        public object OriginalDetectIntentRequest { get; set; } // the raw intent from the original assistant (changes depending on the app initiating it)
    }
}
