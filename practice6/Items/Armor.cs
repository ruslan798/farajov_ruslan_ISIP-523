namespace ISIP523_Faradjov
{
    //я нефор
    internal class Armor : Item
    {
        public int Defense { get; private set; }

        public Armor(string name, int defense) : base(name)
        {
            Defense = defense;
        }

        public override void DisplayStats()
        {
            Console.WriteLine($"Доспехи: {Name} (Защита: {Defense})");
        }
    }
}