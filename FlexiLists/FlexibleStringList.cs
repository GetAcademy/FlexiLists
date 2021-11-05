using System;

namespace FlexiLists
{
        class FlexibleStringList
        {
            private string[] _texts;
            private int _index;

            public FlexibleStringList()
            {
                _texts = new string[1];
                _index = 0;
            }

            public void Add(string text)
            {
                if (_index == _texts.Length)
                {
                    var newTexts = new string[_texts.Length * 2];
                    Console.WriteLine($"Øker lengde fra {_texts.Length} til {_texts.Length * 2}");
                    Array.Copy(_texts, newTexts, _texts.Length);
                    _texts = newTexts;
                }
                _texts[_index] = text;
                _index++;
            }
        }
}
