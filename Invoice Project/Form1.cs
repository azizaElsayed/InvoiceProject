using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtdate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            Random number = new Random();
            txtitem.Text = number.Next().ToString();

            Dictionary<int, string> itemData = new Dictionary<int, string>();
            itemData.Add(5000, "لاب توب ديل");
            itemData.Add(6000, "لابتوب سامسونج");
            itemData.Add(4000, "لاب توب HP");
            itemData.Add(100, "كيبورد عادي");
            itemData.Add(200, "كيبورد Dell");
            itemData.Add(300, "كيبورد HP");
            itemData.Add(400, "ماوس HP");
            itemData.Add(700, " طابعه حبر");
            itemData.Add(1000, "طابعه حبر HP");
            itemData.Add(2000, "طابعه حبر Dell");


            comboBox1.DataSource = new BindingSource(itemData,null);
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
            txtprice.Text = comboBox1.SelectedValue.ToString();

            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.ForeColor = Color.Navy;
            }

           
            
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;






            txtname.Focus();
            txtname.Select();
            txtname.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start (@"https://www.linkedin.com/in/aziza-eltohamy-94474816a/");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdate_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtdate.ContextMenu = new ContextMenu();
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox1.Focus();
                comboBox1.SelectAll();

            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtqua.Focus();
                txtqua.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1) return;

            string Item = comboBox1.Text;
            int Qty = Convert.ToInt32(txtqua.Text);
            int Price =Convert.ToInt32( txtprice.Text);
            int SubTotal = Qty * Price;

            object[] row = { Item, Qty, Price, SubTotal };

            dataGridView1.Rows.Add(row);
            int a = Convert.ToInt32(txttotal.Text);
            txttotal.Text = a + SubTotal + "";
                
             //  txttotal.Text=(Convert.ToInt32(txttotal.Text) + SubTotal).ToString();




        }

        private void txtqua_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                comboBox1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprice.Text = comboBox1.SelectedValue.ToString();

        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtqua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        string oldDataGrid;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                oldDataGrid = dataGridView1.CurrentRow.Cells["colQua"].Value.ToString();

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                string newDataGrid = dataGridView1.CurrentRow.Cells["colQua"].Value.ToString();
                if (!Regex.IsMatch(newDataGrid, "^\\d+$"))
                {
                    dataGridView1.CurrentRow.Cells["colQua"].Value = oldDataGrid;
                }

                else if(oldDataGrid==newDataGrid)
                {

                    return;
                }
                else
                {
                    int p =(int) dataGridView1.CurrentRow.Cells["colPrice"].Value;
                    int q = Convert.ToInt32(newDataGrid);
                    dataGridView1.CurrentRow.Cells["colSubtotal"].Value = p * q;

                    //int newTotal = 0;
                    //foreach(DataGridViewColumn r in dataGridView1.Rows)
                    //{
                    //    //newTotal += Convert.ToInt32(r.);
                    //}


                }


            }


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //printPreviewDialog1.Show();

            //printDialog1.ShowDialog();
           


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{



            printPreviewDialog1.ShowDialog();
            pageSetupDialog1.ShowDialog();
            printDialog1.ShowDialog();


            //  }
        }

        string line = " _____________________      ";
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           
            e.Graphics.DrawImage(Properties.Resources.download, 5, 5, 200, 2);

            e.Graphics.DrawString("رقم الفاتوره:"+txtitem.Text,new Font("Tohama",30), Brushes.Red, 300,30);
            e.Graphics.DrawString("التاريخ :" + txtdate.Text, new Font("Tohama", 30), Brushes.Black,300, 100);
            e.Graphics.DrawString("مطلوب من السيد :" + txtname.Text, new Font("Tohama", 40), Brushes.OrangeRed, 280, 170);

            e.Graphics.DrawString(line, new Font("Tohama", 40), Brushes.Brown,100, 200);


            e.Graphics.DrawRectangle(Pens.Black, 40, 300, e.PageBounds.Width - 40 * 2 ,800);
            float colheight = 60;
            float col1width = 300;
            float col2width = 125+col1width;
            float col3width = 125+col2width;
            float col4width = 125+col3width;
            float margin = 40;
            //SizeF fontSizeDate = e.Graphics.MeasureString(strDate, f);

            //float preheight=

           // e.Graphics.DrawLine(Pens.Black, 20, 400, e.PageBounds.Width, colheight);



            for(int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                e.Graphics.DrawString("الصنف:" + comboBox1.Text, new Font("Tohama", 30), Brushes.Black, 300, 400);

                e.Graphics.DrawString("السعر:" + txtprice.Text, new Font("Tohama", 30), Brushes.Brown, 550, 480);

                e.Graphics.DrawString("الكميه:" + txtqua.Text, new Font("Tohama", 40), Brushes.Brown, 200, 480);

                e.Graphics.DrawString("الاجمالي:" + txttotal.Text, new Font("Tohama", 40), Brushes.Black, 400, 550);




            }








        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
