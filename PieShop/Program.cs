
using PieShop;

Console.WriteLine("~Creating Employee~");
Console.WriteLine("|-----------------|\n");

Employee bethany = new Employee("Bethany", "Smith", "email@email.com", 25, new DateTime(2000, 1, 16));

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);

double receivedWage = bethany.ReceiveWage(true);
Console.WriteLine(receivedWage);

Console.WriteLine("~Creating Employee~");
Console.WriteLine("|-----------------|\n");

Employee george = new Employee("George", "Smith", "email@email.com", 15, new DateTime(2001, 12, 16));

george.DisplayEmployeeDetails();


//sdvsdbvdfbsdfvbsdfbnsdhbsdfgsdf