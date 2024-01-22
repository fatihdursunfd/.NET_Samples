// Class, Interface, Struct, Record, Method ve Delegate'lere uygulanabilir

using Generics;

var dStoreInt = new DataStore<int>();
dStoreInt.Data = 61;
Console.WriteLine(dStoreInt.ToString());

var dStoreString = new DataStore<string>();
dStoreString.Data = "FD";
Console.WriteLine(dStoreString.ToString());

var a = new A()
{
    Id = 1,
    Price = 100,
    Title = "FD"
};

var b = new B()
{
    Id = Guid.NewGuid(),
    Age = 25,
    Name = "Fatih",
    Score = 100,
};


var classInfo_A = new ClassInfo<A>(a);
Console.WriteLine("Info of class A : ");
classInfo_A.GetClassInfo();


var classInfo_B = new ClassInfo<B>(b);
Console.WriteLine("Info of class B : ");
classInfo_B.GetClassInfo();

Console.ReadKey();