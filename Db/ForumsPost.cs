using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ForumsPost
    {
        public ForumsPost()
        {
            ForumsPostVotes = new HashSet<ForumsPostVote>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string Ipaddress { get; set; }
        public int CustomerId { get; set; }
        public int TopicId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int VoteCount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ForumsTopic Topic { get; set; }
        public virtual ICollection<ForumsPostVote> ForumsPostVotes { get; set; }
    }
}
