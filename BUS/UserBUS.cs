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
    internal class UserBUS
    {
        private static DbContext db = new MovieWinformDBcontext();
        private GenericDAO<NguoiDung> userDAO = new GenericDAO<NguoiDung>(db);
        public object GetAll() => userDAO.Entities.Select(x => new { ID = x.MaNguoiDung, Name = x.HoTen, Image = x.HinhAnhNguoiDung, GioiTinh = x.GioiTinh, Email = x.Email, SDT = x.SDT, NgaySinh = x.NgaySinh, userName = x.TaiKhoan }).ToList();
        public NguoiDung Find(int id) => userDAO.Find(id);
        public void Insert(NguoiDung newactor) => userDAO.Insert(newactor);
        public void Update(NguoiDung updateactor) => userDAO.Update(updateactor);
        public void Delete(NguoiDung deleteactor) => userDAO.Delete(deleteactor);
        public void Save() => userDAO.SaveChanges();
    }
}
