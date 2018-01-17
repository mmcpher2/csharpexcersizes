namespace Animals
{
    public class Dog
    {
        public string Name { get; set; }
        public string WalkingSpeed {get; set;}

        public void nameIt(string animalName)
        {
            Name = animalName;
        }

        public void walk(string speed)
        {
            WalkingSpeed = speed;
        }
    }
}