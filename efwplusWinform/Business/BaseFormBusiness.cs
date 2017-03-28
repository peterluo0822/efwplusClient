using DevComponents.DotNetBar;
using EFWCoreLib.CoreFrame.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFWCoreLib.CoreFrame.Business
{
    public partial class BaseFormBusiness : Form, IBaseViewBusiness
    {
        public BaseFormBusiness()
        {
            InitializeComponent();
            //this.Font = new Font("宋体", 9F);
        }


        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region IBaseView 成员

        //public event ControllerEventHandler ControllerEvent;

        private ControllerEventHandler _InvokeController;
        public ControllerEventHandler InvokeController
        {
            get
            {
                return _InvokeController;
            }
            set
            {
                _InvokeController = value;
            }
        }
        private string _frmName;
        public string frmName
        {
            get
            {
                return _frmName;
            }
            set
            {
                _frmName = value;
            }
        }
        #endregion


        public virtual void doBarCode(string barCode)
        {

        }

        [Description("打开窗体之前")]
        public event EventHandler OpenWindowBefore;

        [Description("关闭窗体之后")]
        public event EventHandler CloseWindowAfter;

        public void ExecOpenWindowBefore(object sender, EventArgs e)
        {
            if (OpenWindowBefore != null)
                OpenWindowBefore(sender, e);
        }

        public void ExecCloseWindowAfter(object sender, EventArgs e)
        {
            if (CloseWindowAfter != null)
                CloseWindowAfter(sender, e);
        }

        private Dictionary<string, int> dicIndex;
        /// <summary>
        /// 绑定网格控件的选定索引
        /// </summary>
        /// <param name="grids"></param>
        protected void bindGridSelectIndex(params DataGridView[] grids)
        {
            dicIndex = new Dictionary<string, int>();
            foreach (DataGridView grid in grids)
            {
                grid.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    if ((sender as DataGridView).CurrentCell != null)
                        dicIndex[(sender as DataGridView).Name] = (sender as DataGridView).CurrentCell.RowIndex;
                    else
                        dicIndex[(sender as DataGridView).Name] = -1;
                });
            }
        }
        /// <summary>
        /// 设置网格控件的上次选定行
        /// </summary>
        /// <param name="grids"></param>
        protected void setGridSelectIndex(params DataGridView[] grids)
        {
            foreach (DataGridView grid in grids)
            {
                if (dicIndex.ContainsKey(grid.Name) == false) continue;
                int rowindex = dicIndex[grid.Name];
                int colindex = 0;
                if (rowindex != -1 && rowindex <= (grid.RowCount - 1))
                {
                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        if (grid.Columns[i].Visible)
                        {
                            colindex = i;
                            break;
                        }
                    }
                    grid.CurrentCell = grid[colindex, rowindex];
                }
            }
        }
        /// <summary>
        /// 设置网格控件的指定行
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="rowindex"></param>
        protected void setGridSelectIndex(DataGridView grid, int rowindex)
        {
            int colindex = 0;
            if (rowindex > -1 && rowindex <= (grid.RowCount - 1))
            {
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        colindex = i;
                        break;
                    }
                }
                dicIndex[grid.Name] = rowindex;
                grid.CurrentCell = grid[colindex, rowindex];
            }
        }

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                //case CodeBarInput.WM_IDCARD_INFO:
                //    {
                //        byte[] cInput = new byte[101];
                //        System.Runtime.InteropServices.Marshal.Copy(m.WParam, cInput, 0, 100);
                //        String sInput = System.Text.Encoding.Default.GetString(cInput);
                //        if (sInput.Length > 0)
                //        {
                //        }
                //    }
                //    break;
                //case CodeBarInput.WM_RFID_INFO:
                //    {
                //        byte[] cInput = new byte[101];
                //        System.Runtime.InteropServices.Marshal.Copy(m.WParam, cInput, 0, 100);
                //        String sInput = System.Text.Encoding.Default.GetString(cInput);
                //        if (sInput.Length > 0)
                //        {
                //        }
                //    }
                //    break;
                //case CodeBarInput.WM_SCANNER_INPUT:
                //    {
                //        byte[] cInput = new byte[101];
                //        System.Runtime.InteropServices.Marshal.Copy(m.WParam, cInput, 0, 100);
                //        String sInput = System.Text.Encoding.Default.GetString(cInput);
                //        string barcode = Convert.ToString(sInput).Trim('\0');

                //        if (this.barMainContainer.SelectedDockContainerItem.Tag is EfwControls.CustomControl.BaseFormEx)
                //        {
                //            (this.barMainContainer.SelectedDockContainerItem.Tag as EfwControls.CustomControl.BaseFormEx).doBarCode(barcode);
                //        }
                //    }
                //    break;
                case WindowsAPI.WM_ASYN_INPUT:
                    InvokeController("AsynInitCompleted");
                    break;
                default:
                    base.DefWndProc(ref m);//调用基类函数处理非自定义消息。
                    break;
            }
        }

        /// <summary>
        /// 简单提示，右下角提示
        /// </summary>
        /// <param name="text"></param>
        protected void MessageBoxShowSimple(string text)
        {
            InvokeController("MessageBoxShowSimple", text);
        }
        /// <summary>
        /// 异步调用
        /// </summary>
        protected void AsynInvoked(Func<Object> beginInvoke, Action<Object> endInvoke)
        {
            try {
                if (beginInvoke != null)
                {
                    ToastNotification.Show(this,
                    "数据正在处理中，请等待...",
                    efwplusWinform.Common.CommonResource.load,
                    0,
                    (eToastGlowColor)(eToastGlowColor.Blue),
                    (eToastPosition)(eToastPosition.TopCenter));

                    this.Enabled = false;

                    using (BackgroundWorker bw = new BackgroundWorker())
                    {
                        bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                        bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                        bw.RunWorkerAsync(new object[] { beginInvoke, endInvoke });
                    }
                }
            }
            catch(Exception e)
            {
                ToastNotification.Close(this);
                this.Enabled = true;

                throw e;
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;//这里只是简单的把参数当做结果返回，当然您也可以在这里做复杂的处理后，再返回自己想要的结果(这里的操作是在另一个线程上完成的)
            Func<Object> beginInvoke = (Func<Object>)args[0];
            object result = beginInvoke();
            e.Result = new object[] { args[1], result };
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ToastNotification.Close(this);
            this.Enabled = true;

            object[] rst= (object[])e.Result;
            Action<Object> endInvoke = (Action<Object>)rst[0];
            object result = rst[1];
            endInvoke(result);
            //这时后台线程已经完成，并返回了主线程，所以可以直接使用UI控件了
        }
    }
}
