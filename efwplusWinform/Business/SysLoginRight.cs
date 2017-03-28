using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EFWCoreLib.CoreFrame.Business
{
    /// <summary>
    /// 系统登录后存在Session中用户的信息
    /// </summary>
    [DataContract]
    public class SysLoginRight
    {
        public SysLoginRight()
        {

        }
        public SysLoginRight(int workId)
        {
            _workId = workId;
        }
        private int _userId;
        [DataMember]
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private int _empId;
        [DataMember]
        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private string _empName;
        [DataMember]
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        private int _deptId;
        [DataMember]
        public int DeptId
        {
            get { return _deptId; }
            set { _deptId = value; }
        }
        private string _deptName;
        /// <summary>
        /// 当前登录科室
        /// </summary>
        [DataMember]
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        private int _workId;
        [DataMember]
        public int WorkId
        {
            get { return _workId; }
            set { _workId = value; }
        }

        private string _workName;
        [DataMember]
        public string WorkName
        {
            get { return _workName; }
            set { _workName = value; }
        }
        private int _isAdmin;
        /// <summary>
        /// 是否管理员 0普通用户 1机构管理员 2超级管理员
        /// </summary>
        [DataMember]
        public int IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }
        [DataMember]
        public Guid token { get; set; }
    }
}
