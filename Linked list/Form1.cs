using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
namespace Linked_list
{
    public partial class Form1 : Form
    {
        linkedList_1side<student> mylinkedlist_oneside;
        linkedlist_1_circular<student> mylinkedlist_oneside_circular;
        linkedList_2side<student> mylinkedlist_twoside;
        linkedlist_2_circular<student> mylinkedlist_twoside_circular;
        public enum Side { down, up }
        public enum kind_GPA { Iranian, American, Canadian }
        public enum linkedlist_kind { one_side, one_side_Circular,two_side, two_side_Circular }
        linkedlist_kind my_linkedlist_kind;
        bool details = false;
        public Form1()
        {
            InitializeComponent();
            #region defult
            this.skinEngine1.SkinFile = "./a (3).ssk";
            this.skinEngine1.Active = true;
            groupBox7.Hide();
            this.Size = new System.Drawing.Size(917, 625);
            StreamReader sr = new StreamReader("project_data_Storage.txt");
            if (sr.ReadLine() == "1")
            {
                sr.Close();
                checkBox1.Checked = true;
            }
            try { sr.Close(); }
            catch { }
            #endregion
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            //***************
            mylinkedlist_oneside = new linkedList_1side<student>();
            mylinkedlist_oneside_circular = new linkedlist_1_circular<student>();
            mylinkedlist_twoside = new linkedList_2side<student>();
            mylinkedlist_twoside_circular = new linkedlist_2_circular<student>();
            //show_result();
            show_result(get_array());
        }
        private string Maximum_string(string a,string b)
        {
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                if (a[i] > b[i])
                    return a;
                if (a[i] < b[i])
                    return b;
            }
            if (a.Length>b.Length)
                return a;
            return b;
        }
        private int[] sort_string(string[] s, int[] id, Side side)
        {            
         if (side == Side.down)
         {
             for (int i = 0; i < s.Length; i++)
                 for (int j = i; j < s.Length; j++)
                     if (Maximum_string(s[i], s[j]) == s[j])
                     {
                         string temp = s[i];
                         s[i] = s[j];
                         s[j] = temp;
                         int temp1 = id[i];
                         id[i] = id[j];
                         id[j] = temp1;
                     }
         }
         else
         {
             for (int i = 0; i < s.Length; i++)
                 for (int j = i; j < s.Length; j++)
                     if (Maximum_string(s[i], s[j]) != s[j])
                     {
                         string temp = s[i];
                         s[i] = s[j];
                         s[j] = temp;
                         int temp1 = id[i];
                         id[i] = id[j];
                         id[j] = temp1;
                     }
         }
         return id;
     }
        private int[] sort_flout(float?[] s, int[] id, Side side)
        {            
         if (side == Side.down)
         {
             for (int i = 0; i < s.Length; i++)
                 for (int j = i; j < s.Length; j++)
                     if (s[i]> s[j])
                     {
                         float? temp = s[i];
                         s[i] = s[j];
                         s[j] = temp;
                         int temp1 = id[i];
                         id[i] = id[j];
                         id[j] = temp1;
                     }
         }
         else
         {
             for (int i = 0; i < s.Length; i++)
                 for (int j = i; j < s.Length; j++)
                     if (s[i] < s[j])
                     {
                         float? temp = s[i];
                         s[i] = s[j];
                         s[j] = temp;
                         int temp1 = id[i];
                         id[i] = id[j];
                         id[j] = temp1;
                     }
         }
         return id;
     }
        public int[] get_array()
        {
            int ans_leanght = mylinkedlist_oneside.Count + mylinkedlist_oneside_circular.Count + mylinkedlist_twoside.Count + mylinkedlist_twoside_circular.Count;
            string[] s = new string[ans_leanght];
            int[] id = new int[ans_leanght];
            int counter = 0;
            if (comboBox1.Text=="Downside last name")
            {
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside.At(i).lastName;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside_circular.At(i).lastName;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside.At(i).lastName;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside_circular.At(i).lastName;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_string(s, id, Side.down);
            }
            if (comboBox1.Text=="upside last name")
            {
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside.At(i).lastName;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside_circular.At(i).lastName;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside.At(i).lastName;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside_circular.At(i).lastName;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_string(s, id, Side.up);
            }
            if (comboBox1.Text=="Downside name")
            {
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside.At(i).Name;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside_circular.At(i).Name;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside.At(i).Name;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside_circular.At(i).Name;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_string(s, id, Side.down);
            }
            if (comboBox1.Text=="upside name")
            {
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside.At(i).Name;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_oneside_circular.At(i).Name;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside.At(i).Name;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        s[counter] = mylinkedlist_twoside_circular.At(i).Name;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_string(s, id, Side.up);
            }
            if (comboBox1.Text=="Downside GPA")
            {
                float?[] gpa = new float?[ans_leanght];
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        gpa[counter] =mylinkedlist_oneside.At(i).GPA();
                        if (mylinkedlist_oneside.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_oneside_circular.At(i).GPA();
                        if (mylinkedlist_oneside_circular.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_twoside.At(i).GPA();
                        if (mylinkedlist_twoside.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_twoside_circular.At(i).GPA();
                        if (mylinkedlist_twoside_circular.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_flout(gpa, id, Side.down);
            }
            if (comboBox1.Text=="upside GPA")
            {
                float?[] gpa = new float?[ans_leanght];
                for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_oneside.At(i).GPA();
                        if (mylinkedlist_oneside.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_oneside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_oneside_circular.At(i).GPA();
                        if (mylinkedlist_oneside_circular.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_oneside_circular.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_twoside.At(i).GPA();
                        if (mylinkedlist_twoside.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_twoside.At(i).Id;
                    }
                    catch { }
                }
                for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
                {
                    try
                    {
                        gpa[counter] = mylinkedlist_twoside_circular.At(i).GPA();
                        if (mylinkedlist_twoside_circular.At(i).kind != kind_GPA.Iranian)
                            gpa[counter] *= 5;
                        id[counter++] = mylinkedlist_twoside_circular.At(i).Id;
                    }
                    catch { }
                }
                return sort_flout(gpa, id, Side.up);
            }
            return id;
        }
        public void delet_whit_id(int id)
        {
            student temp;
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside.At(i);                    
                    if (temp.Id == id)
                        mylinkedlist_oneside.Remove(temp);
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside_circular.At(i);
                    if (temp.Id == id)
                        mylinkedlist_oneside_circular.Remove(temp);
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside.At(i);
                    if (temp.Id == id)
                        mylinkedlist_twoside.Remove(temp);
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside_circular.At(i);
                    if (temp.Id == id)
                        mylinkedlist_twoside_circular.Remove(temp);
                }
                catch { }
            }            
        }
        public bool exist_Id(int id)
        {
            student temp;
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside.At(i);
                    if (temp.Id == id)
                        return true;
                }catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                     temp = mylinkedlist_oneside_circular.At(i);
                     if (temp.Id == id)
                         return true;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                     temp = mylinkedlist_twoside.At(i);
                     if (temp.Id == id)
                         return true;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                     temp=mylinkedlist_twoside_circular.At(i);
                     if (temp.Id == id)
                         return true;
                }
                catch { }
            }            
            return false;
        }
        public void show_result(int []id_array)
        {
           textBox10.ForeColor = System.Drawing.Color.Gray;
           textBox10.Text = "you can search heare";
           flowLayoutPanel1.Controls.Clear();                
           for (int i = 0; i < id_array.Length; i++)
           {
               try 
    	       {
                   flowLayoutPanel1.Controls.Add(set_data(get_data_with_id(id_array[i])));	
	           }
	           catch {}
           }
        }
        public void show_result()
        {
            textBox10.ForeColor = System.Drawing.Color.Gray;
            textBox10.Text = "you can search heare";
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    flowLayoutPanel1.Controls.Add(set_data(mylinkedlist_oneside.At(i)));
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    flowLayoutPanel1.Controls.Add(set_data(mylinkedlist_oneside_circular.At(i)));
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    flowLayoutPanel1.Controls.Add(set_data(mylinkedlist_twoside.At(i)));

                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    flowLayoutPanel1.Controls.Add(set_data(mylinkedlist_twoside_circular.At(i)));
                }
                catch { }
            }
        }
        public student_cell set_data(student temp1)
        {
            student_cell temp = new student_cell(this);
            temp.name.Text += temp1.Name;
            temp.lastname.Text += temp1.lastName;
            temp.Id.Text += temp1.Id.ToString();
            temp.id = int.Parse(temp1.Id.ToString());
            temp.Corse_one.Text += temp1.Corse_one;
            temp.Corse_two.Text += temp1.Corse_two;
            temp.Corse_there.Text += temp1.Corse_there;
            temp.gpa_kind.Text += temp1.kind.ToString();
            temp.Unit_one.Text += temp1.Unit_one.ToString();
            temp.Unit_two.Text += temp1.Unit_two.ToString();
            temp.Unit_there.Text += temp1.Unit_there.ToString();
            temp.gpa.Text += temp1.GPA().ToString();
            if (my_linkedlist_kind == linkedlist_kind.one_side)
                temp.linkedlist_kind.Text += "oneside";
            else if (my_linkedlist_kind == linkedlist_kind.one_side_Circular)
                temp.linkedlist_kind.Text += "one_side_Circular";
            else if (my_linkedlist_kind == linkedlist_kind.two_side)
                temp.linkedlist_kind.Text += "two_side";
            else if (my_linkedlist_kind == linkedlist_kind.two_side_Circular)
                temp.linkedlist_kind.Text += "two_side_Circular";
            if (temp1.kind == kind_GPA.Iranian)
            {
                temp.Score_one.Text += temp1.Score_one.ToString();
                temp.Score_two.Text += temp1.Score_two.ToString();
                temp.Score_there.Text += temp1.Score_there.ToString();
            }
            else if (temp1.kind == kind_GPA.Canadian || temp1.kind == kind_GPA.American)
            {
                temp.Score_one.Text += temp1.Score_one_st;
                temp.Score_two.Text += temp1.Score_two_st;
                temp.Score_there.Text += temp1.Score_there_st;
            }
            return temp;
        }
        public student get_data_with_id(int id)
        {
            student temp;
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside_circular.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside_circular.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            return null;
        }
        public void clear_add_panel()
        {
            textBox1.Text = "_";
            textBox9.Text = "_";
            textBox2.Text = "_";
            textBox3.Text = "_";
            textBox5.Text = "_";
            textBox7.Text = "_";
            textBox4.Text = "Corse1";
            textBox6.Text = "Corse2";
            textBox8.Text = "Corse3";
            comboBox2.Text = "unit";
            comboBox3.Text = "unit";
            comboBox4.Text = "unit";
            comboBox5.Text = "score";
            comboBox6.Text = "score";
            comboBox7.Text = "score";
            comboBox8.Text = "score";
            comboBox9.Text = "score";
            comboBox10.Text = "score";
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            bool allow_to_doing = true;
            linkedlist_kind kind_linkedlist;            
            #region set_errorprovider
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();                        
            if (textBox2.Text == "_")
            {
                errorProvider2.SetError(label2, "You must enter Number of student");
                allow_to_doing = false; 
            }
            if (textBox2.Text != "_")
            {
                try 
	            {
                    int.Parse(textBox2.Text);
	            }
	            catch 
	            {
                    errorProvider2.SetError(label2, "just enter a number!");
                    allow_to_doing = false;	
	            }                
            }
            if (radioButton5.Checked==true)
            {                
                if (textBox3.Text == "_" && textBox5.Text == "_" && textBox7.Text == "_")
                {
                    errorProvider3.SetError(label4, "You must enter at least one score");
                    allow_to_doing = false; 
                }
                if (textBox3.Text != "_" )
                {
                    try
                    {
                        if (float.Parse(textBox3.Text) > 20 || float.Parse(textBox3.Text) <0)
                        {
                            errorProvider3.SetError(label4, "Score must be in the range of 0 to 20");
                            allow_to_doing = false; 
                        }
                    }
                    catch
                    {
                        errorProvider3.SetError(label4, "You're only allowed to use numbers!");
                        allow_to_doing = false; 
                    }
                }
                if (textBox5.Text != "_" )
                {
                    try
                    {
                        if (float.Parse(textBox5.Text) > 20 || float.Parse(textBox5.Text) < 0)
                        {
                            errorProvider4.SetError(label4, "Score must be in the range of 0 to 20");
                            allow_to_doing = false;
                        }
                    }
                    catch
                    {
                        errorProvider4.SetError(label5, "You're only allowed to use numbers!");
                        allow_to_doing = false; 
                    }
                }
                if (textBox7.Text != "_")
                {
                    try
                    {
                        if (float.Parse(textBox7.Text) > 20 || float.Parse(textBox7.Text) < 0)
                        {
                            errorProvider5.SetError(label4, "Score must be in the range of 0 to 20");
                            allow_to_doing = false;
                        }
                    }
                    catch
                    {
                        errorProvider5.SetError(label7, "You're only allowed to use numbers!");
                        allow_to_doing = false; 
                    }
                }
            }
            if (radioButton6.Checked==true)
            {
                if (comboBox5.Text=="score"&&comboBox6.Text=="score"&&comboBox7.Text=="score")
                {
                    errorProvider3.SetError(label4, "You must enter at least one score!");
                    allow_to_doing = false; 
                }
                if (comboBox5.Text == "score" && comboBox2.Text != "unit")
                {
                    errorProvider3.SetError(label4, "You must specify score!");
                    allow_to_doing = false; 

                }
                if (comboBox6.Text == "score" && comboBox3.Text != "unit")
                {
                    errorProvider4.SetError(label5, "You must specify score!");
                    allow_to_doing = false; 
                }
                if (comboBox7.Text == "score" && comboBox4.Text != "unit")
                {
                    errorProvider5.SetError(label7, "You must specify score!");
                    allow_to_doing = false; 
                }
            }
            if (radioButton7.Checked == true)
            {
                if (comboBox8.Text == "score" && comboBox9.Text == "score" && comboBox10.Text == "score")
                {
                    errorProvider3.SetError(label4, "You must enter at least one score!");
                    allow_to_doing = false; 
                }
                else if (comboBox8.Text == "score" && comboBox2.Text != "unit")
                {
                    errorProvider3.SetError(label4, "You must specify score!");
                    allow_to_doing = false; 
                }
                else if (comboBox9.Text == "score" && comboBox3.Text != "unit")
                {
                   errorProvider4.SetError(label5, "You must specify score!");
                   allow_to_doing = false; 
                }
                else if (comboBox10.Text == "score" && comboBox4.Text != "unit")
                {
                    errorProvider5.SetError(label7, "You must specify score!");
                    allow_to_doing = false; 
                }
            }
            if (textBox9.Text == "_")
            {
                errorProvider6.SetError(label1, "You must enter last name");
                allow_to_doing = false;
            }

            #endregion
            if (allow_to_doing)
            {
                if (exist_Id(int.Parse(textBox2.Text)))
                {
                    errorProvider2.SetError(label2, "this id is used!");
                    return;
                } 
            }
            if (allow_to_doing)
            {
                student temp = new student();
                if (radioButton5.Checked == true)
                    temp.kind = kind_GPA.Iranian;
                else if (radioButton6.Checked == true)
                    temp.kind = kind_GPA.American;
                else if (radioButton7.Checked == true)
                    temp.kind = kind_GPA.Canadian;
                #region enter_data_to_class
                temp.Name=textBox1.Text;
                temp.lastName=textBox9.Text;
                temp.Id = int.Parse(textBox2.Text);
                temp.Corse_one =  textBox4.Text;
                temp.Corse_two =  textBox6.Text;
                temp.Corse_there =textBox8.Text;
                if (comboBox2.Text!="unit")
                    temp.Unit_one= int.Parse(comboBox2.Text);
                if (comboBox3.Text != "unit")
                    temp.Unit_two = int.Parse(comboBox3.Text);
                if (comboBox4.Text != "unit")
                    temp.Unit_there = int.Parse(comboBox4.Text);
                if (kind_GPA.Iranian == temp.kind)
	            {
                    try
                    {
                        temp.Score_there=float.Parse(textBox7.Text);
                    }
                    catch { }
                    try
                    {
                        temp.Score_one =float.Parse (textBox3.Text) ;
                        }
                    catch { }
                        try
                    {
                        temp.Score_two =float.Parse (textBox5.Text) ;
                    }
                        catch { }
                    
	            }
                else if (kind_GPA.American == temp.kind)
	            {
                    temp.Score_one_st = comboBox5.Text;
                    temp.Score_two_st = comboBox6.Text;
                    temp.Score_there_st = comboBox7.Text;

	            }
                else
                {
                    temp.Score_one_st = comboBox8.Text;
                    temp.Score_two_st = comboBox9.Text;
                    temp.Score_there_st = comboBox10.Text;
                }
                #endregion
                if (radioButton1.Checked==true)
                {
                    kind_linkedlist=linkedlist_kind.one_side;
                    mylinkedlist_oneside.Add(temp);
                }
                else if (radioButton2.Checked==true)
                    {
                    kind_linkedlist=linkedlist_kind.one_side_Circular;
                    mylinkedlist_oneside_circular.Add(temp);
                    }
                else if (radioButton3.Checked==true)
                    {
                    kind_linkedlist=linkedlist_kind.two_side;
                    mylinkedlist_twoside.Add(temp);
                    }
                else if (radioButton4.Checked == true)
                    {
                    kind_linkedlist=linkedlist_kind.two_side_Circular;
                    mylinkedlist_twoside_circular.Add(temp);
                    }
                clear_add_panel();
            }
            //show_result();                        
            show_result(get_array());
        }           
        void delete_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Are you sure you want to delete this data?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (details)
            {
                this.Size = new System.Drawing.Size(917, 625);
                this.MaximumSize = new System.Drawing.Size(917, 625);
                groupBox7.Hide();
                details=false;                
            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(1594, 768);
                this.Size = new System.Drawing.Size(1594, 768);
                groupBox7.Show();
                details = true;
            }
        }     
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("project_data_Storage.txt");
            if (checkBox1.Checked)
                sw.WriteLine("1");
            else
                sw.WriteLine("0");
            sw.Close();
        }
        private void linkedlist1side_Click(object sender, EventArgs e)
        {
            Teaching f = new Teaching(linkedlist_kind.one_side);
            f.ShowDialog();
        }
        private void linkedlist1sidecircular_Click(object sender, EventArgs e)
        {
            Teaching f = new Teaching(linkedlist_kind.one_side_Circular);
            f.ShowDialog();
        }
        private void linkedlist2side_Click(object sender, EventArgs e)
        {
            Teaching f = new Teaching(linkedlist_kind.two_side);
            f.ShowDialog();
        }
        private void linkedlist2sidecircular_Click(object sender, EventArgs e)
        {
            Teaching f = new Teaching(linkedlist_kind.two_side_Circular);
            f.ShowDialog();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox7.Visible = true;

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox7.Visible = false;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
            comboBox10.Visible = true;
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox7.Visible = false;
        }     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_result(get_array());
        }                
        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox temp;
            temp = (TextBox)sender;
            if (temp.Text=="_")
                temp.Text = "";
        }
        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox temp;
            temp = (TextBox)sender;
            if (temp.Text == "")
                temp.Text = "_";
        }
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (comboBox11.SelectedIndex==0)
            {
                this.skinEngine1.SkinFile = "./a (3).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                this.skinEngine1.SkinFile = "./a (6).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 2)
            {
                this.skinEngine1.SkinFile = "./a (7).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 3)            
            {
                this.skinEngine1.SkinFile = "./a (11).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 4)
            {
                this.skinEngine1.SkinFile = "./a (19).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 5)
            {
                this.skinEngine1.SkinFile = "./a (25).ssk";
                this.skinEngine1.Active = true;  
            }
            else if (comboBox11.SelectedIndex == 6)
            {
                this.skinEngine1.SkinFile = "./a (27).ssk";
                this.skinEngine1.Active = true;
            }
            else if (comboBox11.SelectedIndex == 7)
            {
                this.skinEngine1.SkinFile = "./a (33).ssk";
                this.skinEngine1.Active = true;
            }
            else if (comboBox11.SelectedIndex == 8)
            {
                this.skinEngine1.SkinFile = "./a (49).ssk";
                this.skinEngine1.Active = true;
            }
            else if (comboBox11.SelectedIndex == 9)
            {
                this.skinEngine1.SkinFile = "./a (31).ssk";
                this.skinEngine1.Active = true;           
            }
            else if (comboBox11.SelectedIndex == 10)
            {
                this.skinEngine1.Active = false;  
            }
        }
        private void inportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);              
                sr.Close();  
                           
            }
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public student search_ID(int id)
        {
            student temp;
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_oneside_circular.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    temp = mylinkedlist_twoside_circular.At(i);
                    if (temp.Id == id)
                        return temp;
                }
                catch { }
            }
            return null;
        }
        public void show_student(student Data)
        {           
            student_cell temp = set_data(Data);
            flowLayoutPanel1.Controls.Add(temp);
        }
        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {                    
                    search_ID(int.Parse(textBox10.Text));
                }
                catch 
                {
                }           
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox10.ForeColor != System.Drawing.Color.Black)
            {
            textBox10.Text = "";
            textBox10.ForeColor = System.Drawing.Color.Black;
            }
        }
        public void search_id(int id)
        {
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside.At(i).Id==id)
                    {
                        show_student(mylinkedlist_oneside.At(i));
                        return;
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside_circular.At(i).Id == id)
                    {
                        show_student(mylinkedlist_oneside_circular.At(i));
                        return;
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside.At(i).Id == id)
                    {
                        show_student(mylinkedlist_twoside.At(i));
                        return;
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside_circular.At(i).Id == id)
                    {
                        show_student(mylinkedlist_twoside_circular.At(i));
                        return;
                    }
                }
                catch { }
            }
        }
        public void search_gpa(float gpa)
        {
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside.At(i).GPA() == gpa)
                        show_student(mylinkedlist_oneside.At(i));
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside_circular.At(i).GPA() == gpa)
                    {
                        show_student(mylinkedlist_oneside_circular.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside.At(i).GPA() == gpa)
                    {
                        show_student(mylinkedlist_twoside.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside_circular.At(i).GPA() == gpa)
                    {
                        show_student(mylinkedlist_twoside_circular.At(i));
                         
                    }
                }
                catch { }
            }
        }
        public void search_name(string name)
        {
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside.At(i).Name == name)
                    {
                        show_student(mylinkedlist_oneside.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside_circular.At(i).Name == name)
                    {
                        show_student(mylinkedlist_oneside_circular.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside.At(i).Name == name)
                    {
                        show_student(mylinkedlist_twoside.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside_circular.At(i).Name == name)
                    {
                        show_student(mylinkedlist_twoside_circular.At(i));
                         
                    }
                }
                catch { }
            }
        }
        public void search_lastname(string lastname)
        {
            for (int i = 1; i <= mylinkedlist_oneside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside.At(i).lastName==lastname)
                    {
                        show_student(mylinkedlist_oneside.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_oneside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_oneside_circular.At(i).lastName == lastname)
                    {
                        show_student(mylinkedlist_oneside_circular.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside.At(i).lastName == lastname)
                    {
                        show_student(mylinkedlist_twoside.At(i));
                         
                    }
                }
                catch { }
            }
            for (int i = 1; i <= mylinkedlist_twoside_circular.Count; i++)
            {
                try
                {
                    if (mylinkedlist_twoside_circular.At(i).lastName == lastname)
                    {
                        show_student(mylinkedlist_twoside_circular.At(i));
                         
                    }
                }
                catch { }
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (comboBox12.Text=="ID")
            {
                try
                {
                    flowLayoutPanel1.Controls.Clear();
                    search_id(int.Parse(textBox10.Text));
                }
                catch 
                {
                }
            }
            if (comboBox12.Text=="GPA")
            {
                try
                {
                    flowLayoutPanel1.Controls.Clear();
                    search_gpa(float.Parse(textBox10.Text));
                }
                catch
                {
                }
            }
            if (comboBox12.Text=="Name")
            {
                flowLayoutPanel1.Controls.Clear();
                    search_name(textBox10.Text);
            }
            if (comboBox12.Text=="last Name")
            {
                flowLayoutPanel1.Controls.Clear();
                    search_lastname(textBox10.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }                
    }
}
