namespace Generics
{
    public class ClassInfo<T> where T : class
    {
        public T Data { get; set; }

        public Dictionary<string, string?> Props { get; set; }

        public ClassInfo(T data)
        {
            Data = data;
            Props = new Dictionary<string, string?>();
        }

        public void GetClassInfo()
        {
            var type = Data.GetType();
            var props = type.GetProperties();

            foreach (var item in props)
            {
                Props.Add(item.Name, item.GetValue(Data, null)?.ToString());

                Console.WriteLine($"{item.Name} / {item.GetValue(Data, null)?.ToString()} / {item.PropertyType.Name}");
            }
        }
    }

    public class A
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public double Price { get; set; }
    }


    public class B
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public decimal Score { get; set; }
    }
}
