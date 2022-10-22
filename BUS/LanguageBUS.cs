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
    internal class LanguageBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<NgonNgu> languageDAO = new GenericDAO<NgonNgu>(db);
        public List<NgonNgu> Languages => languageDAO.Entities.ToList();
        public object GetAll() => languageDAO.Entities.Select(x => new { ID = x.MaNgonNgu, Name = x.TenNgonNgu }).ToList();
        public NgonNgu Find(int id) => languageDAO.Find(id);
        public void Insert(NgonNgu newLanguage) => languageDAO.Insert(newLanguage);
        public void Update(NgonNgu updateLanguage) => languageDAO.Update(updateLanguage);
        public void Delete(NgonNgu deleteLanguage) => languageDAO.Delete(deleteLanguage);
        public void Save() => languageDAO.SaveChanges();
    }
}
