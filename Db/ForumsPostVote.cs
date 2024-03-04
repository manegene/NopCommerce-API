using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ForumsPostVote
    {
        public int Id { get; set; }
        public int ForumPostId { get; set; }
        public int CustomerId { get; set; }
        public bool IsUp { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ForumsPost ForumPost { get; set; }
    }
}
