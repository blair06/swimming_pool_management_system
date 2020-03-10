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
    public partial class Form3 : Form
    {   //Form3에서 Form2를 제어하게 함
        Form2 f2;
        String[] arr;
        public Form3(Form2 form)
        { 
            InitializeComponent();
            f2 = form;
        }
        
        //회원등록
        private void button1_Click(object sender, EventArgs e)
        {
            string locker = lockerbox.Text;
            string phone = phonebox.Text;
            string name = namebox.Text;
            string house = housebox.Text;
            string age = agebox.Text;
            string registrate = registratebox.SelectedItem.ToString();
            string sex = genderbox.SelectedItem.ToString();
            

           arr = new String[] {name,sex,age,locker,phone,house,registrate };
            ListViewItem member = new ListViewItem(arr);
            f2.listView2.Items.Add(member);

            //파일 저장
            SaveData_member(@"member.txt");
            //멤버현황수
            
          

            f2.lb_current.Text = (f2.listView2.Items.Count).ToString();
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public  void SaveData_member(string fileName)
        {
            // StreamWriter를 이용하여 문자작성기를 생성합니다.
            using (TextWriter text_writer = new StreamWriter(fileName, true))
            {   
                for(int i=0; i<arr.Length; i++)
                {
                    text_writer.Write("{0}|",arr[i]);
                }
                text_writer.Write("\n");

            }
        }
    }
}
