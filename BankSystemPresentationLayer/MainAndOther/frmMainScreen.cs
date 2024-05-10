using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_System_Business_Layer;
using BankSystemBusinessLayer;
using BankSystemPresentationLayer.Transactions;
using BankSystemPresentationLayer.Users;

namespace BankSystemPresentationLayer
{
    public partial class frmMainScreen : Form
    {
        
        clsUser _CurrentUser;
        private int _UserID;
        public frmMainScreen(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        private void CenterChildForm(Form childForm)
        {
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;

            childForm.Location = new Point(x, y);
        }
        private void MaximazeFormWhenLoad()
        {
            
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            //TopMost = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick_1(sender, e);
            _CurrentUser = clsUser.Find(_UserID);
            lblCurrentUser.Text = _CurrentUser.UserName;
            MaximazeFormWhenLoad();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (true)
            {
                timer1.Interval = 1000;
                timer1.Start();
                lblCurrentDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            }

        }

        private void lblCurrentDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnableMainMenueControls()
        {
            pictureBox1.Visible = true;
            lblCurrentDate.Visible = true;
            lblCurrentUser.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void DisableMainMenueControls()
        {
            pictureBox1.Visible = false;
            lblCurrentDate.Visible = false;
            lblCurrentUser.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void EnableMainMenuControlsForPeople(object sender)
        {
            EnableMainMenueControls();
           PeopleMenu.Enabled = true;
        }
        private void DisableMainMenuControlsForPeople()
        {
            DisableMainMenueControls();
            PeopleMenu.Enabled = false;
        }

        private void EnableMainMenuControlsForUsers(object sender)
        {
            EnableMainMenueControls();
            UsersMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForUsers()
        {
            DisableMainMenueControls();
            UsersMenu.Enabled = false;
        }

        private void EnableMainMenuControlsForClients(object sender)
        {
            EnableMainMenueControls();
            ClientsMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForClients()
        {
            DisableMainMenueControls();
            ClientsMenu.Enabled = false;
        }

        private void DisableMainMenuControlsForDeposits()
        {
            DisableMainMenueControls();
            DepositMenu.Enabled = false;
        }
        private void EnableMainMenuControlsForDeposits(object sender)
        {
            EnableMainMenueControls();
            DepositMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForWithdrawls()
        {
            DisableMainMenueControls();
            WithdrawMenu.Enabled = false;
        }
        private void EnableMainMenuControlsForWithdrawls(object sender)
        {
            EnableMainMenueControls();
            WithdrawMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForTransfer()
        {
            DisableMainMenueControls();
            TransferMenu.Enabled = false;
        }
        private void EnableMainMenuControlsForTransfer(object sender)
        {
            EnableMainMenueControls();
            TransferMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForLogedinUser()
        {
            DisableMainMenueControls();
            logedInUserInfoMenu.Enabled = false;
        }
        private void EnableMainMenuControlsForLogedinUser(object sender)
        {
            EnableMainMenueControls();
            logedInUserInfoMenu.Enabled = true;
        }

        private void DisableMainMenuControlsForChangePasswordMenu()
        {
            DisableMainMenueControls();
            changePasswordMenu.Enabled = false;
        }
        private void EnableMainMenuControlsForChangePasswordMenu(object sender)
        {
            EnableMainMenueControls();
            changePasswordMenu.Enabled = true;
        }
        
        private void RejectToShowScreen()
        {
            MessageBox.Show("Access Denied Contact Your Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(!clsPermissions.HasPermission(_CurrentUser.Permission,Convert.ToInt32(clsPermissions.enPermission.People)))
            {
                RejectToShowScreen();
                return;
            }
            if (IsMeueItemOpend(UsersMenu)|| IsMeueItemOpend(ClientsMenu)||IsMeueItemOpend(DepositMenu)
                || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu) || IsMeueItemOpend(logedInUserInfoMenu))
                return;
            frmPeople frm = new frmPeople();
            frm.MdiParent = this;
            DisableMainMenuControlsForPeople();
            //when close Form Enable Main Menu Logo
            frm.DataBack += EnableMainMenuControlsForPeople;
            frm.Show();

            return;
        
        }

       

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.HasPermission(_CurrentUser.Permission, Convert.ToInt32(clsPermissions.enPermission.Users)))
            {
                RejectToShowScreen();
                return;
            }
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu)|| IsMeueItemOpend(ClientsMenu) || IsMeueItemOpend(DepositMenu)
                || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu) || IsMeueItemOpend(logedInUserInfoMenu))
                return;
            frmUsers frm1 = new frmUsers();
            frm1.MdiParent = this;
            DisableMainMenuControlsForUsers();
            //when close Form Enable Main Menu Logo
            frm1.DataBack += EnableMainMenuControlsForUsers;

            frm1.Show();
        }

        private bool IsMeueItemOpend(ToolStripMenuItem Screen)
        {
            //if screen is opend
            if (Screen.Enabled ==  false) 
                return true;

            return false;
        }
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.HasPermission(_CurrentUser.Permission, Convert.ToInt32(clsPermissions.enPermission.Clients)))
            {
                RejectToShowScreen();
                return;
            }
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(DepositMenu)
                || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu) || IsMeueItemOpend(logedInUserInfoMenu)
                 || IsMeueItemOpend(changePasswordMenu))
                return;

            frmClients frm1 = new frmClients();
            frm1.MdiParent = this;
            DisableMainMenuControlsForClients();
            //when close Form Enable Main Menu Logo
            frm1.DataBack += EnableMainMenuControlsForClients;
            frm1.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.HasPermission(_CurrentUser.Permission, Convert.ToInt32(clsPermissions.enPermission.Deposits)))
            {
                RejectToShowScreen();
                return;
            }
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(ClientsMenu) 
                || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu) || IsMeueItemOpend(logedInUserInfoMenu)
                 || IsMeueItemOpend(changePasswordMenu))
                return;
            frmDepositMain frm1 = new frmDepositMain();
            frm1.MdiParent = this;
            DisableMainMenuControlsForDeposits();
            //when close Form Enable Main Menu Logo
            frm1.DataBack += EnableMainMenuControlsForDeposits;
            frm1.Show();
        }

        private void WithdrawMenu_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.HasPermission(_CurrentUser.Permission, Convert.ToInt32(clsPermissions.enPermission.Withdrawls)))
            {
                RejectToShowScreen();
                return;
            }
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(ClientsMenu)
                || IsMeueItemOpend(DepositMenu) || IsMeueItemOpend(TransferMenu) || IsMeueItemOpend(logedInUserInfoMenu)
                 || IsMeueItemOpend(changePasswordMenu))
                return;
            frmWithdrawlsMain frm1 = new frmWithdrawlsMain();
            frm1.MdiParent = this;
            DisableMainMenuControlsForWithdrawls();
            //when close Form Enable Main Menu Logo
            frm1.DataBack += EnableMainMenuControlsForWithdrawls;
            frm1.Show();
        }

        private void TransferMenu_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.HasPermission(_CurrentUser.Permission, Convert.ToInt32(clsPermissions.enPermission.Transfer)))
            {
                RejectToShowScreen();
                return;
            }
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(ClientsMenu)
                || IsMeueItemOpend(DepositMenu) || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(logedInUserInfoMenu)
                 || IsMeueItemOpend(changePasswordMenu))
                return;
            frmTransfersMain frm1 = new frmTransfersMain();
            frm1.MdiParent = this;
            DisableMainMenuControlsForTransfer();
           //when close Form Enable Main Menu Logo
            frm1.DataBack += EnableMainMenuControlsForTransfer;
            frm1.Show();
        }

        

        private void changePasswordMenu_Click(object sender, EventArgs e)
        {
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(ClientsMenu)
                 || IsMeueItemOpend(DepositMenu) || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu)
                  || IsMeueItemOpend(logedInUserInfoMenu))
                return;
            frmChangeUserPassword frm = new frmChangeUserPassword(_CurrentUser.UserID);
            frm.MdiParent = this;
            DisableMainMenuControlsForChangePasswordMenu();
            //when close Form Enable Main Menu Logo
            frm.DataBack += EnableMainMenuControlsForChangePasswordMenu;
            frm.Show();
        }

        private void logedInUserInfoMenu_Click(object sender, EventArgs e)
        {
            //if any form is opend we cant open this form
            if (IsMeueItemOpend(PeopleMenu) || IsMeueItemOpend(UsersMenu) || IsMeueItemOpend(ClientsMenu)
                 || IsMeueItemOpend(DepositMenu) || IsMeueItemOpend(WithdrawMenu) || IsMeueItemOpend(TransferMenu)
                 || IsMeueItemOpend(changePasswordMenu))
                return;
            frmUserDetalis frm = new frmUserDetalis(_CurrentUser.UserID);
            frm.MdiParent = this;
            DisableMainMenuControlsForLogedinUser();
            //when close Form Enable Main Menu Logo
            frm.DataBack += EnableMainMenuControlsForLogedinUser;
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginScreen frm = new frmLoginScreen();
            this.Hide();
            frm.ShowDialog();
            
            
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
