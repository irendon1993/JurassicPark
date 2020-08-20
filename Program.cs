using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    //  PROBLEM) Create a Park for dinosours  
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
        static void Main(string[] args)
        {
            var whenAcquired = DateTime.Now;
            var dinosaurs = new List<Dinosaur>()
            {
              //  Create a dinosour
              new Dinosaur
              {
              Name = "Littlefoot",
              DietType = "Herbivore",
              WhenAcquired = whenAcquired,
              Weight = 230,
              EnclosureNumber = 001,
              },

              new Dinosaur
              {
              Name = "Sharptooth",
              DietType = "Carnivore",
              WhenAcquired = whenAcquired,
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

                if (choice == "VIEW")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine(dinosaur.Description());
                        Console.WriteLine();
                    }
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

                if (choice == "REMOVE")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);

                    if (foundDinosaur != null)
                    {
                        dinosaurs.Remove(foundDinosaur);
                        Console.WriteLine(foundDinosaur.Description());

                        Console.Write("Are you sure? YES or NO: ");
                        var answer = Console.ReadLine();

                        if (answer == "YES")
                        {
                            dinosaurs.Remove(foundDinosaur);
                        }

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

                        else
                        {
                            Console.WriteLine("There is no Dinosaur with that name");
                        }
                    }
                }
                if (choice == "SUMMARY")
                {

                    int HerbivoreCount = dinosaurs.Count(dinosaur => dinosaur.DietType == ("Herbivore"));
                    int CarnivoreCount = dinosaurs.Count(dinosaur => dinosaur.DietType == ("Carnivore"));

                    Console.WriteLine($"There are {HerbivoreCount} herbivores and {CarnivoreCount} carnivores in the park");
                }
                Console.WriteLine("Goodbye");
            }
        }
    }
}

