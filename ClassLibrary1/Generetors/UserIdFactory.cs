namespace ClassLibrary1
{
    public static class UserIdFactory
    {
        private static int id;

        static UserIdFactory()
        {
            
            id++;
        }

        public static int getId()
        {
            return id;
        }
    }
}