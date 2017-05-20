# Notes API

This is a RESTful API that allows you to store and retrieve notes. 

# Setup

1. Install microsoft .net core:
2. Clone this repository
3. Open command line
4. Run the following commands:
    1. cd [Cirectory with the .csproj file]
    2. dotnet restore
    3. dotnet run
6. Open a browser window with the port specified 

# API
##### Note Model

`{
 "id" : 1,
 "body" : "Ask Larry about the TPS reports."
}`

##### Create a new note

`POST /api/notes
BODY a note
Returns: a saved note...` 

##### Get an existing note

`GET /api/notes/{id}
Returns: the requested note..`

##### Get all of my notes

`GET /api/notes
Returns: A list of my notes`

##### Get all of my notes with some body text

`GET /api/notes?query=bodyText
Returns: A list of my notes`