
// See https://aka.ms/new-console-template for more information

//var f1 = (int x) => x + 2;
//var f2 = (int x) => x + 3;

//var ff2 = new Functor<int, int>().Map(f1);
//var ff1 = new Functor<int, int>().Map(f2);
//var q = ff2(ff1(1));
//var r = new Functor<int, int>().Map(x => f1(f2(x)))(1);


//using Functors.Lab1;

//Func<int, int> id = (x) => x;
//Func<int, int> doubleInt = (x) => x * 2;
//Func<int, string> toStr = (x) => x.ToString();
//Func<int, string> composite = (x) => toStr(doubleInt(id(x)));

//var functor = new ListFunctor<int>(new List<int> { 1, 2, 3 }.AsReadOnly())
//    .Map(id)
//    .Map(doubleInt)
//    .Map(toStr);

//var functor2 = new ListFunctor<int>(new List<int> { 1, 2, 3 }.AsReadOnly())
//    .Map(composite);

//foreach (var item in functor.Value)
//{
//    Console.WriteLine($"{item.GetType()}-{item}");
//}

//foreach (var item in functor2.Value)
//{
//    Console.WriteLine($"{item.GetType()}-{item}");
//}

//using CSharpFunctionalPatterns.Lab2_Functors;

////var value = Box<int>.Map(x => x * 2, new Box<int>(10));
////Console.WriteLine(value.Value);

//var value2 = RecordMaybe<int>.Map(x => x + 3, new RecordMaybe<int>.Just(10));

//switch(value2)
//{
//    case RecordMaybe<int>.Just just:
//        Console.WriteLine(just.Value);
//        break;
//    case RecordMaybe<int>.Nothing:
//        break;
//}

using CSharpFunctionalPatterns.Lab2_Functors;
using CSharpFunctionalPatterns.Lab3_ApplicativeFunctors;

//var value = RecordApplicativeMaybe<int>.Lift<int>(new RecordMaybe<Func<int,int>>.Just(x => x + 1), 1);
var value1 = new RecordApplicativeMaybe<int>(new RecordMaybe<int>.Just(4))
    .Apply(new RecordMaybe<Func<int, int>>.Just(x => x))
    .Apply(new RecordMaybe<Func<int, double>>.Just(x => x * 3))
    .Apply(new RecordMaybe<Func<double, string>>.Just(x => $"x={x}"))
    .Value;


var value22 = new RecordApplicativeMaybe<int>(new RecordMaybe<int>.Just(4))
    .Apply(new RecordMaybe<Func<int, int>>.Nothing())
    .Value;
var value23 = new RecordApplicativeMaybe<int>(new RecordMaybe<int>.Nothing())
    .Apply(new RecordMaybe<Func<int, int>>.Just(x => x * 3))
    .Value;

Console.WriteLine(value1);
Console.WriteLine(value22);
Console.WriteLine(value23);