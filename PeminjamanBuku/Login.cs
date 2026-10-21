using Microsoft.EntityFrameworkCore;
using PeminjamanBuku.Data;
using PeminjamanBuku.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeminjamanBuku
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    btnLogin.Enabled = false;

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    var login = await context.Operators.Include(o => o.Role).FirstOrDefaultAsync(o => o.Username == username && o.Password == password);

                    if (login != null)
                    {
                        Session.OperatorId = login.OperatorId;
                        Session.Username = login.Username;
                        Session.Password = login.Password;
                        Session.Role = login.Role.NamaRole;

                        if (login.Role.NamaRole.ToLower() == "admin")
                        {
                            new AdminForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            new Dashboard().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("username atau password salahh!!!", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnLogin.Enabled = true;
                }
            }
        }
    }
}
