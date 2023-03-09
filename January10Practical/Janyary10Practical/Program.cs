namespace January10Practical
{
    public enum Days // : byte type
    { 
        Monday, Tuesday, Wednesday, 
        Thursday, Friday
    }
    class Program
    {
        public static Days MeetingDate
        {
            get; set;
        } = 0; // (Days)1 or Days.Friday
        static void Main()
        {
           
            Console.WriteLine(MeetingDate);


            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Astha Prajapati");

            Days d = (Days)4;// Days d = 0; only for 1st value 
            Console.WriteLine(d +" from 2nd method.");

            Days d1 = Days.Monday;
            Console.WriteLine((int)d1 + " is the index of day of monday.");
            

            Days d2 = Days.Wednesday;
            Console.WriteLine(d2 + "now day of wednesday.");

            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + ":" + (Days)i);

            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);

            

            Console.ReadLine();



        }
    }
}