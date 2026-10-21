
using System;

class PasswordChecker
{
    static void Main()
    {
        while (true) 
        {

        Console.WriteLine("Enter the password:");
        string pass = Console.ReadLine() ?? "";

        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool hasSpecial = false;
        bool hasSpace = false;

        int passed =0;

        foreach(char c in pass)
        {
            if (char.IsUpper(c))
                hasUpper = true;
            else if (char.IsLower(c))
                hasLower = true;
            else if (char.IsDigit(c))
                hasDigit = true;
            else if (char.IsWhiteSpace(c))
                hasSpace = true;
            else if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))     
                hasSpecial = true;
        }
        bool lengthOK = pass.Length >= 8;
        bool noSpaces = !hasSpace;

        Console.WriteLine("\n Password Rules: ");

        Console.WriteLine("8+ characters: " +
            (lengthOK ? "Passed" : "Failed"));

        Console.WriteLine("Uppercase letter: " +
            (hasUpper ? "Passed" : "Failed"));

        Console.WriteLine("Lowercase letter: " +
            (hasLower ? "Passed" : "Failed"));

        Console.WriteLine("Digit: " +
            (hasDigit ? "Passed" : "Failed"));

        Console.WriteLine("Special character: " +
            (hasSpecial ? "Passed" : "Failed"));
        Console.WriteLine("NO Spaces: " + 
            (noSpaces ? "Passed" : "Failed"));
        
        if (noSpaces) passed++;
        if (hasLower) passed++;
        if (hasUpper) passed++;
        if (hasDigit) passed++;
        if (hasSpecial) passed++;
        if (lengthOK) passed++;

        string strength;

        if(passed <= 3)
        {
            strength = "weak";
        }
        else if (passed < 5)
        {
            strength = "medium";
        }
        else
        {
            strength = "strong";
        }
        Console.WriteLine("Password Strength: "+ strength);

        if(strength == "strong")
        {
            Console.WriteLine("Password Accepted");
            break;
        }
        Console.WriteLine("Password is invalid");       
    }
}
}