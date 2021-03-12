using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Type a secret message:");
            string message = Console.ReadLine();

            //convert string to array of characters
            char[] secretMessage = message.ToCharArray();

            //new array of characters to hold encrypted message
            char[] encryptedMessage = new char[secretMessage.Length];
            //Console.WriteLine(encryptedMessage.Length);

            // 4. loop through each character of secretMessage, assign to new letter
            for (int i = 0; i < secretMessage.Length; i++)
            {

                char position = secretMessage[i];
                int alphabetPosition = Array.IndexOf(alphabet, position);
                int newPosition = (alphabetPosition + 3) % 26;
                char newAlphabet = alphabet[newPosition];

          
                encryptedMessage[i] = newAlphabet;
               

            }
            //print encrypted message to console
            string newMessage = String.Join("", encryptedMessage);
            Console.WriteLine($"Your secret message encrypted is: {newMessage}");
        }
    }
}