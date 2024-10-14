namespace Session02.Enums
{

    public static class GenderFriendlyText
    {

        private static Dictionary<Gender, string> FriendlyText = new()
         {
             { Gender.Male,"Male" },
             { Gender.Female,"Female" },
             { Gender.NonBinary,"Non-binary" },
             { Gender.GenderFluid,"Genderfluid" },
             { Gender.Agender,"Agender" },
             { Gender.Other,"Other" },
             { Gender.PreferNotToSay,"Prefer not to say" }
         };

        public static List<string> GetGenderFriendlyTextsList()
        {
            // Return a list of gender-friendly texts
            return FriendlyText.Values.ToList();
        }

    }

}


//public static class GenderFriendlyText
//{
//    private static Dictionary<Gender, string> enum2 = new()
//    {
//        { Gender.Male, "Male" },
//        { Gender.Female, "Female" },
//        { Gender.NonBinary, "Non-binary" },
//        { Gender.GenderFluid, "Genderfluid" },
//        { Gender.Agender, "Agender" },
//        { Gender.Other, "Other" },
//        { Gender.PreferNotToSay, "Prefer not to say" }
//    };

//    public static List<string> GetGenderFriendlyTexts()
//    {
//        // Return a list of gender-friendly texts
//        return enum2.Values.ToList();
//    }
//}

//// Example usage
//public class Program
//{
//    public static void Main()
//    {
//        List<string> genderTexts = GenderFriendlyText.GetGenderFriendlyTexts();
//        foreach (var text in genderTexts)
//        {
//            Console.WriteLine(text);
//        }
//    }
//}
