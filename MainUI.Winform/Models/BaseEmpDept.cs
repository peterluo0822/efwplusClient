using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseEmpDept
    {
        private int  _id;
        /// <summary>
        /// ID
        /// </summary>
        public int Id
        {
            get { return  _id; }
            set {  _id = value; }
        }

        private int  _empid;
        /// <summary>
        /// 人员ID
        /// </summary>
        public int EmpId
        {
            get { return  _empid; }
            set {  _empid = value; }
        }

        private int  _deptid;
        /// <summary>
        /// 科室ID
        /// </summary>
        public int DeptId
        {
            get { return  _deptid; }
            set {  _deptid = value; }
        }

        private int  _defaultflag;
        /// <summary>
        /// 默认科室标志 0否1是
        /// </summary>
        public int DefaultFlag
        {
            get { return  _defaultflag; }
            set {  _defaultflag = value; }
        }

    }
}
