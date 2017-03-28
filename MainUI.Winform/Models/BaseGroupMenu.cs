using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseGroupMenu
    {
        private int  _id;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            get { return  _id; }
            set {  _id = value; }
        }

        private int  _groupid;
        /// <summary>
        /// 组编号
        /// </summary>
        public int GroupId
        {
            get { return  _groupid; }
            set {  _groupid = value; }
        }

        private int  _moduleid;
        /// <summary>
        /// 模块编号
        /// </summary>
        public int ModuleId
        {
            get { return  _moduleid; }
            set {  _moduleid = value; }
        }

        private int  _menuid;
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int MenuId
        {
            get { return  _menuid; }
            set {  _menuid = value; }
        }

    }
}
