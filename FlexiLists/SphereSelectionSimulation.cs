namespace FlexiLists
{
    class SphereSelectionSimulation
    {
        private int[] _indexes;

        public SphereSelectionSimulation()
        {
            _indexes = new int[2];
            _indexes[0] = 0;
            _indexes[1] = 1;
        }

        private static readonly string[] _values = new[] {"rød", "blå", "grønn", "gul", "grå", "svart", "rosa"};
        public bool IsFinished => _indexes[0]==2 && _indexes[1] ==3;
        public string Current => _values[_indexes[0]] +  " " + _values[_indexes[1]];

        public void Next()
        {
            _indexes[1]++;
            if (_indexes[1]==_values.Length)
            {
                _indexes[0]++;
                _indexes[1] = _indexes[0] + 1;
            }
        }
    }
}
