using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_list
{
    public partial class start_up : Form
    {
        int temp = 0;
        public start_up()
        {                        
            InitializeComponent();            
            this.pictureBox1.Image = global::Linked_list.Properties.Resources.unnamed;
            pictureBox1.Hide();
            animator1.Show(pictureBox1);
        }                                                           
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temp == 0)
            {                
                animator1.Hide(pictureBox1);
                animator1.WaitAllAnimations();
                this.pictureBox1.Image = global::Linked_list.Properties.Resources.ds_logo;
                pictureBox1.Hide();
                this.animator1.AnimationType = AnimatorNS.AnimationType.Mosaic;
                animator1.Show(pictureBox1);
                //pictureBox1.Show();
                temp++;
            }
           else if (temp == 1)
            {
                animator1.Hide(pictureBox1);
                this.animator1.AnimationType = AnimatorNS.AnimationType.Rotate;
                animator1.WaitAllAnimations();
                this.pictureBox1.Image = global::Linked_list.Properties.Resources.yekta_banner_right_fa;
                pictureBox1.Hide();
                animator1.Show(pictureBox1);
              //  pictureBox1.Show();
                temp++;
            }
           else if (temp == 2)
            {
                timer1.Interval = 1000;
                temp++;                
            }
            else if (temp == 3)
            {
                this.Close();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<100)
            {
                progressBar1.Value ++;
            }            
        }        
    }
}
