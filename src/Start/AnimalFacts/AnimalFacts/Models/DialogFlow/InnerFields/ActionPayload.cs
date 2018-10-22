using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFacts.Models.DialogFlow.InnerFields
{
    /// <summary>
    /// Contains data about the responses for different requesters. Add new properties
    /// here for different supported input locations like facebook and slack
    /// </summary>
    public class ActionPayload
    {
        public GooglePayload Google { get; set; }
    }
}
