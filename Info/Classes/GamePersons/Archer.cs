namespace Info.classes.GamePersons
{
    public class Archer : BaseGamePerson
    {
        public Archer(int strength, int agility, int stamina, int intellect) : base(strength, agility, stamina, intellect)
        {
            NameClass = "Archer";
            HealthPoints = stamina * 15;
            Mana = intellect * 5;
            Power = strength * 8;
        }
        public override int Attack()
        {
            return Power;
        }
    }
}
