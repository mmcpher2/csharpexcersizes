using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalsShould(){
            _animal = new Animal();
            _dog = new Dog();
        }


        [Fact]
        public void nameAnimal()
        {
            _animal.nameOfAnimal("Jack Rabbit");
            Assert.Equal(_animal.Name, "Jack Rabbit");
        }
        [Fact]
        public void speciesAnimal()
        {
            _animal.speciesOfAnimal("Silly Rabbit");
            Assert.Equal(_animal.Species, "Silly Rabbit");
        }
        [Fact]
        public void checkWalkingSpeed()
        {
            _animal.walk("fast");
            _dog.walk("slow");

            Assert.Equal(_animal.WalkingSpeed, "fast");
            Assert.Equal(_dog.WalkingSpeed, "slow");
        }
    }
}
