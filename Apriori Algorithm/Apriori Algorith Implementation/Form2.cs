using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apriori_Algorith_Implementation
{
    public partial class Form2 : Form
    {
        public List<List<string>> Data { get; set; }
        public Form2(List<List<string>> data)
        {
            InitializeComponent();
            foreach (var item in data)
            {
                richTextBox2.AppendText(string.Join(" ", item.ToArray()) + "\n");
            }
        }
    }
}
