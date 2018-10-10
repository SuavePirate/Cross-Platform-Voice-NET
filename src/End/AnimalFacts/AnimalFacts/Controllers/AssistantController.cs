using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using AnimalFacts.Contexts;
using AnimalFacts.Models.Constants;
using AnimalFacts.Models.DialogFlow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFacts.Controllers
{
    /// <summary>
    /// Endpoints for handling assistant requests
    /// </summary>
    [Route("api/[controller]")]
    public class AssistantController : Controller
    {
        private readonly AnimalContext _context;
        public AssistantController(AnimalContext context)
        {
            _context = context;
        }

        [HttpPost("Alexa")]
        public async Task<SkillResponse> Alexa([FromBody]SkillRequest input)
        {
            try
            {
                // handle welcome / launch requests
                if (input.GetRequestType() == typeof(LaunchRequest))
                {
                    return ResponseBuilder.Ask(Messages.Welcome, null);
                }

                // handle intents
                else if (input.GetRequestType() == typeof(IntentRequest))
                {
                    var intent = (input.Request as IntentRequest)?.Intent;

                    // handle the animal fact response
                    if (intent?.Name == Intents.AnimalFactIntent)
                    {
                        var animalName = intent.Slots["Animal"]?.Value;
                        // find the animal fact and return it as voice
                        var animalFact = await _context.AnimalFacts.FirstOrDefaultAsync(af => af.AnimalName.ToLower() == animalName.ToLower());

                        // if we don't have an animal - reprompt
                        if (animalFact == null)
                        {
                            return ResponseBuilder.Ask("I don't know about that animal. Try a different one!", null);
                        }

                        // return the fact
                        return ResponseBuilder.Tell(animalFact.Fact);
                    }
                }

                return ResponseBuilder.Tell("Something went wrong. Please try again later.");
            }
            catch
            {
                // return a response if something goes wrong
                return ResponseBuilder.Tell("Something went wrong. Please try again later.");
            }
        }

        [HttpPost("GoogleAssistant")]
        public async Task<ActionResponse> GoogleAssistant([FromBody]ActionRequest input)
        {
            try
            {
                var intentName = input.QueryResult.Action;

                // handle welcome / launch requests
                if (intentName == Intents.Welcome)
                {
                    return DialogBuilder.Ask(Messages.Welcome);
                }

                // handle the animal fact response
                if (intentName == Intents.AnimalFactIntent)
                {
                    var animalName = input?.QueryResult?.Parameters["Animal"];
                    // find the animal fact and return it as voice
                    var animalFact = await _context.AnimalFacts.FirstOrDefaultAsync(af => af.AnimalName.ToLower() == animalName.ToLower());

                    // if we don't have an animal - reprompt
                    if (animalFact == null)
                    {
                        return DialogBuilder.Ask("I don't know about that animal. Try a different one!");
                    }

                    // return the fact
                    return DialogBuilder.Tell(animalFact.Fact);
                }


                return DialogBuilder.Tell("Something went wrong. Please try again later.");
            }
            catch
            {
                // return a response if something goes wrong
                return DialogBuilder.Tell("Something went wrong. Please try again later.");
            }
        }
    }
}
