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
    internal class PlanBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<GoiDichVu> PlanDAO = new GenericDAO<GoiDichVu>(db);
        public object GetAll() => PlanDAO.Entities.Select(x => new { ID = x.MaGoiDV, Name = x.TenGoiDV, Price = x.GiaGoiDV, summary = x.MoTaGoiDichVu }).ToList();
        public GoiDichVu Find(int id) => PlanDAO.Find(id);
        public void Insert(GoiDichVu newNation) => PlanDAO.Insert(newNation);
        public void Update(GoiDichVu updateNation) => PlanDAO.Update(updateNation);
        public void Delete(GoiDichVu deleteNation) => PlanDAO.Delete(deleteNation);
        public void Save() => PlanDAO.SaveChanges();
    }
}
