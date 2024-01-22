using ObjectCreation;
using Shared;
using System.Dynamic;

/*
 * Runtime'da dinamik olarak nesne üretmek istenildiği zaman aşağıkdai yöntemler kullanılabilir.
 * Expando Object : 
 * - C#'da dinamik olarak genişletebilir ve şekillendirilebilir nesneler oluşturabilmek için kullanılan bir sınıftır.
 * - Bu sınıf sayesinde, bir object'i genişletebilir, içereisine property ve method eklemee, kaldırma ve değiştirme 
 *   gibi işlemleri yürütebiliriz.
 *  Kullanım amaçları :
 *  1) Dinamik veri yapıları oluşturma
 *  2) Dinamik özellik ekleme
 *  3) Geçici veri saklama
 *  4) Dinamik uygulama geliştirme
 */



// Activator

Type type = typeof(User);
var user = (User)Activator.CreateInstance(type);


// Dynamic

dynamic instance = new User();

// dynamic olarak class'da olmayan prop'ları eklemek
instance.DynamicProperty1 = 61;
instance.DynamicProperty2 = "fd";

Console.WriteLine(instance.DynamicProperty1);
Console.WriteLine(instance.DynamicProperty2);


// ExpandoObject

dynamic obj = new ExpandoObject();
obj.Id = Guid.NewGuid();
obj.UserName = "fd61";
obj.Password = Security.GeneratePassword();
obj.Age = 25;

obj.GetBirthDate = new Func<DateTime>(() => DateTime.Now.AddYears(-obj.Age));

IDictionary<string, object> data = (IDictionary<string, object>)obj;

foreach (KeyValuePair<string, object> item in data)
{
    Console.WriteLine($"Key : {item.Key} / Value : {item.Value} ");
}


Console.ReadKey();