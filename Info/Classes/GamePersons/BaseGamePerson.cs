namespace Info.classes.GamePersons
{
    public abstract class BaseGamePerson
    {
        public string NameClass { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int HealthPoints { get; set; }
        public int Mana { get; set; }
        public int Power { get; set; }
        protected BaseGamePerson(int strength, int agility, int stamina, int intellect)
        {
            Strength = strength;
            Agility = agility;
            Stamina = stamina;
            Intellect = intellect;
        }
        public abstract int Attack();
    }
}
