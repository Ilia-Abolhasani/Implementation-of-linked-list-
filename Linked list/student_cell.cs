using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Linked_list
{
    public partial class student_cell : System.Windows.Forms.GroupBox
    {
        public Label name { get; set; }
        public Label lastname { get; set; }
        public Label Id { get; set; }
        public Label Corse_one { get; set; }
        public Label Corse_two { get; set; }
        public Label Corse_there { get; set; }
        public Label Score_one { get; set; }
        public Label Score_two { get; set; }
        public Label Score_there { get; set; }
        public Label Unit_one { get; set; }
        public Label Unit_two { get; set; }
        public Label Unit_there { get; set; }
        public Label gpa{ get; set; }
        public Label linkedlist_kind{ get; set; }
        public Label gpa_kind{ get; set; }
        public Button delete { get; set; }
        Form1 f;
        public int id{ get; set; }
        public student_cell(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            name = new Label();
            lastname = new Label();
            Id = new Label();
            gpa = new Label();
            linkedlist_kind = new Label();
            gpa_kind = new Label();
            Corse_one = new Label();
            Corse_two = new Label();
            Corse_there = new Label();
            Score_one = new Label();
            Score_two = new Label();
            Score_there = new Label();
            Unit_one = new Label();
            Unit_two = new Label();
            Unit_there = new Label();
            delete = new Button();
            //********************
            //add
            this.Controls.Add(name);
            this.Controls.Add(lastname);
            this.Controls.Add(Id);
            this.Controls.Add(gpa);
            this.Controls.Add(linkedlist_kind);
            this.Controls.Add(gpa_kind);
            this.Controls.Add(Corse_one);
            this.Controls.Add(Corse_two);
            this.Controls.Add(Corse_there);
            this.Controls.Add(Score_one);
            this.Controls.Add(Score_two);
            this.Controls.Add(Score_there);
            this.Controls.Add(Unit_one  );
            this.Controls.Add(Unit_two );
            this.Controls.Add(Unit_there);                                          
            this.Controls.Add(delete);
            //****************
            //events
            delete.Click += delete_Click;
            //****************************
            //Resize
            this.Size = new System.Drawing.Size(230, 440);
            delete.Size = new System.Drawing.Size(160, 30);
            name.Size = new System.Drawing.Size(210, 25);
            lastname.Size = new System.Drawing.Size(210, 25);
            Id.Size = new System.Drawing.Size(210, 25);
            Corse_one.Size = new System.Drawing.Size(210, 25);
            Corse_two.Size = new System.Drawing.Size(210, 25);
            Corse_there.Size = new System.Drawing.Size(210, 25);
            Score_one.Size = new System.Drawing.Size(210, 25);
            Score_two.Size = new System.Drawing.Size(210, 25);
            Score_there.Size = new System.Drawing.Size(210, 25);
            Unit_one.Size = new System.Drawing.Size(210, 25);
            Unit_two.Size = new System.Drawing.Size(210, 25);
            Unit_there.Size = new System.Drawing.Size(210, 25);
            gpa.Size = new System.Drawing.Size(210, 25);
            linkedlist_kind.Size = new System.Drawing.Size(210, 25);
            gpa_kind.Size = new System.Drawing.Size(210, 25);
            Corse_there.Size = new System.Drawing.Size(210, 25);
            //************            
            //text
            name.Text = "name: ";
            lastname.Text = "last name: ";
            Id.Text = "ID: ";
            gpa.Text = "GPA: ";
            linkedlist_kind.Text = "Storge in: ";
            gpa_kind.Text = "gpa_kind: ";
            Corse_one    .Text="Corse_one: ";
            Corse_two.Text = "Corse_two: ";
            Corse_there.Text = "Corse_there: ";
            Score_one.Text = "Score_one: ";
            Score_two.Text = "Score_two: ";
            Score_there.Text = "Score_there: ";
            Unit_one.Text = "Unit_one: ";
            Unit_two.Text = "Unit_two: ";
            Unit_there.Text = "Unit_there: ";
            delete.Text = "delete";
            //***************************
            //location
            name.Location = new System.Drawing.Point(10, 10);
            lastname .Location =new System.Drawing.Point(10, 35);
            Id .Location =new System.Drawing.Point(10, 60);
            Corse_one.Location = new System.Drawing.Point(10, 85);
            Score_one.Location = new System.Drawing.Point(10, 110);
            Unit_one.Location = new System.Drawing.Point(10, 135);
            Corse_two.Location = new System.Drawing.Point(10, 160);
            Score_two.Location = new System.Drawing.Point(10, 185);
            Unit_two.Location = new System.Drawing.Point(10, 210);
            Corse_there.Location = new System.Drawing.Point(10, 235);
            Score_there.Location = new System.Drawing.Point(10, 260);
            Unit_there.Location = new System.Drawing.Point(10, 285);           
            gpa .Location =new System.Drawing.Point(10, 310);
            linkedlist_kind.Location = new System.Drawing.Point(10, 335);
            gpa_kind .Location =new System.Drawing.Point(10, 360);
            delete.Location = new System.Drawing.Point(35, 395);
            //******************************
            //font            
            name .Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastname .Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Id .Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkedlist_kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gpa_kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Corse_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Corse_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Corse_there.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Score_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Score_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Score_there.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Unit_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Unit_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Unit_there.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //*********************************
        }
        void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this data?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                f.delet_whit_id(id);
                }
                catch 
                {}
            }
            f.show_result();
        }

        public student_cell(IContainer container)
        {            
            InitializeComponent();
        }
    }
}
