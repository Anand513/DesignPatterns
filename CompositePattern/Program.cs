using CompositePattern;

Developer d1 = new Developer("Anand");
Developer d2 = new Developer("Dinesh");
Designer d3 = new Designer("Rajesh");

Manager teamlead = new Manager("David");
Manager departmentHead = new Manager("Siva");

teamlead.Add(d1);
teamlead.Add(d2);
teamlead.Add(d3);

departmentHead.Add(teamlead);

departmentHead.showdetails(2);
