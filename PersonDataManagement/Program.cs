namespace PersonDataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!\n");

            List<Person> person = new List<Person>();
            PersonDataMang.AddRecords(person);
            //PersonDataMang.DisplayAllRecords(person);
            PersonDataMang.RetreiveTop2Records(person);
        }
    }
}