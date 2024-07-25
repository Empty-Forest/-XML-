using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudentsGradeManageSystem
{
    internal class XMLUse
    {
        public void CreateXML()//创建XML文件
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建一个声明XML文档的内容，并加入进XML文档作为第一行声明
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            xmlDoc.AppendChild(xmlDeclaration);
            //创建一个根节点（必须的），否则无法创建出XML文档
            XmlElement students = xmlDoc.CreateElement("Students");
            xmlDoc.AppendChild(students);
            //保存XML文件,文件名为Study.Xml
            xmlDoc.Save("Students.xml");
        }
        public void AddXML(string num, string name, string sex, string chinese, string math, string english)//增加XML中的元素
        {
            XmlDocument xmlDoc = new XmlDocument();
            //读取文件
            xmlDoc.Load("Students.xml");
            //获取根节点students
            XmlElement students = xmlDoc.DocumentElement;
            //创建名称为传入的name参数，以学号num为其namespaceURI的子节点
            if (num == "" || name == "" || sex == "" || chinese == "" || math == "" || english == "")
            {
                MessageBox.Show("请将学生信息填写完整");
            }
            else
            {
                if (students[name, num] != null)
                {
                    MessageBox.Show("该生已存在！");
                }
                else
                {
                    XmlElement student = xmlDoc.CreateElement(name, num);
                    students.AppendChild(student);
                    //在子节点student下面创建孙节点：性别、语文成绩、数学成绩、英语成绩
                    XmlElement sSex = xmlDoc.CreateElement("Sex");//性别
                    sSex.InnerText = sex;
                    student.AppendChild(sSex);
                    XmlElement sChinese = xmlDoc.CreateElement("Chinese");//语文成绩
                    sChinese.InnerText = chinese;
                    student.AppendChild(sChinese);
                    XmlElement sMath = xmlDoc.CreateElement("Math");//数学成绩
                    sMath.InnerText = math;
                    student.AppendChild(sMath);
                    XmlElement sEnglish = xmlDoc.CreateElement("English");//英语成绩
                    sEnglish.InnerText = english;
                    student.AppendChild(sEnglish);
                    //保存
                    xmlDoc.Save("Students.xml");
                    MessageBox.Show("添加成功！");
                }
            }
        }
        public void EditXML(string num, string name, string sex, string chinese, string math, string english)//修改XML中的元素
        {
            XmlDocument xmlDoc = new XmlDocument();
            //读取文件
            xmlDoc.Load("Students.xml");
            //获取根节点students
            XmlElement students = xmlDoc.DocumentElement;
            //修改根节点下传入名字为name,学号为num的子节点
            if (num == "" || name == "")
            {
                MessageBox.Show("请选择正确的学生");
            }
            else
            {
                if (students[name, num] == null)
                {
                    MessageBox.Show("该生不存在!");
                }
                else
                {
                    XmlElement student = students[name, num];
                    student["Sex"].InnerText = sex;
                    student["Chinese"].InnerText = chinese;
                    student["Math"].InnerText = math;
                    student["English"].InnerText = english;
                    xmlDoc.Save("Students.xml");
                    MessageBox.Show("修改成功！");
                }
            }
        }
        public void RemoveXML(string num, string name)//删除XML中的元素
        {
            XmlDocument xmlDoc = new XmlDocument();
            //读取文件
            xmlDoc.Load("Students.xml");
            //获取根节点students
            XmlElement students = xmlDoc.DocumentElement;
            //删除根节点下传入名字为name,学号为num的子节点
            if (num == "" || name == "")
            {
                MessageBox.Show("请选择正确的学生");
            }
            else
            {
                if (students[name, num] == null)
                {
                    MessageBox.Show("该生不存在!");
                }
                else
                {
                    students.RemoveChild(students[name, num]);
                    xmlDoc.Save("Students.xml");
                    MessageBox.Show("删除成功！");
                }
            }
        }
    }
}
