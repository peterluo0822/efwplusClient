using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.WcfFrame.ClientController;
using EFWCoreLib.CoreFrame.Business.AttributeInfo;
using Books_Wcf.Winform.IView;
using System.Data;
using EFWCoreLib.WcfFrame.DataSerialize;

namespace Books_Wcf.Winform.Controller
{
    [WinformController(DefaultViewName = "frmBookManager")]//在菜单上显示
    [WinformView(Name = "frmBookManager", DllName = "Books_Wcf.Winform.dll", ViewTypeName = "Books_Wcf.Winform.ViewForm.frmBookManager")]//控制器关联的界面
    public class bookwcfclientController : WcfClientController
    {
        IfrmBookManager _ifrmbookmanager;
        public override void Init()
        {
            _ifrmbookmanager = (IfrmBookManager)DefaultView;
        }
        string msg = "";
        DataTable dt = null;
        public override void AsynInit()
        {
            msg = "Asyn is OK";
            //通过wcf服务调用bookWcfController控制器中的GetBooks方法
            ServiceResponseData retdata = InvokeWcfService("Books.Service", "bookWcfController", "GetBooks");
            dt = retdata.GetData<DataTable>(0);
            
        }

        public override void AsynInitCompleted()
        {
            //MessageBoxShowSimple(msg);
            _ifrmbookmanager.Txt = msg;
            _ifrmbookmanager.loadbooks(dt);
        }

        //保存
        [WinformMethod]
        public void bookSave()
        {
            Action<ClientRequestData> requestAction = ((ClientRequestData request) =>
            {
                request.AddData(_ifrmbookmanager.currBook);
            });

            //通过wcf服务调用bookWcfController控制器中的SaveBook方法，并传递参数Book对象
            InvokeWcfService("Books.Service", "bookWcfController", "SaveBook", requestAction);
            GetBooks();
        }

        //获取书籍目录
        [WinformMethod]
        public void GetBooks()
        {
            //通过wcf服务调用bookWcfController控制器中的GetBooks方法
            ServiceResponseData retdata = InvokeWcfService("Books.Service", "bookWcfController", "GetBooks");
            dt = retdata.GetData<DataTable>(0);
        }
    }
}

