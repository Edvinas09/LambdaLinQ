using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaLinQ
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>() { 1,123,1,654,567,987,4,23,132,465,5494,94,61,64,564,651,6,6};

        List<Person> personList = new List<Person>()
        {
            new Person(1, "Jonas", "Lukasaitis", 18),
            new Person(2, "Auguste", "Pavardenis", 29),
            new Person(3, "Kestutis", "Pavardenis", 35),
            new Person(4, "Vardenis", "Pavardenis", 41),
            new Person(5, "Jonas", "Vandenis", 32),
            new Person(6, "Lukas", "test", 19),
            new Person(7, "Petras", "Pavarde", 20),
        };

        List<student> studentList = new List<student>()
        {
            new student(1, "Rokas", "Lukasaitis", 18),
            new student(2, "Deivis", "Pavardenis", 29),
            new student(3, "Jonas", "Pavardenis", 35),
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in numbers)
            {
                if (item %2 ==0)
                {
                    lstData.Items.Add(item);
                }
            }

            lstData.DataSource = numbers.FindAll( myNumberVar => myNumberVar %2 ==0 );



        }

        private void btnLinQ_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in from MyNumberVariable in numbers where MyNumberVariable %2 ==0 select MyNumberVariable)
            {
                lstData.Items.Add(item);
            }


        }

        private void btnFindVardenis_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in personList.FindAll(myPersonVar => myPersonVar.Name == "Vardenis"))
            {
                lstData.Items.Add(item.Name + " " + item.Surname);
            }

        }

        private void btnFindLinQ_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in from myPersonVar in personList where myPersonVar.Name == "Jonas" select myPersonVar)
            {
                lstData.Items.Add(item.Name + " " + item.Surname);
            }

        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in from myPersonVar in personList.OrderBy(p => p.Age).ThenBy(p => p.Name) select myPersonVar)
            {
                lstData.Items.Add($"Vardas: { item.Name} Pavarde: {item.Name} Amzius: {item.Age}");
            }

        }

        private void btnShowOnlyProp_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in from myPersonVar in personList select new { myPersonVar.Name, myPersonVar.Surname})
            {
                lstData.Items.Add(item);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            lstData.DataSource = null;
            lstData.Items.Clear();

            foreach (var item in from myVar in studentList join myPerVar in personList on myVar.Id equals myPerVar.Id select new {Vardas = myPerVar.Name, Pavarde = myVar.Name })
            {
                lstData.Items.Add(item);
            }
        }
    }
}
