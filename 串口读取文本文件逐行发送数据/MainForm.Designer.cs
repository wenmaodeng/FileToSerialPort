namespace 串口读取文本文件逐行发送数据
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxsenddata = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonchoosefile = new System.Windows.Forms.Button();
            this.buttonsenddata = new System.Windows.Forms.Button();
            this.labelsendcount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxsenddata
            // 
            this.richTextBoxsenddata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxsenddata.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxsenddata.Name = "richTextBoxsenddata";
            this.richTextBoxsenddata.Size = new System.Drawing.Size(518, 224);
            this.richTextBoxsenddata.TabIndex = 0;
            this.richTextBoxsenddata.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxsenddata, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 280);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonchoosefile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonsenddata, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelsendcount, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 233);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonchoosefile
            // 
            this.buttonchoosefile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonchoosefile.Location = new System.Drawing.Point(3, 3);
            this.buttonchoosefile.Name = "buttonchoosefile";
            this.buttonchoosefile.Size = new System.Drawing.Size(166, 38);
            this.buttonchoosefile.TabIndex = 1;
            this.buttonchoosefile.Text = "选择文件";
            this.buttonchoosefile.UseVisualStyleBackColor = true;
            this.buttonchoosefile.Click += new System.EventHandler(this.buttonchoosefile_Click);
            // 
            // buttonsenddata
            // 
            this.buttonsenddata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsenddata.Location = new System.Drawing.Point(175, 3);
            this.buttonsenddata.Name = "buttonsenddata";
            this.buttonsenddata.Size = new System.Drawing.Size(166, 38);
            this.buttonsenddata.TabIndex = 0;
            this.buttonsenddata.Text = "发送数据";
            this.buttonsenddata.UseVisualStyleBackColor = true;
            this.buttonsenddata.Click += new System.EventHandler(this.buttonsenddata_Click);
            // 
            // labelsendcount
            // 
            this.labelsendcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsendcount.Location = new System.Drawing.Point(347, 0);
            this.labelsendcount.Name = "labelsendcount";
            this.labelsendcount.Size = new System.Drawing.Size(168, 44);
            this.labelsendcount.TabIndex = 2;
            this.labelsendcount.Text = "/";
            this.labelsendcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读取文本文件串口逐行发送数据";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxsenddata;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonchoosefile;
        private System.Windows.Forms.Button buttonsenddata;
        private System.Windows.Forms.Label labelsendcount;
    }
}

