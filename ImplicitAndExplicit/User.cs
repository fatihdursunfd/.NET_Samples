namespace ImplicitAndExplicit
{

    /* 
    
    In C#, implicit and explicit operators are used to convert one data type to another.
    Implicit operators are used when the conversion is guaranteed to succeed without data loss. 
    Explicit operators are used when the conversion might result in data loss or when the conversion is not guaranteed to succeed.

    
     * Implicit :
    Implicit operators are used to convert a data type to another data type without explicit user intervention. 
    Implicit conversions are performed automatically by the compiler. Implicit conversions are safe and do not result in data loss.    
    

     * Explicit :
    Explicit operators are used to convert a data type to another data type with explicit user intervention. 
    Explicit conversions are performed using a cast operator. Explicit conversions can result in data loss or throw an exception if the conversion is not possible.
    
     */

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;

        public static implicit operator Employee(User instance)
        {
            return new Employee()
            {
                Id = instance.Id.ToString(),
                FullName = $"{instance.Name} {instance.Surname}",
                Email = instance.Email,
            };
        }

    }

    public class Employee
    {
        public string Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public static explicit operator User(Employee instance)
        {
            return new User()
            {
                Id = new Guid(instance.Id),
                Name = instance.FullName.Split(' ')[0],
                Surname = instance.FullName.Split(' ')[1],
                Email = instance.Email,
            };
        }
    }
}
