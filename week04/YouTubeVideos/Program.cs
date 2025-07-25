using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //DIY video
        Video DyiVideo = new Video(
            "Turn Old Jeans into a Stylish Tote Bag!",
            "CraftyLena",
            560);

        DyiVideo.AddComment(new Comment(
            "MayaDIYQueen",
            "Quick, fun and SO cute. I’m making these for gifts!"));

        DyiVideo.AddComment(new Comment(
            "JulesTheMaker",
            "This saved my weekend! My old Levi’s just found a second life"));

        DyiVideo.AddComment(new Comment(
            "GrannyGina",
            "My granddaughter helped me make one and she loved it, thank you!"));

        videos.Add(DyiVideo);

        //Video game video
        Video VideoGameVideo = new Video(
            "Beating Elden Ring Without Taking a Single Hit",
            "NeoPlayz",
            28800);

        VideoGameVideo.AddComment(new Comment(
            "PixelWarrior",
            "This guy dodged better than my WiFi avoids working "));

        VideoGameVideo.AddComment(new Comment(
            "GameOverTony",
            "Watched this with my jaw on the floor the whole time."));

        VideoGameVideo.AddComment(new Comment(
            "NerdyNicole",
            "Okay but HOW?? I can't even get past the first boss"));

        videos.Add(VideoGameVideo);

        //Band video
        Video BandVideo = new Video(
            "Midnight Wolves – Live at Sunset Stage (Full Set)",
            "SoundStorm Media",
            521);

        BandVideo.AddComment(new Comment(
            "LeoRiffs",
            "That solo at 05:01 gave me chills. Pure fire"));

        BandVideo.AddComment(new Comment(
            "IndieIvy",
            "Saw them live once — this video doesn’t even capture HALF the magic."));

        BandVideo.AddComment(new Comment(
            "GigGoat99",
            "Underrated band. Mark my words, they’ll blow up soon."));

        videos.Add(BandVideo);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine("---------------------------");
        }
    }
}