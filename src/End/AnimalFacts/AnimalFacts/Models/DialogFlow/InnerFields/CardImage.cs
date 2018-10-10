using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields
{
    /// <summary>
    /// An image model used by google assistant cards
    /// </summary>
    public class CardImage
    {
        public string Url { get; set; }
        public string AccessibilityText { get; set; }
    }
}
