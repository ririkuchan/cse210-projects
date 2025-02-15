using System;

namespace YouTubeVideos
{
    public class Comment
    {
        public string Username { get; set; }
        public string Content { get; set; }

        public Comment(string username, string content)
        {
            Username = username;
            Content = content;
        }

        public void DisplayComment()
        {
            Console.WriteLine($" - {Username}: {Content}");
        }
    }
}
