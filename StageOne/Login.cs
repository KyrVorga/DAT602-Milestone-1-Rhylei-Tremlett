﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageOne
{
    public partial class Login : Form
    {
        private Registration _registration_form;
        public Login()
        {
            InitializeComponent();
        }
        public Login(Registration? register)
            : this()
        {
            _registration_form = register;
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            LoginAndRegistrationDAO db_connection = new();


            if (db_connection.LoginUser(username, password))
            {
                MessageBox.Show("Logged in successfully.");
                this.Hide();
                Game game = new Game(this, username);
                game.Show();
            }
            else
            {
                MessageBox.Show("Login failed, please try again.");
            }
        }

        private void redirect_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration register = new Registration(this);
            register.Show();
        }
    }
}
