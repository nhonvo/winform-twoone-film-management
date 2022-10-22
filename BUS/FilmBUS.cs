using MovieWinform.DAO;
using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWinform.BUS
{
    internal class FilmBUS
    {
        private static MovieWinformDBcontext db = new MovieWinformDBcontext();
        private GenericDAO<Phim> filmDAO = new GenericDAO<Phim>(db);
        public List<Phim> Films => filmDAO.Entities.ToList();
        public List<DienVien> GetActorsById(int id)
        {
            return Find(id).DienVienDongPhims.Select(x => x.DienVien).ToList();
        }
        public List<DaoDien> GetDirectorById(int id) => Find(id).DaoDiens.ToList();
        public List<TheLoai> GetGenreById(int id) => Find(id).TheLoais.ToList();
        public List<HashTag> GetHashTagById(int id) => Find(id).HashTags.ToList();
        public void AddRole(int movieID, int actorID, string role)
        {
            DienVienDongPhim newRole = new DienVienDongPhim()
            {
                MaPhim = movieID,
                MaDienVien = actorID,
                TenVaiDien = role
            };
            db.DienVienDongPhims.Add(newRole);
        }
        public void AddDirector(int movieID, int directorID)
        {
            Find(movieID).DaoDiens.Add(db.DaoDiens.Find(directorID));
        }
        public void AddGenre(int movieID, int genreID)
        {
            Find(movieID).TheLoais.Add(db.TheLoais.Find(genreID));
        }
        public void AddHashTag(int movieID,int hashTagID)
        {
            Find(movieID).HashTags.Add(db.HashTags.Find(hashTagID));
        }
        public void DeleteRole(int movieID, int actorID)
        {
            DienVienDongPhim dienVien = this.FindActor(movieID, actorID);
            db.DienVienDongPhims.Remove(dienVien);
        }
        public bool ExistDirector(int movieID,int directorID)
        {
            return Find(movieID).DaoDiens.Any(d => d.MaDaoDien == directorID);
        }
        public bool ExistGenre(int movieID, int genreID)
        {
            return Find(movieID).TheLoais.Any(d => d.MaTheLoai == genreID);
        }
        public bool ExistHashTag(int movieID, int hashTagID)
        {
            return Find(movieID).HashTags.Any(d => d.MaHashTag == hashTagID);
        }
        public void DeleteDirector(int movieID, int directorID)
        {
           // DaoDien daoDien = ;
            Find(movieID).DaoDiens.Remove(db.DaoDiens.Find(directorID));
        }
        public void DeleteGenre(int movieID, int genreID)
        {
            Find(movieID).TheLoais.Remove(db.TheLoais.Find(genreID));
        }
        public void DeleteHashTag(int movieID, int hashTagID)
        {
            Find(movieID).HashTags.Remove(db.HashTags.Find(hashTagID));
        }
        public DienVienDongPhim FindActor(int movieID, int actorID) => db.DienVienDongPhims.FirstOrDefault(actor => actor.MaDienVien == actorID && actor.MaPhim == movieID);
        public object GetAll()
        {
            return filmDAO.Entities.Select(film => new {
                ID = film.MaPhim,
                Title = film.TenPhim,
                Release = film.NgaySanXuat,
                Description = film.NoiDungPhim,
                Summary = film.NoiDungPhimTomTat,
                IMDb = film.DiemIMDB,
                View = film.LuotXem,
                Length = film.ThoiLuong,
                Banner = film.HinhBanner,
                Link = film.LinkPhim,
                VIPLink = film.LinkPhimVip,
                TrailerLink = film.TrailerPhim,
                CountryID = film.MaNuoc,
                LanguageID = film.MaNgonNgu
            }).ToList();
        }
        public Phim Find(int id)
        {
            return filmDAO.Find(id);
        }
        public List<Phim> Search(string filmName) => db.Phims.Where(x => x.TenPhim.Contains(filmName)).ToList();
        public void Insert(Phim newFilm)
        {
            filmDAO.Insert(newFilm);
        }
        public void Update(Phim updateFilm)
        {
            filmDAO.Update(updateFilm);
        }
        public void Delete(Phim deleteFilm)
        {
            filmDAO.Delete(deleteFilm);
        }
        public void Save()
        {
            filmDAO.SaveChanges();
        }
    }
}
