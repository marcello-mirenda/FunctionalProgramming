

internal class Functor<Tin, TOut>
{
    internal Func<Tin, TOut> Map(Func<Tin, TOut> mapping)
    {
        return x => mapping(x);
    }
}
