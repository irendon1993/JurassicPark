using System;
using System.Collections.Generic;
using System.Linq;

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
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

        public string Description()
        {
            //  Dinosour will have:  
            var description = $"{Name}  is a {DietType} dinosaur that Weights {Weight} lbs, their enclosure number is {EnclosureNumber} and was acquired {WhenAcquired} ";

            return description;
        }

    }
    class Program
    {
        static Dinosaur PromptAndFindDinosaur(List<Dinosaur> dinosaursToSearchWithin)
        {
            Console.Write("Name: ");
            var nameOfDinosaurToSearchFor = Console.ReadLine();

            var foundDinosaur = dinosaursToSearchWithin.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaurToSearchFor);

            return foundDinosaur;
        }
        // public DateTime WhenAccquired { get; set; } = DateTime.Now;
        static void Main(string[] args)
        {
            var whenAcquired = DateTime.Now;
            var dinosaurs = new List<Dinosaur>()
            {
              //  Create a dinosour
              new Dinosaur
              {
              Name = "LITTLEFOOT",
              DietType = "HERBIVORE",
              WhenAcquired = whenAcquired,
              Weight = 230,
              EnclosureNumber = 001,
              },

              new Dinosaur
              {
              Name = "CERA",
              DietType = "HERBIVORE",
              WhenAcquired = whenAcquired,
              Weight = 220,
              EnclosureNumber = 001,

              },

            };

            // 
            // Greet visitors 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to our Dino Zoo!");
            Console.WriteLine();
            Console.WriteLine();
            // While the user hasn’t quit the application
            var hasQuitTheApplication = false;

            while (hasQuitTheApplication == false)
            {
                // Show them a menu of options they can do

                Console.WriteLine("Select an option from the Menu below:");
                Console.WriteLine("VIEW - View the dinosaurs we have in the order in which they got here!");
                Console.WriteLine("ADD - Add a new dinosaur to the zoo!");
                Console.WriteLine("REMOVE - Remove a dinosaur from the zoo!");
                Console.WriteLine("TRANSFER - Transfer a dinosaur to a new Enclosure!");
                Console.WriteLine("SUMMARY - Show the number of carnivores and herbivores in the zoo!");
                Console.WriteLine("QUIT - Quit the program!");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "QUIT")
                {
                    hasQuitTheApplication = true;
                }
                if (choice == "ADD")
                {
                    Console.WriteLine("Name: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Diet Type: Carnivore or Herbivore ");
                    var dietType = Console.ReadLine();

                    Console.WriteLine("Weight: ");
                    var weight = Console.ReadLine();
                    var newWeight = int.Parse(weight);

                    Console.WriteLine("Located: ");
                    var enclosureNumber = Console.ReadLine();
                    var newEnclosureNumber = int.Parse(enclosureNumber);

                    Console.WriteLine($"Arrived: { whenAcquired}");

                    var dinosaur = new Dinosaur()

                    {
                        Name = name,
                        DietType = dietType,
                        Weight = newWeight,
                        EnclosureNumber = newEnclosureNumber,
                        WhenAcquired = whenAcquired,
                    };
                    dinosaurs.Add(dinosaur);
                }

                if (choice == "VIEW")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine(dinosaur.Description());
                        Console.WriteLine();
                    }

                }
                if (choice == "TRANSFER")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);

                    if (foundDinosaur != null)
                    {
                        Console.WriteLine(foundDinosaur.Description());

                        Console.Write("Is this the right dinosaur?, YES or NO:");
                        var answer = Console.ReadLine();

                        if (answer == "YES")
                        {
                            Console.Write("New Enclosure Number: ");
                            var newEnclosureNumber = Console.ReadLine();

                            foundDinosaur.EnclosureNumber = int.Parse(newEnclosureNumber);
                        }

                        // /// <c>text</c>


                        // else
                        // {
                        //     return 0;
                        // }


                        // 4. Give User options 
                        // When Console Runs, let user chose between:
                        //    View
                        //     Add
                        //     Remove
                        //     Transfer
                        //     Summary
                        //     Quit


                    }
                    Console.WriteLine("Goodbye");
                }
            }
        }
    }
}
