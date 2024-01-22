using ImplicitAndExplicit;

// implicit

//CustomDay cd = new CustomDay(3);
//int day = cd;

//day = 5;
//cd = day;

// explicit

CustomDay cd = new CustomDay(3);
int day = (int)cd;

day = 5;
cd = (CustomDay)day;


int i1 = 10;
double d1 = i1;                // implicit
long l1 = i1;                  // implicit
long l2 = long.MaxValue;       
int l2Toi3 = (int)l2;          // explicit


var employee = new Employee()
{
    Id = Guid.NewGuid().ToString(),
    Email = "fatih.dursun.616@gmail.com",
    FullName = "Fatih Dursun"
};

var user = (User)employee;     // implicit

user = new User()
{
    Id = Guid.NewGuid(),
    Email = "fatih.dursun.616@gmail.com",
    Name = "Fatih",
    Surname = "Dursun"
};

employee = user;               // explicit

Console.ReadKey();