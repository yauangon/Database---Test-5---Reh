﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team11
{
    public partial class MainForm : Form
    {
        SqlConnection connect = new SqlConnection();
        public MainForm()
        {
            InitializeComponent();
            connect.ConnectionString = @"Data Source=DESKTOP-MUE9P6C\SQLEXPRESS;Initial Catalog=CS486_Team11_DB;Integrated Security=True";
            connect.Open();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            
            AddSongForm nf = new AddSongForm(connect);
            nf.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }
    }
}
