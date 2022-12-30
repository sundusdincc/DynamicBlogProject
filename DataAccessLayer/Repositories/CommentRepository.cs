using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal
    {
        Context c = new Context();
        public void Delete(Comment comment)
        {
            c.Remove(comment);
            c.SaveChanges();
        }

        public Comment GetByID(int id)
        {
            return c.Comments.Find(id);
        }

        public List<Comment> GetListAll()
        {
            return c.Comments.ToList();
        }

        public void Insert(Comment comment)
        {
            c.Add(comment);
            c.SaveChanges();
        }

        public void Updete(Comment comment)
        {
            c.Update(comment);
            c.SaveChanges();
        }

        
    }
}
