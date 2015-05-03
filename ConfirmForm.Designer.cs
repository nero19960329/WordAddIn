namespace WordAddIn
{
    partial class ConfirmForm
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(10, 58);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(247, 20);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "当前为打印预览，是否使用免费打印？";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::WordAddIn.Properties.Resources._01124_149x42x4BPP_;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Location = new System.Drawing.Point(59, 97);
            this.skinButton1.MouseBack = global::WordAddIn.Properties.Resources._01125_149x42x4BPP_;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::WordAddIn.Properties.Resources._01126_149x42x4BPP_;
            this.skinButton1.Size = new System.Drawing.Size(149, 23);
            this.skinButton1.TabIndex = 5;
            this.skinButton1.Text = "是，我要免费打印";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = global::WordAddIn.Properties.Resources._01124_149x42x4BPP_;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.Location = new System.Drawing.Point(59, 135);
            this.skinButton2.MouseBack = global::WordAddIn.Properties.Resources._01125_149x42x4BPP_;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = global::WordAddIn.Properties.Resources._01126_149x42x4BPP_;
            this.skinButton2.Size = new System.Drawing.Size(149, 23);
            this.skinButton2.TabIndex = 6;
            this.skinButton2.Text = "不，我想打印原版文档";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordAddIn.Properties.Resources.background_3;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(264, 183);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = global::WordAddIn.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::WordAddIn.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::WordAddIn.Properties.Resources.sysbtn_close_normal;
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.MiniDownBack = global::WordAddIn.Properties.Resources.aio_setting_down;
            this.MiniMouseBack = global::WordAddIn.Properties.Resources.aio_setting_hover;
            this.MiniNormlBack = global::WordAddIn.Properties.Resources.aio_setting_normal;
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.Name = "ConfirmForm";
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}