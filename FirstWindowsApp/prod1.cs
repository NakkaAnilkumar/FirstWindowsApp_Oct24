using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApp
{
    public partial class prod1 : Form
    {
        public prod1()
        {
            InitializeComponent();
           
        }

        

        private void prod1_Load(object sender, EventArgs e)
        {
            // Create a list of product items
            List<string> productItems = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
                "Item 6",
                "Item 7",
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
                "Item 6",
                "Item 7",
                 "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
                "Item 6",
                "Item 7",
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
                "Item 6",
                "Item 7",
                
                // Add more product items as needed
            };



            // Add the product items to the ListBox
            listBox1.Items.AddRange(productItems.ToArray());



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
