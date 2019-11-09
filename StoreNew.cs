/* Author: David Apple
 * StoreNew.cs
 */

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

namespace WindowsFormsApp2
{
    public partial class StoreNew : Form
    {
 
        public StoreNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this will cause the current form to close
        /// and to open the old one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            uxMainScreen main = new uxMainScreen();
            main.ShowDialog();
            
        }

        /// <summary>
        /// this will exit the whole application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string fileName;
        StringBuilder sb = new StringBuilder();
        
        /// <summary>
        /// will store the information in the textfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStore_Click(object sender, EventArgs e)
        {

            //algorithm to open up a file to write to
            if(uxOpen.ShowDialog() == DialogResult.OK)
            {
                string info = "URL: " + uxUrlTextBox.Text + "\n" +
                    "Username: " + uxUsernameTextBox.Text + "\n" +
                    "Password: " +uxPasswordTextBox.Text + "\n\n";

                fileName = uxOpen.FileName; 
                StreamWriter sw = new StreamWriter(fileName, true); // appending to the text file
                sw.WriteLine(info);

                sw.Close();
            }

            //clearing the textboxes to make room for new entries

            uxUrlTextBox.Clear();
            uxUsernameTextBox.Clear();
            uxPasswordTextBox.Clear();
            
            
        }
    }
}
