using abstract_class;
    {
        // Creating an object of the concrete class
        SuperHuman superBan = new SuperHuman(10, "Invisibility");
        superBan.FoodType = "VEGETARIAN";

        superBan.print_no_of_finger();       // Calls base class method
        superBan.DisplayBehaviour();        // Calls overridden method
        superBan.ShowPower();               // Calls derived class method
    }
