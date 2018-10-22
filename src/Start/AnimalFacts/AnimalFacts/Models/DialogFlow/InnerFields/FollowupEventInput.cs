using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Part of the action response for follow up event requirements
    /// </summary>
    public class FollowupEventInput
    {
        public string Name { get; set; }
        public string LanguageCode { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
    }
}
