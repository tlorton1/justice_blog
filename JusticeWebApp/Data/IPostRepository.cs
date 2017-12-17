using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JusticeWebApp.Data
{
    public interface IPostRepository
    {
        IQueryable<Comment> GetComments();
        IQueryable<Reply> GetRepliesByComment(int commentId);
    }
}
