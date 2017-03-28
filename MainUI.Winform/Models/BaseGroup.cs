using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseGroup
    {
        private int  _groupid;
        /// <summary>
        /// 编号
        /// </summary>
        public int GroupId
        {
            get { return  _groupid; }
            set {  _groupid = value; }
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

        private int  _delflag;
        /// <summary>
        /// 删除标记 0否1是
        /// </summary>
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

        private int  _admin;
        /// <summary>
        /// 是否高级管理员 0否1是
        /// </summary>
        public int Admin
        {
            get { return  _admin; }
            set {  _admin = value; }
        }

        private int  _everyone;
        /// <summary>
        /// 每个人0否1是
        /// </summary>
        public int Everyone
        {
            get { return  _everyone; }
            set {  _everyone = value; }
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

        private string  _property;
        /// <summary>
        /// 属性
        /// </summary>
        public string Property
        {
            get { return  _property; }
            set {  _property = value; }
        }

    }
}
