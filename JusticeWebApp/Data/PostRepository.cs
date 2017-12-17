using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JusticeWebApp.Data
{
    public class PostRepository : IPostRepository
    {
        PostContext _ctx;
        public PostRepository(PostContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Comment> GetComments()
        {
            return _ctx.Comments;
        }

        public IQueryable<Reply> GetRepliesByComment(int commentId)
        {
            return _ctx.Replies.Where(r => r.CommentId == commentId);
        }
    }
}