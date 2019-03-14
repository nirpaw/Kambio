namespace ClassLibrary1
{
    public static class SessionIdFactory
    {
        private static int id = 1;

        static SessionIdFactory()
        {
            id++;
        }

        public static int  getId()
        {
            return id;
        }
    }
}