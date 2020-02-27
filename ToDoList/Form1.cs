using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<string> toDoList= new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string newToDo = txtNewToDo.Text;
            toDoList.Add(newToDo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
