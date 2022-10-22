using MovieWinform.DAO;
using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinform.BUS
{
    internal class HashTagBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<HashTag> HashTagDAO = new GenericDAO<HashTag>(db);
        public object GetAll() => HashTagDAO.Entities.Select(x => new
        {
            ID = x.MaHashTag,
            Name = x.TenTag
        }).ToList();
        public List<HashTag> HashTagList => HashTagDAO.Entities.ToList();
        public HashTag Find(int id) => HashTagDAO.Find(id);
        public void Insert(HashTag newHashTag) => HashTagDAO.Insert(newHashTag);
        public void Update(HashTag updateHashTag) => HashTagDAO.Update(updateHashTag);
        public void Delete(HashTag deleteHashTag) => HashTagDAO.Delete(deleteHashTag);
        public void Save() => HashTagDAO.SaveChanges();
    }
}
