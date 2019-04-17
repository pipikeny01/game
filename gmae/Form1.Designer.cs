namespace gmae
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlayer1Log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlayer2Log = new System.Windows.Forms.TextBox();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayer1Log
            // 
            this.txtPlayer1Log.Location = new System.Drawing.Point(63, 59);
            this.txtPlayer1Log.Multiline = true;
            this.txtPlayer1Log.Name = "txtPlayer1Log";
            this.txtPlayer1Log.Size = new System.Drawing.Size(333, 343);
            this.txtPlayer1Log.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayer2Log
            // 
            this.txtPlayer2Log.Location = new System.Drawing.Point(443, 59);
            this.txtPlayer2Log.Multiline = true;
            this.txtPlayer2Log.Name = "txtPlayer2Log";
            this.txtPlayer2Log.Size = new System.Drawing.Size(317, 343);
            this.txtPlayer2Log.TabIndex = 2;
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Location = new System.Drawing.Point(63, 41);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(33, 12);
            this.lbPlayer1.TabIndex = 3;
            this.lbPlayer1.Text = "label1";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Location = new System.Drawing.Point(441, 41);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(33, 12);
            this.lbPlayer2.TabIndex = 4;
            this.lbPlayer2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.txtPlayer2Log);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlayer1Log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayer1Log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlayer2Log;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
    }
}

