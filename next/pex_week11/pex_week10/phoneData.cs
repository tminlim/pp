using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pex_week10
{
    public class phoneBook
    {
        public List<phoneData> phoneList;

        public string getAllData()
        {
            string result = "";
            foreach (phoneData pd in phoneList)
            {
                result += string.Format("{0} | {1} | {2}\r\n", pd.mGroup, pd.mName, pd.mPhone);
            }
            return result;
        }
        public phoneBook(){
            phoneList = new List<phoneData>();
        }
        public void Add(string name, string phone, string group)
        {
            phoneData pd = new phoneData(name, phone, group);
            phoneList.Add(pd);
        }
        public phoneData Find(string name){
            foreach(phoneData pd  in phoneList){
                if (pd.mName == name)
                    return pd;
            }
            return null;

        }
    }
    public class phoneData
    {
        public string mName;
        public string mPhone;
        public string mGroup;

        public phoneData()
        {
            mName = "";
            mPhone = "";
            mGroup = "";
        }
        public phoneData(string name, string phone, string group)
        {
            mName = name;
            mPhone = phone;
            mGroup = group;
        }
        static void M()
        {
            phoneData p = new phoneData("tmin", "none", "next");
        }
    }
}

