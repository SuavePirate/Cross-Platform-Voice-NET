using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Core.Models.Transfer.Assistants.GoogleAssistant.InnerFields
{
    /// <summary>
    /// Media object for a media response to google assistant
    /// </summary>
    public class MediaObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContentUrl { get; set; }
        public CardImage LargeImage { get; set; }
        public CardImage Icon { get; set; }
        // todo: include image item
    }
}
