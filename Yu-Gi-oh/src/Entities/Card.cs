namespace Yu_Gi_oh.src.Entities
{
    internal abstract class Card
    {
        public string Name { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
        public string GuardianStar { get; set; }

        public Card()
        {

        }

        public Card(string name, int attackPoints, int defensePoints)
        {
            Name = name;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
        }


        public override string ToString()
        {
            return $"{Name} ATK {AttackPoints} DFD {DefensePoints}";

        }

        public string Attack()
        {
            return $"{Name} atacou Inflingindo um dano de {AttackPoints} ";
        }




    }
}

