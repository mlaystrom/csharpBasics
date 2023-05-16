// Plain Old C# Object (POCO)
//This just represents the data object
//PROPERTIES only, not methods (define what the data looks like)

namespace Data;

//same name as our file
public class StreamingContent
{

    public StreamingContent(){
        MaturityRating = MaturityRating.Unrated;
    }
    public StreamingContent(string title, string genre, string description, double score, MaturityRating rating)
    {
        //PROPERTY = parameter;
        Title=title;
        Genre=genre;
        Description=description;
        UserScore=score;
        MaturityRating = rating;

    }
    //adding properties
    public string? Title { get; set; }

    public string? Genre { get; set; }

    public string? Description {get; set; }

    public double UserScore {get; set; }

    public MaturityRating MaturityRating {get; set; } //the enum info MaturityRating-Type MaturityRating-Name

    public bool isFamilyFriendly
    {
        get
        {
           switch (MaturityRating) 
           {
            case MaturityRating.G:
            case MaturityRating.PG:
            case MaturityRating.TV_Y:
            case MaturityRating.TV_G:
            case MaturityRating.TV_PG:
                 return true;
            case MaturityRating.PG_13:
            case MaturityRating.R:
            case MaturityRating.NC_17:
            case MaturityRating.TV_14:
            case MaturityRating.TV_MA:
           
            default:                //default added so that if there is an option that doesn't match, it does default (our else statement)
                return false;
           }
        }
           
    }


}

public enum MaturityRating
{
    G, PG, PG_13, R, NC_17, TV_Y, TV_G, TV_PG, TV_14, TV_MA, Unrated
}