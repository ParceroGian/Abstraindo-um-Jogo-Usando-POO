using System;
using Yu_Gi_oh.src.Entities;

namespace Yu_Gi_oh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster blueEyes = new Monster("Blue-eyes White Dragon", 3000, 2500);
            Monster summonedSkull = new Monster("Summoned Skull", 2500, 1200);
            MonsterEffect celticGuardian = new MonsterEffect("Celtic Guardian", 1400, 1400);

            Console.WriteLine(blueEyes.Attack());
            Console.WriteLine(celticGuardian.Attack(500));
            Console.WriteLine(summonedSkull.Attack());

        }
    }
}
