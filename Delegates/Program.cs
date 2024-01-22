/*
 *  C#'da delegateler metotları temsil eden yapılardır.
 *  Metotların referanslarını temsil etmektedirler.
 *  Delegate'ler üzerinden metotlara erişebilmemize ve tekikleyebilmemize imkan tanımaktadırlar.
 *  Delegate'ler her ne kadar public olarak tanımlanmış olsalar da tanımladıkları sınfıların instance'ları üzerinden erişilememektedir.
 *  Kullanım amaçları : 
 *  1 ) Callback işlemleri
 *  2 ) Event based programing
 *  3 ) Fonksiyon parametreleri
 *  4 ) Dinamik metot atamaları 
 *  
 *  Önceden tanımlanmış delegate'ler ?
 *  Action : Parametre almayan ve geri dönüş değeri olmayan metotları temsil eden önceden tanımlanmış bir delegate'dir.
 *  Action<T> : Generic parametre alan ve geri dönüş değeri olmayan metotları temsil eden önceden tanımlanmış bir delegate'dir.
 *  Func : Generic olarak belirlenmiş tür(ler)'den parametre(ler)'i alan ve yine generic olarak belirlenmiş bir türde geriye 
 *         değer döndüren metotları temsil eden bir delegate'dir.
 *  Predicate : Generic parametreye verilen türde bir parametre alan ve geriye boolean sonuç döndüren metotları temsil eden bir delegate'dir
 */


#region Delegates

void XMethod()
{
    Console.WriteLine("X method run");
}

void AMethod()
{
    Console.WriteLine("A method run");
}

void BMethod()
{
    Console.WriteLine("B method run");
}

X_Handler x_delegate1 = new X_Handler(XMethod);

X_Handler x_delegate2 = XMethod; // Instance compiler tarafından oluşturulur

X_Handler x_delegate3 = new X_Handler(() =>
{
    Console.WriteLine("X method run");
});

X_Handler x_delegate4 = delegate
{
    Console.WriteLine("X method run");
};

Y_Handler y_delegate = (a, b) =>
{
    return (b * 5, a[0]);
};

// delegate'leri çalıştırma

x_delegate1();
(int, char) result = y_delegate.Invoke("fd", 61);

Console.WriteLine($"{result.Item1} / {result.Item2}");

#endregion

#region Multicast Delegates

// bir delegate'e birden fazla metot eklenebilir

A_Handler ab_delegate = AMethod;
ab_delegate += BMethod;

ab_delegate.Invoke();

#endregion

#region Get Method Names

var methods = ab_delegate.GetInvocationList();
foreach (var method in methods)
{
    Console.WriteLine(method.Method.Name);
}

#endregion

#region Generic delegate

Z_Handler<Guid, string, int, string> z_delegate = (x, y, z) => $"id : {x} / username : {y} / age : {z}";
var response = z_delegate(Guid.NewGuid(), "fd", 61);
Console.WriteLine(response);

#endregion

#region Action 

Console.WriteLine("*********************************");

Action action = () => Console.WriteLine("Action");

Action<string> action1 = (a) => Console.WriteLine("Action<T>");

Action<string, int> action2 = (a, b) => Console.WriteLine("Action<T1, T2>");

action();
action1("fd");
action2("fd", 61);

#endregion

#region Func

Console.WriteLine("*********************************");
Console.WriteLine("Func");

Func<int, string> func = (a) => a.ToString();

Func<int, int, bool> func1 = (a, b) => a == b;

var func_result = func(1);
Console.WriteLine(func_result);

var func_result1 = func1(2, 5);
Console.WriteLine(func_result1);

#endregion

#region Predicate

Console.WriteLine("*********************************");
Console.WriteLine("Predicate");

Predicate<int> predicate = (b) => b == 61;

var predicate_response = predicate(1);
Console.WriteLine(predicate_response);

#endregion

#region Lambda Discard Parameters

Func<int, int, string, char> func3 = (_, _, _) => 's';

#endregion


// Metot imzaları

public delegate void A_Handler();
public delegate void B_Handler();
public delegate void X_Handler();
public delegate (int, char) Y_Handler(string a, int b);
public delegate T4 Z_Handler<T1, T2, T3, T4>(T1 a, T2 b, T3 c);