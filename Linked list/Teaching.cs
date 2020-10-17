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
    public partial class Teaching : Form
    {
        Form1.linkedlist_kind Constructor_kind;
        int count_1side = 1;
        int count_2side = 1;
        public Teaching(Form1.linkedlist_kind kind)
        {
            InitializeComponent();
            Constructor_kind = kind;
        }
        private void Teaching_Load(object sender, EventArgs e)
        {
            
            switch (Constructor_kind)
            {
                case Form1.linkedlist_kind.one_side:
                    teaching_1side();
                    break;
                case Form1.linkedlist_kind.one_side_Circular:
                    teaching_1side_circular();
                    break;
                case Form1.linkedlist_kind.two_side:
                    teaching_2side();
                    break;
                case Form1.linkedlist_kind.two_side_Circular:
                    teaching_2side_circular();
                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void teaching_1side()
        {
            label1.Text = "معرفی لیست پیوندی یک طرفه";
            label3.Text = "4";
            label2.Text = "1";
            pictureBox2.Image = global::Linked_list.Properties.Resources._00;
            button1.Enabled = false;
        }
        private void teaching_1side_circular()
        {
            label1.Text = "معرفی لیست پیوندی یک طرفه حلقوی";
            label3.Text = "1";
            label2.Text = "1";
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox2.Image = global::Linked_list.Properties.Resources._10;
        }
        private void teaching_2side()
        {
            label1.Text = "معرفی لیست پیوندی دو طرفه";
            button1.Enabled = false;
            label3.Text = "2";
            label2.Text = "1";
            pictureBox2.Image = global::Linked_list.Properties.Resources._20;
        }
        private void teaching_2side_circular()        
        {
            label1.Text = "معرفی لیست پیوندی یک طرفه حلقوی";
            label3.Text = "1";
            label2.Text = "1";
            pictureBox2.Image = global::Linked_list.Properties.Resources._30;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            if (Constructor_kind==Form1.linkedlist_kind.one_side)
            {
                if (count_1side == 1)
                {
                    count_1side++;
                    label2.Text = "2";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._01;
                    button1.Enabled = true;
                }
                else if (count_1side == 2)
                {
                    count_1side++;
                    label2.Text = "3";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._02;
                }
                else if (count_1side == 3)
                {
                    count_1side++;
                    label2.Text = "4";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._03;
                    button2.Enabled = false;
                }
            }
            else if (Constructor_kind == Form1.linkedlist_kind.two_side)
            {
                if (count_1side == 1)
                {
                    count_1side++;
                    label2.Text = "2";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._21;
                    button2.Enabled = false;
                    button1.Enabled = true;
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Constructor_kind == Form1.linkedlist_kind.one_side)
            {
                if (count_1side == 4)
                {
                    count_1side--;
                    label2.Text = "3";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._02;
                    button2.Enabled = true;
                }
                else if (count_1side == 3)
                {
                    count_1side--;
                    label2.Text = "2";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._01;
                }
                else if (count_1side == 2)
                {
                    count_1side--;
                    label2.Text = "1";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._00;
                    button1.Enabled = false;
                }
            }
            else if (Constructor_kind == Form1.linkedlist_kind.two_side)
            {
                if (count_1side == 2)
                {
                    count_1side--;
                    label2.Text = "1";
                    pictureBox2.Image = global::Linked_list.Properties.Resources._20;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
            }
        }
        
    }
}
