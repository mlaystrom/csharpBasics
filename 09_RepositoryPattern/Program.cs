using Data; //Allows program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
Console.WriteLine(content.isFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;
Console.WriteLine(content.isFamilyFriendly);

