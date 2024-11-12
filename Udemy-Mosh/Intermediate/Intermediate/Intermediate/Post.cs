namespace Intermediate
{
    public class Post
    {
        public string Title;
        public string Description;
        public DateTime PostTime;
        public readonly List<Vote> Votes = new List<Vote>();

        public Post(string title, string description, DateTime postTime)
        {
            this.Title = title;
            this.Description = description;
            this.PostTime = postTime;
            
        }


    }
    
}
