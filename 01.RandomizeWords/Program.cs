/*
 * 01.RandomizeWords
 */

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            List<string> words = (Console.ReadLine() ?? "The Devil")
                .Split()
                .ToList();

            ShuffleAndPrint(words);
        }

        static void ShuffleAndPrint<DataType>(List<DataType> collection)
        {
            Random randomNumber = new();
            for (int i = 0; i < collection.Count; i++)
            {
                int randomIndex = randomNumber.Next(0, collection.Count);
                DataType buffer = collection[i];
                collection[i] = collection[randomIndex];
                collection[randomIndex] = buffer;
            }

            collection.ForEach(collectionMember => Console.WriteLine(collectionMember));
        }
    }
}
