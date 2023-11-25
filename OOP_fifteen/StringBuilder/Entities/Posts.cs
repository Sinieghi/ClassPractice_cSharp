using System.Text;

namespace Proj
{
    class Posts
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = [];

        public Posts()
        {

        }
        public Posts(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comments comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comments comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder s = new();
            s.AppendLine(Title);
            s.Append(Likes);
            s.Append(" Likes - ");
            s.AppendLine(Moment.ToString("dd/MM/yyy HH:mm:ss"));
            s.AppendLine(Content);
            s.AppendLine("Comments: ");
            foreach (Comments c in Comments)
            {
                s.AppendLine(c.Text);
            }
            return s.ToString();
        }
    }
}