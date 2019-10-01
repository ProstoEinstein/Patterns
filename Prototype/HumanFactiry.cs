namespace Prototype
{
    sealed class HumanFactiry
    {
        Human human;

        public HumanFactiry(Human human)
        {
            this.human = human;
        }

        public void SetPrototype(Human human)
        {
            this.human = human;
        }

        public Human MakeCopy()
        {
            return (Human)human.Copy();
        }
    }
}