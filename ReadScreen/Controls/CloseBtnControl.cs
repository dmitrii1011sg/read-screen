using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class CloseBtnControl : UserControl
    {
        public CloseBtnControl()
        {
            InitializeComponent();
        }

        public event EventHandler CloseButtonClick
        {
            add { buttonClose.Click += value; }
            remove { buttonClose.Click -= value; }
        }
    }
}
