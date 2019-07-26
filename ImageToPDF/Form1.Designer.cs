namespace ImageToPDF
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
            this.lab_path = new System.Windows.Forms.Label();
            this.lab_state = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.btn_creat = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_path.Location = new System.Drawing.Point(32, 43);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(104, 16);
            this.lab_path.TabIndex = 0;
            this.lab_path.Text = "选择文件夹：";
            // 
            // lab_state
            // 
            this.lab_state.AutoSize = true;
            this.lab_state.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lab_state.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab_state.Location = new System.Drawing.Point(3, 425);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(59, 16);
            this.lab_state.TabIndex = 1;
            this.lab_state.Text = "状态：";
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_path.Location = new System.Drawing.Point(131, 39);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(633, 26);
            this.tb_path.TabIndex = 2;
            this.tb_path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_path_MouseClick);
            // 
            // tb_info
            // 
            this.tb_info.Font = new System.Drawing.Font("宋体", 10F);
            this.tb_info.Location = new System.Drawing.Point(35, 87);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_info.Size = new System.Drawing.Size(729, 304);
            this.tb_info.TabIndex = 3;
            // 
            // btn_creat
            // 
            this.btn_creat.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_creat.Location = new System.Drawing.Point(699, 413);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(65, 30);
            this.btn_creat.TabIndex = 4;
            this.btn_creat.Text = "生成";
            this.btn_creat.UseVisualStyleBackColor = true;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_clear.Location = new System.Drawing.Point(614, 413);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 30);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(739, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_creat);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lab_state);
            this.Controls.Add(this.lab_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【ImageToPDF】-- by qiyiran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.Label lab_state;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.Button btn_creat;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
    }
}

