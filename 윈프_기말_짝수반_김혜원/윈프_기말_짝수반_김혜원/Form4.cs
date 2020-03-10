using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //합계 기능
        
        public void sum()
        {
            int price = 0;
            for (int i=0; i< listView1.Items.Count; i++)
            {   
                price += int.Parse(listView1.Items[i].SubItems[1].Text);
            }
            textBox1.Text = price.ToString();
        }
        //전체상품 삭제
        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox1.Clear();
        }
        //선택항목 삭제
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("    선택하신 항목이 삭제 됩니다.\n\t계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes){
                if (listView1.SelectedItems.Count > 0){
                    int list_index = listView1.FocusedItem.Index;
                    listView1.Items.RemoveAt(list_index);
                    textBox1.Clear();
                    sum();
                } else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }
        }
        //상품선택시 결제창으로 정보 이동
        private void button3_Click(object sender, EventArgs e)
        {
            String[] product = new String[]{"수영복(원피스형)", "30000"};
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
            //textBox1.Text = button3.Tag.ToString(); 합계에 가격 띄우기
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String[] product = new String[] { "수영복(투피스형)", "32000" };
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] product = new String[] { "수영복(남성형)", "27000" };
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] product = new String[] { "물안경", "15000" };
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String[] product = new String[] { "수영모", "5000" };
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String[] product = new String[] { "스포츠백", "35000" };
            ListViewItem product_item = new ListViewItem(product);
            listView1.Items.Add(product_item);
            sum();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            

        }
        
        //결제 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items == null)
            {
                MessageBox.Show("선택된 상품이 없습니다.");
            }
            else
            {
                MessageBox.Show("결제되었습니다.");
                listView1.Items.Clear();
            }
            
        }
        //합계기능 완료하기
    }
}
