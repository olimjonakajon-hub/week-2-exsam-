public class Post
{
    public string Title { get; set; } = null!;
    public string Description { get; set; }= null!;
    public int LikeCount { get; set; }
    public List<string> Comments { get; set; }
    public bool IsPublished { get; set; }

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
        LikeCount = 0;
        Comments = new List<string>();
        IsPublished = false;
    }

    public void Publish()
    {
        IsPublished = true;
        System.Console.WriteLine("The post is published");

    }
      public void Like()
    {
        LikeCount++;
    }

    public void Comment(string m)
    {
        Comments.Add(m);
    }


    public void Likes()
    {
        LikeCount++;
    }
    
    public void Commente(string e)
    {
        Comments.Add(e);
    }

}