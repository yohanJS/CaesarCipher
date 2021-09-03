using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      //Prompt the user to enter a secret message
      Console.Write("Enter your secret message:");
      string message = Console.ReadLine();
      
      //Convert the message to an array of char
      char[] secretMessage = message.ToCharArray();

      //Create a new empty array of characters to hold the encrypted message
      char[] encryptedMessage = new char[secretMessage.Length];

      //Create an empty for loop that loops through each char of secretMessage
      for(int i = 0; i < secretMessage.Length; i++) {
        //access the character at position i in the secretMessage array and store it in a variable.
        char charMessage = secretMessage[i];
        //Find the position of the character in the alphabet array using the method Array.IndexOf(). Store the value in a variable.
        int charAlphabetPosition = Array.IndexOf(alphabet, charMessage);
        //Add 3 to the letter position and store the value in a variable.
        int plusThree = (charAlphabetPosition + 3) % 26;
        //Find the new encrypted character by getting the character in the alphabet array with that new position.
        char newEncryptedChar = alphabet[plusThree];
        //Find the new encrypted character by getting the character in the alphabet array with that new position.
        encryptedMessage[i] = newEncryptedChar;
      }
      //Convert the character array to a string using String.Join() and print it to the console.
      string messageEncrypted = String.Join("", encryptedMessage);
      Console.WriteLine(messageEncrypted);
    }
  }
}
