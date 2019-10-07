namespace ChainResponsibility.Classes
{
    abstract class Logger
    {
        int priority;
        Logger next;
        internal Logger Next { get => next; set => next = value; }

        protected Logger(int priority)
        {
            this.priority = priority;
        }

        public void WriteMessage(string message, int level)
        {
            if (level <= priority)
            {
                Write(message);
            }
            if (Next != null)
            {
                Next.WriteMessage(message, level);
            }
        }

        protected abstract void Write(string message);
    }
}