namespace WordAddIn
{
    partial class PrintForm
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
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Forme;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(64, 52);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(189, 20);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "是否使用免费打印？";
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::WordAddIn.Properties.Resources._01124_149x42x4BPP_;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.Location = new System.Drawing.Point(29, 97);
            this.skinButton1.MouseBack = global::WordAddIn.Properties.Resources._01125_149x42x4BPP_;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::WordAddIn.Properties.Resources._01126_149x42x4BPP_;
            this.skinButton1.Size = new System.Drawing.Size(117, 23);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "是，我要免费打印";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = global::WordAddIn.Properties.Resources._01124_149x42x4BPP_;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.Location = new System.Drawing.Point(176, 97);
            this.skinButton2.MouseBack = global::WordAddIn.Properties.Resources._01125_149x42x4BPP_;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = global::WordAddIn.Properties.Resources._01126_149x42x4BPP_;
            this.skinButton2.Size = new System.Drawing.Size(116, 23);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "不，我要花钱打印";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::WordAddIn.Properties.Resources.background_3;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(310, 139);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = global::WordAddIn.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::WordAddIn.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::WordAddIn.Properties.Resources.sysbtn_close_normal;
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel1);
            this.DropBack = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(30, 30);
            this.MiniDownBack = global::WordAddIn.Properties.Resources.aio_setting_down;
            this.MiniMouseBack = global::WordAddIn.Properties.Resources.aio_setting_hover;
            this.MiniNormlBack = global::WordAddIn.Properties.Resources.aio_setting_normal;
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.MobileApi = false;
            this.Name = "PrintForm";
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PrintForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}