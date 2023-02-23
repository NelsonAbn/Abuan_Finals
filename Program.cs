using System;
using System.Collections.Generic;

namespace Abuan_Finals
{
    internal class Program
    {
        static List<string> registeredLicensed = new List<string> () ; 
        
		 static List<string> DataView = new List<string> ();
		
        static void Main(string[] args)
        {
            Console.WriteLine("------ LTMS PORTAL -------");
			
            ShowMainMenu(); //method 

            string userInput = GetUserInput();
				
			

            while (userInput != "x" && userInput != "X") //looping
            {
                switch (userInput) //conditional 
                {
                    case "1":
                        RegisterLicense();
						IdentifyLicense();
                        ShowMainMenu();
                        userInput = GetUserInput();
						
                        break;
                    case "2":
                        Console.WriteLine("\n_________LOGIN FORM__________");
                        Console.Write(">> Enter DL number to login: ");
                        var license = Console.ReadLine();

                        if (IsLicenseExists(license))
                        {
                            Console.WriteLine("\n!!! WELCOME TO THE SYSTEM!\n\n");
                            userInput = "x";
                            
                        }
                        else
                        {
                            Console.WriteLine("\n!!! License not found please try again!\n\n");

                            ShowMainMenu();

                            userInput = GetUserInput();
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n_________REMOVE ACCOUNT__________");
                        Console.Write(">> Enter DL number to be removed: ");
                        var licenseRemove = Console.ReadLine();

                        if (IsLicenseExists(licenseRemove))
                        {
                            registeredLicensed.Remove(licenseRemove);
                            Console.WriteLine("\n!!! Successfully removed the DL number!\n\n");

                            ShowMainMenu();

                            userInput = GetUserInput();
                        }
                        else
                        {
                            Console.WriteLine("\n!!!  DL number not found please try again!\n\n");

                            ShowMainMenu();

                            userInput = GetUserInput();
                        }
                        break;			
					case "4":	
					Console.WriteLine("\n_________VIEW DATA ______");
					ShowData();
					ShowMainMenu();
                    userInput = GetUserInput();
                    break;
					
					case "5":
						ShowInfo();
						ShowMainMenu();
						userInput = GetUserInput();
					break;	
					
                    default:
                        break;
                }
            }
        }

        static void ShowMainMenu() 
        {
            Console.WriteLine("_______MAIN MENU________");
            Console.WriteLine("Enter 1 to Register (if new user)");
            Console.WriteLine("Enter 2 to Login (if already a user)");
            Console.WriteLine("Enter 3 to Remove your account (if already a user)");
			Console.WriteLine("Enter 4 to The data ");
			Console.WriteLine("Enter 5 Info About Licenses ");
            Console.WriteLine("Enter x to exit application");
            Console.WriteLine("________________________");
        }

        static string GetUserInput() 
        {
            Console.Write(">> user input: ");
            string input = Console.ReadLine();

            
            return input;
        }

        static bool IsLicenseExists(string licenseNumber) 
        {
            int found = registeredLicensed.IndexOf(licenseNumber);

            if (found == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void RegisterLicense()
        {
            Console.WriteLine("\n_________REGISTRATION FORM__________");
            Console.Write(">> Enter DL number to register: ");
            registeredLicensed.Add(Console.ReadLine());
            Console.WriteLine("\n!!! successfully registered DL number!\n\n");
        }
		
		
		
		 static void IdentifyLicense()
        {
            Console.WriteLine("\n_________TYPE OF YOUR LICENSE ______");
			Console.WriteLine("Non Prof or Professional??");
            DataView.Add(Console.ReadLine());
            Console.WriteLine("\n!!! Successfully identify your license!\n\n");
        }
		
		
		 static void ShowData()
        {
            Console.WriteLine("----DATA---");

            Console.WriteLine(">>>Drivers License NUMBER");
            foreach (var license in registeredLicensed)
            {
                Console.WriteLine("DL no." + " " + license);
            }

            Console.WriteLine(">>>TYPE OF DL");
            foreach (var data in DataView)
            {
                Console.WriteLine(data);
            }
        }
		
		static void ShowInfo()
		{
			Console.WriteLine("Before anyone can legally drive any vehicle in the Philippines, you must obtain a driver’s license from the Land Transportation Office. ");
						Console.WriteLine("The purpose is to ensure that the driver is well equipped with the knowledge and skills for the safety of the driver, passengers, and the public.");
						Console.WriteLine("");
						Console.WriteLine("However, things get complicated, especially for first-time applicants because there are three kinds of licenses: student, non-professional, and professional.");
						Console.WriteLine("");
						Console.WriteLine("A student permit is easy to understand as it means the bearer is still learning to drive. The confusion comes in when they need to know about the difference between professional and non-professional driver's license.");
						Console.WriteLine("It should be noted though that a bearer of a student permit is not allowed to drive a vehicle without the supervision or guidance of a licensed driver.");
						Console.WriteLine("");
						Console.WriteLine("*** Restriction Codes ***");
						Console.WriteLine("");
						Console.WriteLine("To start off with the understanding the difference between a professional driver's license and a non professional license, we must first understand the restriction codes implemented by the LTO. ");
						Console.WriteLine("For each restriction, there are specific vehicle types that are included, and they are the only ones that you are allowed to drive.");
						Console.WriteLine("");
						Console.WriteLine("VEHICLE CATEGORIES");
						Console.WriteLine("These are what the LTO now uses to indicate what vehicles a license holder with certain codes may or may not drive.");
						Console.WriteLine("L1 – A two-wheeled vehicle with a maximum design speed not exceeding 50kph");
						Console.WriteLine("L2 – A three-wheeled vehicle with a maximum design speed not exceeding 50kph");
						Console.WriteLine("L3 – A two-wheeled vehicle with a maximum design speed exceeding 50kph");
						Console.WriteLine("L4 – A motorcycle with sidecar with a maximum design speed exceeding 50kph");
						Console.WriteLine("L5 – Three-wheeler (symmetrically arranged) with a maximum speed exceeding 50kph");
						Console.WriteLine("L6 – Four-wheeler whose unladen mass is not more than 350kg and with a maximum design speed not exceeding 45kph");
						Console.WriteLine("L7 – Four-wheeler whose unladen mass is not more than 550kg and with a maximum design speed not exceeding 45kph");
						Console.WriteLine("M1  – Vehicles up to 5,000kg GVW with not more than eight passenger seats or Automatic clutch up to 5,000kg GVW with not more than eight passenger seats");
						Console.WriteLine("M2 – Vehicles up to 5,00kg GVW with more than eight passenger seats");
						Console.WriteLine("N1 – Vehicles up to 3,500kg GVW for carriage of goods");
						Console.WriteLine("N2, N3 – Vehicles exceeding 3,500 kgs GVW for the carriage of goods");
						Console.WriteLine("M3 – Vehicles above 5,000 kgs GVW with more than 8 passenger seats");
						Console.WriteLine("O1 – Articulated Vehicle not more than 750 kgs GVW");
						Console.WriteLine("O2 –Articulated Vehicle exceeding 750 up to 3,500 kgs GVW");
						Console.WriteLine("O3, O4 – Articulated Vehicle exceeding 3,500 kgs GVW");
						Console.WriteLine("");
						Console.WriteLine("Driver's License codes");
						Console.WriteLine(">> A, A1 – can drive L1, L2, L3, L4, L5, L6");		
						Console.WriteLine(">> B, B1, B2 – can drive M1, M2, N1");
						Console.WriteLine(">> C – can drive N2, N3");
						Console.WriteLine(">> D – can drive M3");
						Console.WriteLine(">> BE – can drive  O1, O2");
						Console.WriteLine(">> CE – can drive O3, O4");
						
						
		}
		
		
    }
}
