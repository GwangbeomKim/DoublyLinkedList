using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OJT_KGB_NO1_DoublyLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initModule();
        }

        /// <summary>
        /// initializeModule 
        /// </summary>
        private void initModule()
        { 
            listView.View = View.Details;           // 컬럼형식으로 변경
            listView.FullRowSelect = true;          // Row 전체 선택
            listView.Columns.Add("No", 100);        //Number Collumn 
            listView.Columns.Add("Name", 300);      //Name Collumn

            DisplayButton(false);
        }

        /// <summary>
        /// Button Status 
        /// </summary>
        /// <param name="type"></param>
        private void DisplayButton(bool type, bool? uploadtype = null)
        {
            
            if (type == true && uploadtype == true)
            {
                button_Pre.Hide();
                button_Next.Show();
                button_Reverse.Show();
            }
            else if(type == true)
            {
                button_Pre.Show();
                button_Next.Show();
                button_Reverse.Show();
            }
            else
            {
                button_Pre.Hide();
                button_Next.Hide();
                button_Reverse.Hide();
            }
        }

        /// <summary>
        /// Make LinkedList from path
        /// </summary>
        public class Text_Read_Write
        {
            public LinkedList linkedList = new LinkedList();

            public string[] GetStringFromTxt(string path)
            {
                string[]lines = System.IO.File.ReadAllLines(path);
                if (lines.Length == 0)
                { MessageBox.Show("txt 파일이 비어있습니다");}
                else
                { 
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (i == 0) { linkedList.AddFirst(lines[i]); }
                        else { linkedList.Add(lines[i]); }
                    }
                }
                return lines;
            }

        }

        Text_Read_Write m_Text_RW = new Text_Read_Write();

        string[] w_Lines;

        /// <summary>
        /// Upload List and Label
        /// </summary>
        /// <param name="lines"></param>
        private void UpLoad_Label_List(string[] lines)
        {
            if (lines.Length > 0)
            { 
                this.label_Name.Text = lines[0];

                this.listView.Items.Clear();
                this.listView.BeginUpdate();
                for (int i = 0; i < lines.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem($"{i}");
                    lvi.SubItems.Add(lines[i]);
                    this.listView.Items.Add(lvi);
                }
                this.listView.EndUpdate();
                DisplayButton(true,true);
            }
            else
            { 
                this.label_Name.Text = null;
                this.listView.Items.Clear();
                DisplayButton(false);
            }
        }
        
        #region 이벤트 처리
        /// <summary>
        /// Button Click to upload file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt"; // 텍스트 File Only
            theDialog.InitialDirectory = @"C:\Users\KIM\Desktop\OJT_KGB_NO1_DoublyLinkedList\OJT_KGB_NO1_DoublyLinkedList"; // Path Default

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.FileName.ToString(); // File Path
                label_Path.Text = path;
                w_Lines = m_Text_RW.GetStringFromTxt(path);
                UpLoad_Label_List(w_Lines);
            }
        }

        /// <summary>
        /// Button Click to show previous Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Pre_Click(object sender, EventArgs e)
        {
            string preNodeData = m_Text_RW.linkedList.PreFind(label_Name.Text).Data;
            string preNodeHead = m_Text_RW.linkedList.PreFind(label_Name.Text)?.Data;
            label_Name.Text = preNodeData;


            if (preNodeHead == null)
            { button_Pre.Visible = false; }
            else
            {
                DisplayButton(true);
            }
        }

        /// <summary>
        /// Button Click to show next name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Next_Click(object sender, EventArgs e)
        {
            string nextNodeData = m_Text_RW.linkedList.NextFind(label_Name.Text).Next?.Data;
            string nextNodeHead = m_Text_RW.linkedList.NextFind(label_Name.Text).Next.Next?.Data;

            label_Name.Text = nextNodeData;
            
            if (nextNodeHead == null)
            { button_Next.Visible = false; }
            else
            {
                DisplayButton(true);
            }
        }

        /// <summary>
        ///  Button Click to reverse order of Node in LinkedList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reverse_Click(object sender, EventArgs e)
        {
           string[] lines = m_Text_RW.linkedList.Reverse();
           UpLoad_Label_List(lines);
            w_Lines = lines;
        }

        /// <summary>
        ///  Button Click to save file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Save_Click(object sender, EventArgs e)
        {
            string filePath = this.label_Path.Text;
            File.WriteAllLines(filePath, w_Lines);
            MessageBox.Show("저장되었습니다");
        }

    #endregion
    }



}
