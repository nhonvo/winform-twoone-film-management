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
    internal class DirectorBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<DaoDien> DirectorDAO = new GenericDAO<DaoDien>(db);
        public List<DaoDien> DirectorList => DirectorDAO.Entities.ToList();
        public object GetAll() => DirectorDAO.Entities.Select(x => new { ID = x.MaDaoDien, Name = x.TenDaoDien, Image = x.HinhAnhDaoDien }).ToList();
        public DaoDien Find(int id) => DirectorDAO.Find(id);
        public void Insert(DaoDien newDirector) => DirectorDAO.Insert(newDirector);
        public void Update(DaoDien updateDirector) => DirectorDAO.Update(updateDirector);
        public void Delete(DaoDien deleteDirector) => DirectorDAO.Delete(deleteDirector);
        public void Save() => DirectorDAO.SaveChanges();
 public object LoadData(int pageNumber, int numberRecord) => DirectorDAO.Entities.OrderBy(x => x.MaDaoDien).Select(
            x => new {
                ID = x.MaDaoDien,
                Name = x.TenDaoDien,
                Image = x.HinhAnhDaoDien
            }).Skip((pageNumber - 1) * numberRecord).Take(numberRecord).ToList();
    }
}
