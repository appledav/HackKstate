/* Author: David Apple 
 * Retrieve.cs
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
    public partial class Retrieve : Form
    {
        public Retrieve()
        {
            InitializeComponent();
        }

        uxMainScreen mx = new uxMainScreen();
        StoreNew sn = new StoreNew();
        
        /// <summary>
        /// this will attempt to search for a desired username
        /// if not found, will ask to place in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRetrieveButton_Click(object sender, EventArgs e)
        {
            /*open the file using the openfile diaglog
             * store the file name
             * traverse through the whole file and store all the information into an array of strings
             *      if url matches any value in the file
             *          grab the index at that point and exit the loop
             * username is array at index + 1
             * pasword is array at index + 2
             */
            string fileName;
            int fileLength = 0;

            if(uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = uxOpenDialog.FileName;
                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                {
                    fileLength++;
                    sr.ReadLine();
                }
                sr.Close();

                ///////////////////////////////////////////////////
                ///
                string[] fileContents = new string[fileLength];

                StreamReader sr2 = new StreamReader(fileName);
                int loc = 0;

                while (!sr2.EndOfStream)
                {
                    fileContents[loc] = sr2.ReadLine();
                    loc++;
                }

                int j = 0;
                bool found = false;
                for (int i = 0; i < fileContents.Length; i++)
                {
                    if (fileContents[i] != "")
                    {
                        if (fileContents[i].Substring(5) == uxURLText.Text)
                        {
                            found = true;
                            j = i;
                            break;
                        }
                    }
                }
                sr2.Close();

                if (!found)
                {
                    var result = MessageBox.Show("URL not found, would you like " +
                                "to add to database?", "Enter new", MessageBoxButtons.YesNoCancel);
                    if(result == DialogResult.Yes)
                    {
                        this.Hide();
                        sn.ShowDialog();
                    }
                    else if(result == DialogResult.No)
                    {
                        var newResult = MessageBox.Show("Exit program?" , 
                            "Leave program", MessageBoxButtons.YesNo);
                        if(newResult == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else
                        {

                            this.Refresh();
                            //r.ShowDialog();
                           
                        }
                    }
                    else
                    {
                        this.Refresh();
                        //r.ShowDialog();
                    }
                }
                string newLine = Environment.NewLine;
                string s = fileContents[j + 1] + newLine + fileContents[j + 2];
                uxResults.Text = s;          
            }

        }

        /// <summary>
        /// will return to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mx.ShowDialog();
        }

        /// <summary>
        /// exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
