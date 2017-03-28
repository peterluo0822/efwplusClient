using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseMessage
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

        private int  _messagetypeid;
        /// <summary>
        /// 消息类型ID
        /// </summary>
        public int MessageTypeID
        {
            get { return  _messagetypeid; }
            set {  _messagetypeid = value; }
        }

        private string  _messagetypecode;
        /// <summary>
        /// 消息类型代码
        /// </summary>
        public string MessageTypeCode
        {
            get { return  _messagetypecode; }
            set {  _messagetypecode = value; }
        }

        private int  _sendempid;
        /// <summary>
        /// 发送人
        /// </summary>
        public int SendEmpID
        {
            get { return  _sendempid; }
            set {  _sendempid = value; }
        }

        private int  _senddept;
        /// <summary>
        /// 发送科室
        /// </summary>
        public int SendDept
        {
            get { return  _senddept; }
            set {  _senddept = value; }
        }

        private int  _receivingdept;
        /// <summary>
        /// 接收科室
        /// </summary>
        public int ReceivingDept
        {
            get { return  _receivingdept; }
            set {  _receivingdept = value; }
        }

        private DateTime  _sendtime;
        /// <summary>
        /// 消息发送时间
        /// </summary>
        public DateTime SendTime
        {
            get { return  _sendtime; }
            set {  _sendtime = value; }
        }

        private string  _messagetitle;
        /// <summary>
        /// 消息标题
        /// </summary>
        public string MessageTitle
        {
            get { return  _messagetitle; }
            set {  _messagetitle = value; }
        }

        private string  _messagecontent;
        /// <summary>
        /// 消息内容
        /// </summary>
        public string MessageContent
        {
            get { return  _messagecontent; }
            set {  _messagecontent = value; }
        }

        private int  _limittime;
        /// <summary>
        /// 消息有效期
        /// </summary>
        public int Limittime
        {
            get { return  _limittime; }
            set {  _limittime = value; }
        }

    }
}
