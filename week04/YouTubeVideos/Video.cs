using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // in seconds
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
            Console.WriteLine($"Comments ({GetCommentCount()}):");
            foreach (var comment in Comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine();
        }
    }
}
