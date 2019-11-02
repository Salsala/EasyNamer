using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyNamer
{
    public partial class FileListControl : UserControl
    {
        public string ListName { set => label1.Text = value; }
        public FileListControl()
        {
            InitializeComponent();
        }

    }
}
