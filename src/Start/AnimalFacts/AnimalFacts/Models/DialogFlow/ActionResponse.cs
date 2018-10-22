using System;
using System.Collections.Generic;
using System.Text;
using AnimalFacts.Models.DialogFlow.InnerFields;

namespace AnimalFacts.Models.DialogFlow
{
    /// <summary>
    /// Represents the output that Google Assistant expects in response from a registered Action.
    /// Check out the structure details in the docs here https://dialogflow.com/docs/fulfillment#v2-api
    /// </summary>
    public class ActionResponse
    {
        public string FulfillmentText { get; set; }
        public IEnumerable<FulfillmentMessage> FulfillmentMessages { get; set; }
        public string Source { get; set; }
        public ActionPayload Payload { get; set; }
        public IEnumerable<ActionOutputContext> OutputContexts { get; set; }
        public FollowupEventInput FollowupEventInput { get; set; }
    }
}
