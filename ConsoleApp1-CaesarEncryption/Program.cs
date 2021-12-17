using System;

namespace ConsoleApp1_CaesarEncryption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Ask user to input string
            Console.WriteLine("Input a string to be encrypted with Caesar encryption");
            //Read the string and save it to userInput variable
            string userInput = Console.ReadLine();
            //Pass user string through the CaesarEncrypt method and return an encrypted string
            string userOutput = CaesarEncrypt(userInput);
            //Print the encrypted string to the console
            Console.WriteLine($"The input text has been encrypted as follows: \n{userOutput}");
        }

        //The CaesarEncrypt method takes the userInput string as a parameter and outputs and encrypted string
        private static string CaesarEncrypt(string userInput)
        {
            //Declare and initialize string variable userOutput
            string userOutput = "";
            //For each character in the input string, starting at position 0 and ending at the last character,...
            for (int i = 0; i < userInput.Length; i++)
            {
                //...Convert the character to three letter down/forewards in the ascii table and add this to the userOutput string
                userOutput += Convert.ToChar(userInput[i] + 3);
            }
            return userOutput;
        }
    }
}