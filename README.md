## HTTP 5204, Winter 2021, Humber College.
### Assignment name : Passion Project
### Student Name: Jalaluddin Qureshi

**Task/ features Completed**
- [x] 1 One-to-Many relation with working CRUD.
- [x] 2 Table linked using Foreign Key 
- [x] 3 Regex Validation
- [x] 4 Searching by Keyword
- [x] 5 Filter by Food “Category”
- [x] 6 Sorting the result by Price

## Technical Notes
* Each app that will use the entity data model also requires the connection string that tells the Entity Framework how to connect to the database. The connection string is stored in the <connectionStrings> elements in the Web.config file.
  
* The libraries required for the projects are stored in the packages folder. In particular, the "EntityFramework" needs to be installed for the project as follow, 
  * Tools > NuGet Package Manager > Manage NuGet Packages for solution > Browse > Search "entityframework".
  
* LINQ allows you to write query expressions, similar to SQL queries, that retrieve information from a variety of data sources, not just databases.

* Javascript files are stored in the script folder.
  
* With an auto-implemented property, the C# compiler automatically creates a hidden private instance variable, and the get and set accessors for getting and setting that hidden instance variable. Therefore the variable names in the classes defined in the Model folder have the following, **{ get; set; }**.
  
* The .cs files in the Migration folder contain information about the changes made in the model file (SQL tables) during each migration.
  
* The DbSet<TEntity> class (in the DAL folder) represents a collection for a given entity within the model and is the gateway to database operations against an entity.
  
* The Content folder stores the .css files (including minimized version) and images used in the display.
  
## Screenshots
![regex](https://user-images.githubusercontent.com/58306478/110216087-2e6e7480-7e7b-11eb-9533-0c3a459baf6e.jpg)


![table-linked](https://user-images.githubusercontent.com/58306478/110216135-71c8e300-7e7b-11eb-8cd4-e56fa72f8aab.jpg)


![filter](https://user-images.githubusercontent.com/58306478/110216180-9de46400-7e7b-11eb-9ef6-87381a313c85.jpg)


![search](https://user-images.githubusercontent.com/58306478/110216204-c8ceb800-7e7b-11eb-8571-fa262dbab8f4.jpg)


![sorting](https://user-images.githubusercontent.com/58306478/110216229-eac83a80-7e7b-11eb-941b-0c1c24b5f1fb.jpg)


![delete](https://user-images.githubusercontent.com/58306478/110216321-83f75100-7e7c-11eb-9d21-4a82aaea8c48.jpg)

** References **
> Deitel, Paul, and Harvey Deitel. Visual C# how to program. Pearson, 2016.
