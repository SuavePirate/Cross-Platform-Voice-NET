using AnimalFacts.Models.DialogFlow.InnerFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFacts.Models.DialogFlow
{
    /// <summary>
    /// Just some helper stuff for returning a structure response.
    /// Similar to the Alexa.NET ResponseBuilder
    /// </summary>
    public static class DialogBuilder
    {
        public static ActionResponse Tell(string text)
        {
            return new ActionResponse
            {
                FulfillmentText = text,
                Payload = new ActionPayload
                {
                    Google = new GooglePayload
                    {
                        ExpectUserResponse = false,
                        Text = text,
                        RichResponse = new RichResponsePayload()
                        {
                            Items = new List<RichResponseItemContainer>()
                            {
                                new RichResponseItemContainer
                                {
                                    SimpleResponse = new SimpleResponseItem
                                    {
                                        TextToSpeech = $"<speak>{text}</speak>"
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public static ActionResponse Ask(string text)
        {
            return new ActionResponse
            {
                FulfillmentText = text,
                Payload = new ActionPayload
                {
                    Google = new GooglePayload
                    {
                        ExpectUserResponse = true,
                        Text = text,
                        RichResponse = new RichResponsePayload()
                        {
                            Items = new List<RichResponseItemContainer>()
                            {
                                new RichResponseItemContainer
                                {
                                    SimpleResponse = new SimpleResponseItem
                                    {
                                        TextToSpeech = $"<speak>{text}</speak>"
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
