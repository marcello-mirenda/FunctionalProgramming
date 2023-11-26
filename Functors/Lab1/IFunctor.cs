namespace Functors.Lab1
{
    internal interface IFunctor<T>
    {
        T Value { get; }
        IFunctor<U> Map<U>(Func<T, U> mapper);
    }
}
