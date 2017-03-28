using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseWorkers
    {

        private int _workId;
        /// <summary>
        /// 
        /// </summary>
        public int WorkId
        {
            get { return _workId; }
            set { _workId = value; }
        }

        private string  _workno;
        /// <summary>
        /// 机构编码
        /// </summary>
        public string WorkNo
        {
            get { return  _workno; }
            set {  _workno = value; }
        }

        private string  _workname;
        /// <summary>
        /// 工作组名称
        /// </summary>
        public string WorkName
        {
            get { return  _workname; }
            set {  _workname = value; }
        }

        private string  _memo;
        /// <summary>
        /// 工作组备注
        /// </summary>
        public string Memo
        {
            get { return  _memo; }
            set {  _memo = value; }
        }

        private string  _regkey;
        /// <summary>
        /// 注册码
        /// </summary>
        public string RegKey
        {
            get { return  _regkey; }
            set {  _regkey = value; }
        }

        private string  _editioncode;
        /// <summary>
        /// 版本号
        /// </summary>
        public string EditionCode
        {
            get { return  _editioncode; }
            set {  _editioncode = value; }
        }

        private int  _delflag;
        /// <summary>
        /// 启用标识：-1新建 0启用 1禁用
        /// </summary>
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

    }
}
