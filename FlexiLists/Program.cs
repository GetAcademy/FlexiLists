using System;

namespace FlexiLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fire kuler:
             * rød
             * gul
             * grønn
             * blå
             *
             * Hvis man trekker to tilfeldige kuler, generer alle muligheter.
             *  - 4x3
             *
             */

            var simulation = new SphereSelectionSimulation();
            while (!simulation.IsFinished)
            {
                Console.WriteLine(simulation.Current);
                simulation.Next();
            }
            Console.WriteLine(simulation.Current);


            //FlexibleListGenericsDemo();
            //FlexibleListDemo1();
        }

        private static void FlexibleListGenericsDemo()
        {
            var list = new FlexibleList<float>();

            while (true)
            {
                string text = Console.ReadLine();
                float number = Convert.ToSingle(text);
                list.Add(number);
            }

            var list2 = new FlexibleList<bool>();

            while (true)
            {
                var text = Console.ReadLine();
                bool value = text.ToLower() == "ja";
                list2.Add(value);
            }
        }

        private static void FlexibleListDemo1()
        {
            var list = new FlexibleStringList();

            while (true)
            {
                var text = Console.ReadLine();
                list.Add(text);
            }

            var list2 = new FlexibleStringList();

            while (true)
            {
                var text = Console.ReadLine();
                list2.Add(text);
            }
        }
    }
}
