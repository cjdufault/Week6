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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string newToDo = txtNewToDo.Text;

            if (!String.IsNullOrWhiteSpace(newToDo)){ // do nothing if field is empty
                if (ItemExists(newToDo))
                {
                    MessageBox.Show("Item already exists");
                    txtNewToDo.Clear();
                }
                else
                {
                    clsToDo.Items.Add(newToDo);
                    txtNewToDo.Clear();
                    txtNewToDo.Focus();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> toRemove = new List<string>();

            // add checked items to lstDone and toRemove
            foreach(string item in clsToDo.CheckedItems)
            {
                toRemove.Add(item);
                lstDone.Items.Add(item);
            }

            // remove all items that were added to toRemove from clsToDo.Items
            foreach(string item in toRemove)
            {
                clsToDo.Items.Remove(item);
            }
        }

        // tests if an item is already in clsToDo.Items, regardless of case
        private bool ItemExists(string testItem)
        {
            string testItemLower = testItem.ToLower();
            bool exists = false;
            
            // compare each item to testItem, set exists to true and break if one does
            foreach(string compareItem in clsToDo.Items)
            {
                string compareItemLower = compareItem.ToLower();
                if (testItemLower.Equals(compareItemLower))
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
