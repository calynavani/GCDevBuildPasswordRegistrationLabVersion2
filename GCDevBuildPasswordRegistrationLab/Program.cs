using System;
using System.Linq;
using System.Collections.Generic;


namespace GCDevBuildPasswordRegistrationLab
{
    class Program
    {
        static void Main(string[] args)

        {
            //I really tried my best on this lab but I honestly have no idea what I'm doing.
            // I did reach out for help and the concepts are still not clicking.
            //It is my hopes that this weekend I am able to teach myself the concepts reviwed this week as I have not grasped the concets introduced begginning on Tuesday.
            // I am submitting two unfinished programs for this lab.
            


            int minPasswordLength = 7;
            int maxPasswordLength = 12;
              //password requirements

            //minimum of 7 and max of 12
            

            //string lowercase = "abcdefghijklmnopqrstuvwxyz";
            //string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string digits = "0123456789";
            string specailChars = "!@#$%^&*";


            //usernmae requiremnts
            //must have letters and num
            //must have min of 5 letters
            //must have minimum lenght of 7 chars
            //must have max length of 12 chars
            int minUsernameLength = 7;
            int maxUsernameLength = 12;
            int minUsernameLetters = 5;
            //Can not include profanity


            //a counter to keep track of the password requirements
            int passwordScore = 0;
            // a counter to keep track of username requirements
            int usernameScore = 0;

            int totalScore = passwordScore + usernameScore;

          

            Console.WriteLine("Hello User :)");
            Console.WriteLine();

            //Ask user to enter password and then capture the password

            string userPassword = GetInput();


            //Ask user to enter an username and then capture the username
            Console.WriteLine();

            string userName = GetInput2();

 
            bool usernameHasLettersandNums = userName.Any(char.IsLetterOrDigit);
            bool usernameHasFiveLetters = UsernameLetterNumChecker(userName, minUsernameLetters);//caaling my new method to check if username contains 5 letters


            List<string> passWords = new List<string>();
            {

                
                passWords.Add(userPassword);
            }

           // foreach(string password in passWords)
           // {
            //    Console.WriteLine(password);
            //}
        //was unable to print the lists I created

            List<string> userNames = new List<string>();
            {
                
                userNames.Add(userName);
            }

            if (usernameHasLettersandNums)
            {
                usernameScore++;
                
            }
            else
            {
                Console.WriteLine("This username does not meet letter and number requirements");
                

            }

            if (userName.Length >= minUsernameLength || userName.Length <= maxUsernameLength)
            {
                usernameScore++;


            }
            else
            {
                Console.WriteLine("This username does not meet length requirements");

            }

            if (usernameHasFiveLetters)
            {
                usernameScore++;

            }
            else
            {
                Console.WriteLine("This username does not meet letter and number requirements");

            }
            // was unable to get the console to print any of the username error lines
            Console.WriteLine();
            //  foreach(string username in userNames)
            // {
            //     Console.WriteLine(username);
            //  }


            // bools to use in the if statments:
            bool passwordHasOneLowerCase = userPassword.Any(char.IsLower);
            bool passwordHasOneUpperCase = userPassword.Any(char.IsUpper);
            bool passwordHasOneSpecialChar = SpecialCharChecker(userPassword, specailChars);  //calling my new method to check special chars in password
            bool passwordHasOneDigit = userPassword.Any(char.IsDigit);

            
            

            if (userPassword.Length >= minPasswordLength && userPassword.Length <= maxPasswordLength)
            {
                passwordScore++;


            }
            else
            {
                Console.WriteLine("This password does not meet length requirements");

            }
            


            if (passwordHasOneLowerCase)
            {
                passwordScore++;


            }
            else
            {
                Console.WriteLine("This password does not meet lowecase requirements");

            }

            if (passwordHasOneUpperCase)
            {
                passwordScore++;
                passwordHasOneUpperCase = true;

            }
            else
            {
                Console.WriteLine("This password does not meet uppercase requirements");

            }


            if (passwordHasOneDigit)
            {
                passwordScore++;

            }
            else
            {
                Console.WriteLine("This password does not meet number requirements");


            }
            if (passwordHasOneSpecialChar)
            {
                passwordScore++;

            }
            else
            {
                Console.WriteLine("This password does not contain special characters");

            }

           
        }
  

            public static string GetInput()
            {
                Console.WriteLine("Lets create a password.");
                Console.Write("The password must contain: \no At least one lowercase letter\no At least one uppercase letter\no At least one number\no A minimun of 7 characters\no A maximum of 12 characters\no Can include any of the following special characters(! @ # $ % ^ & *): ");
                string password = Console.ReadLine();
            
                return password;
            }
        public static string GetInput2()
        {
            Console.WriteLine("Lets now create a username.");
            Console.Write("The user name must contain: \no Must contain both letters and numbers\no Must have at minimum 5 letters\no At minimum lenght of 7 characters\no At maxium 12 characters: "); 
            string username = Console.ReadLine();

            return username;
        }
        //this compares my string special chars agaisnt the characterss used in the userpassword and then if the password contains a speicla character it will return a true bool
        public static bool SpecialCharChecker(string userPassword, string specialChars)
        {
            foreach (char character in userPassword)
            {
               if(specialChars.Contains(character))
                {
                    return true;
                }

            }
            return false;
        }
        // I'm unsure if this method actually does what I think It does and would like to understand how to check to see if it works.
        public static bool UsernameLetterNumChecker(string username, int minUsernameLetters)
        {
            foreach(char letter in username)
            {
                if (minUsernameLetters.Equals(5))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
