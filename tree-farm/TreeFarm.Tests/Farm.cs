using System;

namespace TreeFarm
{
    internal class Farm
    {
        public List<Tree> TreeList = new List<Tree>();
        public void AddTree(Tree tree)
        {
            TreeList.add(tree);
        }

        public void RemoveTree(Tree tree)
        {
            TreeList.add(tree);
        }
    }
}