# Ringtones Web Project With .Net
 This repository contains the source code of a website that retrieves data from a database. It was made with MVC architecture using .Net and unit testing is performed on a certain unit in the project.

 ## Overview
 Using .NET MVC and database integration, I adapted a ready-made website template to my needs. This gave my site a dynamic feel and allowed me to provide users with a more personalized experience.
 I used a Code-First approach to this project.
 I used the W3Layouts site to download a ready-made template for the project.
 In summary, this project retrieves content from the database and this data is used to customize and make dynamic the desired areas of a website. Model view controller architecture was used in the project.
 I used microsoft sql server as database.

 ## Description of web-site
 This site is a simple music site. It retrieves content related to the music offered to customers from the database. The customer can listen to the music he wants on the site, if she/he wants to buy it, she/he adds it to her/his cart and proceeds with the payment process. If the payment process is successful, the music can be downloaded.

 ## Unit Testing Implementation
 Additionally, the project tests a controller method in an ASP.NET MVC application. The relevant test tests the Index method in the HomeController class.

Arrange (Preparation): At the beginning of the test, an instance (controller) of the HomeController class is created. This creates an instance of the controller class you want to test.

Act: Then the Index method is called and its result is assigned to the result variable.

Assert: Using the Assert.IsInstanceOfType method, it is verified whether the result variable is a ViewResult type. So the Index method should return a view result.

The main purpose of this test is to verify whether the Index method returns the expected type of result. When a result of type ViewResult is received, this usually indicates that the controller method returned an HTML view.

## Pdf File
You can see what the entire software engineering process requires for this project in the pdf file. There, the methodologies used, requirements analysis, models and more are specified.

