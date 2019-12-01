﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
 
namespace UserMaintenance
{ 
    public BindingList<User> users = new BindingList<User>();
    
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            lblFullName.Text = Resource1.FullName; // label1

            btnAdd.Text = Resource1.Add; // button1

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLastName.Text
            };
            users.Add(u);
        }
    }
}
