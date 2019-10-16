﻿using Microsoft.Bot.Builder.Solutions.Contextual.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Solutions.Contextual.Rules
{
    public class CacheRule : IRule
    {
        public async Task<string> GetAnaphoraResolutionResultAsync(AnaphoraResolutionState state)
        {
            if (state.Pron == PossessivePronoun.ThirdPerson)
            {
                if (state.PreviousContacts.Count() > 0)
                {
                    return state.PreviousContacts.Last();
                }
            }

            return null;
        }
    }
}
