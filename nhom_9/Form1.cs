﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace nhom_9
{
    [Serializable]
    public partial class frm_dat_lich : Form
    {
        DanhSachDatLich dsdatlich;
        DatLich dl;

        public frm_dat_lich()
        {
            InitializeComponent();

            dgv_danhsach.CellDoubleClick += dgv_danhsach_CellDoubleClick;

        }

        private void frm_dat_lich_Load(object sender, EventArgs e)
        {
            dtp_thoigian.Text = DateTime.Now.ToString();

            dsdatlich = new DanhSachDatLich();
            dl = new DatLich();

            //Doc file

            string[] tam = File.ReadAllLines("danhsachdatlich.txt");
            for (int i = 0; i < tam.Length; i++)
            {
                string line = tam[i];
                string[] tam2 = line.Split("\t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                DatLich datLich = new DatLich();
                datLich.id = tam2[0];
                datLich.tieude = tam2[1];
                datLich.noidung = tam2[2];
                datLich.thoigian = Convert.ToDateTime(tam2[3]);
                datLich.trangthai = tam2[4];
                dl = new DatLich(datLich.id, datLich.tieude, datLich.noidung, datLich.thoigian, datLich.trangthai);
                dsdatlich.AddDanhSachDatLich(dl);
            }

            hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);

            //Trạng thái công việc 
            if (chk_hoanthanh.Checked == false)
                chk_hoanthanh.ForeColor = Color.Red;
            //Cố định form
            splitContainer1.IsSplitterFixed = true;
            splitContainer2.IsSplitterFixed = true;
        }
        private void hienthidanhsachdatlich(DataGridView dgv, List<DatLich> ds)
        {
            dgv.DataSource = ds;
        }

        private void btn_luu_lich_Click(object sender, EventArgs e)
        {
            if (txt_tieude.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tiêu đề ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //luu lich
                string ip = Guid.NewGuid().ToString();

                string trangthai = "Chưa hoàn thành";
                dtp_thoigian.Focus();
                dl = new DatLich(ip, txt_tieude.Text, txt_noidung.Text, Convert.ToDateTime(dtp_thoigian.Text), trangthai);
                if (dsdatlich.timTG(dl))
                {
                    MessageBox.Show("Thời gian bị trùng. Mời bạn đặt lại thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    TimeSpan time = Convert.ToDateTime(dtp_thoigian.Text).Subtract(DateTime.Now);
                    int phuttoido = time.Minutes;
                    if (phuttoido >= 1)
                    {
                        dsdatlich.AddDanhSachDatLich(dl);
                        hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);

                        //Ghi File
                        try
                        {
                            StreamWriter swt = new StreamWriter("danhsachdatlich.txt", false, Encoding.UTF8);
                            foreach (DatLich datLich in dsdatlich.danhSachDatLich)
                            {
                                string dong = datLich.id.ToString() + "\t" + datLich.tieude + "\t" + datLich.noidung + "\t" + datLich.thoigian.ToString() + "\t" + datLich.trangthai;
                                swt.WriteLine(dong);
                            }
                            swt.Close();
                            MessageBox.Show("Lịch đã lưu thành công  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lịch lưu thất bại ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thời gian không phù hợp. Mời bạn chọn lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btn_tao_moi_Click(object sender, EventArgs e)
        {


            txt_tieude.Text = "";
            txt_noidung.Text = "";
            dtp_thoigian.Value = DateTime.Now;
            chk_hoanthanh.Checked = false;
            HienThiChiTiet(null);


        }

        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_danhsach.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();

                DatLich lich = dsdatlich.TimTheoID(id);
                HienThiChiTiet(lich);
            }
        }
        private void dgv_danhsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_danhsach.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();

                DatLich lich = dsdatlich.TimTheoID(id);
                HienThiChiTiet(lich);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_danhsach.SelectedRows;

            if (selectedRows.Count > 0)
            {
                DataGridViewRow row = selectedRows[0];
                string id = row.Cells["ID"].Value.ToString();

                //sửa thông tin lịch
                DatLich lichCanSua = dsdatlich.TimTheoID(id);
                if (lichCanSua != null)
                {
                    
                    string trangthai;
                    if (chk_hoanthanh.Checked)
                    {
                        trangthai = "Hoàn thành";
                    }
                    else
                    {
                        trangthai = "Chưa hoàn thành";
                    }
                    lichCanSua.SuaDanhSachDatLich(txt_tieude.Text, txt_noidung.Text, Convert.ToDateTime(dtp_thoigian.Text), trangthai);
                    LuuDanhSachDatLichToFile();
                    hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);
                    
                }
            }
        }

        private void LuuDanhSachDatLichToFile()
        {
            try
            {
                StreamWriter swt = new StreamWriter("danhsachdatlich.txt", false, Encoding.UTF8);
                foreach (DatLich datLich in dsdatlich.danhSachDatLich)
                {
                    string dong = datLich.id.ToString() + "\t" + datLich.tieude + "\t" + datLich.noidung + "\t" + datLich.thoigian.ToString() + "\t" + datLich.trangthai;
                    swt.WriteLine(dong);
                }
                swt.Close();
                MessageBox.Show("Danh sách đã được cập nhật và lưu lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu danh sách thất bại ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HienThiChiTiet(DatLich lich)
        {
            if (lich != null)
            {
                txt_tieude.Text = lich.tieude;
                txt_noidung.Text = lich.noidung;
                dtp_thoigian.Value = lich.thoigian;
                if (lich.trangthai.Equals("Hoàn thành"))
                {
                    chk_hoanthanh.Checked = true;
                }
                else
                {
                    chk_hoanthanh.Checked = false;
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection selectedRows = dgv_danhsach.SelectedRows;

            if (selectedRows.Count > 0)
            {

                DataGridViewRow row = selectedRows[0];
                string id = row.Cells["ID"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dsdatlich.XoaDanhSachDatLich(id);
                    hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);
                    LuuDanhSachDatLichToFile();
                }
            }
        }

        private void chk_hoanthanh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hoanthanh.Checked)
                chk_hoanthanh.ForeColor = Color.Green;
        }

        private void frm_dang_xuat_Click(object sender, EventArgs e)
        {

            frm_dang_nhap f = new frm_dang_nhap();
            f.Show();
            this.Hide();
        }

        private void frm_thoatchuongtrinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_dang_xuat_Click_1(object sender, EventArgs e)
        {
            frm_dang_nhap f = new frm_dang_nhap();
            f.Show();
            this.Hide();
        }

        private void frm_thoatchuongtrinh_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_dat_lich_Load_1(object sender, EventArgs e)
        {

        }
    }
}
