using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseEmployee
    {
        private int  _empid;
        /// <summary>
        /// ID
        /// </summary>
        public int EmpId
        {
            get { return  _empid; }
            set {  _empid = value; }
        }

        private string  _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return  _name; }
            set {  _name = value; }
        }

        private int  _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex
        {
            get { return  _sex; }
            set {  _sex = value; }
        }

        private DateTime  _brithday;
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Brithday
        {
            get { return  _brithday; }
            set {  _brithday = value; }
        }

        private string  _szm;
        /// <summary>
        /// 数字吗
        /// </summary>
        public string Szm
        {
            get { return  _szm; }
            set {  _szm = value; }
        }

        private string  _pym;
        /// <summary>
        /// 拼音吗
        /// </summary>
        public string Pym
        {
            get { return  _pym; }
            set {  _pym = value; }
        }

        private string  _wbm;
        /// <summary>
        /// 五笔码
        /// </summary>
        public string Wbm
        {
            get { return  _wbm; }
            set {  _wbm = value; }
        }

        private int  _delflag;
        /// <summary>
        /// 删除标记0否1是
        /// </summary>
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

    }
}
