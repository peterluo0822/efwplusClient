using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseModule
    {
        private int  _moduleid;
        /// <summary>
        /// 编号
        /// </summary>
        public int ModuleId
        {
            get { return  _moduleid; }
            set {  _moduleid = value; }
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

        private string  _memo;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return  _memo; }
            set {  _memo = value; }
        }

        private int  _sortid;
        /// <summary>
        /// 排序
        /// </summary>
        public int SortId
        {
            get { return  _sortid; }
            set {  _sortid = value; }
        }

        private string  _serverip;
        /// <summary>
        /// 服务IP
        /// </summary>
        public string ServerIP
        {
            get { return  _serverip; }
            set {  _serverip = value; }
        }

    }
}
