using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseDept
    {
        private int  _deptid;
        /// <summary>
        /// ID
        /// </summary>
        public int DeptId
        {
            get { return  _deptid; }
            set {  _deptid = value; }
        }

        private int  _layer;
        /// <summary>
        /// 级别
        /// </summary>
        public int Layer
        {
            get { return  _layer; }
            set {  _layer = value; }
        }

        private string  _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return  _name; }
            set {  _name = value; }
        }

        private string  _pym;
        /// <summary>
        /// 拼音码
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

        private string  _szm;
        /// <summary>
        /// 数字码
        /// </summary>
        public string Szm
        {
            get { return  _szm; }
            set {  _szm = value; }
        }

        private string  _code;
        /// <summary>
        /// 代码
        /// </summary>
        public string Code
        {
            get { return  _code; }
            set {  _code = value; }
        }

        private int  _delflag;
        /// <summary>
        /// 删除标识 0否1是
        /// </summary>
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

        private int  _sortorder;
        /// <summary>
        /// 排序号
        /// </summary>
        public int SortOrder
        {
            get { return  _sortorder; }
            set {  _sortorder = value; }
        }

        private string  _memo;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return  _memo; }
            set {  _memo = value; }
        }

    }
}
