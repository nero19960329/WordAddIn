namespace WordAddIn
{
    partial class CopiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skinNumericUpDown1 = new CCWin.SkinControl.SkinNumericUpDown();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinNumericUpDown1
            // 
            this.skinNumericUpDown1.ArrowColor = System.Drawing.Color.Black;
            this.skinNumericUpDown1.BaseColor = System.Drawing.Color.Transparent;
            this.skinNumericUpDown1.BorderColor = System.Drawing.Color.Transparent;
            this.skinNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinNumericUpDown1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinNumericUpDown1.Location = new System.Drawing.Point(79, 57);
            this.skinNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.skinNumericUpDown1.Name = "skinNumericUpDown1";
            this.skinNumericUpDown1.Size = new System.Drawing.Size(55, 21);
            this.skinNumericUpDown1.TabIndex = 0;
            this.skinNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::WordAddIn.Properties.Resources._01124_149x42x4BPP_;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Location = new System.Drawing.Point(152, 57);
            this.skinButton1.MouseBack = global::WordAddIn.Properties.Resources._01125_149x42x4BPP_;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::WordAddIn.Properties.Resources._01126_149x42x4BPP_;
            this.skinButton1.Size = new System.Drawing.Size(101, 21);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(29, 58);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "份数：";
            // 
            // CopiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordAddIn.Properties.Resources.background_3;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(273, 108);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = global::WordAddIn.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::WordAddIn.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::WordAddIn.Properties.Resources.sysbtn_close_normal;
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinNumericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopiesForm";
            this.ShadowWidth = 6;
            this.ShowDrawIcon = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入份数";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CopiesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinNumericUpDown skinNumericUpDown1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}