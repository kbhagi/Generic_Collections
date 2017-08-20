using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var numbers2 = numbers;
            numbers2.Add(123);

            var i1 = ImmutableList<int>.Empty;
            i1.Add(10);
            int count = i1.Count;
            var i2 = i1.Add(10);
             i2 = i2.Add(10);

            var builder = i2.ToBuilder();
            builder.Add(30);
            var i3 = builder.ToImmutable();
            var i4 = numbers.ToImmutableList();
            numbers.Add(1);

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine(numbers.Count());
            foreach (var number in numbers)
                Console.WriteLine(number);
            numbers[1] = 123;
            for (int index = 0; index < numbers.Count; index += 1)
                Console.WriteLine(numbers[index]);
        //    numbers[4] = 456;
            var nullables = new List<double?>();
            nullables.Add(123.4);
            nullables.Insert(0, 456.7);
            nullables.Add(null);
            nullables.Sort();
            nullables.Add(-54.3);
            var text = new List<string>()
            {
                "Hello",
                "Goodbye"
            };
            int location = text.IndexOf("Goodbye");
            location = text.IndexOf("goodbye");
            var dictionary = new Dictionary<string, string>()
            {
            ["doh"]="a deer, a female deer" ,
            ["re"] ="a drop of golden sun",
            ["mi"]= "a name I call myself" 
            };
            string definition = dictionary["mi"];
            dictionary["fa"] = "a long, long way to run";

            dictionary.Add("soh", "a needle pulling thread");
          //  definition = dictionary["me"];
            string reDefinition;
            if(dictionary.TryGetValue("re", out reDefinition))
                Console.WriteLine(reDefinition);
            foreach (var key in dictionary.Keys)
                Console.WriteLine($"{key} = {dictionary[key]}");
            foreach (var pair in dictionary)
                Console.WriteLine($"{pair.Key}={pair.Value}");
            foreach (var value in dictionary.Values)
                Console.WriteLine($"{value}");

            

  

        }
    }
}
