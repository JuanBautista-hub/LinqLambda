using System;

namespace LinqMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // create numbers range 
            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            // declarative query
            // immediate execute
            numbers.Where(i => i >= 5).ToList().ForEach((number) =>
            Console.WriteLine(number)
            );

            var order = numbers.Where(num => num * 2 == 10).OrderBy(i => i).ToList();
            order.ForEach((number) => Console.WriteLine(number));


            // deferred execution
            IEnumerable<int> numbers2 = Enumerable.Range(1, 10);
            var numberRang = numbers.Where(i =>
            {
                Console.WriteLine($"Evaluando el numero {i}");
                return i >= 5;
            });

            foreach (var number in numberRang)
            {
                Console.WriteLine(number);
            }

        }

    }
}