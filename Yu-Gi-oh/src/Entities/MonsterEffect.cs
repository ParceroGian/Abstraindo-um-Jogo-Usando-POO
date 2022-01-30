namespace Yu_Gi_oh.src.Entities
{
    internal class MonsterEffect : Card
    {
        public MonsterEffect(string name, int attackPoints, int defensePoints)
        {
            Name = name;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
        }

        public string Attack(int guardianStar)
        {
            return $"{Name} atacou Com seu ataque especial inflingindo um dano de {AttackPoints + guardianStar} Pontos ";
        }


    }
}
