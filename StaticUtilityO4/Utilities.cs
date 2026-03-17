namespace UtilitiesSpace
{
    public class UtilitiesClass
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("\nHowdy do! Top of the mornin to ya!");
        }
        
        public static void UserResponseToUpper()
        {
            Console.Write("How are you today? ");
            string? response = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("No response entered.");
                return;
            }

            Console.WriteLine($"{response.ToUpper()}? Well... How about that. Isn't that wild?");
        }
        //let me know if public on a var is against the rules, 
        // the system didnt seem to like "string response" or 
        // adding public to the start, but then indenting it with 
        // no public works out just fine?

        //this isnt python why does it LIKE that?! thats weird
        

        /* //Example Actions
        Display welcome message

        Convert text to uppercase

        Count characters in a string


        */
            
        /* Example Console Interaction
        (✅Enter text:
            hello world

        (✅Uppercase: HELLO WORLD
        (✅Character count: 11

        Restrictions
        ❌ No instance fields

        ❌ No new

        ❌ No constructors*/

    }
}