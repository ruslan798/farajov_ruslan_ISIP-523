using System;
using System.Collections.Generic;

namespace ISIP523_Faradjov
{
    // ь
    internal abstract class Item
    {
        public string Name { get; protected set; }

        public Item(string name)
        {
            Name = name;
        }

        public abstract void DisplayStats();
    }
}