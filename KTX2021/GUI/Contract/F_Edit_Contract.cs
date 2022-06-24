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

namespace Dormitory_Management_2021.GUI.HopDong
{
    public partial class SuaHopDong : Form
    {
        string con_str = "Data Source = LAPTOP-O6D84MLP\\SQLEXPRESS; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public SuaHopDong()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from hopdong";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hopdong");
        }
        public void LoadSuaHopDong(string mahopdong, string maphong, string ten, string ngaylap, string ketthuc, string tongtien)
        {
            txtmahopdong.Text = mahopdong;
            txtmaphong.Text = maphong;
            txtten.Text = ten;
            dtpngaylap.Value = Convert.ToDateTime(ngaylap);
            dtpngaylap.Value = Convert.ToDateTime(ketthuc);
            txttongtien.Text = tongtien;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahopdong = txtmahopdong.Text;
            string maphong = txtmaphong.Text;
            string ten = txtten.Text;
            string ngaylap = dtpngaylap.Value.ToString();
            string ketthuc = dtpketthuc.Value.ToString();
            string tongtien = txttongtien.Text;
            string sql = "insert into hopdong values(@mahopdong,@maphong,@ten,@ngaylap,@ketthuc,@tongtien)";
            string sql2 = "select COUNT(maphong) from hopdong where maphong = '" + maphong + "'";
            string sql3 = "select soluong from phong where maphong = '" + maphong + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            int x = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            int y = Convert.ToInt32(cmd3.ExecuteScalar().ToString());
            if(x < y)
            {
                cmd.Parameters.Add(new SqlParameter("@mahopdong", mahopdong));
                cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
                cmd.Parameters.Add(new SqlParameter("@ketthuc", ketthuc));
                cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs > 0)
                {
                    MessageBox.Show("ok");
                    show();
                    this.Close();
                    return;
                }
            }
            else
            {
                string tinhtrang = "Đầy";
                maphong = txtmaphong.Text;
                string sql4 = "update phong set tinhtrang = @tinhtrang where maphong = @maphong";
                SqlCommand cmd4 = new SqlCommand(sql4, conn);
                cmd4.Parameters.Add(new SqlParameter("@tinhtrang", tinhtrang));
                cmd4.Parameters.Add(new SqlParameter("@maphong", maphong));
                int rs2 = (int)cmd4.ExecuteNonQuery();
                if (rs2 > 0)
                {
                    MessageBox.Show("PHÒNG ĐẦY");
                    show();
                    this.Close();
                    return;
                }
            }
            conn.Close();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahopdong = txtmahopdong.Text;
            string maphong = txtmaphong.Text;
            string ten = txtten.Text;
            string ngaylap = dtpngaylap.Value.ToString();
            string ketthuc = dtpketthuc.Value.ToString();
            string tongtien = txttongtien.Text;
            string sql = "update hopdong set mahopdong = @mahopdong ,maphong = @maphong,ten = @ten,ngaylap = @ngaylap,ketthuc = @ketthuc,tongtien = @tongtien where mahopdong = @mahopdong and maphong = @maphong";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahopdong", mahopdong));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            cmd.Parameters.Add(new SqlParameter("@ten", ten));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            cmd.Parameters.Add(new SqlParameter("@ketthuc", ketthuc));
            cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                MessageBox.Show("ok");
                show();
                this.Close();
                return;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahopdong = txtmahopdong.Text;
            string maphong = txtmaphong.Text;
            string sql = "delete hopdong where mahopdong = @mahopdong and maphong = @maphong";
            string sql2 = "select count(maphong) from hopdong where maphong = '" + maphong + "'";
            string sql4 = "select soluong from phong where maphong = '" + maphong + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            int x = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            int y = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
            label3.Text = x.ToString();
            label4.Text = y.ToString();
            if (x == 1 || y >= x)
            {
                maphong = txtmaphong.Text;
                string tinhtrang = "Trống";
                string sql3 = "update phong set tinhtrang = @tinhtrang where maphong = '" + maphong + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.Parameters.Add(new SqlParameter("@maphong", maphong));
                cmd3.Parameters.Add(new SqlParameter("@tinhtrang", tinhtrang));
                int rs3 = (int)cmd3.ExecuteNonQuery();
            }
            cmd.Parameters.Add(new SqlParameter("@mahopdong", mahopdong));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs == 1)
            {
                MessageBox.Show("Đã Xóa");
                show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SAI");
            }
        }

        private void SuaHopDong_Load(object sender, EventArgs e)
        {
            txtmahopdong.Enabled = false;
            txtmaphong.Enabled = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            dtpngaylap.Text = DateTime.Now.ToString("d");
            int value = number.Next(0, 1000000000);
            txtmahopdong.Enabled = true;
            txtmaphong.Enabled = true;
            txtmahopdong.Text = "HD" + value.ToString();
            txtmaphong.Clear();
            txtten.Clear();
            txttongtien.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            //string sql = "select COUNT(*) from hopdong where maphong ='P01'";
            string sql = "select tongtien from hopdong where maphong ='P01'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label1.Text = reader["tongtien"].ToString();
                int x = Convert.ToInt32(label1.Text);
                if (x == 1)
                {
                    conn = new SqlConnection(con_str);
                    string maphong = txtmaphong.Text;
                    string tinhtrang = "het";
                    string sql2 = "update phong set maphong = @maphong ,tinhtrang = @tinhtrang where soluong > 5";
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.Add(new SqlParameter("@maphong", maphong));
                    cmd2.Parameters.Add(new SqlParameter("@tinhtrang", tinhtrang));
                    int rs = (int)cmd2.ExecuteNonQuery();
                    conn.Close();
                    if (rs > 0)
                    {
                        MessageBox.Show("THANHHHHHHH COONNNNNGNGNNGNG");
                        show();
                        this.Close();
                        return;
                    }
                }
                //conn.Close();
                //txtmahopdong.Text = "khong thể thêm";
                //MessageBox.Show("NON");
                //label1.Text = "tongtien";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string sql = "select COUNT(*) from hopdong where maphong ='P01'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = (SqlDataReader)cmd.ExecuteScalar();
            reader.Read();
            if (reader.HasRows)
            {
                    label2.Text =cmd.ExecuteScalar().ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpngaylap_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string maphong = txtmaphong.Text;
            string sql = "select count(maphong) from hopdong where maphong = '" + maphong + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int x = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            label3.Text = x.ToString();
            if(x == 1)
            {
                    conn = new SqlConnection(con_str);
                    maphong = txtmaphong.Text;
                    string tinhtrang = "Trống";
                    string sql2 = "update phong set maphong = @maphong ,tinhtrang = @tinhtrang where soluong > 5";
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.Add(new SqlParameter("@maphong", maphong));
                    cmd2.Parameters.Add(new SqlParameter("@tinhtrang", tinhtrang));
                    int rs = (int)cmd2.ExecuteNonQuery();
                    conn.Close();
                    if (rs > 0)
                    {
                        MessageBox.Show("THANHHHHHHH COONNNNNGNGNNGNG");
                        show();
                        this.Close();
                        return;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahopdong = txtmahopdong.Text;
            string maphong = txtmaphong.Text;
            string sql5 = "select SUM(tongtien) from hoadon";
            string sql4 = "select soluong from phong where maphong = '" + maphong + "'";
            conn.Open();

            SqlCommand cmd4 = new SqlCommand(sql4, conn);

            int y = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
            label4.Text = y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = dtpngaylap.Value;
            DateTime ketthuc = dtpketthuc.Value;
            label5.Text = DateTime.Now.ToString("M/d/yyyy");
            int rs = DateTime.Compare(ngaylap, ketthuc);
            int count = 0;
            label6.Text = count.ToString();
            {
                if (rs < 0)
                {
                    MessageBox.Show("qua som");
                }
                else if (rs == 0) MessageBox.Show("same");
                else
                {
                    count = count + 1;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            //string sql = "select COUNT(*) from hopdong where maphong ='P01'";
            string sql = "select SUM(tongtien) as tongtien from hoadon";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label6.Text = reader["tongtien"].ToString();
                }
            }
    }
}
