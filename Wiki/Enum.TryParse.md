### `Enum.TryParse` in C#

`Enum.TryParse` is a method used to convert a string representation of the name or numeric value of an enum constant to the corresponding enum object. It returns `true` if the parsing is successful, and `false` otherwise.

#### Syntax:
```csharp
Enum.TryParse<TEnum>(string value, out TEnum result);
Enum.TryParse<TEnum>(string value, bool ignoreCase, out TEnum result);

using System;

namespace Session02.Enum
{
    public enum Gender
    {
        Male,
        Female,
        NonBinary,
        GenderFluid,
        Agender,
        Other,
        PreferNotToSay
    }

    class Program
    {
        static void Main()
        {
            string input = "Female";

            // Case-insensitive parsing
            if (Enum.TryParse(input, true, out Gender gender))
            {
                Console.WriteLine($"Parsed Gender: {gender}");
            }
            else
            {
                Console.WriteLine("Invalid Gender value.");
            }
        }
    }
}


 
This markdown provides an explanation of `Enum.TryParse`, its syntax, parameters, return value, and an example of how to use it in C#.
