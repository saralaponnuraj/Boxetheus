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