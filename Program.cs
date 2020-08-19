using System;
using System.Collections.Generic;
namespace JurassicPark
{
    //  PROBLEM) Create a Park for dinosours  
    //      
    // DATA
    // 
    // // public DateTime WhenAccquired {get; set;} = DateTime.Now;
    // System.Threading.Thread.Sleep(3000);
    // Console.WriteLine("PLease Enter the name of your ");

    // var dino2 = new Dinosour()
    // {

    // }
    // 
    // 
    // 
    // 
    //     
    //ALGORITHM 

    class Dinosaur
    {

        public string Name { get; set; }
        public string DietType { get; set; }
        // public DateTime TimeAcquired { get; set}
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

        public string Description()
        {
            //  Dinosour will have:  
            var description = "${Name}  is a {DietType} dinosaur that Weights {Weight} lbs and their enclosure number is {EnclosureNumber} ");

            return description;
        }

    }
    class Program
    {
        //public DateTime WhenAccquired {get; set;} = DateTime.Now;
        //
        // 


        static void Main(string[] args)
        {
            // 
            // Greet visitors 
            Console.WriteLine("Welcome to Jurassic Park");
            // Add dinosours to a list
            var dinosaurs = new List<Dinosaur>()
            {
              //  Create a dinosour
              new Dinosaur
              {
              Name = "LITTLEFOOT",
              DietType = "vegetarian", 
              // WhenAccquired = time(),
              Weight = 230,
              EnclosureNumber = 001,
              },

              new Dinosaur
              {
              Name = "CERA",
              DietType = "vegetarian", 
              // WhenAccquired = time(),
              Weight = 220,
              EnclosureNumber = 001,

              },

            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to our Dino Zoo!");
            Console.WriteLine();
            Console.WriteLine();
            // While the user hasn’t quit the application
            var hasQuitTheApplication = false;
            while (hasQuitTheApplication == false)
            { // Show them a menu of options they can do

                Console.WriteLine("Select an option from the Menu below:");

                {
                    Console.WriteLine("VIEW - View the dinosaurs we have in the order in which they got here!");
                }

                Console.WriteLine("ADD - Add a new dinosaur to the zoo!");
                Console.WriteLine("REMOVE - Remove a dinosaur from the zoo!");
                Console.WriteLine("TRANSFER - Transfer a dinosaur to a new Enclosure!");
                Console.WriteLine("SUMMARY - Show the number of carnivores and herbivores in the zoo!");
                Console.WriteLine("QUIT - Quit the program!");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "VIEW")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine(dinosaur.Description());
                    }
                    Console.Write(N)
                }




                else (choice == “QUIT”)
                {
                    hasQuitTheApplication = true;
                }
                Console.WriteLine(” GOODBYE “);
            }



            // 4. Give User options 
            // When Console Runs, let user chose between:
            //    View
            //     Add
            //     Remove
            //     Transfer
            //     Summary
            //     Quit


        }


    }
}
