using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseGroupUser
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

        private int  _userid;
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId
        {
            get { return  _userid; }
            set {  _userid = value; }
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
