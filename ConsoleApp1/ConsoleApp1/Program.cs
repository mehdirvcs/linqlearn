using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> prods = new Products().ProductList;
            //List<Customer> custs = Customers.CustomerList;

            //List<Product> products = prods.ProductList;

            //var soldOutProducts = from prod in prods
            //                      where prod.UnitsInStock == 0
            //                      select prod;

            //Console.WriteLine("Sold out products:");
            //foreach (var product in soldOutProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} is sold out!");
            //}


            //var expensiveInStockProducts = from prod in prods.ProductList
            //                               where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
            //                               select prod;

            //Console.WriteLine("In-stock products that cost more than 3.00:");
            //foreach (var product in expensiveInStockProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.");
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numsPlusOne = from n in numbers
            //                  select n + 1;

            //Console.WriteLine("Numbers + 1:");
            //foreach (var i in numsPlusOne)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var textNums = from n in numbers
            //               select strings[n];

            //Console.WriteLine("Number strings:");
            //foreach (var s in textNums)
            //{
            //    Console.WriteLine(s);
            //}

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var upperLowerWords = from w in words
            //                      select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            //foreach (var ul in upperLowerWords)
            //{
            //    Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            //}

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var upperLowerWords = from w in words
            //                      select (Upper: w.ToUpper(), Lower: w.ToLower());

            //foreach (var ul in upperLowerWords)
            //{
            //    Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            //}

            //var first3WAOrders = (
            //                        from cust in custs
            //                        from order in cust.Orders
            //                        where cust.Region == "WA"
            //                        select (cust.CustomerID, order.OrderID, order.OrderDate))
            //                        .Take(3);

            //Console.WriteLine("First 3 orders in WA:");
            //foreach (var order in first3WAOrders)
            //{
            //    Console.WriteLine(order);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            //Console.WriteLine("First numbers less than 6:");
            //foreach (var num in firstNumbersLessThan6)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            //Console.WriteLine("First numbers not less than their position:");
            //foreach (var n in firstSmallNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// In the lambda expression, 'n' is the input parameter that identifies each
            //// element in the collection in succession. It is is inferred to be
            //// of type int because numbers is an int array.
            //var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            //Console.WriteLine("All elements starting from first element divisible by 3:");
            //foreach (var n in allButFirst3Numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            //Console.WriteLine("All elements starting from first element less than its position:");
            //foreach (var n in laterNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] digits = { "zero", "one", "two", "three", "four", "six", "five", "seven", "eight", "nine" };

            //var reversedIDigits = (
            //    from digit in digits
            //    where digit[1] == 'i'
            //    select digit)
            //    .Reverse();

            //Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            //foreach (var d in reversedIDigits)
            //{
            //    Console.WriteLine(d);
            //}

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numberGroups = from n in numbers
            //                   group n by n % 5 into g
            //                   select (Remainder: g.Key, Numbers: g);

            //foreach (var g in numberGroups)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:");
            //    foreach (var n in g.Numbers)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            //var customerOrderGroups = from c in custs
            //                          select
            //                          (
            //                          c.CompanyName,
            //                          YearGroups: from o in c.Orders
            //                                      group o by o.OrderDate.Year into yg
            //                                      select
            //                                      (
            //                                      Year: yg.Key,
            //                                      MonthGroups: from o in yg
            //                                                   group o by o.OrderDate.Month into mg
            //                                                   select (Month: mg.Key, Orders: mg)
            //                                      )
            //                          );

            //foreach (var ordersByCustomer in customerOrderGroups)
            //{
            //    Console.WriteLine($"Customer Name: {ordersByCustomer.CompanyName}");
            //    foreach (var ordersByYear in ordersByCustomer.YearGroups)
            //    {
            //        Console.WriteLine($"\tYear: {ordersByYear.Year}");
            //        foreach (var ordersByMonth in ordersByYear.MonthGroups)
            //        {
            //            Console.WriteLine($"\t\tMonth: {ordersByMonth.Month}");
            //            foreach (var order in ordersByMonth.Orders)
            //            {
            //                Console.WriteLine($"\t\t\tOrder: {order}");
            //            }
            //        }
            //    }
            //}

            //string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            //var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());

            //foreach (var set in orderGroups)
            //{
            //    // The key would be the first item in the set
            //    foreach (var word in set)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("...");
            //}

            //string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            //var orderGroups = anagrams.GroupBy(
            //            w => w.Trim(),
            //            a => a.ToUpper(),
            //            new AnagramEqualityComparer()
            //            );
            //foreach (var set in orderGroups)
            //{
            //    Console.WriteLine(set.Key);
            //    foreach (var word in set)
            //    {
            //        Console.WriteLine($"\t{word}");
            //    }
            //}

            //var numbers = from n in Enumerable.Range(100, 50)
            //              select (Number: n, OddEven: n % 2 == 1 ? "odd" : "even");

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            //}

            //var numbers = Enumerable.Repeat(7, 10);

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] words = { "cherry", "apple", "blueberry" };

            //int shortestWord = words.Min(w => w.Length);

            //Console.WriteLine($"The shortest word is {shortestWord} characters long.");

            //var categories = from p in prods
            //                 group p by p.Category into g
            //                 let minPrice = g.Min(p => p.UnitPrice)
            //                 select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));

            //foreach (var c in categories)
            //{
            //    Console.WriteLine($"Category: {c.Category}");
            //    foreach (var p in c.CheapestProducts)
            //    {
            //        Console.WriteLine($"\tProduct: {p}");
            //    }
            //}

            //double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            //double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            //Console.WriteLine($"Total product of all numbers: {product}");

            //double startBalance = 100.0;

            //int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            //double endBalance =
            //    attemptedWithdrawals.Aggregate(startBalance,
            //        (balance, nextWithdrawal) =>
            //            ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            //Console.WriteLine($"Ending balance: {endBalance}");

            //var wordsA = new string[] { "apple", "cherry", "blueberry" };
            //var wordsB = new string[] { "cherry", "apple", "blueberry" };

            //bool match = wordsA.SequenceEqual(wordsB);

            //Console.WriteLine($"The sequences match: {match}");

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var allNumbers = numbersA.Concat(numbersB);

            //Console.WriteLine("All numbers from both arrays:");
            //foreach (var n in allNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            // Deferred execution lets us define a query once
            // and then reuse it later after data changes.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var lowNumbers = from n in numbers
            //                 where n <= 3
            //                 select n;

            //Console.WriteLine("First run numbers <= 3:");
            //foreach (int n in lowNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    numbers[i] = -numbers[i];
            //}

            //// During this second run, the same query object,
            //// lowNumbers, will be iterating over the new state
            //// of numbers[], producing different results:
            //Console.WriteLine("Second run numbers <= 3:");
            //foreach (int n in lowNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] categories = {
            //    "Beverages",
            //    "Condiments",
            //    "Vegetables",
            //    "Dairy Products",
            //    "Seafood"
            //};

            //var q = from c in categories
            //        join p in prods on c equals p.Category into ps
            //        select (Category: c, Products: ps);

            //foreach (var v in q)
            //{
            //    Console.WriteLine(v.Category + ":");
            //    foreach (var p in v.Products)
            //    {
            //        Console.WriteLine("   " + p.ProductName);
            //    }
            //}


        }

    }
}
