using System;
using System.Security.Cryptography.X509Certificates;
namespace ATM_Machine{
    public class Program{
        public static void Main(String[] args){

            void printOptions(){

                    System.Console.WriteLine("Please choose from one of the following options");
                    System.Console.WriteLine("1 Deposit");
                    System.Console.WriteLine("2 Withdraw");
                    System.Console.WriteLine("3 Show Balance");
                    System.Console.WriteLine("4 exit"); 
                     }

              //Deposit Money.
            void Deposit(CardHolder currentUser){

            Console.WriteLine("How much would you like to deposit");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentUser.getBalance());

            Console.WriteLine("Thank you, your new balance is: " + currentUser.getBalance());
            }

                //Withdraw Money.
            void withdraw(CardHolder currentUser){

                   Console.WriteLine("How much would you like to Withdraw");
                    double withdraw = Double.Parse(Console.ReadLine());

                        if( currentUser.getBalance() < withdraw ) {
                    
                     System.Console.WriteLine("You can not withdraw more money than you have.");
                    
                        }
                        else{
                                currentUser.setBalance(currentUser.getBalance() - withdraw);
                                System.Console.WriteLine("Thank you for using this ATM machine.");
                             }
            }

                //Show current balance.
    	       void balance(CardHolder currentUser){

                System.Console.WriteLine("Current Balance: " + currentUser.getBalance());
             }


        List<CardHolder> cardHolders = new List<CardHolder>();

        cardHolders.Add(new CardHolder("3193193", 1234, "John", "Griffith", 150.30));
        cardHolders.Add(new CardHolder("2031032", 4321, "Ashley", "Jones", 321.13));
        cardHolders.Add(new CardHolder("643120391", 2468, "Muneeb", "Harding", 105.59));
        cardHolders.Add(new CardHolder("9419410", 4826, "Frida", "Dickerson", 851.84));
        cardHolders.Add(new CardHolder("231398401", 9999, "Dawn", "Smith", 54.27));


        //Prompt user
        System.Console.WriteLine("Welcome to this ATM Machine");
        System.Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        CardHolder currentUser;

        while(true){

            try{

                    debitCardNum = Console.ReadLine();

                    currentUser =  cardHolders.FirstOrDefault( a => a.cardNum == debitCardNum);

                    //FirstOrDefault allows  enumerate a list and search for certain properties and return the entire object

                    if(currentUser != null) 
                    {
                        break;
                        
                        }

                        else{

                            Console.WriteLine("Card not recognized, Try again");
                        }
            }
                catch{
                              Console.WriteLine("Card not recognized, Try again");

            }
        }


        System.Console.WriteLine("Please enter your pin: ");
        int userPin = 0;


  while(true){

            try{

                    userPin = Int32.Parse(Console.ReadLine());
                    
                    //FirstOrDefault allows  enumerate a list and search for certain properties and return the entire object

                    if(currentUser.getPin() == userPin) {
                        
                        break;
                        }

                        else{

                            Console.WriteLine("Incorrect pin, Try again");
                        }
            }
            catch{


                              Console.WriteLine("Incorrect pin, Try again");

            }
        }

        Console.WriteLine("Welcome, " + currentUser.getFirstName());
        int option = 0;


        do {     
           
            try{ 
     

                printOptions();
               option = Int32.Parse(Console.ReadLine());

            switch(option){

                case 1: 

                Deposit(currentUser);
                break;


                case 2: 

                withdraw(currentUser);
                break;


                 case 3: 

              balance(currentUser);
                break;

            case 4: 


                break;

            default: 

            System.Console.WriteLine("Choose an option, please.");
            break; 
            }
}

catch{

            System.Console.WriteLine("Unknown Response.");
        }
        }
        while(option != 4);
            System.Console.WriteLine("Thank you, have a nice day");








        }
    }
}