using System;

namespace nop
{
    public class Player
    {
        public enum Operator { Shield, Doctor, Sniper, Assault }
        private readonly ShieldLevel _shieldLevel;
        public string Name { get; set; }
        public int Health { get; private set; }
        private readonly Operator _op;

        public Player(string name, Operator op, ShieldLevel shield)
        {
            Name = name;
            _op = op;
            Health = 100;
            _shieldLevel = shield;
        }

        public void ApplyDamage(int dmg)
        {
            int totalDmgReceived = dmg - _shieldLevel.ApplyShield();
            Health -= totalDmgReceived;
            Console.WriteLine($"Player: {Name} has shield protection of {_shieldLevel.ApplyShield()}");
            Console.WriteLine($"Damage Taken: {dmg}");
            Console.WriteLine($"Current Health is: {Health}");
            Console.WriteLine("---------------------------------------------");
        }

    }
}