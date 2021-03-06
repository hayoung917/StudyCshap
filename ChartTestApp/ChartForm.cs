﻿using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartTestApp
{
    public partial class ChartForm : MetroForm
    {
        public readonly string strConnstring = 
            "Data Source=localhost;" +
            "Port=3306;" +
            "Database=employees;" +
            "Uid=root;" +
            "Password=mysql_p@ssw0rd";

        public readonly string strQuery = "SELECT CONCAT(em.first_name, ' ', em.last_name) AS emp_name, " +
                                          "       em.gender, " +
                                          "       em.hire_date, " +
                                          "       dp.dept_no, " +
                                          "       dt.dept_name, " +
                                          "       MAX(sl.salary) AS max_salary " +
                                          "  FROM employees AS em " +
                                          " INNER JOIN dept_emp AS dp " +
                                          "    ON em.emp_no = dp.emp_no " +
                                          " INNER JOIN departments AS dt " +
                                          "    ON dp.dept_no = dt.dept_no " +
                                          " INNER JOIN salaries AS sl " +
                                          "    ON em.emp_no = sl.emp_no " +
                                          " WHERE em.hire_date >= '2000-01-01' " +
                                          " GROUP BY em.first_name, em.last_name, em.gender, em.hire_date, dt.dept_name " +
                                          " ORDER BY em.first_name ASC ";

        public ChartForm()
        {
            InitializeComponent();
        }

        private void BtnYValues_Click(object sender, EventArgs e)
        {
            chart1.Series["Score"].Points.Clear();  //처음값 초기화, "Score"대신 인덱스 써도 됨
            chart1.Series[0].Points.Add(98);
            chart1.Series[0].Points.Add(72);
            chart1.Series[0].Points.Add(50);
            chart1.Series[0].Points.Add(100);
            chart1.Series[0].Points.Add(88);
            chart1.Series[0].Points.Add(63);

            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].ChartType = SeriesChartType.Spline;   //타원선 곡선
            //chart1.Series[0].ChartType = SeriesChartType.Area;     //라인그래프 안을 채워줌
            //chart1.Series[0].ChartType = SeriesChartType.Pie;      //원형차트
        }

        private void BtnXYValues_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();  //처음값 초기화
            chart1.Series[0].Points.AddXY("이하영", 98);
            chart1.Series[0].Points.AddXY("김가람", 72);
            chart1.Series[0].Points.AddXY("여예지", 50);
            chart1.Series[0].Points.AddXY("오동욱", 100);
            chart1.Series[0].Points.AddXY("백규현", 88);
            chart1.Series[0].Points.AddXY("임창섭", 63);

            chart1.Series[0].IsValueShownAsLabel = true;

            chart1.Series[0].ChartType = SeriesChartType.Line;  //차트가 막대기에서 선으로 바뀜

        }

        private void BtnDataBind_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("이하영", 98.4));
            students.Add(new Student("임창섭", 63.9));
            students.Add(new Student("백규현", 100.0));
            students.Add(new Student("오동욱", 50.3));
            students.Add(new Student("김가람", 72.7));
            students.Add(new Student("여예지", 88.4));

            chart1.Series[0].Points.DataBind(students, "Name", "Score", null);
            chart1.Series[0].ChartType = SeriesChartType.Bar;
            chart1.Series[0].IsValueShownAsLabel = true;    //그래프 끝에 값 보이게 함
            chart1.Series[0].Color = Color.Bisque;
        }

        private class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score)
            {
                Name = name;
                Score = score;
            }
        }

        private void BtnMultiChart_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Add("area1");
            chart1.ChartAreas.Add("area2");

            chart1.Series.Add("series1");
            chart1.Series.Add("series2");
            chart1.Series.Add("series3");

            chart1.Series["series1"].ChartArea = "area1";
            chart1.Series["series2"].ChartArea = "area2";
            chart1.Series["series3"].ChartArea = "area2";

            chart1.Series["series1"].ChartType = SeriesChartType.Spline;
            chart1.Series["series2"].ChartType = SeriesChartType.Line;
            chart1.Series["series3"].ChartType = SeriesChartType.Bubble;

            chart1.Series["series1"].Color = Color.Red;
            chart1.Series["series2"].Color = Color.Blue;
            chart1.Series["series3"].Color = Color.Green;

            chart1.Series["series1"].Points.AddXY(1, 100);
            chart1.Series["series1"].Points.AddXY(2, 400);
            chart1.Series["series1"].Points.AddXY(3, 200);
            chart1.Series["series1"].Points.AddXY(4, 300);
            chart1.Series["series1"].Points.AddXY(5, 900);

            chart1.Series["series2"].Points.AddXY(1, 120);
            chart1.Series["series2"].Points.AddXY(2, 430);
            chart1.Series["series2"].Points.AddXY(3, 290);
            chart1.Series["series2"].Points.AddXY(4, 380);
            chart1.Series["series2"].Points.AddXY(5, 901);

            chart1.Series["series3"].Points.AddXY(1, 220);
            chart1.Series["series3"].Points.AddXY(2, 330);
            chart1.Series["series3"].Points.AddXY(3, 660);
            chart1.Series["series3"].Points.AddXY(4, 440);
            chart1.Series["series3"].Points.AddXY(5, 550);

            chart1.Series["series3"].Points[3].Color = Color.HotPink;
            chart1.Series["series3"].Points[4].Color = Color.Orange;
        }

        private void BtnDBBind_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(strConnstring))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);    //연동
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);   //adapter로 cmd연동
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                chart1.DataSource = ds.Tables[0];
                chart1.Series[0].XValueMember = "emp_Name";
                chart1.Series[0].YValueMembers = "max_salary";
                chart1.DataBind();

                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1; //x축간격을 1로 지정
                chart1.ChartAreas[0].AxisX.Title = "Employees";
                chart1.ChartAreas[0].AxisY.Title = "Salaries";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "${0,0}";

                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Name = "Salary";
                chart1.Series[0].LabelFormat = "{0,0}";
                chart1.Series[0].Color = Color.DeepPink;
            }
        }
    }
}

