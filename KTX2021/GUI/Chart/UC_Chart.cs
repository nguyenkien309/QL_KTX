using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dormitory_Management_2021.GUI.Chart
{
    public partial class UC_Chart : UserControl
    {
        string con_str = "Data Source = LAPTOP-O6D84MLP\\SQLEXPRESS; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UC_Chart()
        {
            InitializeComponent();
        }
        private void checkloai()
        {

        }
        private void show()
        {
            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-O6D84MLP\\SQLEXPRESS; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            if (loai == "Sinh Viên")
            {
                txttongtien.Visible = true;
                string sql = "select lop,COUNT(masv) as SL from sinhvien group by lop";
                SqlDataAdapter ad2 = new SqlDataAdapter(sql, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart1.DataSource = dt2;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart1.Series["Series1"].XValueMember = "lop";
                chart1.Series["Series1"].YValueMembers = "SL";
            }
            else
            {
                string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' group by maphong";
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Hóa Đơn";
                chart1.Series["Series1"].XValueMember = "maphong";
                chart1.Series["Series1"].YValueMembers = "tongtien";
            }
     
        }
        private void show2()
        {
            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-O6D84MLP\\SQLEXPRESS; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            if (loai == "Sinh Viên")
            {
                string sql = "select lop,COUNT(masv) as SL from sinhvien group by lop";
                SqlDataAdapter ad2 = new SqlDataAdapter(sql, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart2.DataSource = dt2;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart2.Series["Series1"].XValueMember = "lop";
                chart2.Series["Series1"].YValueMembers = "SL";
            }
            else
            {
                string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' group by maphong";
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart2.DataSource = dt;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
                chart2.Series["Series1"].XValueMember = "maphong";
                chart2.Series["Series1"].YValueMembers = "tongtien";
            }
        }
        private void showtotal()
        {
            conn = new SqlConnection(con_str);
            string ngaylap = comboBox1.Text;
            string sql = "select SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txttongtien.Text = reader["tongtien"].ToString();
            }
        }
        private void showbill()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from hoadon";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }
        private void UC_Chart_Load(object sender, EventArgs e)
        {
            cbbloai.SelectedIndex = 0;
            cbbloai.SelectedIndex = 0;
            showbill();
            show();
            show2();
            showtotal();
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            if (cbbloai.Text == "Sinh Viên")
            {
                txttongtien.Visible = false;
                dgv.Visible = false;
            }
            else
            {
                txttongtien.Visible = true;
                dgv.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            show();
            show2();
            showtotal();
            if (cbbloai.Text == "Sinh Viên")
            {
                txttongtien.Visible = false;
                dgv.Visible = false;
            }
            else
            {
                txttongtien.Visible = true;
                dgv.Visible = true;
            }
        }
        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_MouseClick(object sender, MouseEventArgs e)
        {
            var collectionx = chart2.Series.Select(series => series.Points.Where(point => point.XValue == 1).ToString()).ToString();
            MessageBox.Show(collectionx);
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }

        //comboBox1.Items.Clear()
    }
