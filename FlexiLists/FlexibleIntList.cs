using System;

namespace FlexiLists
{
    class FlexibleIntList
    {
        private int[] _texts;
        private int _index;

        public FlexibleIntList()
        {
            _texts = new int[1];
            _index = 0;
        }

        public void Add(int number)
        {
            if (_index == _texts.Length)
            {
                var newTexts = new int[_texts.Length * 2];
                Console.WriteLine($"Øker lengde fra {_texts.Length} til {_texts.Length * 2}");
                Array.Copy(_texts, newTexts, _texts.Length);
                _texts = newTexts;
            }
            _texts[_index] = number;
            _index++;
        }
    }
}
