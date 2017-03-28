using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFWCoreLib.CoreFrame.Business;

namespace EFWCoreLib.WinformFrame
{
    /// <summary>
    /// Winform程序
    /// </summary>
    public class WinformGlobal
    {
        public static ILoading winfromMain;
        public static SysLoginRight LoginUserInfo;

        /// <summary>
        /// 启动程序
        /// </summary>
        public static void Main()
        {
            FrmSplash frmSplash = new FrmSplash(Init);
            winfromMain = frmSplash as ILoading;
            System.Windows.Forms.Application.Run(frmSplash);
        }

        private static bool Init()
        {
            try
            {

                CoreFrame.Init.AttributeManager.WinformControllerManager.LoadAttribute();

                string entrycontroller= "wcfclientLoginController";

                EFWCoreLib.WinformFrame.Controller.WinformController controller = EFWCoreLib.WinformFrame.Controller.ControllerHelper.CreateController(entrycontroller);
                //controller.Init();
                if (controller == null)
                    throw new Exception("没有找到wcfclientLoginController启动控制器！");
                ((System.Windows.Forms.Form)controller.DefaultView).Show();
                winfromMain.MainForm = ((System.Windows.Forms.Form)controller.DefaultView);

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                //AppExit();
                return false;
            }
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        public static void Exit()
        {
            (winfromMain as Form).Dispose();
        }

        public static void AppConfig()
        {
            FrmConfig config = new FrmConfig();
            config.ShowDialog();
        }
    }
}
