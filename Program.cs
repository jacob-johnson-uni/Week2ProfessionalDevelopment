namespace HandshakeProblem
{
    class program
    {
        static void Main()
        {
            Console.Write("Enter the number of people in the group: ");
            string numPeople = Console.ReadLine();
            int people = Convert.ToInt32(numPeople);

            int peopleminus = people - 1;
            int numOfShakes = people * peopleminus / 2;

            Console.WriteLine($"The number of shakes is: {numOfShakes}");
        }
    }
}