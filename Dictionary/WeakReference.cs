using System;
using System.Collections.Generic;

namespace Dictionary
{
    public static class WeakReference
    {
        private static Dictionary<int, System.WeakReference> _data = new Dictionary<int, System.WeakReference>();

        public static void Start()
        {
            Data d = new Data(10);

            foreach (var item in _data)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Target}");
            }

            Console.ReadLine();
        }

        private class Data
        {
            public Data(int count)
            {
                for (int i = 1; i < count; i++)
                {
                    _data.Add(i, new System.WeakReference(new OtherClass(i * 2), false));
                }
            }
        }

        private class OtherClass
        {
            private int _value;

            public OtherClass(int value)
            {
                this._value = value;
            }

            public override string ToString()
            {
                return this._value.ToString();
            }
        }
    }
}
