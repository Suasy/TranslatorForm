using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace TranslatorForm
{
    public partial class TransForm : Form
    {
        Translator trans = new Translator();
        LangDic lang = LangDic.getLangDic();

        Dictionary<string, string> srcDic;
        Dictionary<string, string> dstDic;

        bool uitbxHasText = false;

        bool isSwapable = false;

        //定义委托
        public delegate void DoSomeCallBack();

        //声明回调 
        DoSomeCallBack doSomeCallBack;

        //定义Timer
        System.Timers.Timer timer;

        public TransForm()
        {
            InitializeComponent();

            //设置图标
            this.Icon = MyResource.logo;

            //初始化字典
            this.srcDic = new Dictionary<string, string>(lang.en2zh);
            this.dstDic = new Dictionary<string, string>(lang.en2zh);
            this.dstDic.Remove("auto");

            //下拉列表框数据绑定
            BindingSource bsSrc = new BindingSource();
            BindingSource bsDst = new BindingSource();

            bsSrc.DataSource = this.srcDic;
            uicbxSrc.DataSource = bsSrc;
            uicbxSrc.ValueMember = "Key";
            uicbxSrc.DisplayMember = "Value";
            
            bsDst.DataSource = this.dstDic;
            uicbxDst.DataSource = bsDst;
            uicbxDst.ValueMember = "Key";
            uicbxDst.DisplayMember = "Value";

            //设置回调
            this.doSomeCallBack = new DoSomeCallBack(TranslateAsync);

            //设置定时器
            setTimer();
        }

        private string Translate(string q, string from, string to)
        {
            return trans.Translate(q, from, to);
        }

        private void setTimer()
        {
            this.timer = new System.Timers.Timer();

            this.timer.Interval = 1500;
            this.timer.Elapsed += delegate {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(doSomeCallBack);
                }
                else
                {
                    TranslateAsync();
                };
            };

            this.timer.Start();
        }

        private async Task<string> TranslateTask()
        {
            string q = uitbxSrc.Text;
            string from = uicbxSrc.SelectedValue.ToString();
            string to = uicbxDst.SelectedValue.ToString();

            Task<string> task = new Task<string>(
                () => { return Translate(q, from, to); }
            );

            task.Start();

            //等待异步执行完毕
            string dst = await task;

            return dst;
        }

        private async void TranslateAsync()
        {
            string dst = await TranslateTask();
            uitbxDst.Text = dst;
        }

        //点击清空按钮
        private void uibtnClr_Click(object sender, EventArgs e)
        {
            uitbxSrc.Clear();
            uitbxDst.Clear();

            uitbxSrc.Text = "请输入文本进行翻译。";
            uitbxSrc.ForeColor = Color.DimGray;
            this.uitbxHasText = false;
        }

        //点击交换按钮
        private void uibtnSwap_Click(object sender, EventArgs e)
        {
            //交互语言
            int temp = uicbxSrc.SelectedIndex;
            uicbxSrc.SelectedIndex = uicbxDst.SelectedIndex + 1;
            uicbxDst.SelectedIndex = temp - 1;

            //交换文本
            string text = uitbxSrc.Text;
            uitbxSrc.Text = uitbxDst.Text;
            uitbxDst.Text = text;
        }

        //改变源语言
        private void uicbxSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uicbxSrc.SelectedIndex == 0)
                this.isSwapable = false;
            else
                this.isSwapable = true;

            uibtnSwap.Enabled = this.isSwapable;
        }

        //下拉列表框获得焦点
        private void UITextBox_Enter(object sender, EventArgs e)
        {
            UITextBox uitbx = sender as UITextBox;

            if (this.uitbxHasText == false)
                uitbx.Text = "";

            uitbx.ForeColor = Color.FromArgb(48, 48, 48);
        }

        //下拉列表框失去焦点
        private void UITextBox_Leave(object sender, EventArgs e)
        {
            UITextBox uitbx = sender as UITextBox;

            if (uitbx.Text == "")
            {
                uitbx.Text = "请输入文本进行翻译。";
                uitbx.ForeColor = Color.DimGray;
                this.uitbxHasText = false;
            }
            else
                this.uitbxHasText = true;
        }
    }
}
