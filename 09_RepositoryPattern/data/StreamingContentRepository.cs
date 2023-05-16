namespace Data;

public class StreamingContentRepository
{
    // Field that acts as our "Database" connection

    //READONLY because we don't want our collection reference to change
    //_contentDirectory has underscore at beginning because it is a PRIVATE FIELD
    private readonly List<StreamingContent>_contentDirectory = new List<StreamingContent>();

    //CREATE
    //Add to our list or CREATE a new data entry (starting with a method)
    public bool AddContentToDirectory(StreamingContent content) //StreamingContent type and parameter
    {
        //Check the state of the current directory
        int startingCount =_contentDirectory.Count;

         //Try to add the new content to the directory
         if(content.Title != null)
            {
                _contentDirectory.Add(content);
            }


        //Check to see that it worked and was added
        bool countIncreased = _contentDirectory.Count > startingCount;

        //Return a true/false based on the result
        return countIncreased;
    }

    //READ
    //adding methods

    public List<string> GetTitles()
    {
        // Declare a list to store the titles
        List<string> titles = new List<string>();
        //Add each title to that list (foreach loop)
        foreach(StreamingContent content in _contentDirectory)
        {
            //Add the title property to the list unless it's null
            //if it's null, add "untitled" to the list
           
            titles.Add(content.Title ?? "unknown");//was showing could be nullible so added the ?? and""
        }
        //Return our new list
        return titles;

        //this smaller bit of code would do the same thing as avove public List<string>GetTitle()
        //.Select is the C# equivalent of JS .map

       // return _contentDirectory.Select(content => content.Title ?? "Untitled").ToList();
    }

    public List<StreamingContent> GetDirectory ()
    {
        //Returns a reference to the readonly list
        //commented out
       // return _contentDirectory;


        //Creates a new List with the same content
        //Returns a reference to the the new list
        return new List<StreamingContent>(_contentDirectory);
    }

    //UPDATE

    //DELETE
}