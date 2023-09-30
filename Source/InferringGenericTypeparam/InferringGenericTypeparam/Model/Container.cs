namespace InferringGenericTypeparam.Model
{
    public class Container<TClass, TValue>
        where TClass : GenericClass<TValue>
    {
        public required TClass Instance { get; init; }
    }
}
