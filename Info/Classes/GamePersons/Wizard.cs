namespace Info.classes.GamePersons
{
    public class Wizard : BaseGamePerson
    {
        public string NameClass { get; }
        public Wizard(int strength, int agility, int stamina, int intellect) : base(strength, agility, stamina, intellect)
        {
            NameClass = "Wizard";
            HealthPoints = stamina * 10;
            Mana = intellect * 30;
            Power = strength * 10;
        }
        public override int Attack()
        {
            return Power;
        }
    }
}
