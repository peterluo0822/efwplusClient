using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseDeptLayer
    {
        private int  _layerid;
        /// <summary>
        /// 节点ID
        /// </summary>
        public int LayerId
        {
            get { return  _layerid; }
            set {  _layerid = value; }
        }

        private int  _pid;
        /// <summary>
        /// 父节点ID
        /// </summary>
        public int PId
        {
            get { return  _pid; }
            set {  _pid = value; }
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

    }
}
