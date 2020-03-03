using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace combox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student student = new Student();     //创建一个Student对象的实例

            CB_Grades.DataContext = student; //指定Text属性的数据上下文，CB_Grades为 ComboBox 的 name 属性



            List<Grades> grades = new List<Grades>(); //创建一个List<Grades>集合，并初始化对象

            grades.Add(new Grades { GradeID = 1, GradeName = "高一" });

            grades.Add(new Grades { GradeID = 2, GradeName = "高二" });

            grades.Add(new Grades { GradeID = 3, GradeName = "高三" });



            CB_Grades.ItemsSource = grades;  //指定下拉列表的 ItemsSource 数据源 ，CB_Grades为 ComboBox 的 name 属性
        }

      }
    public class Grades

    {

        public int GradeID { get; set; }

        public string GradeName { get; set; }

    }
    public class Student

    {

        int ID { get; set; }

        string Name { get; set; }

        string Sex { get; set; }

        int Age { get; set; }

        string Grade { get; set; }

        string Class { get; set; }

    }

}
