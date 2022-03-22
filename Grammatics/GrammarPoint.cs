using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terça_Feira.Grammatics
{
    internal sealed class GrammarPoint
    {
        internal GrammarPoint(string[] inputs, GrammarSubType grammarSubType)
        {
            Inputs = inputs;
            GrammarSubType = grammarSubType;
            GrammarSubType = grammarSubType;
            Inputs = inputs;
        }

        internal string[] Inputs { get; }
        internal GrammarSubType GrammarSubType { get; }
    }
}
