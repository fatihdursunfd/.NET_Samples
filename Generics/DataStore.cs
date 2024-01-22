namespace Generics
{
    public class DataStore<T>
    {
        public T Data { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
