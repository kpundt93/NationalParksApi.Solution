# National Parks API

#### By: Katie Pundt

#### _An API with basic details about US National Parks._

## Technologies Used
* C#
* .NET5
* NuGet
* ASP.NET Core
* Swagger
* git
* GitHub
* MySQL
* MySQL Workbench

## Description
_An API to look up basic information about US National parks. Users can filter results by state, park name, keywords, and if they've visited that park._

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kpundt93/NationalParksApi.Solution.git`
* After cloning the project, navigate into it using the command `cd NationalParksApi.Solution/NationalParksApi`
* Create a file named "appsettings.json" in the `NationalParksApi` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=katie_pundt;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to start the server

## Swagger Documentation
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) for automated documentation. You can also use Swagger to test out queries.

### Swagger Instructions:
* Navigate to http://localhost:5000/index.html to access Swagger and view API endpoints
* Test out queries by clicking on the "Try It Out" button, enter your query in the form and click the "Execute" button to view responses
* Note: the server must be running to access Swagger and test out queries

## API endpoints
#### HTTP Requests
```
GET /api/Parks
POST /api/Parks
GET /api/Parks{id}
PUT /api/Parks{id}
DELETE /api/Parks{id}
```
#### Parameters
| Parameter | Type | Description |
| --- | --- | --- |
| Name | string | Returns any park by name |
| State | string | Returns parks located in that state |
| Visited | string | Returns parks based on if they've been visited by the user |
| Description | string | Returns a short description of the park when given a keyword (ex: volcano, alpine, etc) |

#### Example Query
```
localhost:5000/api/parks?state=or
```
#### Sample JSON
```
[
  {
    "parkId": 1,
    "name": "Crater Lake",
    "state": "OR",
    "description": "Crater Lake lies in the caldera of Mount Mazama formed 7,700 years ago after an eruption. It is the deepest lake in the United States and is known for its blue color and water clarity. There are two islands in the lake, and, with no inlets or outlets, all water comes through precipitation.",
    "visited": "Yes"
  }
]
```

## Known Bugs
* No known bugs

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2022_ _Katie Pundt_
