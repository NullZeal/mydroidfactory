using Microsoft.Web.WebView2.Core;
using MyDroidFactory.Business;
using MyDroidFactory.Data;

namespace MyDroidFactory.UI;

public partial class Login : Form
{
    private bool thereAreUnsavedChanges = false;

    List<User> listOfUsers = UserXmlData.GetUserList();
    public Login()
    {
        InitializeComponent();
        wvFactoryVideo.Hide();
    }

    public bool isUserAndPasswordComboPresentInCurrentList()
    {
        if (
            listOfUsers.Any(x => x.UserName == txtUsername.Text)
            &&
            listOfUsers.Any(x => x.Password == txtPassword.Text)
            )
            return true;
        else
            return false;
    }

    public bool isUserPresentInCurrentList()
    {
        if (
            listOfUsers.Any(x => x.UserName == txtUsername.Text)
            )
            return true;
        else
            return false;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (isUserAndPasswordComboPresentInCurrentList())
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();

            Hide();
            wvFactoryVideo.Dispose();
        }
        else
        {
            
            MessageBox.Show("Invalid Username or Password",
                            "Invalid Credentials",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }

    private void btnCreateAccount_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text == "" ||
            txtUsername.Text == "")
        {
            MessageBox.Show("An Account must have a username and password.",
                            "Account Creation Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            return;
        }

        if (isUserPresentInCurrentList())
        {
            MessageBox.Show("Username is already taken.",
                "Account Creation Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtPassword.Text = "";
            txtUsername.Text = "";
            return;
        }

        var newUser = new User(txtUsername.Text, txtPassword.Text);
        listOfUsers.Add(newUser);
        UserXmlData.SaveUserList(listOfUsers);
        MessageBox.Show(
            "Success! Account Created.",
            "Account Created",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        txtPassword.Text = "";
        txtUsername.Text = "";
    }



    private void wvFactoryVideo_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
    {
        //playIntroAudio(); Don't need it anymore, since I implemented the automatic mouse click!
        pbLoading.Hide();
        wvFactoryVideo.Show();
        int oldcursorX = Cursor.Position.X;
        int oldcursorY = Cursor.Position.Y;
        Point video = wvFactoryVideo.PointToScreen(Point.Empty);
        video.X += 55;
        video.Y += 155;
        Cursor.Position = video;
        UIIntelligence.DoMouseClick();
        Cursor.Position = new Point(oldcursorX,oldcursorY);
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void Login_FormClosing(object sender, FormClosingEventArgs e)
    {
        string message;
        MessageBoxIcon icon;
        if (thereAreUnsavedChanges)
        {
            message = "*** THERE ARE UNSAVED CHANGES! ***\n\n" +
                      "Do you really want to exit?";
            icon = MessageBoxIcon.Warning;
        }
        else
        {
            message = "Do you really want to exit the login screen?";
            icon = MessageBoxIcon.Information;
        }

        var result = MessageBox.Show(message,
                                     "Confirmation",
                                     MessageBoxButtons.YesNo,
                                     icon);

        if (result == DialogResult.No)
            e.Cancel = true;
    }   
}
