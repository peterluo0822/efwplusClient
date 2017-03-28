using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainUIFrame.Entity
{
    public class BaseMenu
    {
        private int  _menuid;
        /// <summary>
        /// 编号
        /// </summary>
        public int MenuId
        {
            get { return  _menuid; }
            set {  _menuid = value; }
        }

        private int  _sortid;
        /// <summary>
        /// 排序号
        /// </summary>
        public int SortId
        {
            get { return  _sortid; }
            set {  _sortid = value; }
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

        private string  _dllname;
        /// <summary>
        /// DLL名称
        /// </summary>
        public string DllName
        {
            get { return  _dllname; }
            set {  _dllname = value; }
        }

        private string  _funname;
        /// <summary>
        /// 引出函数名称
        /// </summary>
        public string FunName
        {
            get { return  _funname; }
            set {  _funname = value; }
        }

        private string  _funwcfname;
        /// <summary>
        /// 引出WCF名称
        /// </summary>
        public string FunWcfName
        {
            get { return  _funwcfname; }
            set {  _funwcfname = value; }
        }

        private int  _moduleid;
        /// <summary>
        /// 所属模块编号
        /// </summary>
        public int ModuleId
        {
            get { return  _moduleid; }
            set {  _moduleid = value; }
        }

        private int  _pmenuid;
        /// <summary>
        /// 父菜单编号
        /// </summary>
        public int PMenuId
        {
            get { return  _pmenuid; }
            set {  _pmenuid = value; }
        }

        private int  _menutoolbar;
        /// <summary>
        /// 是否显示在toolbar
        /// </summary>
        public int MenuToolBar
        {
            get { return  _menutoolbar; }
            set {  _menutoolbar = value; }
        }

        private int  _menulookbar;
        /// <summary>
        /// 是否显示在outlookbar
        /// </summary>
        public int MenuLookBar
        {
            get { return  _menulookbar; }
            set {  _menulookbar = value; }
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

        private string  _image;
        /// <summary>
        /// 菜单图片
        /// </summary>
        public string Image
        {
            get { return  _image; }
            set {  _image = value; }
        }

        private string  _urlid;
        /// <summary>
        /// UrlID
        /// </summary>
        public string UrlId
        {
            get { return  _urlid; }
            set {  _urlid = value; }
        }

        private string  _urlname;
        /// <summary>
        /// Url名称
        /// </summary>
        public string UrlName
        {
            get { return  _urlname; }
            set {  _urlname = value; }
        }

        private string  _bindsql;
        /// <summary>
        /// 绑定SQL
        /// </summary>
        public string BindSQL
        {
            get { return  _bindsql; }
            set {  _bindsql = value; }
        }

    }
}
