namespace _06_RepositoryPattern_Repository
{
    
    public enum GenreType
    {
        Horror = 1, RomCom, SciFi, Documentary, Comedy, Drama, Action, Bromance
            // enums have a numerical value for each different item. Default starts at 0.
            // We can reassign the starting position simply by setting a value to it as shown above with "Horror"
    }    
    
    // Plain Old C# Object --- POCO
    public class StreamingContent
    {
        // A simple class that is an object. It only holds data.
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }

        //ctor tab+tab to built out a quick constructor
        public StreamingContent( string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
        }
        
    }
}