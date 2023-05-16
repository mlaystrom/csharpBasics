using Data; //Allows program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
content.Title= "The SpongeBob Movie"; 

Console.WriteLine(content.isFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;  //changing the maturity rating to show property changes to reflect
Console.WriteLine(content.isFamilyFriendly);


StreamingContentRepository repository = new StreamingContentRepository();

bool wasAdded = repository.AddContentToDirectory(content);//streaming content that added earlier (near top)

Console.WriteLine(wasAdded ? "The content was added" : "The content was not added"); //shows after added Title of "SpongeBob Movie" that is was added