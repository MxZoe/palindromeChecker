using System;
using System.Collections.Generic;

namespace PalindromeChecker
{
  public class Checker
  {
   public static void Main()
   {
      Console.WriteLine("Please enter a word or phrase.");
      string toCheck = Console.ReadLine();
      char[] charCheck = toCheck.ToCharArray(0, toCheck.Length);
      char[] compareArray = new char[toCheck.Length];
      string reversed = "";
      string currentLetter = "";
      bool isPalindrome = true;
      for(int i = 0; i < toCheck.Length; i++)
      {
        int j = toCheck.Length - 1;
        j -= i;
        compareArray[i] = charCheck[j];
        currentLetter = compareArray[i].ToString();
        reversed = reversed + currentLetter;
         
      }

      for(int i = 0; i < toCheck.Length; i++)
      {
        
        if(charCheck[i] != compareArray[i])
        {
          isPalindrome = false;
          break;
        } 
      }

      if(isPalindrome)
      {
        Console.WriteLine("Your word, " + toCheck + ", is a palindrome! :)");

      } else
      {
        Console.WriteLine("Your word, " + toCheck + ", is not a palindrome. :(");
      }

    }
  }
}