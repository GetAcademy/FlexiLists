using System;

namespace FlexiLists
{
    class FlexibleList<T>
    {
        private T[] _texts;
        private int _index;

        public FlexibleList()
        {
            _texts = new T[1];
            _index = 0;
        }

        public void Add(T value)
        {
            if (_index == _texts.Length)
            {
                var newTexts = new T[_texts.Length * 2];
                Console.WriteLine($"Øker lengde fra {_texts.Length} til {_texts.Length * 2}");
                Array.Copy(_texts, newTexts, _texts.Length);
                _texts = newTexts;
            }
            _texts[_index] = value;
            _index++;
        }
    }
}
