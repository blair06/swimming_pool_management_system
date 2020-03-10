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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            

        }

        private void 헬스장물품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }
        //선택항목 삭제
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            if (MessageBox.Show("    선택하신 회원항목이 삭제 됩니다.\n\t계속 하시겠습니까?", "회원 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    int list_index = listView2.FocusedItem.Index;
                    listView2.Items.RemoveAt(list_index);
                    
                    lb_current.Text = (listView2.Items.Count).ToString();
                    SaveData_member(@"member.txt");

                }
                else
                {
                    MessageBox.Show("선택된 회원항목이 없습니다.");
                }
            }
        }
        private void SaveData_member(string fileName)
        {          
            using (TextWriter tWriter = new StreamWriter(fileName))
            {
                foreach (ListViewItem item in listView2.Items)
                {    
                    tWriter.WriteLine(string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}"

                        , item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text));
                }
            }
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //form 로드시 member.txt내용을 리스트뷰에 띄우기
        string[,] to_listview = new string[100, 100];
        private void Form2_Load(object sender, EventArgs e)
        {  
            StreamReader reader = new StreamReader(@"member.txt");
            string sampleString = null;
            Form3 form3 = new Form3(this);

            while (!reader.EndOfStream)
            {
                sampleString = reader.ReadLine();
                
                if (sampleString == null)
                {
                    break;
                }

                string[] str = sampleString.Split('|');


                ListViewItem member = new ListViewItem(str[0]);
                
                lb_current.Text = (listView2.Items.Count+1).ToString();
               
                for (int i = 1; i < str.Length; i++)
                {
                    member.SubItems.Add(str[i]);
                }
                listView2.Items.Add(member);
                
            }
            reader.Close();


        }

    }
}
