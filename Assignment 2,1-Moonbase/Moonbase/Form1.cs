using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moonbase
{
    public partial class MoonbaseAssignment1 : Form
    {
        private readonly UserPositionTracker _positionTracker;

        public MoonbaseAssignment1()

        {

            InitializeComponent();
            _positionTracker = new UserPositionTracker();
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            _positionTracker.UserPosition = e.Location;
        }
        //A strip menu I added to create a couple of drop down menu opions. 
        private void MinFacialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //A button I created to indicate a coupon code when clicked.  I also loaded an image in the property.
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the code MOONDANCE for 20% off treatment ");
        

        }
        // The button North will open a new form when clicked, creating the check in lounge area.
        private void ButtonNorth_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show();
        }
        //The button West will open a third form when clicked, creating the sauna area.
        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        //The button East will open a fourth form when clicked, creating the salt room.
        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(); 
        }
        //I changed the cursor to a hand icon when you hover over the button.
        private void Hand(object sender, EventArgs e)
        {
            buttonNorth.Cursor = Cursors.Hand;
        }
        //Here the South button directs you to form 5 when you click it.  
        private void Button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        //cursors set for all buttons here
        private void MoonbaseAssignment1_Load(object sender, EventArgs e)
        {
            buttonNorth.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
        }
    }


    public class UserPositionTracker
    {
        private Point _userPosition;

        public Point UserPosition
        {
            get { return _userPosition; }
            set
            {
                if (_userPosition != value)
                {
                    _userPosition = value;
                    LogPosition(_userPosition);
                }
            }

        }
        private void LogPosition(Point position)
        {
            string logPath = "User_position_log.txt";
            string logEntry = $"x;  {position.X},  Y: {position.Y},  Time: {DateTime.Now}";


            File.AppendAllText(logPath, logEntry + Environment.NewLine);
        }

    }

}
