using System;

namespace NewCRM.View
{
    public class Validate
    {
        private static Validate _Instance;
        public static Validate Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Validate();
                }
                return _Instance;
            }
            private set { }
        }
        public int ValidateID(string id)
        {
            if (int.TryParse(id, out int parseId))
            {
                return parseId;
            }
            else
            {
                Console.WriteLine("Invalid ID!");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            return -1;
        }
    }
}
