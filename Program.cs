using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_5th_Edition___Race_Selector
{
    class Program
    {
        //https://www.dndbeyond.com/races
        //https://dndguide.com/races/
        //http://connorscampaigns.wikidot.com/d-d-proficiencies
        //https://5elanguages.com/
        static void Main(string[] args)
        {
            Introduction();
            Invitation();
            int choice = InvitationValidation();
            RaceSelection(choice);
        }

        // Introduction Methods
        static void Introduction()
        {
            // Introduction of the code
            Console.WriteLine("Welcome to the Race Selector for Dungeons and Dragons 5th edition, created by Guilherme Campos");
            Console.WriteLine("Below you will find a list of the different races that we have on our database and which are also playable");
            Console.WriteLine("Don't forget to check with your Dungeon Master if there are any exceptions before using this code and enjoy your adventure!!");
        }

        static void Invitation()
        {
            // Inviting the user to interact with the program
            Console.WriteLine("Please choose one of the races listed below: ");
            Console.WriteLine("\n\t1-Aaracokra \n\t2-Asimaar \n\t3-Bugbear \n\t4-Dragonborn \n\t5-Dwarf \n\t6-Elf \n\t7-Firbolg \n\t8-Genasi \n\t9-Goblin \n\t10-Goliath \n\t11-Gnome \n\t12-Half-Elf \n\t13-Half-Orc \n\t14-Halfling \n\t15-Hobgoblin \n\t16-Human \n\t17-Kenku \n\t18-Kobold \n\t19-Lizardfolk \n\t20-Orc \n\t21-Tabaxi \n\t22-Tiefling \n\t23-Tortle \n\t24-Triton \n\t25-Warforged \n\t26-Yuan-ti Purebloods \n");
            Console.Write("Your choice is: ");
        }

        static int InvitationValidation()
        {
            //Makes the validation of this part of the code and in case it is not correct it will use "recursion" to go back and call the invitation 
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 26)
            {
                Console.WriteLine("Sorry, but your input was invalid");
                Invitation();
            }
            return choice;
        }

        // Validation and Selection methods
        // I chose this way, so I could reuse them later in my code
        static void RaceSelection(int choice)
        {
            // This code will call the respective race based on the user input, his/her choice
            if (choice == 1)
                CallAaracokra();
            else if (choice == 2)
                CallAasimaar();
            else if (choice == 3)
                CallBugbear();
            else if (choice == 4)
                CallDragonborn();
            else if (choice == 5)
                CallDwarf();
            else if (choice == 6)
                CallElf();
            else if (choice == 7)
                CallFirbolg();
            else if (choice == 8)
                CallGenasi();
            else if (choice == 9)
                CallGnome();
            else if (choice == 10)
                CallGoblin();
            else if (choice == 11)
                CallGoliath();
            else if (choice == 12)
                CallHalfElf();
            else if (choice == 13)
                CallHalfOrc();
            else if (choice == 14)
                CallHalfling();
            else if (choice == 15)
                CallHobgoblin();
            else if (choice == 16)
                CallHuman();
            else if (choice == 17)
                CallKenku();
            else if (choice == 18)
                CallKobold();
            else if (choice == 19)
                CallLizardfolk();
            else if (choice == 20)
                CallOrc();
            else if (choice == 21)
                CallTabaxi();
            else if (choice == 22)
                CallTiefling();
            else if (choice == 23)
                CallTortle();
            else if (choice == 24)
                CallTriton();
            else if (choice == 25)
                CallWarforged();
            else
                CallYuanTi();
        }

        // This specific code I believe to be able to write this way due to its "universality", all the races can be male and female
        // The other codes get a little bit more specific, that's why I cracked it down in a "selection" and a "validation" part
        static int GenderSelection()
        {
            Console.WriteLine("Below you'll see some question that can be answered by you to set your custom information, otherwise, the code will generate random information for you");
            Console.WriteLine("Is the gender important to you on this adventure? Choose one of the options below.");
            Console.WriteLine("1-Yes, I want my character to be male \n2-Yes, I want my character to be female \n3-No, it doesn't matter");
            Console.Write("Your choice is: ");

            int gender_choice;
            while (!int.TryParse(Console.ReadLine(), out gender_choice) || gender_choice < 1 || gender_choice > 3)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            if (gender_choice != 0)
                return gender_choice;
            else
                return 0;
        }

        static int AgeSelection()
        {
            // This code is the selector, the user will select if this information is important for him or not
            Console.WriteLine("Is the age important to you on this adventure? Choose one of the options below.");
            Console.WriteLine("1-Yes, it is and I want to set my age \n2-No, it is not");
            Console.Write("Your choice is: ");
            int age_choice;
            while (!int.TryParse(Console.ReadLine(), out age_choice) || age_choice < 1 || age_choice > 2)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            // this part will return the answer
            return age_choice;
        }

        static int AgeValidation()
        {
            // This is basically the TryParse that will force he user to enter a valid input, restricted by "logical" reasons
            // No one can be younger then 1 year old 
            Console.Write("Your age is: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 1)
            {
                Console.Write("Sorry, but your input was invalid \nYour age is: ");
            }

            return age;
        }

        static int AlignmentTendencySelection()
        {
            // This code is the selector, the user will select if this information is important for him or not
            Console.WriteLine("Do you want to set your character alignment?");
            Console.WriteLine("1-Yes, I want to set my character alignment and tendency \n2-No, you can set a random one for me ");
            Console.Write("Your choice is: ");
            int tendency_choice;
            while (!int.TryParse(Console.ReadLine(), out tendency_choice) || tendency_choice < 1 || tendency_choice > 2)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            // this part will return the answer
            return tendency_choice;
        }

        static int TendencyValidation()
        {
            // This is basically the TryParse that will force he user to enter a valid input, restricted by "logical" reasons
            // the user has to choose the available options (they can be seen in each "CallRace" method, because even though they can choose any of the options 
            // I wanted to customize and make a specific "description" of each race's most common alignment and tendency, which can be totally ignored
            // One race may tend to be Evilish or Goodish, while others may tend to be Neutral, there would be no point in putting this information here, because it is not "universal"
            int tendency;
            Console.Write("Your choice is: ");
            while (!int.TryParse(Console.ReadLine(), out tendency) || tendency < 1 || tendency > 3)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            return tendency;
        }

        static int AlignmentValidation()
        {
            // This is basically the TryParse that will force he user to enter a valid input, restricted by "logical" reasons
            // the user has to choose the available options (they can be seen in each "CallRace" method, because even though they can choose any of the options 
            // I wanted to customize and make a specific "description" of each race's most common alignment and tendency, which can be totally ignored
            // One race may tend to be Evilish or Goodish, while others may tend to be Neutral, there would be no point in putting this information here, because it is not "universal"
            int alignment;
            Console.Write("Your choice is: ");
            while (!int.TryParse(Console.ReadLine(), out alignment) || alignment < 1 || alignment > 3)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            return alignment;
        }

        static int HeightSelection()
        {
            // This code is the selector, the user will select if this information is important for him or not
            Console.WriteLine("Is the height important to you on this adventure? Choose one of the options below.");
            Console.WriteLine("1-Yes, it is and I want to set my height \n2-No, it is not");
            Console.Write("Your choice is: ");
            int height_choice;
            while (!int.TryParse(Console.ReadLine(), out height_choice) || height_choice< 1 || height_choice> 2)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            // this part will return the answer
            return height_choice;
        }

        static double HeightValidation()
        {
            // This is basically the TryParse that will force he user to enter a valid input, restricted by "logical" reasons
            // For logical reasons, nobody can have "0" or negative Kg
            double height;
            Console.Write("Your choice is: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height < 1)
            {
                Console.Write("Sorry, but your input was invalid \nYour age is: ");
            }

            return height;
        }

        static int WeightSelection()
        {
            // This code is the selector, the user will select if this information is important for him or not
            Console.WriteLine("Is the weight important to you on this adventure? Choose one of the options below.");
            Console.WriteLine("1-Yes, it is and I want to set my weight \n2-No, it is not");
            Console.Write("Your choice is: ");
            int weight_choice;
            while (!int.TryParse(Console.ReadLine(), out weight_choice) || weight_choice < 1 || weight_choice > 2)
            {
                Console.Write("Sorry, but your input was invalid \nYour choice is: ");
            }

            // this part will return the answer
            return weight_choice;
        }

        static int WeightValidation()
        {
            // This is basically the TryParse that will force he user to enter a valid input, restricted by "logical" reasons
            // For logical reasons, nobody can have "0" or negative height
            int weight;
            Console.Write("Your weight is: ");
            while (!int.TryParse(Console.ReadLine(), out weight) || weight < 1)
            {
                Console.Write("Sorry, but your input was invalid \nYour weight is: ");
            }

            return weight;
        }

        // Done
        static void CallAaracokra()
        {
            Aaracokra P1 = new Aaracokra();
            // Setting gender
            int gender = GenderSelection();
            P1.Set_Genre(gender);
            SkipLine();

            // Setting age
            int age_choice = AgeSelection();
            // Custom Part
            Console.WriteLine("Aaracokras generally lives up to 30 years old, but you can set whatever value you want.");
            if (age_choice == 1)
                P1.Set_Age(AgeValidation());
            else
                P1.Set_Age(0);
            SkipLine();

            // Setting tendency and alignment
            int tendency_choice = AlignmentTendencySelection();
            // Custom Part
            Console.WriteLine("Aaracokra tends to be Good or Neutral, but you can choose his tendency the way you want \n1-Good \n2-Neutral \n3-Evil");
            if (tendency_choice == 1)
            {
                P1.Set_Tendency(TendencyValidation());
                // Custom Part
                Console.WriteLine("Aaracokra aligns to be Lawful, Neutral or Chaotic \n1-Lawful \n2-Neutral \n3-Chaotic");
                P1.Set_Alignment(AlignmentValidation());
            }
            else
            {
                P1.Set_Tendency(0);
                P1.Set_Alignment(0);
            }
            SkipLine();

            // Setting height
            int height_choice = HeightSelection();
            // Custom Part
            Console.WriteLine("Aaracokra is generally 5 feet tall, but you can set whatever value you want");
            if (height_choice == 1)
                 P1.Set_Height(HeightValidation());
            else
                P1.Set_Height(0);
            SkipLine();

            // Setting weight
            int weight_choice = WeightSelection();
            if (weight_choice == 1)
            {
                int weight;
                if (gender == 1)
                {
                    Console.WriteLine("Male Aaracokra generally weights 75~125 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P1.Set_Weight(weight);
                }

                else
                {
                    Console.WriteLine("Female Aaracokra generally weights 50~100 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P1.Set_Weight(weight);
                }

            }
            else
                P1.Set_Weight(0);

            SkipLine();
            SkipLine();
            P1.DisplayAaracokra();
        }

        // Done
        static void CallAasimaar()
        {
            Aasimar P2 = new Aasimar();
            // Setting gender
            int gender = GenderSelection();
            P2.Set_Genre(gender);
            SkipLine();

            // Setting age
            int age_choice = AgeSelection();
            // Custom Part
            Console.WriteLine("Aasimar generally lives up to 180 years old, but you can set whatever value you want.");
            if (age_choice == 1)
                P2.Set_Age(AgeValidation());
            else
                P2.Set_Age(0);
            SkipLine();

            // Setting tendency and alignment
            int tendency_choice = AlignmentTendencySelection();
            // Custom Part
            
            if (tendency_choice == 1)
            {
                P2.Set_Tendency(TendencyValidation());
                Console.WriteLine("Aasimar tends to be Good. But often outcast aasimars are the neutral or even the evil.\n1-Good \n2-Neutral \n3-Evil");
                P2.Set_Tendency(TendencyValidation());
                // Custom Part
                Console.WriteLine("Aasimar can be Lawful, Neutral or Chaotic \n1-Lawful \n2-Neutral \n3-Chaotic");
                P2.Set_Alignment(AlignmentValidation());
            }
            else
            {
                P2.Set_Tendency(0);
                P2.Set_Alignment(0);
            }
            SkipLine();

            // Setting height
            int height_choice = HeightSelection();
            // Custom Part
            Console.WriteLine("Aasimar is generally 6 feet tall, but you can set whatever value you want");
            if (height_choice == 1)
                P2.Set_Height(HeightValidation());
            else
                P2.Set_Height(0);
            SkipLine();

            // Setting weight
            int weight_choice = WeightSelection();
            if (weight_choice == 1)
            {
                int weight;
                if (gender == 1)
                {
                    Console.WriteLine("Male Aasimar generally weights 124~280 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P2.Set_Weight(weight);
                }

                else
                {
                    Console.WriteLine("Female Aasimar generally weights 89~245 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P2.Set_Weight(weight);
                }

            }
            else
                P2.Set_Weight(0);

            // Setting Sub Race
            // This part is almost totally specific, so I think it's a little bit pointless to create a method just for it 
            Console.WriteLine("Which sub race is your Aasimar? Choose one of the options below.");
            Console.WriteLine("1-Protector \n2-Scourge \n3-Fallen");
            Console.Write("Your choice is: ");
            int subrace_choice;
            while (!int.TryParse(Console.ReadLine(), out subrace_choice) || subrace_choice < 1 || subrace_choice > 3)
            {
                Console.WriteLine("Sorry, but your input was invalid \nYour choice is: ");
            }
            if (subrace_choice == 1)
            {
                P2.Set_SubRace(subrace_choice);
            }
            else if(subrace_choice == 2)
            {
                P2.Set_SubRace(subrace_choice);
            }

            else
            {
                P2.Set_SubRace(subrace_choice);
            }

            SkipLine();
            SkipLine();
            P2.DisplaysAasimar();
        }

        // Done
        static void CallBugbear()
        {
            Bugbear P3 = new Bugbear();
            // Setting gender
            int gender = GenderSelection();
            P3.Set_Genre(gender);
            SkipLine();

            // Setting age
            int age_choice = AgeSelection();
            // Custom Part
            Console.WriteLine("Bugbears generally lives up to 80 years old, but you can set whatever value you want.");
            if (age_choice == 1)
                P3.Set_Age(AgeValidation());
            else
                P3.Set_Age(0);
            SkipLine();

            // Setting tendency and alignment
            int tendency_choice = AlignmentTendencySelection();
            if (tendency_choice == 1)
            {
                // Custom Part
                Console.WriteLine("Bugbears tends to be Neutral or Evil \n1-Neutral \n2-Evil");
                P3.Set_Tendency(TendencyValidation());
                // Custom Part
                Console.WriteLine("Bugbear aligns to be Lawful, Neutral or Chaotic \n1-Lawful \n2-Neutral \n3-Chaotic");
                P3.Set_Alignment(AlignmentValidation());
            }
            else
            {
                P3.Set_Tendency(0);
                P3.Set_Alignment(0);
            }
            SkipLine();

            // Setting height
            int height_choice = HeightSelection();
            // Custom Part
            Console.WriteLine("Bugbear is generally 7 or 8 feet tall, but you can set whatever value you want");
            if (height_choice == 1)
                P3.Set_Height(HeightValidation());
            else
                P3.Set_Height(0);
            SkipLine();

            // Setting weight
            int weight_choice = WeightSelection();
            if (weight_choice == 1)
            {
                int weight;
                if (gender == 1)
                {
                    Console.WriteLine("Male BugBears generally weights 250~300 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P3.Set_Weight(weight);
                }

                else
                {
                    Console.WriteLine("Female BugBears generally weights 250~300 lbs, but you can set whatever value you want");
                    weight = WeightValidation();
                    P3.Set_Weight(weight);
                }

            }
            else
                P3.Set_Weight(0);

            Console.WriteLine();
            Console.WriteLine();
            P3.DisplaysBugbear();
        }

        // Done
        static void CallDragonborn()
        {
            Dragonborn P4 = new Dragonborn();
            // Setting gender
            int gender = GenderSelection();
            P4.Set_Genre(gender);
            SkipLine();

            // Setting age
            int age_choice = AgeSelection();
            // Custom Part
            Console.WriteLine("Dragonborn generally lives up to 80 years old, but you can set whatever value you want.");
            if (age_choice == 1)
                P4.Set_Age(AgeValidation());
            else
                P4.Set_Age(0);
            SkipLine();

            // Setting tendency and alignment
            // Setting tendency and alignment
            int tendency_choice = AlignmentTendencySelection();
            if (tendency_choice == 1)
            {
                // Custom Part
                Console.WriteLine("Dragonborns tend to either Good or Evil. But you can set whatever value you want for your Dragonborn.\n1-Good \n2-Neutral \n3-Evil");
                P4.Set_Tendency(TendencyValidation());
                // Custom Part
                Console.WriteLine("Dragonborns tend to be either Lawful or Chaotic. But you can set whatever values you want for your Dragonborn \n1-Lawful \n2-Neutral \n3-Chaotic");
                P4.Set_Alignment(AlignmentValidation());
            }
            else
            {
                P4.Set_Tendency(0);
                P4.Set_Alignment(0);
            }
            SkipLine();

            // Setting height
            int height_choice = HeightSelection();
            // Custom Part
            Console.WriteLine("Dragonborns can be 7 feet tall, but you can set whatever value you want");
            if (height_choice == 1)
                P4.Set_Height(HeightValidation());
            else
                P4.Set_Height(0);
            SkipLine();


            // Setting weight
            // Setting weight
            int weight_choice = WeightSelection();
            if (weight_choice == 1)
            {
                int weight;
                if (gender == 1)
                {
                    Console.WriteLine("Male Dragonborns weight generally fluctuates between 220 and 320 pounds, but you can set whatever value you want");
                    weight = WeightValidation();
                    P4.Set_Weight(weight);
                }

                else
                {
                    Console.WriteLine("Female Dragonborns weight generally fluctuates between 220 and 320 pounds, but you can set whatever value you want");
                    weight = WeightValidation();
                    P4.Set_Weight(weight);
                }

            }
            else
                P4.Set_Weight(0);

            // Setting Sub Race
            Console.WriteLine("Which Heritage has your Dragonborn? Choose one of the options below.");
            Console.WriteLine("1-Black \n2-Blue \n3-Brass \n4-Bronze \n5-Copper \n6-Gold \n7-Green \n8-Red \n9-White \n10-Silver");
            Console.Write("Your choice is: ");
            int subrace_choice;
            while (!int.TryParse(Console.ReadLine(), out subrace_choice) || subrace_choice < 1 || subrace_choice > 10)
            {
                Console.WriteLine("Sorry, but your input was invalid \nYour choice is: ");
            }
            if (subrace_choice == 1)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 2)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 3)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 4)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 5)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 6)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 7)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 8)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else if (subrace_choice == 9)
            {
                P4.Set_Heritage(subrace_choice);
            }
            else
            {
                P4.Set_Heritage(subrace_choice);
            }

            SkipLine();
            SkipLine();
            P4.DisplaysDragonborn();
        }

        // Under Construction
        static void CallDwarf()
        {

        }

        // Under Construction
        static void CallElf()
        {

        }

        // Under Construction
        static void CallFirbolg()
        {

        }

        // Under Construction
        static void CallGenasi()
        {

        }

        // Under Construction
        static void CallGoblin()
        {

        }

        // Under Construction
        static void CallGoliath()
        {

        }

        // Under Construction
        static void CallGnome()
        {

        }

        // Under Construction
        static void CallHalfElf()
        {

        }
        
        // Under Construction
        static void CallHalfOrc()
        {

        }

        // Under Construction
        static void CallHalfling()
        {

        }

        // Under Construction
        static void CallHobgoblin()
        {

        }

        // Under Construction
        static void CallHuman()
        {

        }

        // Under Construction
        static void CallKenku()
        {

        }

        // Under Construction
        static void CallKobold()
        {

        }

        // Under Construction
        static void CallLizardfolk()
        {

        }

        // Under Construction
        static void CallOrc()
        {

        }

        // Under Construction
        static void CallTabaxi()
        {

        }

        // Under Construction
        static void CallTiefling()
        {

        }

        // Under Construction
        static void CallTortle()
        {

        }

        // Under Construction
        static void CallTriton()
        {

        }

        // Under Construction
        static void CallWarforged()
        {

        }

        // Under Construction
        static void CallYuanTi()
        {

        }

        static void SkipLine()
        {
            Console.WriteLine();
        }

    }

    public class MainLists
    {
        // Languages
        public static string[] standard_languages = { "Common", "Draconic", "Dwarvish", "Elvish", "Giant", "Gnomish", "Goblin", "Halfling", "Infernal", "Orc" };
        public static string[] exotic_languages = { "Aaracokra", "Abyssal", "Aquan", "Auran", "Celestial", "Druidic", "Deep Speech", "Ignan", "Primordial", "Sylvan", "Undercommon", "Terran", "Aasimar" };

        // Genre      
        public static string[] genre = { "Male", "Female" };

        // Alignment and Tendency
        public static string[] alignment = { "Lawful", "Neutral", "Chaotic" };
        public static string[] tendency = { "Good", "Neutral", "Evil" };

        // Diet
        public static string[] diet = { "Carnivore", "Herbivore", "Omnivore" };

        // Basic Proficiencies
        public static string[] proficiency_basic = { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "Endurance", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion ", "Sleight of Hand", "Stealth", "Streetwise", "Survival" };

        // Weapon Proficencies
        public static string[] weapon_proficiency = { "Axes", "Picks", "Blowguns", "Bows", "Brawling", "Clubs", "Staffs", "Crossbows", "Flails", "Hammers", "Maces", "Hooks", "Sickles", "Long Blades", "Natural Weapons", "Pistols", "Polearms", "Rifles", "Short Blades", "Siege Weapons", "Spears", "Thrown", "Slings", "Whips", "Net", "Chains" };

        // Races 
        public static string[] races = { "Aaracokra", "Asimaar", "Bugbear", "Dragonborn", "Dwarf", "Elf", "Firbolg", "Genasi", "Goblin", "Goliath", "Gnome", "Half-Elf", "Half-Orc", "Halfling", "Hobgoblin", "Human", "Kenku", "Kobold", "Lizardfolk", "Orc", "Tabaxi" , "Tiefling", "Tortle", "Triton", "Warforged", "Yuan-ti Purebloods" };
    }

    class Aaracokra
    {
        static Random rand_gen = new Random();
        //*************************************************************************
        //Customizable part

        // Can be whatever Lawful, Neutral or Chaotic
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // Generally Good or Neutral
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 2)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        //Lives up to 30 years old
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 31);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(50, 150);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height = 5.0;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        //*************************************************************************
        //Inert Traits

        private string inert_trait_1 = "+2 Dexterity";
        private string inert_trait_2 = "+1 Wisdom";
        private string inert_proficiency = MainLists.proficiency_basic[12];
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.exotic_languages[0], MainLists.exotic_languages[3] };
        
        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 25; // Feet, Walking
        private int inert_flight_distance = 50; // Feet, Flying
        private string talons = "1d4 - slashing damage";

        string inert_diet = MainLists.diet[0];

        // Special Skills
        string standing_jump = "When you’re in 1st level you can jump (it might be a long jump or High Jump) from your standing position without your first move 10 feet and also you can ignore the half distance penalty.\n\n";
        string fly_spell = "On your self at will, you may cast the fly spell at 5th level. \nYou can also glide. \nYou’ve resistance to damage at the level 3rd there only you have received like a result of falling. \nYou might make a long jump and also high jump as a single action and also double the distance of each which is to execute a glide. \nAny damage can be taken and also immediately ends the glide. \nExecuting a glide may provoke an opportunity attack.\n\n";
        string claustrophobia = "When it is in spaces smaller than the 10ft x 10ft which doesn’t have the exact access to the sky\n\n";
        string plumage = " Plumage incorporated into the body designates the membership hierarchy in the tribe. \nAarakocra male is signified with bright colored feathers draped in red, orange or yellow colors. \nFemales adorn more subtle themed feathers in grey or brown colors.\n\n";
        string beak_talons = "They have narrow legs transforming into sharp talons and claws designed to fight the opponents and adversaries in case of skirmishes.\n\n";
        string speech_behavior = "Speech behavior of the humanoid includes chirping sounds conveying different meanings to the friends and opponents. \nIt is similar what the humans often do with the facial expressions and hand gestures. \nAarakocra loses its cool when it finds people who do not understand its behavior. \nOne should take the threat of humanoid as a jest but sometimes the innocuous chirping also entails sudden attack.\n\n";

        public Aaracokra()
        {

        }

        public void DisplayAaracokra()
        {
            // Main Description
            Console.WriteLine("Race = Aaracokra \nAaracokra Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());

            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nInert Trait 2 = {1} \nProficiencies = {2}\n", inert_trait_1, inert_trait_2, inert_proficiency);
            Console.Write("Languages= ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feets and Weight = {1} lbs",Get_Height() , Get_Weight());
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets \nFlying distance = {1} feets\n", inert_walk_distance, inert_flight_distance);
            Console.WriteLine("Special Skills: \nTalons Damage = {0} \nStanding Jump = {1} \nFly Spell = {2} \nClaustrophobia = {3}", talons, standing_jump, fly_spell, claustrophobia);
            Console.WriteLine("Plumage = {0} \nBeak and Talons = {1} \nSpeech Behavior = {2}\n ", plumage, beak_talons, speech_behavior);
        }

    }

    class Aasimar
    {
        static Random rand_gen = new Random();

        // Lawful, Neutral or Chaotic
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // Good, Neutral or Evil, most of them are good but outcast ones can be neutral or evil
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 3)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        // Lives up to 160 years old 
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 161);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(89, 281);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height = 6.7;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        string subrace_explanation;
        string subrace_bonus_trait;
        string subrace_bonus_ability;
        string subrace_bonus_transformation;
        public void Set_SubRace(int input)
        {
            if (input == 1) // Protector
            {
                subrace_explanation = "The protector aasimars are charged by the powers of good to guard the weak like to strike at evil wherever it arises and also to stand the vigilant against any kind of the darkness.\nA protector aasimar receives advices and also directives at the very young age and the directives and advices are like urge to stand against the evil\n";
                subrace_bonus_trait = "+1 Wisdom\n";
                subrace_bonus_ability = "Radiant Soul: To unleash the devine energy with in yourself, you can use your action from the starting of 3rd level and to sprout from your back wings. \n It causes your eyes to glimmer and two luminous and incorporeal wings. \n";
                subrace_bonus_transformation = "In this protector aasimar your transformation lasts either for 1 minute or until you end it as a bonus action \n. During this protector aasimar your flying speed is 30 ft. \nYou can deal extra radiant damage for one target whenever you deal damage to it with the attack or a spell but it happens once for each and every of your turns. \nFinally the extra damage will be equal to your level. \nYou will not allowed to use this again once you have finished this trait usage but you need to finish a long rest to use it again. \n";
            }

            else if (input == 2)
            {
                subrace_explanation = "Scourge aasimars are imbued with the divine energy which blazes intensely within them only. \nOf course it feeds the powerful desire to destroy the evil-a desire that is, at its best, unflinching and also at it’s worst and ofcourse all consuming. \nMany of the scourge aasimar wear the masks to block out the world and also focusing to containing this power and they unmasking themselves in the battle only. \n";
                subrace_bonus_trait = "+1 Constitution\n";
                subrace_bonus_ability = "Radiant Consumption: To unleash the devine energy with in yourself. \nYou can use your action from the starting of 3rd level it causes searing light to radiate from you and also pour out of your mouth (Including teeth) and your eyes and threaten to char you.\n";
                subrace_bonus_transformation = "Your transformation lasts either for 1 minute or up to you end it as a bonus action.\nAt the ending time of your each and evey turn you and each creature which is with in 10 ft of you would take same radiant damage which is equal to the half your level(rounded up). \nBut during it you shed a bright light within a 10ft radius and also the dim light for an additional 10ft. \nYou can deal extra radiant damage for one target whenever you deal damage to it with the attack or a spell but it happens once for each and every of your turns. \nFinally the extra damage will be equal to your level. \nYou will not allowed to use this again once you have finished this trait usage but you need to finish a long rest to use it again.\n";
            }

            else
            {
                subrace_explanation = "An Aasimar can become one of the fallen a group of aasimar when an aasimar who was touched by the dark powers like a youth or else who turned to the evil in an early adulthood will might be the fallen aasimar and whose inner light has been replaced by the shadow.\n";
                subrace_bonus_trait = "+1 Strength\n";
                subrace_bonus_ability = "Necrotic Shroud: To unleash the devine energy with in yourself, you can use your action from the starting of 3rd level. \nIt causes your eyes to turn them into pool and from your back the two skeletal, ghostly, flightless wings to sprout. \nThe instant which you transform and other creatures which are in the distance of 10ft from your exact location that can see on a charishma saving through (DC 8 + your proficiency bonus + your Charisma modifier) you must each succeed or it might  become frightened of you until the end of your next turn.\n";
                subrace_bonus_transformation = "Your transformation lasts either for 1 minute or up to you end it as a bonus action. \nDuring it, once on each of your turns, you can deal bonus necrotic damage to one target but when you deal any damage to it with a spell or an attack and necrotic damage equals your level whatever you have extra.\n";
            }
        }

        public string Get_Subrace (int input)
        {
            string[] arr = { subrace_explanation, subrace_bonus_trait, subrace_bonus_ability, subrace_bonus_transformation };
            return arr[input];
        }

        //*************************************************************************
        // Inert Traits

        private string inert_trait = "+2 Charisma";
        private string inert_proficiency = MainLists.proficiency_basic[12];
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.exotic_languages[12]};
        
        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 30; // Feet, Walking
        string inert_diet = MainLists.diet[2];

        // Special Skills
        string dark_vision = "You have the superior vision even in the dark and dim conditions too, you have to thanks to your holy heritage. \nYou can able to see in the dim light within the 60 feet of you like if it was the bright light and in the darkness like if it was dim light. \nYou can’t discern the color in the darkness and only shades of the gray.\n\n";
        string celestial_heritage = "Celestials can be ideal warriors because they are resistant to necrotic damage and also radiant damages.\n\n";
        string healing_hands = "You can touch the creature and also cause it to regain the number of hit points which are equal to your level and it is as an action. \nOnce you use this trait then you don’t have another chance to use this trait again until you finish the long rest.\n\n";
        string light_bearer = "Charisma is your spell casting ability for it and you knew the light cantrip.\n\n";
        string inert_magics = "Cast Light";
        string damage_resistance = "Acid Damage\n\n";

        string behavior = "Aasimar creature is quite vigilant about the surroundings however they are misunderstood like Tiefling. \nPeople hate the characters however they are not despised like the ones belonging to the fiendish blood lines. \nSome of the creatures brought up by the understanding patients suffer from numerous prejudices due to the unique nature.\nThe creature is also known for a deep empathy with others.\n\n";

        public Aasimar()
        {

        }

        public void DisplaysAasimar()
        {
            // Main Description
            Console.WriteLine("Race Aasimar \nAasimar Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());
            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nSubrace Trait = {1} \nSubrace Explanation = {2} \nSubrace Ability = {3} \nSubrace Transformation = {4} \nProficiencies = {5}\n", inert_trait, Get_Subrace(1), Get_Subrace(0), Get_Subrace(2), Get_Subrace(3), inert_proficiency);
            Console.Write("Languages= ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feets and Weight = {1} lbs", inert_weight, height);
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets \n", inert_walk_distance);
            Console.WriteLine("Special Skills: \nDark Vision = {0} \nCelestial Heritage = {1} \nHealing Hands = {2} \nLight Bearer = {3} \nInert Magics= {4} \nDamage Resistance = {5}", dark_vision, celestial_heritage, healing_hands, light_bearer, inert_magics, damage_resistance);
            Console.WriteLine("Behavior = {0}", behavior);
        }
    }

    class Bugbear
    {

        static Random rand_gen = new Random();

        // Lawful, Neutral or Chaotic
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // Good, Neutral or Evil
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 3)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        // Lives up to 80 years old
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 81);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(250, 301);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height = 6.7;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        //*************************************************************************
        // Inert Traits

        private string inert_trait_1 = "+2 Strength";
        private string inert_trait_2 = "+1 Dexterity";
        private string inert_proficiency = MainLists.proficiency_basic[17];
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.standard_languages[6] };

        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 30; // Feet, Walking
        string inert_diet = MainLists.diet[2];

        // Special Skills
        string dark_vision = "With in 60 feet of you, you can see dim light as if it was bright light and in the darkness as like it was dim light. \nYou can able to see in the dim light within the 60 feet of you like if it was the bright light and in the darkness like if it was dim light. \nYou can’t discern the color in the darkness and only shades of the gray.\n\n";
        string long_limbed = "Whenever you make a melee attack on your turn there your reach for it is 5 feet greater than the normal.\n\n";
        string powerful_build = "You can count as one size larger when it is determining your carrying the capacity and also the weight which you can push, drag or lift.\n\n";
        string surprise_attack = "If you surprise any creature and hit it with an attack on your first turn in the combat and the attack on your first turn in the combat and also the attack deals an extra 2d6 damage to it. Simply you can use this trait only once for the combat.\n\n";

        string behavior = "Bugbear is a very short tempered creature and can easily fly into rages. \nThey are prone to fight at the slightest of provocations however certain bugbears are adamant to overcome the issue due to the rewards earned from the virtue.\n\n";

        public Bugbear()
        {

        }

        public void DisplaysBugbear()
        {
            // Main Description
            Console.WriteLine("Race Bugbear \nBugbear Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());
            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nInert Trait 2 = {1} \nProficiencies = {5}\n", inert_trait_1, inert_trait_2, inert_proficiency);
            Console.Write("Languages= ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feet and Weight = {1} lbs", inert_weight, height);
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets\n", inert_walk_distance);
            Console.WriteLine("Special Skills: \nDark Vision = {0} \nLong Limbed = {1} \nPowerful Build = {2} \nSurprise Attack = {3} ", dark_vision, long_limbed, powerful_build, surprise_attack);
            Console.WriteLine("Behavior = {0}", behavior);
        }
    }

    class Dragonborn
    {
        static Random rand_gen = new Random();

        // Lawful, Neutral or Chaotic Dragonborns tend to be Either all the way Lawful or Chaotic
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // Good, Neutral or Evil, Dragonborns tend to be either all the way good or evil
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 3)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        // Lives up to 80 years 
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 81);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(220, 321);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height = 6.7;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        string heritage_explanation;
        string heritage_breath_weapon;
        string heritage_resistance;

        public void Set_Heritage(int input)
        {
            if (input == 1) // Protector
            {
                heritage_explanation = "Black";
                heritage_breath_weapon = "Acid 5 by 30 ft. line (Dex. save)";
                heritage_resistance = "Acid";
            }

            else if (input == 2)
            {
                heritage_explanation = "Blue";
                heritage_breath_weapon = "Lightning	5 by 30 ft. line (Dex. save)";
                heritage_resistance = "Lightning";
            }

            else if (input == 3)
            {
                heritage_explanation = "Brass";
                heritage_breath_weapon = "Fire 5 by 30 ft. line (Dex. save)";
                heritage_resistance = "Fire";
            }


            else if (input == 4)
            {
                heritage_explanation = "Bronze";
                heritage_breath_weapon = "Lightning	5 by 30 ft. line (Dex. save)";
                heritage_resistance = "Lighting";
            }

            else if (input == 5)
            {
                heritage_explanation = "Copper";
                heritage_breath_weapon = "Acid 5 by 30 ft. line (Dex. save)";
                heritage_resistance = "Acid";
            }

            else if (input == 6)
            {
                heritage_explanation = "Gold";
                heritage_breath_weapon = "Fire 15 ft. cone (Dex. save)";
                heritage_resistance = "Fire";
            }

            else if (input == 7)
            {
                heritage_explanation = "Green";	
                heritage_breath_weapon = "Poison 15 ft. cone (Con. save)";
                heritage_resistance = "Poison";
            }

            else if (input == 8)
            {
                heritage_explanation = "Red";
                heritage_breath_weapon = "Fire 15 ft. cone (Dex. save)";
                heritage_resistance = "Fire";
            }

            else if (input == 9)
            {
                heritage_explanation = "White";
                heritage_breath_weapon = "Cold	15 ft. cone (Con. save)";
                heritage_resistance = "Cold";
            }

            else
            {
                heritage_explanation = "Silver";
                heritage_breath_weapon = "Cold	15 ft. cone (Con. save)";
                heritage_resistance = "Cold";

            }
        }

        public string Get_Heritage(int input)
        {
            string[] arr = { heritage_explanation, heritage_breath_weapon, heritage_resistance};
            return arr[input];
        }

        //*************************************************************************
        // Inert Traits

        private string inert_trait_1 = "+2 Strength";
        private string inert_trait_2 = "+1 Charisma";
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.standard_languages[1] };

        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 30; // Feet, Walking
        string inert_diet = MainLists.diet[2];

        
        public Dragonborn()
        {

        }

        public void DisplaysDragonborn()
        {
            // Main Description
            Console.WriteLine("Race Dragonborn \nDragonborn Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());
            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nInert Trait 2 = {1} \nHeritage Explanation = {2} \nBreath Weapon = {3} \nHeritage Resistance = {4} \n", inert_trait_1, inert_trait_2, Get_Heritage(0), Get_Heritage(1), Get_Heritage(2));
            Console.Write("Languages= ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feet and Weight = {1} lbs", inert_weight, height);
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets\n", inert_walk_distance);
        }
    }

    class Dwarf
    {
        static Random rand_gen = new Random();

        // Dwarves are not reckless creatures but believe in an ordered society. They are of the view that people should live in harmony and everybody has the right to a just living.
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // Good, Neutral or Evil
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 3)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        // Lives up to 350 years old 
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 351);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        // Average weight 150 lbs
        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(100, 201);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        // Average height of 4/5 feet tall
        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height =4.7;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        string subrace_explanation;
        string subrace_bonus_trait;
        string subrace_bonus_ability;

        public void Set_SubRace(int input)
        {
            if (input == 1) // Hill Dwarf
            {
                subrace_explanation = "Hill Dwarfs reside in the inner echelons of the hill side and are marked by impeccable resilience.\n";
                subrace_bonus_trait = "+1 Wisdom\n";
                subrace_bonus_ability = "The hit point increases by a single value while also shows upward trend with increase in the level\n";
            }

            else // Mountain Dwarf
            {
                subrace_explanation = "The dwarf is the doyen of rugged terrain and can survive in tough conditions without any problem. \nIndividual would be taller with a lighter complexion and high energy levels. \n";
                subrace_bonus_trait = "+2 Strength\n";
                subrace_bonus_ability = "Individual is a master in dealing with Light and medium armor\n";
            }
        }

        public string Get_Subrace(int input)
        {
            string[] arr = { subrace_explanation, subrace_bonus_trait, subrace_bonus_ability};
            return arr[input];
        }

        //*************************************************************************
        // Inert Traits

        private string inert_trait = "+2 Constitution";
        private string inert_proficiency = MainLists.proficiency_basic[6];
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.standard_languages[2] };
        private string[] weapon_proficiency = { MainLists.weapon_proficiency[0], MainLists.weapon_proficiency[8] };

        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 25; // Feet, Walking, doesn't change even if wearing heavy armor
        string inert_diet = MainLists.diet[0];

        // Special Skills
        string dark_vision = "Since the dwarves live an underground life, they have an impeccable vision that can see through the dark. \nOne of the most important attributes of the dwarves is that they can recognize dim light from a distance of about 60 feet. \nDistinguishing color in the darkness is a cake walk for the sturdy character. \n\n";
        string damage_resistance = "As a character, you are resistant to poison damages and can also save throws against poison.\n\n";

        string behavior = "D&d 5e dwarf lives for a very long time with the maximum age increasing to 400 years. \nIn fact, the oldest ones belong to a very different era as they have very interesting stories to tell to the younger generations. \nFor instance, the oldest ones can recount that how three centuries ago orcs occupied the fort and send all the dwarves into exile for about 250 years. \nLongevity helps them to create a new perspective about the world and the events; therefore they are far more experienced than the human race. \nThe personality of dwarves resembles a stoic and giant mountain where they spend majority of their lives. \nDue to high endurance, they face difficulties with a significant degree of chivalry. \nDwarf 5e soldiers are very loyal to the clans as they cherish their ancient history and roots of the bravery. \nIndividual dwarves are very loyal to their clans and are known for the commitments however sometimes they become too stubborn.\n\n";

        public Dwarf()
        {

        }

        public void DisplaysDwarf()
        {
            // Main Description
            Console.WriteLine("Race Dwarf \nDwarf Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());
            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nSubrace Trait = {1} \nSubrace Explanation = {2} \nSubrace Ability = {3} \nSubrace Skills = {4} \nProficiencies = {5}\n", inert_trait, Get_Subrace(1), Get_Subrace(0), Get_Subrace(2), Get_Subrace(3), inert_proficiency);
            Console.Write("Weapon Proficiency = ");
            for (int i = 0; i < weapon_proficiency.Length; i++)
            {
                Console.Write("{0} ",weapon_proficiency[i]);
            }
            Console.Write("Languages = ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feets and Weight = {1} lbs", inert_weight, height);
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets \n", inert_walk_distance);
            Console.WriteLine("Special Skills: \nDark Vision = {0} \nDamage Resistance = {1}", dark_vision, damage_resistance);
            Console.WriteLine("Behavior = {0}", behavior);
        }
    }

    class Elf
    {
        static Random rand_gen = new Random();

        // 
        private string inert_alignment;
        public void Set_Alignment(int input)
        {
            if (input == 1)
                inert_alignment = MainLists.alignment[0];
            else if (input == 2)
                inert_alignment = MainLists.alignment[1];
            else if (input == 3)
                inert_alignment = MainLists.alignment[2];
            else
                inert_alignment = MainLists.alignment[rand_gen.Next(0, 3)];
        }

        private string Get_Alignment()
        {
            return inert_alignment;
        }

        // 
        private string inert_tendency;
        public void Set_Tendency(int input)
        {
            if (input == 1)
                inert_tendency = MainLists.tendency[0];
            else if (input == 2)
                inert_tendency = MainLists.tendency[1];
            else if (input == 3)
                inert_tendency = MainLists.tendency[2];
            else
                inert_tendency = MainLists.tendency[rand_gen.Next(0, 3)];
        }

        private string Get_Tendency()
        {
            return inert_tendency;
        }

        // Male or Female
        private string inert_genre;
        public void Set_Genre(int input)
        {
            if (input == 1)
                inert_genre = MainLists.genre[0];
            else if (input == 2)
                inert_genre = MainLists.genre[1];
            else
                inert_genre = MainLists.genre[rand_gen.Next(0, 2)];
        }

        private string Get_Genre()
        {
            return inert_genre;
        }

        // Lives up to 900 years old 
        int inert_age;
        public void Set_Age(int input)
        {
            if (input == 0)
                inert_age = rand_gen.Next(0, 901);
            else
                inert_age = input;
        }

        private int Get_Age()
        {
            return inert_age;
        }

        // Average weight 150 lbs
        private int inert_weight;
        public void Set_Weight(int input)
        {
            if (input == 0)
                inert_weight = rand_gen.Next(130, 171);
            else
                inert_weight = input;
        }

        private int Get_Weight()
        {
            return inert_weight;
        }

        // Average height of 5/6 feet tall
        private double height;
        public void Set_Height(double input)
        {
            if (input == 0)
                height = 5.4;
            else
                height = input;
        }

        private double Get_Height()
        {
            return height;
        }

        string subrace_explanation;
        string subrace_bonus_trait;
        string subrace_bonus_ability;

        public void Set_SubRace(int input)
        {
            if (input == 1) // Hill Dwarf
            {
                subrace_explanation = "Hill Dwarfs reside in the inner echelons of the hill side and are marked by impeccable resilience.\n";
                subrace_bonus_trait = "+1 Wisdom\n";
                subrace_bonus_ability = "The hit point increases by a single value while also shows upward trend with increase in the level\n";
            }

            else // Mountain Dwarf
            {
                subrace_explanation = "The dwarf is the doyen of rugged terrain and can survive in tough conditions without any problem. \nIndividual would be taller with a lighter complexion and high energy levels. \n";
                subrace_bonus_trait = "+2 Strength\n";
                subrace_bonus_ability = "Individual is a master in dealing with Light and medium armor\n";
            }
        }

        public string Get_Subrace(int input)
        {
            string[] arr = { subrace_explanation, subrace_bonus_trait, subrace_bonus_ability };
            return arr[input];
        }

        string custom_trait;
        public void Set_CustomTrait(string input)
        {
                custom_trait = input;
        }

        private string Get_CustomTrait()
        {
            return custom_trait;
        }

        string custom_language;
        public void Set_CustomLanguage(string input)
        {
            custom_trait = input;
        }

        private string Get_CustomLanguage()
        {
            return custom_language;
        }

        //*************************************************************************
        // Inert Traits

        private string inert_trait = "+2 Dexterity";
        private string inert_proficiency = MainLists.proficiency_basic[12];
        private string[] inert_languages = { MainLists.standard_languages[0], MainLists.standard_languages[3], custom_language };
        private string[] weapon_proficiency = { MainLists.weapon_proficiency[0], MainLists.weapon_proficiency[8] };

        private string body_type = "Medium";
        string body_shape = "Humanoid";
        private int inert_walk_distance = 30; // Feet, Walking, doesn't change even if wearing heavy armor
        string inert_diet = MainLists.diet[0];

        // Special Skills
        string dark_vision = "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. \nYou can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. \nYou can’t discern color in darkness, only shades of gray\n\n";
        string damage_resistance = "As a character, you are resistant to poison damages and can also save throws against poison.\n\n";
        string fey_ancestry = "You have advantage on saving throws against being charmed, and magic can’t put you to sleep.";
        string trance = "Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) \nWhile meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. \nAfter resting in this way, you gain the same benefit that a human does from 8 hours of sleep.\n";

        string behavior = "D&d 5e dwarf lives for a very long time with the maximum age increasing to 400 years. \nIn fact, the oldest ones belong to a very different era as they have very interesting stories to tell to the younger generations. \nFor instance, the oldest ones can recount that how three centuries ago orcs occupied the fort and send all the dwarves into exile for about 250 years. \nLongevity helps them to create a new perspective about the world and the events; therefore they are far more experienced than the human race. \nThe personality of dwarves resembles a stoic and giant mountain where they spend majority of their lives. \nDue to high endurance, they face difficulties with a significant degree of chivalry. \nDwarf 5e soldiers are very loyal to the clans as they cherish their ancient history and roots of the bravery. \nIndividual dwarves are very loyal to their clans and are known for the commitments however sometimes they become too stubborn.\n\n";

        public Elf()
        {

        }

        public void DisplaysDwarf()
        {
            // Main Description
            Console.WriteLine("Race Dwarf \nDwarf Traits\n");
            Console.WriteLine("Alignment = {0} {1}", Get_Alignment(), Get_Tendency());
            Console.WriteLine("Genre = {0}", Get_Genre());
            Console.WriteLine("Age = {0} years old", Get_Age());
            Console.WriteLine("Natural Abilities: \n\nInert Trait 1 = {0} \nChoosen Trait = {1} \nSubrace Explanation = {2} \nSubrace Ability = {3} \nSubrace Skills = {4} \nProficiencies = {5}\n", inert_trait, Get_CustomTrait(), inert_proficiency);
            Console.Write("Weapon Proficiency = ");
            for (int i = 0; i < weapon_proficiency.Length; i++)
            {
                Console.Write("{0} ", weapon_proficiency[i]);
            }
            Console.Write("Languages = ");
            for (int i = 0; i < inert_languages.Length; i++)
            {
                Console.Write("{0} ", inert_languages[i]);
            }

            Console.WriteLine("\n{0} {1}", body_type, body_shape);
            Console.WriteLine("Height = {0} feets and Weight = {1} lbs", inert_weight, height);
            Console.WriteLine("Diet = {0}", inert_diet);
            Console.WriteLine("Walking distance = {0} feets \n", inert_walk_distance);
            Console.WriteLine("Special Skills: \nDark Vision = {0} \nDamage Resistance = {1}", dark_vision, damage_resistance);
            Console.WriteLine("Behavior = {0}", behavior);
        }
    }


}
