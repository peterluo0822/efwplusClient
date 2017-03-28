using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.CoreFrame.Business.AttributeInfo;
using System.Reflection;
using System.IO;

namespace EFWCoreLib.CoreFrame.Init.AttributeManager
{
    public class WinformControllerManager 
    {
        /// <summary>
        /// 控制器配置信息
        /// </summary>
        public static List<WinformControllerAttributeInfo> ControllerList;

        public static void LoadAttribute()
        {
            List<Assembly> Assemblys = GetLocalAssembly();

            ControllerList = new List<WinformControllerAttributeInfo>();

            for (int k = 0; k < Assemblys.Count; k++)
            {
                //System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(BusinessDll[k]);
                System.Reflection.Assembly assembly = Assemblys[k];
                Type[] types = assembly.GetTypes();
                for (int i = 0; i < types.Length; i++)
                {
                    WinformControllerAttribute[] winC = ((WinformControllerAttribute[])types[i].GetCustomAttributes(typeof(WinformControllerAttribute), true));

                    if (winC.Length > 0)
                    {
                        WinformControllerAttributeInfo cmdC = new WinformControllerAttributeInfo();
                        cmdC.controllerName = types[i].Name;
                        cmdC.defaultViewName = winC[0].DefaultViewName;
                        cmdC.winformController = (WinformFrame.Controller.WinformController)Activator.CreateInstance(types[i], null);
                        cmdC.MethodList = new List<WinformMethodAttributeInfo>();
                        cmdC.ViewList = new List<WinformViewAttributeInfo>();

                        MethodInfo[] property = types[i].GetMethods();
                        for (int n = 0; n < property.Length; n++)
                        {
                            WinformMethodAttribute[] WinM = (WinformMethodAttribute[])property[n].GetCustomAttributes(typeof(WinformMethodAttribute), true);
                            if (WinM.Length > 0)
                            {
                                WinformMethodAttributeInfo cmdM = new WinformMethodAttributeInfo();
                                cmdM.methodName = property[n].Name;
                                cmdM.methodInfo = property[n];
                                cmdC.MethodList.Add(cmdM);
                            }
                        }

                        WinformViewAttribute[] viewAttribute = (WinformViewAttribute[])types[i].GetCustomAttributes(typeof(WinformViewAttribute), true);
                        for (int n = 0; n < viewAttribute.Length; n++)
                        {
                            WinformViewAttributeInfo winView = new WinformViewAttributeInfo();
                            winView.Name = viewAttribute[n].Name;
                            winView.DllName = viewAttribute[n].DllName;
                            winView.ViewTypeName = viewAttribute[n].ViewTypeName;
                            winView.IsDefaultView = winView.Name == cmdC.defaultViewName ? true : false;

                            //Assembly _assembly = Assembly.LoadFrom(winView.DllName);
                            winView.ViewType = assembly.GetType(winView.ViewTypeName, false, true);
                            cmdC.ViewList.Add(winView);
                        }
                        ControllerList.Add(cmdC);
                    }
                }
            }
        }

        private static List<Assembly> GetLocalAssembly()
        {
            List<System.Reflection.Assembly> list = new List<System.Reflection.Assembly>();

            string ApiAssembly = AppDomain.CurrentDomain.BaseDirectory + "WinAssembly";
            DirectoryInfo Dir = new DirectoryInfo(ApiAssembly);
            if (Dir.Exists)
            {
                FileInfo[] dlls = Dir.GetFiles("*.dll", SearchOption.AllDirectories);
                foreach (var i in dlls)
                {
                    list.Add(System.Reflection.Assembly.Load(i.Name.Replace(".dll", "")));
                }
            }
            return list;
        }

        public static WinformControllerAttributeInfo GetControllerAttributeInfo(string controller)
        {
            List<WinformControllerAttributeInfo> list = ControllerList;
            if (list != null && list.FindIndex(x => x.controllerName == controller) > -1)
            {
                return list.Find(x => x.controllerName == controller);
            }
            return null;
        }
    }

    public class WinformControllerAttributeInfo
    {
        public string controllerName { get; set; }
        public string defaultViewName { get; set; }
        public WinformFrame.Controller.WinformController winformController { get; set; }
        public List<WinformMethodAttributeInfo> MethodList { get; set; }
        public List<WinformViewAttributeInfo> ViewList { get; set; }
    }

    public class WinformViewAttributeInfo
    {
        public string Name { get; set; }
        public string DllName { get; set; }
        public string ViewTypeName { get; set; }
        public bool IsDefaultView { get; set; }
        public Type ViewType { get; set; }
    }

    public class WinformMethodAttributeInfo
    {
        public string methodName { get; set; }
        public System.Reflection.MethodInfo methodInfo { get; set; }
        public List<string> dbkeys { get; set; }
    }
}
