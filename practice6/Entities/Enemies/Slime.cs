using ISIP523_Faradjov;
using System;

namespace ISIP523_Faradjov
{
    internal class Slime : Enemy
    {
        public static int DamageReduction = 2; // Уменьшение урона на 2 единицы

        public Slime() : base("Слизень", 35, 6, 4)
        {
            Name = "Слизень";
            MaxHP = 35;
            CurrentHP = MaxHP;
            Attack = 6;
            Defense = 4;
        }

        public override void ApplySpecialEffect(Creature target) { }
        public override int CalculateDamage(Creature target) => Attack;
    }
}