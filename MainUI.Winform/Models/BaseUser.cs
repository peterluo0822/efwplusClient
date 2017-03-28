using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseUser
    {
        private int  _userid;
        /// <summary>
        /// ID
        /// </summary>
        public int UserID
        {
            get { return  _userid; }
            set {  _userid = value; }
        }

        private int  _empid;
        /// <summary>
        /// 人员编号
        /// </summary>
        public int EmpID
        {
            get { return  _empid; }
            set {  _empid = value; }
        }

        private string  _code;
        /// <summary>
        /// 用户名
        /// </summary>
        public string Code
        {
            get { return  _code; }
            set {  _code = value; }
        }

        private string  _password;
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            get { return  _password; }
            set {  _password = value; }
        }

        private int  _groupid;
        /// <summary>
        /// 所属组
        /// </summary>
        public int GroupId
        {
            get { return  _groupid; }
            set {  _groupid = value; }
        }

        private int  _lock;
        /// <summary>
        /// 锁定标记 0否1是
        /// </summary>
        public int Lock
        {
            get { return  _lock; }
            set {  _lock = value; }
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

        private int  _usertype;
        /// <summary>
        /// 0普通 1收费员 2医生 3护士 4药剂
        /// </summary>
        public int UserType
        {
            get { return  _usertype; }
            set {  _usertype = value; }
        }

        private string  _doctorpost;
        /// <summary>
        /// 医生岗位
        /// </summary>
        public string DoctorPost
        {
            get { return  _doctorpost; }
            set {  _doctorpost = value; }
        }

        private string  _nursepost;
        /// <summary>
        /// 护士岗位
        /// </summary>
        public string NursePost
        {
            get { return  _nursepost; }
            set {  _nursepost = value; }
        }

        private int  _isadmin;
        /// <summary>
        /// 0普通用户 1机构管理员 2超级管理员
        /// </summary>
        public int IsAdmin
        {
            get { return  _isadmin; }
            set {  _isadmin = value; }
        }

    }
}
