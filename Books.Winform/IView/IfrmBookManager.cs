using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EFWCoreLib.WinformFrame.Controller;
using BooksModels;

namespace Books_Wcf.Winform.IView
{
    public interface IfrmBookManager : IBaseView
    {
        //给网格加载数据
        void loadbooks(DataTable dt);
        //当前维护的书籍
        Books currBook { get; set; }

        DataTable getBookdt { get; }

        string Txt { set; }
    }
}
