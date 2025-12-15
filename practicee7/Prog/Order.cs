using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicee7

{
    internal class Order
    {
        private static int LastId = 0;

        public int Id;
        public Parts Part;
        public int TurnsToDelive;
        public int PartQuantity;

        public Order(Parts part, int quantity)
        {
            Id = LastId++;
            Part = part;
            PartQuantity = quantity;
            TurnsToDelive = 2;

            Console.WriteLine($"Заказ {Id} сформирован!");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id}. {Part}: {PartQuantity} шт.\nБудет доставлено через {TurnsToDelive} д.");
        }
    }
}
