using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Video List
        List<Video> videos = new List<Video>();

        // Initialize Videos & Add Comments
        Video videoOne = new Video("Cats and Dogs", "George Sutherland", 120);
        videoOne.MakeComment("Aww! How cute!", "Molly Pendleton");
        videoOne.MakeComment("Aww! Adorable!", "Sally Remington");
        videoOne.MakeComment("I really love that little black kitten!", "Georgia Lund");
        videoOne.MakeComment(
            "Ooh, where could I get a dalmation puppy like that!",
            "Wesley Grimes"
        );

        Video videoTwo = new Video("NFL Bloopers 2004", "Michael Smith", 360);
        videoTwo.MakeComment("Hahaha!", "Steve Rice");
        videoTwo.MakeComment("That is embarrassing!", "Riley Downes");
        videoTwo.MakeComment("Why can't the Jets draft a good QB!?!", "Devon White");
        videoTwo.MakeComment("That wideout got leveled!", "Norman Tuttle");

        Video videoThree = new Video("Wet N' Wild Kids", "Suzy Jones", 480);
        videoThree.MakeComment("Whoa!", "Jasper Lott");
        videoThree.MakeComment("Aww! Fun!", "Wendy Miles");
        videoThree.MakeComment("Go blue team!", "Dale Clark");
        videoThree.MakeComment("Hahaha! That was some wipeout!", "");

        Video videoFour = new Video("DIY Basement", "Frank Michaels", 1200);
        videoFour.MakeComment("Good heavens! That looks hard! Great job!", "Marcy Rollins");
        videoFour.MakeComment("I could to that better!", "");
        videoFour.MakeComment("Bookmarking for later.", "Harold Price");
        videoFour.MakeComment(
            "Blimey! That turned out better than I imagined it would.",
            "Blake Emory"
        );

        // Add The Videos To The List
        videos.Add(videoOne);
        videos.Add(videoTwo);
        videos.Add(videoThree);
        videos.Add(videoFour);

        // Iterate And Display Videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}
