namespace nhom_9
{
    partial class frm_dat_lich
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            cb_LapThongBao = new CheckBox();
            cb_ThongBao = new CheckBox();
            LapThongBao = new ComboBox();
            ThoiGianThongBao = new ComboBox();
            btn_tao_moi = new Button();
            splitContainer2 = new SplitContainer();
            chk_hoanthanh = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            dtp_thoigian = new DateTimePicker();
            label2 = new Label();
            btn_luu_lich = new Button();
            label4 = new Label();
            txt_noidung = new TextBox();
            label1 = new Label();
            txt_tieude = new TextBox();
            btn_timkiem = new Button();
            label3 = new Label();
            txt_timkiem = new TextBox();
            dgv_danhsach = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Cyan;
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(cb_LapThongBao);
            splitContainer1.Panel1.Controls.Add(cb_ThongBao);
            splitContainer1.Panel1.Controls.Add(LapThongBao);
            splitContainer1.Panel1.Controls.Add(ThoiGianThongBao);
            splitContainer1.Panel1.Controls.Add(btn_tao_moi);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(1205, 641);
            splitContainer1.SplitterDistance = 252;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // cb_LapThongBao
            // 
            cb_LapThongBao.AutoSize = true;
            cb_LapThongBao.Location = new Point(217, 138);
            cb_LapThongBao.Name = "cb_LapThongBao";
            cb_LapThongBao.Size = new Size(22, 21);
            cb_LapThongBao.TabIndex = 4;
            cb_LapThongBao.UseVisualStyleBackColor = true;
            cb_LapThongBao.CheckedChanged += cb_LapThongBao_CheckedChanged;
            // 
            // cb_ThongBao
            // 
            cb_ThongBao.AutoSize = true;
            cb_ThongBao.Location = new Point(217, 83);
            cb_ThongBao.Name = "cb_ThongBao";
            cb_ThongBao.Size = new Size(22, 21);
            cb_ThongBao.TabIndex = 3;
            cb_ThongBao.UseVisualStyleBackColor = true;
            cb_ThongBao.CheckedChanged += cb_ThongBao_CheckedChanged;
            // 
            // LapThongBao
            // 
            LapThongBao.FormattingEnabled = true;
            LapThongBao.Items.AddRange(new object[] { "1", "7", "30" });
            LapThongBao.Location = new Point(93, 131);
            LapThongBao.Name = "LapThongBao";
            LapThongBao.Size = new Size(118, 33);
            LapThongBao.TabIndex = 2;
            LapThongBao.SelectedIndexChanged += LapThongBao_SelectedIndexChanged;
            // 
            // ThoiGianThongBao
            // 
            ThoiGianThongBao.FormattingEnabled = true;
            ThoiGianThongBao.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60" });
            ThoiGianThongBao.Location = new Point(93, 77);
            ThoiGianThongBao.Name = "ThoiGianThongBao";
            ThoiGianThongBao.Size = new Size(118, 33);
            ThoiGianThongBao.TabIndex = 1;
            ThoiGianThongBao.SelectedIndexChanged += ThoiGianThongBao_SelectedIndexChanged;
            // 
            // btn_tao_moi
            // 
            btn_tao_moi.Location = new Point(66, 13);
            btn_tao_moi.Margin = new Padding(4);
            btn_tao_moi.Name = "btn_tao_moi";
            btn_tao_moi.RightToLeft = RightToLeft.No;
            btn_tao_moi.Size = new Size(118, 36);
            btn_tao_moi.TabIndex = 0;
            btn_tao_moi.Text = "Tạo mới";
            btn_tao_moi.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(255, 255, 128);
            splitContainer2.Panel1.Controls.Add(chk_hoanthanh);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(button1);
            splitContainer2.Panel1.Controls.Add(dtp_thoigian);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(btn_luu_lich);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(txt_noidung);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(txt_tieude);
            splitContainer2.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(192, 255, 192);
            splitContainer2.Panel2.Controls.Add(btn_timkiem);
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(txt_timkiem);
            splitContainer2.Panel2.Controls.Add(dgv_danhsach);
            splitContainer2.Panel2.RightToLeft = RightToLeft.No;
            splitContainer2.Size = new Size(948, 641);
            splitContainer2.SplitterDistance = 312;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // chk_hoanthanh
            // 
            chk_hoanthanh.AutoSize = true;
            chk_hoanthanh.Location = new Point(725, 21);
            chk_hoanthanh.Margin = new Padding(4);
            chk_hoanthanh.Name = "chk_hoanthanh";
            chk_hoanthanh.Size = new Size(131, 29);
            chk_hoanthanh.TabIndex = 13;
            chk_hoanthanh.Text = "Hoàn thành";
            chk_hoanthanh.UseVisualStyleBackColor = true;
            chk_hoanthanh.CheckedChanged += chk_hoanthanh_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(725, 201);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 12;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(725, 128);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 11;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtp_thoigian
            // 
            dtp_thoigian.CustomFormat = "      HH:mm                     dd/MM/yyyy";
            dtp_thoigian.Format = DateTimePickerFormat.Custom;
            dtp_thoigian.Location = new Point(140, 265);
            dtp_thoigian.Margin = new Padding(4);
            dtp_thoigian.Name = "dtp_thoigian";
            dtp_thoigian.Size = new Size(562, 31);
            dtp_thoigian.TabIndex = 10;
            dtp_thoigian.Value = new DateTime(2023, 11, 12, 20, 13, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 274);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 9;
            label2.Text = "Thời gian:";
            // 
            // btn_luu_lich
            // 
            btn_luu_lich.Location = new Point(725, 262);
            btn_luu_lich.Margin = new Padding(4);
            btn_luu_lich.Name = "btn_luu_lich";
            btn_luu_lich.Size = new Size(118, 36);
            btn_luu_lich.TabIndex = 6;
            btn_luu_lich.Text = "Lưu lịch";
            btn_luu_lich.UseVisualStyleBackColor = true;
            btn_luu_lich.AutoSizeChanged += btn_luu_lich_Click;
            btn_luu_lich.Click += btn_luu_lich_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 3;
            label4.Text = "Nội dung :";
            // 
            // txt_noidung
            // 
            txt_noidung.Location = new Point(140, 69);
            txt_noidung.Margin = new Padding(4);
            txt_noidung.Multiline = true;
            txt_noidung.Name = "txt_noidung";
            txt_noidung.Size = new Size(562, 168);
            txt_noidung.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Tiêu đề :";
            // 
            // txt_tieude
            // 
            txt_tieude.Location = new Point(140, 15);
            txt_tieude.Margin = new Padding(4);
            txt_tieude.Name = "txt_tieude";
            txt_tieude.Size = new Size(562, 31);
            txt_tieude.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(725, 24);
            btn_timkiem.Margin = new Padding(4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(118, 36);
            btn_timkiem.TabIndex = 3;
            btn_timkiem.Text = "SREACH";
            btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(109, 24);
            txt_timkiem.Margin = new Padding(4);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(593, 31);
            txt_timkiem.TabIndex = 1;
            // 
            // dgv_danhsach
            // 
            dgv_danhsach.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhsach.GridColor = SystemColors.ActiveBorder;
            dgv_danhsach.Location = new Point(15, 64);
            dgv_danhsach.Margin = new Padding(4);
            dgv_danhsach.Name = "dgv_danhsach";
            dgv_danhsach.RowHeadersWidth = 51;
            dgv_danhsach.Size = new Size(869, 245);
            dgv_danhsach.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 5;
            label5.Text = "Thời gian ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 134);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 6;
            label6.Text = "Ngày lặp ";
            // 
            // frm_dat_lich
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1205, 641);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_dat_lich";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt lịch";
            Activated += frm_dat_lich_Load;
            Load += frm_dat_lich_Load;
            Click += frm_dat_lich_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox txt_noidung;
        private Label label1;
        private Button btn_luu_lich;
        private Label label4;
        private TextBox txt_tieude;
        private DataGridView dgv_danhsach;
        private Label label2;
        private Button btn_tao_moi;
        private Button btn_timkiem;
        private Label label3;
        private TextBox txt_timkiem;
        private DateTimePicker dtp_thoigian;
        private Button button2;
        private Button button1;
        private CheckBox chk_hoanthanh;
        private ComboBox LapThongBao;
        private ComboBox ThoiGianThongBao;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private CheckBox cb_ThongBao;
        private CheckBox cb_LapThongBao;
        private System.Windows.Forms.Timer timer2;
        private Label label6;
        private Label label5;
    }
}