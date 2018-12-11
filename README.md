# CSUN Comp586 - OO Software Dev

## Final Project - Prison Love

Prison Love is a SPA dating app powered by Angular for frontend and .NET Core API for backend. Its where inmates come to find love.

## [Live Demo](https://datingappapi20181211122529.azurewebsites.net)

## Requirements Met (All):

1. MVC architecture including routing - MVC is built in to .net core api and angular by default, routing is handled on angular side via angular         router for the various anguar member components, view DatingApp.API/src/app/routes.ts and each component for implementation.
2. Object-Relational Model (ORM) - ORM was handled on api side via Entity Framework Core and the database used for Sqlite3, it handles the saving       of users, photos, messages, likes. The tables also have the requested one to many relationship.
3. Single-Page Application (SPA) - The SPA frontend is done via Angular. There are various components and services added on angular side that make      get/post calls which hits the controllers on the api side.
4. Dependency Injection (DI) - This is inherintly built into .net core and angular, many of the providers and modules can only be used via              injecting them into the module constructor which would make it available throughout the module .ts class. Api side, transient DI was used.
5. Authentication using JWT - For authentication, the angular app checks to see if the token is present and valid before allowing into parts of the     app such as members and such. Additionally, a JWT token gets sent up with every request because parts of the API are for authorized users only      and will return value only if the bearer token is included in the header.

## Additional Requirements:
1. Authorization was also implemented on the api controller side, for example view the UsersController in DatingApp.API/Controllers
2. OOP Patterns used - Repository pattern was used with an interface and a provided implementation, and DTO Pattern. The data transfer object           pattern was used to send the the login info such as username and password to the controller, it is useful when we want to pass multiple             attributes in a single shot.
3. AutoMapper was also used to map the full User class class to two slightly modified User classes, one for simple card view on angular side and        second one for a more detailed page.

### Instructions
-   Provided username and password to test: chris, password
-   Users can register themselves, passwords have to be between 5 and 20 characters.
-   Once logged in, the user can go to the Matches/List/Messages section as shown in the Nav bar.
-   Only the Matches section was worked on for this project due to time constraints. 
-   In the Matches section, you can hover over various inmates and then click on the image or person icon to go into the detailed member page.
-   In the detailed member page, you can see tabs with more detailed info regarding those persons.
-   If you created your own login, the member page includes some pre filled info. In the future there would be a way to edit the info yourself.

### Tutorial Followed: <i>Build an app with ASPNET Core and Angular from scratch</i> by Neil Cummings
