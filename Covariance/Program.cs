
// Amir Moeini Rad
// August 20, 2025
// Help from Google NotebookLM

// Main Concept: Demonstrating Covariance in C# with Delegates
// Covariance means that a method can return a more derived type than what is specified in the delegate type.
// This example uses the built-in delegate type `Func<out T>()` to illustrate covariance.
// Also look at the Contravariance example in 'CSharp.Contravariance' repository.


namespace Covariance
{
    public class CovarianceExample
    {
        // Define a method that returns a string (a more specific type)
        static string GetSpecificMessage()
        {
            return "Hello from a specific string message!";
        }



        // Main method to demonstrate covariance with delegates
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Covariance for Return Types with Delegates in C#.NET.");
            Console.WriteLine("-----------------------------------------------------\n");



            // 1. Create a Func<string> delegate instance.
            // This delegate returns a string (a more specific type).
            // 'System.Func<out T>()' is a built-in delegate type in C# that represents a method
            // that takes no parameters and returns a value of type T.
            // Compare 'Func<>' with 'Action<>'.
            Func<string> stringProvider = GetSpecificMessage;
            Console.WriteLine($"stringProvider delegate result: \"{stringProvider()}\"");



            // 2. Demonstrate covariance: Assign Func<string> to Func<object>.
            // Func<TResult> is covariant in TResult.
            // This conversion is safe because a delegate that promises to return a string
            // can certainly fulfill a promise to return an object, as a string 'is an' object.
            Func<object> objectProvider = stringProvider;



            // 3. Invoke the Func<object> and print its result.
            object result = objectProvider();
            Console.WriteLine($"\nobjectProvider delegate result (originally Func<string>): \"{result}\"");

            // Although 'result' is of type 'object', it holds a string value and returns the 'String' type.
            Console.WriteLine($"objectProvider result type: {result.GetType().Name}");



            Console.WriteLine("\nDone.");
        }
    }
}
