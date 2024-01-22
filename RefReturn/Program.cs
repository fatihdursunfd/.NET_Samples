int x = 5;
Console.WriteLine($"First value of x : {x}");
X(x);
Console.WriteLine($"Last value of x : {x}");

void X(int a)
{
    a = 61;
}

var y = 10;
Console.WriteLine($"First value of x : {y}");
Y_ref(ref y);
Console.WriteLine($"Last value of x : {y}");

void Y_ref(ref int a)
{
    a = 61;
}

var z = 10;
Console.WriteLine($"First value of x : {z}");
z = Z_ref_return(ref z);
Console.WriteLine($"Last value of x : {z}");

ref int Z_ref_return(ref int a)
{
    a = 61;
    return ref a;
}


int a = 16;
ref int b = ref a;
Console.WriteLine($"First value of b : {b}");
a = 61;
Console.WriteLine($"Last value of b : {b}");

Console.ReadKey();