namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = new() { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            List<List<string>> result = new();

            while (arr.Count > 0)
            {
                result.Add(EqualsElems(arr));
            }

            var count = 1;

            foreach (var items in result)
            {
                Console.WriteLine($"Массив {count}:");

                foreach (var item in items)
                {
                    Console.Write($"{item},");
                }

                Console.WriteLine();

                count++;
            }

            static List<string> EqualsElems(List<string> arr)
            {
                string currentItem = arr.First();

                List<string> result = new()
                {
                    currentItem
                };

                arr.Remove(currentItem);

                foreach (var item in arr)
                {
                    if (currentItem.Length != item.Length)
                        continue;

                    bool compare = true;

                    foreach (var i in currentItem.ToLower())
                    {
                        compare = item.ToLower().Contains(i);

                        if (!compare)
                            break;
                    }

                    if (compare)
                        result.Add(item);
                }

                foreach (var item in result)
                    if (arr.Contains(item))
                        arr.Remove(item);

                return result;
            }
        }
    }
}