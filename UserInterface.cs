/* Author: David Apple
 * UserInterface.cs
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

namespace WindowsFormsApp2
{
    public partial class uxMainScreen : Form
    {
        public uxMainScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// new form will appear and hide the current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStoreNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreNew sn = new StoreNew();
            sn.ShowDialog();
            
            
        }

        /// <summary>
        /// new form will appear and hide the current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRetrieve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retrieve r = new Retrieve();
            r.ShowDialog();
        }
    }
}
