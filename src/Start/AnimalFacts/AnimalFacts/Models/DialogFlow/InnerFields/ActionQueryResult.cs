using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Contains information about the user's original query
    /// </summary>
    public class ActionQueryResult
    {
        public string QueryText { get; set; }
        public string Action { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public bool AllRequiredParamsPresent { get; set; }
        public string FulfillmentText { get; set; }
        public IEnumerable<FulfillmentMessage> FulfillmentMessages { get; set; }
        public IEnumerable<ActionOutputContext> OutputContexts { get; set; }
        public ActionIntent Intent { get; set; }
        public double IntentDetectionConfidence { get; set; }
        public object DiagnosticInfo { get; set; }
        public string LanguageCode { get; set; }
    }
}
