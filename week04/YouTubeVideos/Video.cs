class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of Comments: {CommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.CommenterName()}: {comment.CommentText()}");
        }
        Console.WriteLine();
    }
}