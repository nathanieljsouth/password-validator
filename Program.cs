using System;

/*
Write a program that validates a password. It should read the password from the new line
 and check that it is at least 8 characters long and 
 contains at least one uppercase letter, 
 one lowercase letter, and one digit. 
 If the input doesn't meet these requirements,
  your program should output an error-specific message as follows: 

"Password length should be 8 symbols or more." 
"Password should contain at least one uppercase letter." 
"Password should contain at least one lowercase letter." 
"Password should contain at least one digit." 

@ author
@ version
@ date 

Need to figure out (in C#)
- how to measure length of string
- how check if a char is a Capital -letter - char.IsUpper(c)
- how to check if a character is a lowercase letter - char.IsLower(c)
- how to check if a character is a digit (numerical) - char.IsDigit(c)
- all of this must be related to the TryParse functions we look at input validation

*/

namespace passwordvalidation
{

    class Password {
        //member variable for my Password class - i might need it
        //string pass;
        const int MIN_LENGTH = 8;
        public void checkPassword(string userPassword) {
            //check if p has a value first
            Console.WriteLine($"The value you have sent me is {userPassword}");

            //variables will hold the answer to the isUpper/isLower/isDigit
            bool lowerCaseFound = false;
            bool upperCaseFound = false;
            bool digitFound = false;

            //go through each character in my password and check if requirements
            //are being met
            foreach(char c in userPassword) {
                if (upperCaseFound==false){
                    upperCaseFound = char.IsUpper(c);
                }
                if (lowerCaseFound==false){
                    lowerCaseFound = char.IsLower(c);
                }
                if (digitFound==false){
                    digitFound = char.IsDigit(c);
                }
                //If we have found everything we need then stop checking
                if(upperCaseFound && lowerCaseFound && digitFound){
                    //We've found all the requirements so jump out of the loop
                    break;
                }
            }
            //Write out the results
            if((userPassword.Length >= MIN_LENGTH) && upperCaseFound && lowerCaseFound && digitFound){
                //We've found all the requirements so jump out
                Console.WriteLine($"The password is good");
            }
            else {
                //At least one test failed, go through them
                if (userPassword.Length < MIN_LENGTH){
                    Console.WriteLine ($"Password must be at least {MIN_LENGTH} characters long");
                } 

                if (upperCaseFound==false){
                    Console.WriteLine ($"No upper case character found");
                } 

                if (lowerCaseFound==false){
                    Console.WriteLine ($"No lower case character found");
                } 

                if (digitFound==false){
                    Console.WriteLine ($"No digit found");
                } 

            } 
        }//end checkPassword


    } //end Password
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //connect the two classes together -access the checkPassword
            //create an object of my Password class
            Password myData = new Password();

            //ask for a password
            Console.WriteLine("Please enter a password");
            string myPassword = Console.ReadLine();

            ///using this object
            /*
            if (!string.IsNullOrEmpty(myPassword))
                myData.checkPassword(myPassword);
            else {
                Console.WriteLine("you have not entered anything! please enter a password");
                Console.WriteLine("Please enter a password");
                myPassword = Console.ReadLine();

            }*/
            while(string.IsNullOrEmpty(myPassword)) {
                Console.WriteLine("you have not entered anything! please enter a password");
                Console.WriteLine("Please enter a password");
                myPassword = Console.ReadLine();
            }
            myData.checkPassword(myPassword);

        }//end Main
    }//end Program
}//end namespace
