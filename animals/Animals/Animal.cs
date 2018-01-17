namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }

        public void nameIt(string animalName)
        {
            Name = animalName;
        }
    }
}