
using Microsoft.Speech.Recognition;
using System.Collections.Generic;
using Terça_Feira.Grammatics.Grammars;

namespace Terça_Feira.Grammatics
{
    internal static class Builder
    {
        internal static string[] RejectedReturns = new string[]
        {
        "Não entendi",
        "Desculpe, Maicon, não entendi",
        "Maicon, pode repetir?"
        };

        internal static List<Grammar> GetGrammars()
        {
            var grammars = new List<Grammar>();
            var grammarsBases = GetGrammarBases();

            foreach (var gb in grammarsBases)
            {
                var choices = new Choices();

                foreach (var gp in gb.GrammarPoints)
                {
                    choices.Add(gp.Inputs);
                }

                var grammarbuilder = new GrammarBuilder(choices);
                grammars.Add(new Grammar(grammarbuilder) { Name = gb.Name });
            }

            return grammars;
        }

        private static List<GrammarBase> GetGrammarBases() => new List<GrammarBase>()
        {
            new GSystem(GrammarType.System),
        };

    }
}
