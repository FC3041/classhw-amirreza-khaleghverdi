using System;

public class Program
{
    public static void reverse(string s, out string srev)
    {
        srev = "";
        foreach (char c in s)
            srev = c + srev;
    }
    public static void reverseWordsInSentence(string sentence, out string reversedSentence)
    {
        string[] words = sentence.Split(' ');
        reversedSentence = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            reversedSentence += words[i];
            if (i > 0) 
                reversedSentence += " ";
        }
    }
    public static void reverseWordsAndCharacters(string sentence, out string reversedSentence)
    {
        string[] words = sentence.Split(' ');
        reversedSentence = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            reverse(words[i], out string reversedWord);
            reversedSentence += reversedWord;
            if (i > 0)
                reversedSentence += " ";
        }
    }
    public static void Main(string[] args)
    {
        string inputSentence = "hello its a test";
        string reversedWords, reversedWordsAndChars;

        reverseWordsInSentence(inputSentence, out reversedWords);

        reverseWordsAndCharacters(inputSentence, out reversedWordsAndChars);

        Console.WriteLine("Original Sentence: " + inputSentence);
        Console.WriteLine("Reversed Words: " + reversedWords);
        Console.WriteLine("Reversed Words and Characters: " + reversedWordsAndChars);
    }
}