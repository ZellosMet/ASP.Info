namespace Info.classes.GamePersons
{
    public class Spearmen : BaseGamePerson
    {
        public string NameClass { get; }
        public Spearmen(int strength, int agility, int stamina, int intellect) : base(strength, agility, stamina, intellect)
        {
            NameClass = "Spearmen";
            HealthPoints = stamina * 20;
            Mana = intellect * 5;
            Power = strength * 15;
        }
        public override int Attack()
        {
            return Power;
        }
    }
}
