using System.Dynamic;

namespace ObjectCreation
{
    public class User : DynamicObject
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public User()
        {
            Console.WriteLine($"{nameof(User)} instance created");
        }

        private readonly Dictionary<string, object> props = new();

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            props.Add(binder.Name, value);
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return props.TryGetValue(binder.Name, out result);
        }

    }
}