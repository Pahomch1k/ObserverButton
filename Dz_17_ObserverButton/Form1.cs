using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_17_ObserverButton
{
    public partial class Form1 : Form
    {
        int flag;

        Subject subject = new Subject();

        public Form1()
        {
            InitializeComponent();
            flag = 0;
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                subject.Attach(button5);
                subject.Attach(button6);
                flag++;
                button5.Text = "Отписка на перемещение";
            }
            else
            {
                subject.Detach(button5);
                subject.Detach(button6);
                flag++;
                button5.Text = "Подписка на перемещение";
            } 
        }


        private void UP_Click(object sender, EventArgs e)
        {
            subject.UP();
        }
         
        private void DOWN_Click(object sender, EventArgs e)
        {
            subject.DOWN();
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            subject.LEFT();
        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            subject.RIGHT();
        }
    }
}
