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
    internal class GenreBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<TheLoai> GenreDAO = new GenericDAO<TheLoai>(db);
        public object GetAll() => GenreDAO.Entities.Select(x => new { ID = x.MaTheLoai, Name = x.TenTheLoai }).ToList();
        public List<TheLoai> GenreList => GenreDAO.Entities.ToList();
        public TheLoai Find(int id) => GenreDAO.Find(id);
        public void Insert(TheLoai newGenre) => GenreDAO.Insert(newGenre);
        public void Update(TheLoai updateGenre) => GenreDAO.Update(updateGenre);
        public void Delete(TheLoai deleteGenre) => GenreDAO.Delete(deleteGenre);
        public void Save() => GenreDAO.SaveChanges();
    }
}
