using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCoreLib.CoreFrame.Init;
using EFWCoreLib.CoreFrame.Init.AttributeManager;
using EFWCoreLib.WinformFrame.Controller;

namespace EFWCoreLib.CoreFrame.Init
{
    public static class AppPluginManageExtension
    {
        public static void InitAllWinformController()
        {
            List<WinformControllerAttributeInfo> list = WinformControllerManager.ControllerList;
            if (list != null)
            {
                foreach (var c in list)
                {
                    if ((c.controllerName == "wcfclientLoginController") == false)
                    {
                        (c.winformController as WinformController).InitFinish = false;
                        (c.winformController as WinformController).AsynInitCompletedFinish = false;
                    }
                }
            }
        }
    }
}
