using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        promptGenerator generator = new promptGenerator();
        
        Console.WriteLine("Welcome to your personal journal.");

        string choice = "";

        while (choice != "5")
        {
            DisplayMenu();
            Console.WriteLine("Choose your action(s) from the list below: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter your thoughts for today.");
                //display(promptGenerator.getRandomPrompt);
                string prompt = generator.getRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string entry = Console.ReadLine();

                //get current date and save as string
                string date = "27 January 2023";

                Entry dailyThoughts = new Entry();
                dailyThoughts._date = date;
                dailyThoughts._prompt = prompt;
                dailyThoughts._text = response;

                myJournal.AddEntry(dailyThoughts);
            }
            else if (choice == "2")
    
                
                myJournal.Display();
                
                //journal.addEntry()
                //entry.display();
            }
            else if (choice == "3")
            {
                
                myJournal.Load();
                
            }
            else if (choice == "4")
            {
                Console.Write("What file would you like to save to? ");
                string file = Console.ReadLine();

                myJournal.Save(file);
                
        
            }
        }
    }
    
    static void DisplayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");    

    }

}







    



//File: Develop02.cs
//Author: Donna Meregillano

//Purpose: Create journal entries with prompts.

//product_name = []
//response = ""
//products = []
//#product_price = []
//print('Welcome to the Shopping Cart Program!')

//while response !='5':  
    //print()
    //print('Please select one of the following:')
    //print('1. Add item')
    //print('2. View cart')
    //print('3. Remove item')
    //print('4. Compute total')
    //print('5. Quit')
    //print()

    //response = input('Please enter an action: ')
    //if response == '1':
    
        //products = input('What item would you like to add? ')
        //product_name.append(products)

        //for product in product_name:
            //print(f'{product} has been added to the cart.')

    //if response == '2':
        //print(f'The contents of the shopping cart are: ')
        //for products in product_name:
            //print(products)
            
    
    //if response == '5':
        //print('Thank you.  Goodbye.')