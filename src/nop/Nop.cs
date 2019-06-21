using System;

namespace nop
{
    class Nop
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Player 1", Player.Operator.Shield, new FullArmor());
            var player2 = new Player("Player 2", Player.Operator.Assault, new LightVest());
            var player3 = new Player("Player 3", Player.Operator.Sniper, ShieldLevel.Null);

            player1.ApplyDamage(10);
            player2.ApplyDamage(10);
            player3.ApplyDamage(10);
        }
    }
}
