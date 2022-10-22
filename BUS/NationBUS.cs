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
    internal class NationBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<DatNuoc> NationDAO = new GenericDAO<DatNuoc>(db);
        public List<DatNuoc> Nations => NationDAO.Entities.ToList();
        public object GetAll() => NationDAO.Entities.Select(x => new { ID = x.MaNuoc, Name = x.TenNuoc }).ToList();
        public DatNuoc Find(int id) => NationDAO.Find(id);
        public void Insert(DatNuoc newNation) => NationDAO.Insert(newNation);
        public void Update(DatNuoc updateNation) => NationDAO.Update(updateNation);
        public void Delete(DatNuoc deleteNation) => NationDAO.Delete(deleteNation);
        public void Save() => NationDAO.SaveChanges();
    }
}
