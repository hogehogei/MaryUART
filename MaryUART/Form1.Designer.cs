namespace MaryUART
{
    partial class MaryUART
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.UARTSendButton = new System.Windows.Forms.Button();
            this.RecvTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UARTStartButton = new System.Windows.Forms.Button();
            this.UARTRecvTimer = new System.Windows.Forms.Timer(this.components);
            this.UARTCloseButton = new System.Windows.Forms.Button();
            this.COMPortMenu = new System.Windows.Forms.ComboBox();
            this.BaudrateMenu = new System.Windows.Forms.ComboBox();
            this.DatabitsMenu = new System.Windows.Forms.ComboBox();
            this.ParityMenu = new System.Windows.Forms.ComboBox();
            this.StopBitsMenu = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendTextBox
            // 
            this.SendTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendTextBox.Location = new System.Drawing.Point(12, 34);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(284, 22);
            this.SendTextBox.TabIndex = 0;
            // 
            // UARTSendButton
            // 
            this.UARTSendButton.Location = new System.Drawing.Point(319, 29);
            this.UARTSendButton.Name = "UARTSendButton";
            this.UARTSendButton.Size = new System.Drawing.Size(75, 23);
            this.UARTSendButton.TabIndex = 1;
            this.UARTSendButton.Text = "送信";
            this.UARTSendButton.UseVisualStyleBackColor = true;
            this.UARTSendButton.Click += new System.EventHandler(this.UARTSendButton_Click);
            // 
            // RecvTextBox
            // 
            this.RecvTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RecvTextBox.Location = new System.Drawing.Point(454, 29);
            this.RecvTextBox.Multiline = true;
            this.RecvTextBox.Name = "RecvTextBox";
            this.RecvTextBox.Size = new System.Drawing.Size(422, 313);
            this.RecvTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "COMPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Databits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "StopBits";
            // 
            // UARTStartButton
            // 
            this.UARTStartButton.Location = new System.Drawing.Point(41, 241);
            this.UARTStartButton.Name = "UARTStartButton";
            this.UARTStartButton.Size = new System.Drawing.Size(75, 23);
            this.UARTStartButton.TabIndex = 13;
            this.UARTStartButton.Text = "接続";
            this.UARTStartButton.UseVisualStyleBackColor = true;
            this.UARTStartButton.Click += new System.EventHandler(this.UARTOpenButton_Click);
            // 
            // UARTRecvTimer
            // 
            this.UARTRecvTimer.Enabled = true;
            this.UARTRecvTimer.Interval = 200;
            this.UARTRecvTimer.Tick += new System.EventHandler(this.UARTRecvData);
            // 
            // UARTCloseButton
            // 
            this.UARTCloseButton.Location = new System.Drawing.Point(147, 241);
            this.UARTCloseButton.Name = "UARTCloseButton";
            this.UARTCloseButton.Size = new System.Drawing.Size(75, 23);
            this.UARTCloseButton.TabIndex = 14;
            this.UARTCloseButton.Text = "終了";
            this.UARTCloseButton.UseVisualStyleBackColor = true;
            this.UARTCloseButton.Click += new System.EventHandler(this.UARTCloseButton_Click);
            // 
            // COMPortMenu
            // 
            this.COMPortMenu.FormattingEnabled = true;
            this.COMPortMenu.Location = new System.Drawing.Point(101, 86);
            this.COMPortMenu.Name = "COMPortMenu";
            this.COMPortMenu.Size = new System.Drawing.Size(121, 20);
            this.COMPortMenu.TabIndex = 15;
            // 
            // BaudrateMenu
            // 
            this.BaudrateMenu.FormattingEnabled = true;
            this.BaudrateMenu.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudrateMenu.Location = new System.Drawing.Point(101, 112);
            this.BaudrateMenu.Name = "BaudrateMenu";
            this.BaudrateMenu.Size = new System.Drawing.Size(121, 20);
            this.BaudrateMenu.TabIndex = 16;
            // 
            // DatabitsMenu
            // 
            this.DatabitsMenu.FormattingEnabled = true;
            this.DatabitsMenu.Items.AddRange(new object[] {
            "8",
            "9"});
            this.DatabitsMenu.Location = new System.Drawing.Point(101, 138);
            this.DatabitsMenu.Name = "DatabitsMenu";
            this.DatabitsMenu.Size = new System.Drawing.Size(121, 20);
            this.DatabitsMenu.TabIndex = 17;
            // 
            // ParityMenu
            // 
            this.ParityMenu.FormattingEnabled = true;
            this.ParityMenu.Items.AddRange(new object[] {
            "None"});
            this.ParityMenu.Location = new System.Drawing.Point(101, 164);
            this.ParityMenu.Name = "ParityMenu";
            this.ParityMenu.Size = new System.Drawing.Size(121, 20);
            this.ParityMenu.TabIndex = 18;
            // 
            // StopBitsMenu
            // 
            this.StopBitsMenu.FormattingEnabled = true;
            this.StopBitsMenu.Items.AddRange(new object[] {
            "1"});
            this.StopBitsMenu.Location = new System.Drawing.Point(101, 193);
            this.StopBitsMenu.Name = "StopBitsMenu";
            this.StopBitsMenu.Size = new System.Drawing.Size(121, 20);
            this.StopBitsMenu.TabIndex = 19;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Crimson;
            this.StatusLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.StatusLabel.Location = new System.Drawing.Point(260, 86);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(170, 59);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "接続待ち";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaryUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 354);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StopBitsMenu);
            this.Controls.Add(this.ParityMenu);
            this.Controls.Add(this.DatabitsMenu);
            this.Controls.Add(this.BaudrateMenu);
            this.Controls.Add(this.COMPortMenu);
            this.Controls.Add(this.UARTCloseButton);
            this.Controls.Add(this.UARTStartButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecvTextBox);
            this.Controls.Add(this.UARTSendButton);
            this.Controls.Add(this.SendTextBox);
            this.Name = "MaryUART";
            this.Text = "MaryUART";
            this.Load += new System.EventHandler(this.MaryUART_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button UARTSendButton;
        private System.Windows.Forms.TextBox RecvTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UARTStartButton;
        private System.Windows.Forms.Timer UARTRecvTimer;
        private System.Windows.Forms.Button UARTCloseButton;
        private System.Windows.Forms.ComboBox COMPortMenu;
        private System.Windows.Forms.ComboBox BaudrateMenu;
        private System.Windows.Forms.ComboBox DatabitsMenu;
        private System.Windows.Forms.ComboBox ParityMenu;
        private System.Windows.Forms.ComboBox StopBitsMenu;
        private System.Windows.Forms.Label StatusLabel;
    }
}

