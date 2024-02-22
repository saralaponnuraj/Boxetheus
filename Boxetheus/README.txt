Group: Theta 
Group Members: Sarala Ponnuraj
	       Dheeru Harshavardhan Rao Erabelly
	       Eshika Lad
Subject: - Web Application Security
Instructor: - Mr. Andrew Steele
===========================================================================================================================================================================
Discussion

Date: 15-02-2024
1434


Following our extensive research on the BOX product and subsequent development efforts for our web application, "Boxetheus,".
We included the following fields in our SQL database: Brand, Order Date, Category, Design, Shape, Size, Quality, and price. 

===========================================================================================================================================================================

Date: 18-02-2024
1042



web application implementation

Task 1:

Navigate to the new project dialogue, pick the ASP.NET Core web application with the model-view-controller architecture, and enter the project named Boxetheus. 

In the next stage, check the application's functionality by validating that it is running successfully.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 2:

Add the "BoxWorldController.cs" controller to the core. Perform the function and call it using the URL routing logic format identified in the "program.cs" file.

 To make use of scaffolding, right-click in the Solution Explorer's "Controllers" folder, select "Add > New Scaffolded Item," and then select "Controller - Empty." Click "Add" after entering the controller class name and confirming. 

Applying the [Route] attribute to the controller class or action methods will specify the routing logic. A parameter specifying the URL pattern is needed for the [Route] attribute.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 3:

Introduce the "--.cshtml" view, which generates HTML responses. Create a design for the homepage of the application.

Make a view for the HelloWorldController class's Index action method that shows the current date and time in addition to a greeting.

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

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Task 4:

To define the data model for the application, create a data model class in the Models folder. Furthermore, created a Boxview Context class in the Data folder that is a DbSet for the Movie model and represents the database context. This class is derived from DbContext.

started the migration process by choosing the Package Manager Console from the Tools menu, then NuGet Package Manager.

Launched the application and clicked the "Box App" link to confirm that it worked as intended. examined the registration of the generated database context class as well.

examined the "Initialcreate.cs" migration file to learn about its contents and ramifications.



===========================================================================================================================================================================

Date: 19-02-2024
0207

Task 5:
Utilize a database in a Boxetheus ASP.NET Core application.

Opened the SQL Server Object and examined the database using the view menu option .In the models folder, I made a new class called SeedData, changed the code, and added a new list of movies.

The code could see the list of movies seeded when it was executed because the seed initializer had been added and had replaced the contents of the program.cs class.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 6:
New action methods with search capabilities have been added to the controller that displays data. Based on the given search parameters, data extraction and filtering were improved.The relevant views were modified to incorporate a search form and efficiently display the search results.created and put into use an HTML search form that collects user input and uses it for searches inside the display.

Introduced an action method in the controller to manage form submissions. took the search query out of the form and used it to filter the data.enhanced data access logic to support search capabilities by implementing search logic. Based on the supplied search query, data was filtered, and the returning results were carefully examined.

Verified the search results that were shown and adjusted the view layout to properly display the results.Utilized Razor syntax to conditionally render the search results within the view.Rigorously tested the web application to ensure the search functionality operates as expected.


===========================================================================================================================================================================
Date: 20-02-2024

Task 7:
1010

Perform SQL operations by analyzing the database design and adding the ViewData class into the model. Improve basic functionality by introducing controller methods and views, and make any changes as needed. Increase security by adding the HttpPost property, which specifies that the method is only enabled for POST requests.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 8:
 Include the @model directive at the top of the view to signal that it expects the model to be used in the view templates. Add a search functionality to the index action method, letting users search for objects by name using a LINQ query. Increase the search capacity by including a genre search tool in the Index view.

Add the new field in the core. Mitigate the new field in the database
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 9:
Opened the ASP.NET Core MVC app in Visual Studio: Navigated to the Model Class: Identify and open the model class that corresponds to the data entity requiring validation.
Apply Data Annotations for Validation Within the model class, use data annotations (attributes) to define validation rules for the properties. For instance, use [Required] for mandatory fields, [StringLength] for maximum length, or custom annotations for specific requirements.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Observation:

ASP.NET Core allows developers to create custom validation logic, supports both client-side and server-side validation, and provides users with instant feedback. This gives users quick feedback on their input, which improves the user experience. In accordance with user choices, programs can show error messages in many languages thanks to the system's support for error message localization. This improves user experience and enables more seamless integration with other systems.
Quick Responses to Users: By adding validation, the user experience is improved as users receive quick feedback on their input.
I could become more knowledgeable about server-side and client-side validation. Both client-side and server-side validation are supported by ASP.NET Core. Client-side validation is mainly managed via data annotations, whereas server-side validation makes sure that the data is intact on the server.
Custom Validation Logic: In addition to normal annotations, custom validation logic enables developers to apply certain business rules.
Localization of Error Messages: ASP.NET Core Boxetheus allows apps to display error messages in many languages according to user preferences.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2024-02-22

Added images to the home page, create, edit , details and privacy page





