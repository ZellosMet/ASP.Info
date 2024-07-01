namespace Info.classes.GamePersons
{
    public class Warrior : BaseGamePerson
    {
        public string NameClass { get; }
        public Warrior(int strength, int agility, int stamina, int intellect) : base(strength, agility, stamina, intellect)
        {
            NameClass = "Warrior";
            HealthPoints = stamina * 20;
            Mana = intellect * 5;
            Power = strength * 10;
        }
        public override int Attack()
        {
            return Power;
        }
    }
}
