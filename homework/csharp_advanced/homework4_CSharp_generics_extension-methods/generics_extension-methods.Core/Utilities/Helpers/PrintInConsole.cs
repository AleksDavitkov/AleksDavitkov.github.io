namespace generics_extension_methods.Core.Utilities.Helpers
{
    public class PrintInConsole
    {
        public void Print<T>(T name, T lastName)
        {
            Console.WriteLine($"{name} {lastName}");
        }

        public void PrintCollection<T>(List<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}