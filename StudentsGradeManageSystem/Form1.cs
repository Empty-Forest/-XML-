using System.Xml;

namespace StudentsGradeManageSystem
{
    public partial class Form1 : Form
    {
        XMLUse xmlUse = new XMLUse();
        public Form1()
        {
            InitializeComponent();
            //����ļ�·����û��Students.xml�ļ����򴴽�����
            if (!File.Exists("Students.xml"))
            {
                xmlUse.CreateXML();//����xml�ļ�
                ScreenXML();
            }
            else
            {
                ScreenXML();
            }
        }
        private void ScreenXML()//��ʾ�ļ��е�����ѧ������ɼ�
        {
            //������б�������
            StudentList.Rows.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            //��ȡ�ļ�
            xmlDoc.Load("Students.xml");
            //��ȡ���ڵ�students
            XmlElement students = xmlDoc.DocumentElement;
            //��ȡ���ڵ������е��ӽڵ�
            XmlNodeList student = students.ChildNodes;
            int studentCount = student.Count;
            //ѭ�������ӽڵ�
            for (int i = 0; i < studentCount; i++)
            {
                string sNum = student[i].NamespaceURI;
                string sName = student[i].LocalName;
                //�ӽڵ������е�����
                string sSex = student[i]["Sex"].InnerText;
                string sC = student[i]["Chinese"].InnerText;
                string sM = student[i]["Math"].InnerText;
                string sE = student[i]["English"].InnerText;
                string[] sRow = { sNum, sName, sSex, sC, sM, sE };
                StudentList.Rows.Add(sRow);
            }
        }
        private void RefreshTextbox()//�����������
        {
            numText.Text = "";
            nameText.Text = "";
            sexText.Text = "";
            chineseText.Text = "";
            mathText.Text = "";
            englishText.Text = "";
        }
        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)//�ı�ѡȡ
        {
            numText.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
            nameText.Text = StudentList.SelectedRows[0].Cells[1].Value.ToString();
            sexText.Text = StudentList.SelectedRows[0].Cells[2].Value.ToString();
            chineseText.Text = StudentList.SelectedRows[0].Cells[3].Value.ToString();
            mathText.Text = StudentList.SelectedRows[0].Cells[4].Value.ToString();
            englishText.Text = StudentList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void FindBt_Click(object sender, EventArgs e)//��ѯ��ť
        {
            XmlDocument xmlDoc = new XmlDocument();
            //��ȡ�ļ�
            xmlDoc.Load("Students.xml");
            //��ȡ���ڵ�students
            XmlElement students = xmlDoc.DocumentElement;
            if (nameText.Text != "" && numText.Text == "")
            {
                if (students[nameText.Text] != null)//ֻ������
                {
                    XmlElement student = students[nameText.Text];
                    numText.Text = students[nameText.Text].NamespaceURI;
                    sexText.Text = student["Sex"].InnerText;
                    chineseText.Text = student["Chinese"].InnerText;
                    mathText.Text = student["Math"].InnerText;
                    englishText.Text = student["English"].InnerText;
                    MessageBox.Show("�Ѳ��ҵ�������");
                }
                else
                {
                    MessageBox.Show("����������!");
                }
            }
            else if (nameText.Text != "" && numText.Text != "")//ѧ�ź����ֶ���
            {
                if (students[nameText.Text, numText.Text] != null)
                {
                    XmlElement student = students[nameText.Text, numText.Text];
                    numText.Text = students[nameText.Text].NamespaceURI;
                    sexText.Text = student["Sex"].InnerText;
                    chineseText.Text = student["Chinese"].InnerText;
                    mathText.Text = student["Math"].InnerText;
                    englishText.Text = student["English"].InnerText;
                    MessageBox.Show("�Ѳ��ҵ�������");
                }
                else
                {
                    MessageBox.Show("����������!");
                }
            }
            else if (nameText.Text == "" && numText.Text != "")//ֻ��ѧ��
            {
                //��������ѧ��
                XmlNodeList allStudents = students.ChildNodes;
                //������ѧ����ѧ��,�����ѧ�Ŷ��ϣ��������������ʾ����������
                bool studentNum = false;//��Ϊ�Ƿ�鵽��ѧ��������
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
                    MessageBox.Show("�Ѳ��ҵ�������");
                }
                else
                {
                    MessageBox.Show("����������!");
                }
            }
            else
            {
                MessageBox.Show("��ѡ����ȷ��ѧ��");
            }
        }

        private void RefreshBt_Click(object sender, EventArgs e)//��հ�ť
        {
            RefreshTextbox();
            ScreenXML();
        }

        private void AddBt_Click(object sender, EventArgs e)//���Ӱ�ť
        {
            xmlUse.AddXML(numText.Text, nameText.Text, sexText.Text, chineseText.Text, mathText.Text, englishText.Text);
            RefreshTextbox();
            ScreenXML();
        }

        private void EditBt_Click(object sender, EventArgs e)//�޸İ�ť
        {
            xmlUse.EditXML(numText.Text, nameText.Text, sexText.Text, chineseText.Text, mathText.Text, englishText.Text);
            RefreshTextbox();
            ScreenXML();
        }

        private void DeleteBt_Click(object sender, EventArgs e)//ɾ����ť
        {
            xmlUse.RemoveXML(numText.Text, nameText.Text);
            RefreshTextbox();
            ScreenXML();
        }
    }
}
