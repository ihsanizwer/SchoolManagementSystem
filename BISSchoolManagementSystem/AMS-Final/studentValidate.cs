using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_Final
{
    class studentValidate
    {
        private string aNo;
        private string sname;

        public studentValidate()
        { 
        
        }

        public studentValidate(string admissionNo, string sName)
        {
            this.aNo = admissionNo;
            this.sname = sName;
        }

        public string getaNo()
        {
            return aNo;
        }

        public void setadmissionNo(string aNo)
        {
            this.aNo = aNo;
        }

        public string getsname()
        {
            return sname;
        }

        public void setsname(string sname)
        {
            this.sname = sname;
        }

        public Boolean studentValidEmpty(string word)
        {
            if (word != "")
            {
                return true;
            }
            else
                return false;
        }

        public Boolean studentSearchValid(string character)
        {
            if ((character.StartsWith("BIS") || character.StartsWith("bis")))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean studentSearchClass(string character)
        {
            if ((character.StartsWith("G") || character.StartsWith("g")))
            {
                return true;
            }
            else
                return false;
        }

        
        public Boolean adNoValid(string aNo)
        {
            int a = aNo.Length;
            string res1 = this.aNo.Substring(3,a);
            foreach (char c in res1)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public Boolean isLetter(string word)
        {
            foreach (char c in word)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public Boolean isNumber(string words)
        {
            foreach (char c in words)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }





    }


}
