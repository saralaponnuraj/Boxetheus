2024-02-18

The controller class named as "HelloWorldController".
To use the scaffolding(tools) feature, right-clicked the Controllers folder in the Solution Explorer and selected Add > New Scaffolded Item. Then, select MVC Controller - Empty and clicked on Add. Entered the name of the controller class and click Add again. 
To specify the routing logic, use the [Route] attribute on the controller class or the action methods. The [Route] attribute takes a parameter that defines the URL pattern

2024-02-18 10:42PM
Create a view for the Index action method of the HelloWorldController class that displays a welcome message and the current date and time.

Problems:
How to create a view file and associate it with a controller action method?
How to use Razor syntax to write dynamic HTML code in the view file?
How to pass data from the controller to the view?

Solutions:

1. In the Solution Explorer, right-click on the Views folder and select Add > New Folder. Named the folder as `HelloWorld`.
2. Right-clicked on the `HelloWorld` folder and selected Add > New Item.
3. In the Add New Item dialog, selected Show All Templates.
4. In the search box in the upper-right corner, entered `view`.
5. Then Selected Razor View - Empty and kept the default name `Index.cshtml`.
6. Replaced the contents of the `Views/HelloWorld/Index.cshtml` Razor view file.
7. In the `HelloWorldController` class, replaced the `Index` method.

Part 4, add a model to an ASP.NET Core MVC app
Add a model to an ASP.net Core MVC app
1) Added a data model class : A Movie class is created in the Models folder to represent the data model for the application and in MovieContext class, derived from DbContext, is created in the Data folder. This class represents the database context and includes a DbSet for the Movie model.
2) Initiated the Migration from tools menu selected NuGet Package Manager and chosen Package Manager Console.
3) Tested the app by running the app and by selecting the Movie App link and examined the generated database context class and registration.
4) Examined the Migration Initialcreate.cs migration file 

Part 5, Work with a database in an ASP.NET Core MVC app
1) Examined the database from view menu option opened the SQL Server Object 
2) Created a new class named SeedData in the models folder and replaced the code and added new movie list.
3) Added the seed initializer replaced the contents of program.cs class and when executed the code could see the list of movie seeded in the code.