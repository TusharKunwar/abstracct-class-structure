using sealed_class;

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the sealed class
        SuperHuman superBan = new SuperHuman(10, "Invisibility");
        superBan.FoodType = "VEGETARIAN";

        // Calling methods
        superBan.print_no_of_finger();
        superBan.DisplayBehaviour();
        superBan.ShowPower();
    }
}
