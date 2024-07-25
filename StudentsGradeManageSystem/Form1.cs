using System.Xml;

namespace StudentsGradeManageSystem
{
    public partial class Form1 : Form
    {
        XMLUse xmlUse = new XMLUse();
        public Form1()
        {
            InitializeComponent();
            //如果文件路径上没有Students.xml文件，则创建出来
            if (!File.Exists("Students.xml"))
            {
                xmlUse.CreateXML();//创建xml文件
                ScreenXML();
            }
            else
            {
                ScreenXML();
            }
        }
        private void ScreenXML()//显示文件中的所有学生及其成绩
        {
            //清空所有表中数据
            StudentList.Rows.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            //读取文件
            xmlDoc.Load("Students.xml");
            //获取根节点students
            XmlElement students = xmlDoc.DocumentElement;
            //获取根节点下所有的子节点
            XmlNodeList student = students.ChildNodes;
            int studentCount = student.Count;
            //循环所有子节点
            for (int i = 0; i < studentCount; i++)
            {
                string sNum = student[i].NamespaceURI;
                string sName = student[i].LocalName;
                //子节点下所有的数据
                string sSex = student[i]["Sex"].InnerText;
                string sC = student[i]["Chinese"].InnerText;
                string sM = student[i]["Math"].InnerText;
                string sE = student[i]["English"].InnerText;
                string[] sRow = { sNum, sName, sSex, sC, sM, sE };
                StudentList.Rows.Add(sRow);
            }
        }
        private void RefreshTextbox()//清空文字内容
        {
            numText.Text = "";
            nameText.Text = "";
            sexText.Text = "";
            chineseText.Text = "";
            mathText.Text = "";
            englishText.Text = "";
        }
        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)//文本选取
        {
            numText.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
            nameText.Text = StudentList.SelectedRows[0].Cells[1].Value.ToString();
            sexText.Text = StudentList.SelectedRows[0].Cells[2].Value.ToString();
            chineseText.Text = StudentList.SelectedRows[0].Cells[3].Value.ToString();
            mathText.Text = StudentList.SelectedRows[0].Cells[4].Value.ToString();
            englishText.Text = StudentList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void FindBt_Click(object sender, EventArgs e)//查询按钮
        {
            XmlDocument xmlDoc = new XmlDocument();
            //读取文件
            xmlDoc.Load("Students.xml");
            //获取根节点students
            XmlElement students = xmlDoc.DocumentElement;
            if (nameText.Text != "" && numText.Text == "")
            {
                if (students[nameText.Text] != null)//只填名字
                {
                    XmlElement student = students[nameText.Text];
                    numText.Text = students[nameText.Text].NamespaceURI;
                    sexText.Text = student["Sex"].InnerText;
                    chineseText.Text = student["Chinese"].InnerText;
                    mathText.Text = student["Math"].InnerText;
                    englishText.Text = student["English"].InnerText;
                    MessageBox.Show("已查找到该生！");
                }
                else
                {
                    MessageBox.Show("该生不存在!");
                }
            }
            else if (nameText.Text != "" && numText.Text != "")//学号和名字都填
            {
                if (students[nameText.Text, numText.Text] != null)
                {
                    XmlElement student = students[nameText.Text, numText.Text];
                    numText.Text = students[nameText.Text].NamespaceURI;
                    sexText.Text = student["Sex"].InnerText;
                    chineseText.Text = student["Chinese"].InnerText;
                    mathText.Text = student["Math"].InnerText;
                    englishText.Text = student["English"].InnerText;
                    MessageBox.Show("已查找到该生！");
                }
                else
                {
                    MessageBox.Show("该生不存在!");
                }
            }
            else if (nameText.Text == "" && numText.Text != "")//只填学号
            {
                //遍历所有学生
                XmlNodeList allStudents = students.ChildNodes;
                //查所有学生的学号,如果有学号对上，则输出，否则显示该生不存在
                bool studentNum = false;//作为是否查到了学生的依据
                foreach (XmlNode student in allStudents)
                {
                    if (student.NamespaceURI == numText.Text)
                    {
                        nameText.Text = student.Name;
                        sexText.Text = student["Sex"].InnerText;
                        chineseText.Text = student["Chinese"].InnerText;
                        mathText.Text = student["Math"].InnerText;
                        englishText.Text = student["English"].InnerText;
                        studentNum = true;
                        break;
                    }
                }
                if (studentNum == true)
                {
                    MessageBox.Show("已查找到该生！");
                }
                else
                {
                    MessageBox.Show("该生不存在!");
                }
            }
            else
            {
                MessageBox.Show("请选择正确的学生");
            }
        }

        private void RefreshBt_Click(object sender, EventArgs e)//清空按钮
        {
            RefreshTextbox();
            ScreenXML();
        }

        private void AddBt_Click(object sender, EventArgs e)//增加按钮
        {
            xmlUse.AddXML(numText.Text, nameText.Text, sexText.Text, chineseText.Text, mathText.Text, englishText.Text);
            RefreshTextbox();
            ScreenXML();
        }

        private void EditBt_Click(object sender, EventArgs e)//修改按钮
        {
            xmlUse.EditXML(numText.Text, nameText.Text, sexText.Text, chineseText.Text, mathText.Text, englishText.Text);
            RefreshTextbox();
            ScreenXML();
        }

        private void DeleteBt_Click(object sender, EventArgs e)//删除按钮
        {
            xmlUse.RemoveXML(numText.Text, nameText.Text);
            RefreshTextbox();
            ScreenXML();
        }
    }
}
