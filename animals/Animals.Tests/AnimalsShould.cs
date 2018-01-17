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
            _animal.nameIt("Jack Rabbit");

            Assert.Equal(_animal.Name, "Jack Rabbit");

        }
    }
}
