using OperatorOverloading;

var user = new User()
{
    Name = "Fatih",
    Email = "fatih.dursun.616@gmail.com"
};

var id = Guid.NewGuid().ToString();
var isEqual = user == id;

Console.WriteLine(isEqual);

id = user.Id.ToString();
isEqual = user == id;

Console.WriteLine(isEqual);