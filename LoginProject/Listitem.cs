using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Listitem : UserControl
    {
        public Listitem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _type;
        private Image _icon;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; lblType.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picPoke.Image = value; }
        }


        #endregion

        private void Listitem_Load(object sender, EventArgs e)
        {
            this.TabStop = false;
        }
    }
}
