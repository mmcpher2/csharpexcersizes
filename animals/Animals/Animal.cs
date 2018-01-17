namespace Animals
{
    public class Animal
    {
        public string Name {get; set;}
        public string Species {get; set;}
        public string WalkingSpeed {get; set;}

        public void nameOfAnimal(string animalName)
        {
            Name = animalName;
        }
        public void speciesOfAnimal(string animalSpecies)
        {
            Species = animalSpecies;
        }
        public void walk(string speed)
        {
            WalkingSpeed = speed;
        }
    }
}