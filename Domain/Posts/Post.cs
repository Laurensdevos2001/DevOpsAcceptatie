using Ardalis.GuardClauses;
using Oogarts.Domain.Accounts;
using Oogarts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Posts
{
    public class Post : Entity
    {
        private Account author = default!;
        public Account Author
        {
            get => author;
            set => author = Guard.Against.Null(value, nameof(Author));
        }
        private string content = default!;
        public string Content
        {
            get => content;
            set => content = Guard.Against.NullOrWhiteSpace(value, nameof(Content));
        }
        private string title = default!;
        public string Title
        {
            get => title;
            set => title = Guard.Against.NullOrWhiteSpace(value, nameof(Title));
        }

        private string introduction = default!;

        public string Introduction
        {
            get => introduction;
            set => introduction = Guard.Against.NullOrWhiteSpace(value, nameof(Introduction));
        }

        private string image = default!;
        public string Image
        {
            get => image;
            set => image = Guard.Against.Null(value, nameof(image));
        }
        private Post() { }

        public Post(Account author, string content, string title, string introduction, string image)
        {
            Author = author;
            Content = content;
            Title = title;
            Introduction = introduction;
            Image = image;
        }
    }
}
