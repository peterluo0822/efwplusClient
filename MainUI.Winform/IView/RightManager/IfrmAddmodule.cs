using EFWCoreLib.WinformFrame.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainUIFrame.Entity;

namespace WinMainUIFrame.Winform.IView.RightManager
{
    public interface IfrmAddmodule : IBaseView
    {
        BaseModule currModule { get; set; }
    }
}
