using MovieWinform.BUS;
using MovieWinform.DAO;
using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinform
{
    public partial class UCUser : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCUser()
        {
            InitializeComponent();
        }

        #region dbMethods
        private UserBUS userBUS = new UserBUS();
        public void LoadUser()
        {
            dataGridViewUser.DataSource = userBUS.GetAll();
        }
        String imageUpload;

        public void CreateUser()
        {
            NguoiDung newUser = new NguoiDung()
            {
                HoTen = txtUserName.Text,
                TaiKhoan = txtUserName.Text,
                GioiTinh = txtGender.Text,
                Email = txtEmail.Text,
                SDT = txtPhoneNumber.Text,
                HinhAnhNguoiDung = imageUpload
            };

            userBUS.Insert(newUser);
            userBUS.Save();
        }
        public void UpdateUser()
        {
            int UserId = Int32.Parse(txtUserID.Text);
            string UserName = txtUserName.Text;
            string fullName = txtFullName.Text;
            string GioiTinh = txtGender.Text;
            string Email = txtEmail.Text;
            string SDT = txtPhoneNumber.Text;
            string avatar = txtAvatar.Text;
            NguoiDung updateUser = userBUS.Find(UserId);
            updateUser.TaiKhoan = UserName;
            updateUser.HoTen = fullName;
            updateUser.GioiTinh = GioiTinh;
            updateUser.Email = Email;
            updateUser.SDT = SDT;
            updateUser.HinhAnhNguoiDung = avatar;
            updateUser.HinhAnhNguoiDung = imageUpload;
            userBUS.Update(updateUser);
            userBUS.Save();
        }
        public void DeleteUser()
        {
            int UserId = Int32.Parse(txtUserID.Text);
            NguoiDung deleteUser = userBUS.Find(UserId);

            userBUS.Delete(deleteUser);
            userBUS.Save();
        }
        #endregion
        private void User_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "-1";
            txtUserName.Text = "";
            txtFullName.Text = "";
            txtGender.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAvatar.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteUser();
            LoadUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text is null || txtFullName.Text is null || txtGender.Text is null || txtPhoneNumber.Text is null || txtEmail.Text is null || txtGender.Text is null || txtAvatar.Text is null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateUser();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateUser();
                msg = "Cập Nhật Thành Công";
            }
            LoadUser();
            MessageBox.Show(msg, "Thông Báo");
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxActor.Image = new Bitmap(opnfd.FileName);
            }
            imageUpload = opnfd.SafeFileName;
        }

        private void dataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewUser.CurrentRow;
            string UserId = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string fullName = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            string UserImage = (selectedRow.Cells[2].Value != null) ? selectedRow.Cells[2].Value.ToString() : "";
            string GioiTinh = (selectedRow.Cells[3].Value != null) ? selectedRow.Cells[3].Value.ToString() : "";
            string Email = (selectedRow.Cells[4].Value != null) ? selectedRow.Cells[4].Value.ToString() : "";
            string SDT = (selectedRow.Cells[5].Value != null) ? selectedRow.Cells[5].Value.ToString() : "";
            string NgaySinh = (selectedRow.Cells[6].Value != null) ? selectedRow.Cells[6].Value.ToString() : "";
            string UserName = (selectedRow.Cells[7].Value != null) ? selectedRow.Cells[7].Value.ToString() : "";
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string binPath = Path.GetDirectoryName(startupPath);
            string path = Path.GetDirectoryName(binPath);
            Image image = Image.FromFile(path + @"\Resources\sample\" + UserImage);
            pictureBoxActor.Image = image;
            txtUserID.Text = UserId;
            txtUserName.Text = UserName;
            txtFullName.Text = fullName;
            txtGender.Text = GioiTinh;
            txtPhoneNumber.Text = SDT;
            txtEmail.Text = Email;
            txtAvatar.Text = UserImage;
            dtpBirthDate.Text = NgaySinh;
            txtPhoneNumber.Text = SDT;
            mode = UPDATE;
        }
    }
}
