using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseConvert
{
    public partial class CaseConvertMain : Form
    {
        public CaseConvertMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 转大写 按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toUpperButton_Click(object sender, EventArgs e)
        {
            if (this.Controls["inputTextBox"] is TextBox input &&
                    this.Controls["outputTextBox"] is TextBox output)
            {
                output.Text = input.Text.ToUpper();
            }
        }

        private void toLowerButton_Click(object sender, EventArgs e)
        {
            if (this.Controls["inputTextBox"] is TextBox input &&
                    this.Controls["outputTextBox"] is TextBox output)
            {
                output.Text = input.Text.ToLower();
            }
        }

        private void swapCaseButton_Click(object sender, EventArgs e)
        {
            if (this.Controls["inputTextBox"] is TextBox input &&
                   this.Controls["outputTextBox"] is TextBox output)
            {
                output.Text = SwapCase(input.Text);
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (this.Controls["outputTextBox"] is TextBox output && !string.IsNullOrEmpty(output.Text))
            {
                Clipboard.SetText(output.Text);
                MessageBox.Show("已复制到剪贴板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 实现大小写互换功能
        /// </summary>
        private string SwapCase(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                else if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                // 非字母字符不做处理
            }
            return new string(chars);
        }
    }
}
