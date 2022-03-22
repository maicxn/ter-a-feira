using System.Collections.Generic;

namespace Terça_Feira.Grammatics.Grammars
{
    internal sealed class GSystem : GrammarBase
    {
        internal GSystem(GrammarType grammarType)
            : base(grammarType.ToString(), GetGrammarPoints()) { }

        private static List<GrammarPoint> GetGrammarPoints() => new List<GrammarPoint>()
        {
             GetTurnOfGrammarPoint(),
        };

        private static GrammarPoint GetTurnOfGrammarPoint()
        {
            var inputs = new string[] 
            {
                    "Desligar",
                    "Fechar",
                    "Desligue",
                    "Desligar o sistema",
                    "Fechar sistema" 
            };

            return new GrammarPoint(inputs, GrammarSubType.TurnOf);



        }
    }
}
