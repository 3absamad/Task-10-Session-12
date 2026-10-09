using Day_01_G03;
using System;
using System.Linq;
using static Day_01_G03.ListGenerator;
using static System.Net.WebRequestMethods;
namespace Task_10_Session_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            //1.
            //Fluent Syntax
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p;
            //foreach (var product in result)
            //    Console.WriteLine(product);


            //2.
            //Fluent Syntax
            //var result = ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00m);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock != 0 && p.UnitPrice > 3.00m
            //             select p;
            //foreach (var product in result)
            //    Console.WriteLine(product);


            //3.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((word, index) => word.Length < index);
            //foreach (var word in result) 
            //    Console.WriteLine(word);

            #endregion

            #region Element Operators

            //1.
            //var result = ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            //2.
            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000m);
            //Console.WriteLine(result);

            //3.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(num => num > 5)
            //                .Skip(1) //****New Keyword****
            //                .FirstOrDefault();

            //Console.WriteLine(result);

            #endregion

            #region Aggregate Operators

            //1.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(result);


            //2.
            //Fluent Syntax
            //var result = CustomersList.Select(c => new { c.CustomerID, c.CustomerName, NoOfOrders = c.Orders == null ? 0 : c.Orders.Length });
            //foreach (var c in result)
            //    Console.WriteLine(c);

            //Query Syntax  
            //var result = from c in ListGenerator.CustomersList
            //             select new { c.CustomerName, NoOfOrders = c.Orders == null ? 0 : c.Orders.Length };
            //foreach (var item in result)
            //    Console.WriteLine(item);


            //3.
            //Fluent Syntax
            //var result = ProductsList.GroupBy(p => p.Category) //****New Keyword****
            //                         .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //Query Syntax
            //var result = from p in ProductsList
            //                  group p by p.Category into g
            //                  select new { Category = g.Key, ProductCount = g.Count() };
            //foreach (var item in result)
            //    Console.WriteLine($"{item.Category}: {item.ProductCount}");


            //4.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count();
            //Console.WriteLine(result);



            //string dictionaryPath = "dictionary_english.txt";
            //if (File.Exists(dictionaryPath))
            //{
            //    string[] words = File.ReadAllLines(dictionaryPath);

            //    // Q5. 
            //    //Fluent
            //    Console.WriteLine(words.Sum(word => word.Length));

            //    //Query
            //    Console.WriteLine((from word in words select word.Length).Sum());

            //    // Q6. 
            //    //Fluent
            //    Console.WriteLine(words.Min(word => word.Length));

            //    //Query
            //    Console.WriteLine((from word in words select word.Length).Min());

            //    //Q7.
            //    //Fluent
            //    Console.WriteLine(words.Max(word => word.Length));

            //    //Query
            //    Console.WriteLine((from word in words select word.Length).Max());

            //    // Q8.
            //    //Fluent
            //    Console.WriteLine(words.Average(word => word.Length));

            //    //Query
            //    Console.WriteLine((from word in words select word.Length).Average());
            //}
            //else
            //{
            //    Console.WriteLine("\nDictionary questions Q5-Q8 skipped: dictionary_english.txt was not found.");
            //}


            #endregion

            #region Ordering Operators

            //1.
            //Fluent Syntax
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             orderby p.ProductName
            //             select p;

            //foreach (var product in result)
            //    Console.WriteLine(product);


            //2.
            //string[] mixedWords = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = mixedWords.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result) 
            //    Console.WriteLine(word);


            //3.
            //Fluent Syntax
            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             orderby p.UnitsInStock descending
            //             select p;

            //foreach (var product in result)
            //    Console.WriteLine(product);


            //4.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //Fluent Syntax
            //var result = Arr.OrderBy(word => word.Length)
            //                .ThenBy(word => word);

            //foreach (var word in result)
            //    Console.WriteLine(word);

            //Query Syntax
            //var result = from word in Arr
            //             orderby word.Length, word
            //             select word;

            //foreach (var word in result)
            //    Console.WriteLine(word);


            //5.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.Length)
            //                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);


            //6.
            //Fluent Syntax
            //var result = ProductsList.OrderBy(p => p.Category)
            //                         .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             orderby p.Category, p.UnitPrice descending
            //             select p;

            //foreach (var product in result)
            //    Console.WriteLine(product);


            //7.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.Length)
            //                .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);


            //8.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i')
            //                .Reverse();

            //foreach (var word in result)
            //    Console.WriteLine(word);

            #endregion

            #region Transformation Operators

            //1.
            //Fluent Synatx
            //var result = ProductsList.Select(p => p.ProductName);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             select p;
            //foreach (var product in result)
            //    Console.WriteLine(product);


            //2.
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //Fluent Syntax
            //var result = words.Select(word => new { UpperCase = word.ToUpper(), LoweCase = word.ToLower() });

            //foreach (var word in result)
            //    Console.WriteLine(word);

            //Query Syntax
            //var result = from word in words
            //             select new { UpperCase = word.ToUpper(), LowerCase = word.ToLower() };

            //foreach (var word in result)
            //    Console.WriteLine(word);


            //3.
            //Fluent Syntax
            //var result = ProductsList.Select(p => new { p.ProductID, p.ProductName, p.Category, Price = p.UnitPrice });

            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Query Syntax
            //var result = from p in ProductsList
            //             select new { p.ProductID, p.ProductName, p.Category, Price = p.UnitPrice };

            //foreach (var product in result)
            //    Console.WriteLine(product);


            //4.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((number, index) =>
            //new
            //{
            //    Number = number,
            //    Index = index,
            //    Matches = number == index
            //});

            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result)
            //    Console.WriteLine(item);


            //5.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //Fluent Synatx
            //var result = numbersA.SelectMany(a => numbersB, (a, b) => new { A = a, B = b })
            //                     .Where(pair => pair.A < pair.B);

            //foreach (var pair in result)
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");

            //Query Syntax
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };
            //foreach (var pair in result)
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");


            //6.
            //Fluent Synatx
            //var result = CustomersList.SelectMany(c => c.Orders)
            //                          .Where(o => o.Total < 500.00m);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            //Query Syntax
            //var result = from c in CustomersList
            //             from o in c.Orders
            //             where o.Total < 500.00m
            //             select o;

            //foreach (var order in result)
            //    Console.WriteLine(order);


            //7.
            //Fluent Synatx
            //var result = CustomersList.SelectMany(c => c.Orders)
            //                          .Where(o => o.OrderDate.Year == 1998);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            //Query Syntax
            //var result = from c in CustomersList
            //             from o in c.Orders
            //             where o.OrderDate.Year == 1998
            //             select o;

            //foreach (var order in result)
            //    Console.WriteLine(order);

            #endregion
        }
    }
}
