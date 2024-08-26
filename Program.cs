using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace LinQ_demo_1
{
    class prog
    {
        static void Main(string[] args)
        {
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> oddnum = numbers.Where(num => num % 2 == 1).ToList();
            //foreach (int item in oddnum)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #region LINQ SYNTAX
            #region fluent syntax
            // as a static method
            //var Oddnumber = Enumerable.Where(Numbers, x => x % 2 == 1);
            //foreach(var item in Oddnumber) {  Console.WriteLine(item); }
            //// as a extension method [ recommended ]
            //var Oddnumber2 = Numbers.Where(x => x % 2 == 1);
            #endregion
            #region query synax
            //var Oddnum = from N in Numbers 
            //             where N % 2 == 1 
            //             select N;

            //    foreach (var item in Oddnum)
            //{
            //    Console.WriteLine(item);
            //}
            // Must be Begin With keyword "From"
            // Must Be End With Select OR GroupBy
            #endregion
            #endregion
            #region deferred execution
            //    List<int> numbers2 = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            //var oddnumbers2 = numbers3.Where(x => x % 2 == 1);
            //numbers2.AddRange(new int[] { 11, 21, 31, 41, 51 });
            //foreach (var item in oddnumbers2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region immediate execution
            //List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var oddnumbers3 = numbers3.Where(x => x % 2 == 1).ToList();
            //numbers3.AddRange(new int[] { 11, 21, 31, 41, 51 });
            //foreach (var item in oddnumbers3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region data setup
            //Console.WriteLine(listgenerator.ProductsList[0]);
            //Console.WriteLine(listgenerator.CustomersList[0]);
            #endregion
            #region filteration operation

            #region getproduct
            //var result = listgenerator.ProductsList.Where(p => p.UnitsInStock == 0); --1
            //var result = from p in listgenerator.ProductsList --2
            //             where p.UnitsInStock == 0
            //             select p;

            //foreach (var item in result) 
            //{ 
            //Console.WriteLine(item);
            //}
            #endregion

            #region
            //var result = listgenerator.ProductsList.Where(c => c.Category == "Meat/Poultry" && c.UnitsInStock > 0);
            //foreach (var item in result) { 
            //Console.WriteLine(item);
            //}           
            //var result = from x in listgenerator.ProductsList
            //             where x.Category == "Meat/Poultry" && x.UnitsInStock > 0
            //             select x;
            //foreach ( var x in result ) { Console.WriteLine( x ); }
            #endregion
            #endregion
            #region transformation opertators
            //var result = listgenerator.CustomersList.Select(x => x.CustomerName);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            ////var result2=listgenerator.CustomersList.SelectMany(x => x.Orders); // select many with [array]
            ////foreach (var name in result2)
            ////{
            ////    Console.WriteLine(name);
            ////}
            ////var resullt3 = from x in listgenerator.CustomersList
            ////                from o in x.Orders
            ////                select o;

            #region Select Product ld and Product Name (2 coloums in the same time )
            //var Result = listgenerator.ProductsList.Select(p => new { Productid = p.ProductID, ProductName = p.ProductName });
            #endregion

            #region select with condition and edit data
            //var res = listgenerator.ProductsList.Where(p => p.UnitsInStock > 0)
            //                                    .Select(p => new
            //                                    {
            //                                        id = p.ProductID
            //                                    ,
            //                                        ProductName = p.ProductName
            //                                    ,
            //                                        UnitPrice = p.UnitPrice
            //                                    ,
            //                                        unitsinstock = (p.UnitsInStock * 0.1M)
            //                                    });
            #endregion

            #endregion
            #region Get Products Ordered By Price Asc
            //var res1 = listgenerator.ProductsList.OrderBy(p => p.UnitPrice);//thenby() // Ascending order
            //foreach (var item in res1) { Console.WriteLine(item); };

            #endregion
            #region Elements Operator — Immediate Execution [Valid Only With Fluent Syntax]
            //var Result = listgenerator.ProductsList.First(); // Get First Element At sequence
            //Result=listgenerator.ProductsList.Last(); // Get Last Element At Sequence
            //Console.WriteLine(Result? .ProductName ??"not found" )  ;
            //var Result2 = listgenerator.ProductsList.FirstOrDefault();  //علشان تتجنب ان يكون في اكسيبشن   // Get First Element At sequence

            //var Result= ProductList.ElementAt(77);
            // ArgumentOutOfRangeException: Index was out of range
            // var Result= ProductList.ElementAtordefault(77)
            // // If Index Was Out Range Return Default ==null

         //   var MinLength = listgenerator.ProductsList.Min(P => P.ProductName.Length);

         //var Result1 = (from P in listgenerator.ProductsList
         //    where P.ProductName.Length ==MinLength
         //    select P).FirstOrDefault();
         //   Console.WriteLine(Result1);

         //   var Result = listgenerator.ProductsList.Sum ( P=> P.UnitPrice);
         //   Result = listgenerator.ProductsList.Average(P=>P.UnitPrice);
            #endregion
        }
    }
}