## Factory-Method Design Patterns

This .Net C# project demonstrates "Factory Method" design pattern and is inspired by the book -   
	-------------------------------------------------------------------  
	Freeman, Eric; Robson, Elisabeth; Bates, Bert; Sierra, Kathy.   
	Head First Design Patterns: A Brain-Friendly Guide. O'Reilly Media.  
	-------------------------------------------------------------------

### Pattern Definition

The Factory Method Pattern defines an interface for creating an object, 
but lets subclasses decide which class to instantiate. 
Factory Method lets a class defer instantiation to subclasses.

### The Project Main Code Units

"GenreFactory" class has factory method "GetMoodGenre", 
	and this method create and returns "Genre" object. 
"AlbumFactory" has factory method "GetGenreAlbum", 
	and this method create and returns "Album" object.

### Additional Info

This project has clear and intuitive user interface.
