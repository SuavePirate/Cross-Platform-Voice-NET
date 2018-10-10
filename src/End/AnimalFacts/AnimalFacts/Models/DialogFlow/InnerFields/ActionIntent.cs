using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Contains information about the intent of an action request
    /// </summary>
    public class ActionIntent
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
