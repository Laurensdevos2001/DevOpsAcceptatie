using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using Oogarts.Domain.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Diseases
{
    public class Disease : Entity
    {
        private int authorid = default!;
        public int AuthorId
        {
            get => authorid;
            set => authorid = Guard.Against.Null(value, nameof(authorid));
        }

        private string content = default!;
        public string Content
        {
            get => content;
            set => content = Guard.Against.NullOrWhiteSpace(value, nameof(content));
        }
        private string name = default!;
        public string Name
        {
            get => name;
            set => name = Guard.Against.NullOrWhiteSpace(value, nameof(name));
        }

        private Disease() { }

        public Disease(int authorid, string content, string name)
        {
            AuthorId = authorid;
            Content = content;
            Name = name;
        }
    }
}
