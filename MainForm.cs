using System.Security.Principal;
using Todolist.UserControls;

namespace Todolist;

public partial class MainForm : Form
{

    List<string> myAc = new List<string>
    {
            "Đọc sách",
            "Tập thể dục",
            "Học lập trình",
            "Nấu ăn",
            "Gọi điện cho gia đình"
    };

    public MainForm()
    {
        InitializeComponent();
    }


    private void panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    void addUserControl(UserControl userControl)
    {
        userControl.Dock = DockStyle.Fill;
        panelContainer.Controls.Clear();
        panelContainer.Controls.Add(userControl);
    }

    //DIeu huong Tab
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        UC_todayActivities ut = new UC_todayActivities();
        addUserControl(ut);
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        UC_Home uh = new UC_Home();
        addUserControl(uh);
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        UC_Account ua = new UC_Account();
        addUserControl(ua);
    }
}