namespace CampusDeneme._02
{
    partial class Message
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtReciverID = new System.Windows.Forms.TextBox();
            this.txtMessageContent = new System.Windows.Forms.TextBox();
            this.btnLoadMessages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChatScreen = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Message";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 66);
            this.panel3.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(633, 397);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 15;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtReciverID
            // 
            this.txtReciverID.Location = new System.Drawing.Point(21, 90);
            this.txtReciverID.Name = "txtReciverID";
            this.txtReciverID.Size = new System.Drawing.Size(100, 20);
            this.txtReciverID.TabIndex = 16;
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.Location = new System.Drawing.Point(48, 359);
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.Size = new System.Drawing.Size(625, 20);
            this.txtMessageContent.TabIndex = 17;
            // 
            // btnLoadMessages
            // 
            this.btnLoadMessages.Location = new System.Drawing.Point(557, 105);
            this.btnLoadMessages.Name = "btnLoadMessages";
            this.btnLoadMessages.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMessages.TabIndex = 19;
            this.btnLoadMessages.Text = "Load";
            this.btnLoadMessages.UseVisualStyleBackColor = true;
            this.btnLoadMessages.Click += new System.EventHandler(this.btnLoadMessages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Restore the chat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Recivers Number:";
            // 
            // txtChatScreen
            // 
            this.txtChatScreen.Location = new System.Drawing.Point(21, 212);
            this.txtChatScreen.Name = "txtChatScreen";
            this.txtChatScreen.ReadOnly = true;
            this.txtChatScreen.Size = new System.Drawing.Size(767, 130);
            this.txtChatScreen.TabIndex = 24;
            this.txtChatScreen.Text = "";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChatScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadMessages);
            this.Controls.Add(this.txtMessageContent);
            this.Controls.Add(this.txtReciverID);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Name = "Message";
            this.Text = "Message";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtReciverID;
        private System.Windows.Forms.TextBox txtMessageContent;
        private System.Windows.Forms.Button btnLoadMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtChatScreen;
    }
}