
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

using Functors.Lab2;

var value = Box<int>.Map(x => x * 2, new Box<int>(10));

var value2 = RecordMaybe<int>.Map(x => x + 3, new RecordMaybe<int>.Just(10));

Console.WriteLine(value.Value);
switch(value2)
{
    case RecordMaybe<int>.Just just:
        Console.WriteLine(just.Value);
        break;
    case RecordMaybe<int>.Nothing:
        break;
}
