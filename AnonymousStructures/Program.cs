/*
 * - C#'da daha esnek ve okunaklı kod yazabilmek ve belirli senaryolarda isimlendirme gereksimini
 *  ortadan kaldırabilemk için anonymous kavramı geliştirilmişitir.
 * - Bizler bu kavram sayesinde ihtiyaç doğrultusunda ilgili yapılanmayı önceden tanımlanmaya gerek olmadan
 *   hızlıca proptotipleyip bu sayede sonuç odaklı çözümler getrirebilmekteyiz.
 */


#region Anonymous Objects

using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

var anonymousObject = new
{
    Name = "FD",
    Age = 25
};

// readonly olduğu için değeri değiştirilemez.
//anonymousObject.Name = "FD61";

#endregion

#region Anonymous Collections

var cols = new[] { 5, 89, -5 };
var lst = new Collection()
{
    new {Name = "FD", Age = 25},
    new {Name = "KD", Age = 27}
};

#endregion

#region Anonymous Methods

int Add_Function(int n1, int n2)
{
    return n1 + n2;
}

Add add_function1 = new Add((n1, n2) => n1 + n2);
Add add_function2 = (n1, n2) => n1 + n2;
Add add_function3 = Add_Function;
Add add_function4 = delegate (int n1, int n2)
{
    return n1 + n2;
};


var func1 = () => { Console.WriteLine("func1"); };                       // Action
var func2 = (string s) => { Console.WriteLine("func1"); };               // Action
var func3 = () => { return true; };                                      // Func
var func4 = (int n, string b) => { return n.ToString() == b; };          // Func


delegate int Add(int n1, int n2);

#endregion