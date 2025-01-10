

using AdaptorPattern;



IPrinter obj=new AdapterPrinter(new LegacyPrinter());

obj.Print("Hello from modern printer");

