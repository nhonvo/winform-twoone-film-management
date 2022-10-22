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
    internal class ActorBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<DienVien> actorDAO = new GenericDAO<DienVien>(db);
        public List<DienVien> Actors => actorDAO.Entities.ToList();
        public object GetAll() => actorDAO.Entities.Select(x => new { ID = x.MaDienVien, Name = x.TenDienVien, Image = x.HinhAnhDienVien }).ToList();
        public DienVien Find(int id) => actorDAO.Find(id);
        public void Insert(DienVien newactor) => actorDAO.Insert(newactor);
        public void Update(DienVien updateactor) => actorDAO.Update(updateactor);
        public void Delete(DienVien deleteactor) => actorDAO.Delete(deleteactor);
        public void Save() => actorDAO.SaveChanges();
        public object LoadData(int pageNumber, int numberRecord) => actorDAO.Entities.OrderBy(x => x.MaDienVien).Select(
            x => new { ID = x.MaDienVien, 
            Name = x.TenDienVien, 
            Image = x.HinhAnhDienVien }).Skip((pageNumber - 1) * numberRecord).Take(numberRecord).ToList();

    }
}
