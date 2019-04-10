# csvtest
csv import/export  test in C#

generic csv importer/exporter in dotnetcore2.2 using reflection.
abstracted csv processes into separate classes that are inherited by concrete classes.
this structure lends itself to unit testing the csv classes/methods (which is to be done).
the example is implemented as a console application. In normal circumstances this would be an MVC or a WEBapi app 
which would have DI/IOC built into startup.cs. 
I just wanted access to EF, so this was added directly to the console app rather than through services.
I used SQLite, rather than SQL Server driver, to simplify the demonstration.
The CSV classes implement int & string data types in order to demonstrate the implementation. 
Additional data types for float, decimal, date, etc to be added. 
