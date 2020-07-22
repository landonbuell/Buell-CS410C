using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            // Constructor for FormMain object
            InitializeComponent();
            initSubMenu();
            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void initSubMenu()
        {
            panelSubmenu1.Visible = false;
            panelSubmenu2.Visible = false;
            panelSubmenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            // Hide all submenu panel objects
            if (panelSubmenu1.Visible == true)
                panelSubmenu1.Visible = false;
            if (panelSubmenu2.Visible == true)
                panelSubmenu2.Visible = false;
            if (panelSubmenu3.Visible == true)
                panelSubmenu3.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            // Show submenu panel when clicked
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu3);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
