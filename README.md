# SpaceLaunches
A sample solution shows how to connect to another API using ASP.NET API Controller

This will pull the next 5 space launches from the public API of https://launchlibrary.net/
Another page can display some details of 5 rockets with the wiki links and thumbnail pictures with links to the full-sized picture of the rocket.

Although the public API can be consumed directly, the frontend is calling the internal API which in turn calls the public API, process it and then send the result back to the UI.

This project uses the following technologies:
1. C#
2. ASP.NET Core 2.1
3. Angular 7
4. Bootstrap 3
