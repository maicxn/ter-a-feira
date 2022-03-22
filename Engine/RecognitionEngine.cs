using Microsoft.Speech.Recognition;

using System.Globalization;
using Terça_Feira.Grammatics;

namespace Terça_Feira.Engine
{
    internal sealed class RecognitionEngine : SpeechRecognitionEngine
    {
        internal RecognitionEngine(CultureInfo cultureInfo) : base(cultureInfo)
        {
            SetInputToDefaultAudioDevice();
            LoadGrammar();

        }

        internal bool IsRunning { get; private set; } = false;

        internal void Start()
        {
            if (!IsRunning)
                RecognizeAsync(RecognizeMode.Multiple);
            IsRunning = true;
        }

        internal void Stop()
        {

            if (IsRunning)
                RecognizeAsyncCancel();
            IsRunning = false;
        }

        private void LoadGrammar()
        {
            foreach (var g in Builder.GetGrammars())
            {
                LoadGrammar(g);
            }
        }


    }

}
