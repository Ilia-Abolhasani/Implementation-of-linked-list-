using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
   public class student
    {
        //enum kind_GPA {Iranian,American,Canadian}
        public Form1.kind_GPA kind;
        public String Name { get; set; }
        public String lastName { get; set; }
        public int Id { get; set; }
        public String Corse_one{ get; set; }
        public String Corse_two{ get; set; }
        public String Corse_there { get; set; }
        public float? Score_one { get; set; }
        public float? Score_two { get; set; }
        public float? Score_there { get; set; }
        public string Score_one_st { get; set; }
        public string Score_two_st { get; set; }
        public string Score_there_st { get; set; }
        public int Unit_one { get; set; }
        public int Unit_two { get; set; }
        public int Unit_there { get; set; }
        public student()
        {
            #region defult
            Corse_one = "Corse_one";
            Corse_two = "Corse_two";
            Corse_there = "Corse_there";
            Score_one = null;
            Score_two = null;
            Score_there = null;
            Unit_one = 1;
            Unit_two = 1;
            Unit_there = 1;
            Score_one_st = null;
            Score_two_st = null;
            Score_there_st = null;
            #endregion
        }
        public float? GPA()
        {
            #region Iranian
            if (kind == Form1.kind_GPA.Iranian)
            {
                float? ans = 0;
                int temp = 0;
                if (Score_one!=null)
                {
                    ans += Score_one * Unit_one;
                    temp += Unit_one;
                }
                if (Score_two != null)
                {
                    ans += Score_two * Unit_two;
                    temp += Unit_two;
                }
                if (Score_there != null)
                {
                    ans += Score_there * Unit_there;
                    temp += Unit_there;
                }
                if (temp != 0)
                    ans /= temp;
                return ans; 
            }
            #endregion
            #region American || canada
            else
            {
                float? ans = 0;
                int temp = 0;
                if (Score_one_st != null && Score_one_st != "score")
                {
                    ans += Numerical_equivalent(Score_one_st) * Unit_one;
                    temp += Unit_one;
                }
                if (Score_two_st != null && Score_two_st != "score")
                {
                    ans += Numerical_equivalent(Score_two_st) * Unit_two;
                    temp += Unit_two;
                }
                if (Score_there_st != null && Score_there_st != "score")
                {
                    ans += Numerical_equivalent(Score_there_st) * Unit_there;
                    temp += Unit_there;
                }
                if (temp != 0)
                    ans /= temp;
                return ans;                  
            }
            #endregion                      
            return null; 
        }
        private float? Numerical_equivalent(string s)
        {            
            switch (s)
            {
                case "A":
                    return 4;                
                case "A-":
                    return 3.7F;
                case "B+":
                    return 3.3F ;
                case "B":
                    return 3;
                case "B-":
                    return 2.7F;
                case "C+":
                    return 2.3F;
                case "C":
                    return 2;
                case "C-":
                    return 1.7F;
                case "D+":
                    return 1.3F;
                case "D":
                    return 1;
                case "D-":
                    return 0.7F;
                case "F":
                    return 0;                
                default:
                    return null;
            }            
        }
    }
}
