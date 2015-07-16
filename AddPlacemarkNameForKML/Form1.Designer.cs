namespace AddPlacemarkNameForKML
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxFileKML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnAddNamesToKML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxFileKML
            // 
            this.txtBoxFileKML.Location = new System.Drawing.Point(81, 73);
            this.txtBoxFileKML.Name = "txtBoxFileKML";
            this.txtBoxFileKML.ReadOnly = true;
            this.txtBoxFileKML.Size = new System.Drawing.Size(307, 21);
            this.txtBoxFileKML.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "KML文件：";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(420, 73);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "选择...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnAddNamesToKML
            // 
            this.btnAddNamesToKML.Location = new System.Drawing.Point(175, 115);
            this.btnAddNamesToKML.Name = "btnAddNamesToKML";
            this.btnAddNamesToKML.Size = new System.Drawing.Size(146, 46);
            this.btnAddNamesToKML.TabIndex = 3;
            this.btnAddNamesToKML.Text = "开始添加...";
            this.btnAddNamesToKML.UseVisualStyleBackColor = true;
            this.btnAddNamesToKML.Click += new System.EventHandler(this.btnAddNamesToKML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(77, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "1.点击选择，选择kml文件路径； 2.点击“开始添加按钮”";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNamesToKML);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFileKML);
            this.Name = "Form1";
            this.Text = "添加Name字段到KML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFileKML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnAddNamesToKML;
        private System.Windows.Forms.Label label2;
    }
}

