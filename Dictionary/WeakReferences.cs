using System;
using System.Collections.Generic;

namespace Dictionaries
{
    public static class WeakReferences
    {
        private static Dictionary<int, WeakReference> data = new Dictionary<int, WeakReference>();

        public static void Start()
        {
            Data d = new Data(10);

            foreach (var item in data)
            {
                Console.WriteLine(string.Format("{0} - {1}", item.Key, item.Value));
            }

            Console.ReadLine();
        }

        private class Data
        {
            public Data(int count)
            {
                for (int i = 1; i < count; i++)
                {
                    data.Add(i, new WeakReference(new OtherClass(i * 2), false));
                }
            }
        }

        private class OtherClass
        {
            private int value;

            public OtherClass(int value)
            {
                this.value = value;
            }
        }
    }
}
