﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatDesign
{
    public partial class MessageBox : UserControl
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        private string _username;
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value; bunifuLabel1.Text = value;
            }


        }
    }
}
