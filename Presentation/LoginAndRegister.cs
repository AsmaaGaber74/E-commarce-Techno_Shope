﻿using Appliaction.Contract;
using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class LoginAndRegister : Form
    {
        AdminPanal adminPanal;

        public string NameofAdmin { get; set; }


        private readonly    IUserService userService;
        public LoginAndRegister()
        {
            InitializeComponent();

            userService = new UserService(new UserRepository(new _Context()));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {

            // Show the login panel
            panel_login.BringToFront();
        }

        private void button_GoTo_Register_Click(object sender, EventArgs e)
        {
            // Show the register panel
            panel_register.BringToFront();
        }



        private void pictureBox1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonٌُ_ٌRegister_Click(object sender, EventArgs e)
        {
            string firstName = textBox_FName.Text;
            string lastName = textBox_LName.Text;
            string username = textBox_UName.Text;
            string Email = textBox_eimal.Text;
            string password = textBox_Pass.Text;
            string confirmPassword = textBox_Confirm_Pass.Text;
            string phoneNumber = textBox_Phone_Number.Text;


            if (!userService.IsUsernameAvailable(username))
            {
                // Username is available, add the user to the database

                if (password == confirmPassword)
                {


                    User newUser = new User
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserName = username,
                        Password = password,
                        Email = Email,


                        PhoneNumber = Convert.ToInt32(phoneNumber)
                    };

                    userService.AddUser(newUser);


                    // MessageBox.Show("User registered successfully!");
                    label_User_regis.Text = "User registered successfully!";

                }
                else
                {
                    
                    label_ErrorMas.Text = ("Error password Please enter correct password");
                    label_User_regis.Text = ("");
                }


                //else 

            }
            else
            {
                label_ErrorMas.Text = ("Username is available. Please choose another username.");
                label_User_regis.Text = ("");
            }


        }

        private void label_FName_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_UName_Login.Text;
            string password = textBox_Pss_login.Text;



            User user = userService.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {

                label_log_suc.Text = ("Login successful!");
                label_error_mas_log.Text = (" ");
                //  Logic to handle  Role
                if (userService.GetUserRole(user) == "admin")
                {
                    NameofAdmin = user.FirstName + "  " + user.LastName;
                    adminPanal = new AdminPanal(NameofAdmin);
                    this.Hide();
                    adminPanal.Show();
                    
                }

            }
            else
            {
                label_error_mas_log.Text = ("Login failed. Please check the username and password.");
                label_log_suc.Text=(" ");
            }
        }

        private void textBox_LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UName_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Pass_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Confirm_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label_UName_Click(object sender, EventArgs e)
        {

        }

        private void label_LName_Click(object sender, EventArgs e)
        {

        }

        private void panel_register_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PNumber_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Number_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Phone_Number.Text, out int phoneNumber))
            {

                Console.WriteLine($"Phone Number: {phoneNumber}");
            }
            else
            {

                MessageBox.Show("Please enter a valid numeric value for the phone number.");
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_eimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrorMas_Click(object sender, EventArgs e)
        {

        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}