using Intro.Busines;
using Intro.Entities;

Console.WriteLine("Hello, World!");

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs...";
//course1.Price = 10;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java 17 vs...";
//course2.Price = 5;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12 vs...";
//course3.Price = 15;

//Course[] courses = {course1, course2, course3};

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / "+ courses[i].Price + "TL");
//}

Console.WriteLine(" ");

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price + "TL");
}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678901";
customer1.FirstName = "Çağdaş";
customer1.LastName = "ÖZER";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.NationalIdentity = "12345678902";
customer2.FirstName = "Ulaş";
customer2.LastName = "ÖZER";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaİo";
customer3.CustomerNumber = "123789";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ÖzerRent";
customer4.CustomerNumber = "123987";
customer4.TaxNumber = "1234567891";


//int n1 = 10;
//int n2 = 20;
//n1 = n2;
//n2 = 50;
//Console.WriteLine(n1);

//value types --> int, bool, double...

//string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
//string[] cities2 = { "Bursa", "Erzurum", "Erzincan" };

//cities2 = cities1;
//cities1[0] = "Adana";

//Console.WriteLine(cities2[0]);

//referance types --> array, class, interface...

                              //101        //102      //103       //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}