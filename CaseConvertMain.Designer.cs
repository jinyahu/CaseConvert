
using System.Windows.Forms;

namespace CaseConvert
{
    partial class CaseConvertMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.toUpperButton = new System.Windows.Forms.Button();
            this.toLowerButton = new System.Windows.Forms.Button();
            this.swapCaseButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(20, 20);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(165, 15);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "请输入需要转换的文本:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 45);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(540, 100);
            this.inputTextBox.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.toUpperButton);
            this.buttonPanel.Controls.Add(this.toLowerButton);
            this.buttonPanel.Controls.Add(this.swapCaseButton);
            this.buttonPanel.Controls.Add(this.copyButton);
            this.buttonPanel.Location = new System.Drawing.Point(20, 160);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(540, 40);
            this.buttonPanel.TabIndex = 2;
            // 
            // toUpperButton
            // 
            this.toUpperButton.Location = new System.Drawing.Point(10, 5);
            this.toUpperButton.Name = "toUpperButton";
            this.toUpperButton.Size = new System.Drawing.Size(120, 30);
            this.toUpperButton.TabIndex = 0;
            this.toUpperButton.Text = "转大写";
            this.toUpperButton.Click += new System.EventHandler(this.toUpperButton_Click);
            // 
            // toLowerButton
            // 
            this.toLowerButton.Location = new System.Drawing.Point(150, 5);
            this.toLowerButton.Name = "toLowerButton";
            this.toLowerButton.Size = new System.Drawing.Size(120, 30);
            this.toLowerButton.TabIndex = 1;
            this.toLowerButton.Text = "转小写";
            this.toLowerButton.Click += new System.EventHandler(this.toLowerButton_Click);
            // 
            // swapCaseButton
            // 
            this.swapCaseButton.Location = new System.Drawing.Point(290, 5);
            this.swapCaseButton.Name = "swapCaseButton";
            this.swapCaseButton.Size = new System.Drawing.Size(120, 30);
            this.swapCaseButton.TabIndex = 2;
            this.swapCaseButton.Text = "大小写互换";
            this.swapCaseButton.Click += new System.EventHandler(this.swapCaseButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(430, 5);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(100, 30);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "复制结果";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(20, 210);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(75, 15);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "转换结果:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(20, 235);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(540, 100);
            this.outputTextBox.TabIndex = 4;
            // 
            // CaseConvertMain
            // 
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Name = "CaseConvertMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "英文字母大小写转换工具";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label inputLabel;
        private TextBox inputTextBox;
        private Panel buttonPanel;
        private Button toUpperButton;
        private Button toLowerButton;
        private Button swapCaseButton;
        private Button copyButton;
        private Label outputLabel;
        private TextBox outputTextBox;
    }
}

