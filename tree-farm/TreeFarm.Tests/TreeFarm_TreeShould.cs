using System;
using Xunit;

namespace TreeFarm.Tests
{
    public class TreeFarm_TreeShould
    {
        private Tree _tree;

        public void TreeShould()
        {
            _tree = new Tree() { Height = 4.2, Location = "A3", Type = "Oak" };
        }

        [Fact]
        public void ChangeLocation()
        {
            // Given this input to the method
            string newLocation = _tree.Move("B3");

            // We are asserting that the output should be this
            Assert.Equal(newLocation, "B3");
        }

        [Fact]
        public void Grow()
        {
            // Given this input to the method
            double newOakHeight = _tree.Grow(0.3);

            // We are asserting that the output should be this
            Assert.Equal(newOakHeight, 4.5);

            // Given this input to the method
            newOakHeight = _tree.Grow(0.2);

            // We are asserting that the output should be this
            Assert.Equal(newOakHeight, 4.7);
        }
    }
}
