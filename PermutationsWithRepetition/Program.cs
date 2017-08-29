using System;
public class Program
{

    public static void Main()
    {

        // Create an alphabet to work with
        char[] alphabet = new char[] { 'a', 'b' };
        // Find all possible combinations of this alphabet in the string size of 4
        StringExcersise.possibleStrings(4, alphabet, "");
        Console.ReadKey();
    }

}
class StringExcersise
{

    public static void possibleStrings(int maxLength, char[] alphabet, String curr)
    {

        // If the current string has reached it's maximum length
        if (curr.Length == maxLength)
        {
            Console.WriteLine(curr);

        }
        // Else add each letter from the alphabet to new strings and process these new strings again
        else
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                String oldCurr = curr;
                curr += alphabet[i];
                possibleStrings(maxLength, alphabet, curr);
                curr = oldCurr;
            }
        }
    }
}