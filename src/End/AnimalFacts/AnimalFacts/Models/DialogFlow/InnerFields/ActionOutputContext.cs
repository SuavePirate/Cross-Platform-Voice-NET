using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Property of the action request to provide output context
    /// </summary>
    public class ActionOutputContext
    {
        public string Name { get; set; }
        public int LifespanCount { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
    }
}
