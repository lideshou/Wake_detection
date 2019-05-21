namespace Log_pull
{
    partial class Pull_Log
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
            this.btn_Pull = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Pull
            // 
            this.btn_Pull.Location = new System.Drawing.Point(12, 12);
            this.btn_Pull.Name = "btn_Pull";
            this.btn_Pull.Size = new System.Drawing.Size(115, 40);
            this.btn_Pull.TabIndex = 0;
            this.btn_Pull.Text = "show times";
            this.btn_Pull.UseVisualStyleBackColor = true;
            this.btn_Pull.Click += new System.EventHandler(this.btn_Pull_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(12, 72);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(115, 40);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "reset";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(133, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "times";
            // 
            // Pull_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Pull);
            this.Name = "Pull_Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_pull";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pull;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label1;
    }
}

