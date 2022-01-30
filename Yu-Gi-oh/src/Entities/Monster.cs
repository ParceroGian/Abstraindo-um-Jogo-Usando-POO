namespace Yu_Gi_oh.src.Entities
{
    internal class Monster : Card
    {
        public Monster(string name, int attackPoints, int defensePoints)
        {
            Name = name;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
        }

    }
}
