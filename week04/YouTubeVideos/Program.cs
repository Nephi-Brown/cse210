class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The History of Sega", "Umar Mendoza", 3407);
        Video video2 = new Video("Scripture Study, 1 Nephi Chapters 13-16", "Everyday Sunday School", 415);
        Video video3 = new Video("Is chocolate good for you?", "MedicalMemes", 744);
        Video video4 = new Video("John Reviews - Mountains of the Medeteranian, by Fred Dukes", "John T Reacts", 1507);

        video1.AddComments(new Comment("Alice S.", "This was really interesting! You put a lot of work into the research."));
        video1.AddComments(new Comment("Robert F.", "You covered a lot of stuff I've never heard about before, but stuff felt a little rushed at times. Great video though."));
        video1.AddComments(new Comment("Charlie U.", "I learned a lot."));

        video2.AddComments(new Comment("Dave R.", "This was a bit too advanced for me."));
        video2.AddComments(new Comment("Evellyn E.", "Excellent explanations! This makes the chapters so much easier to understand."));
        video2.AddComments(new Comment("Frank O.", "Can't wait to try these techniques."));

        video3.AddComments(new Comment("Grace G.", "No. There, end of video."));
        video3.AddComments(new Comment("Heidi I.", "Clickbait title much? Videos good though."));
        video3.AddComments(new Comment("Ivan Y.", "Doesn't really feel like your name makes sense if your doing actual health content."));
        video3.AddComments(new Comment("Olivia C.", "It's a good video."));

        video4.AddComments(new Comment("Alice S.", "Pretty long video to not really say a lot."));
        video4.AddComments(new Comment("James K.", "Interesting, but not much more than if I just watched the actual thing."));
        video4.AddComments(new Comment("Lenny T.", "Well, by the end of this I don't really think I need to watch the original documentary."));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}