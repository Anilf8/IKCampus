namespace CampusDeneme._02
{
    partial class PostShare
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
            this.txtPostText = new System.Windows.Forms.TextBox();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPostSelectPic = new System.Windows.Forms.Button();
            this.postAddPicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.postAddPicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPostText
            // 
            this.txtPostText.Location = new System.Drawing.Point(53, 263);
            this.txtPostText.Multiline = true;
            this.txtPostText.Name = "txtPostText";
            this.txtPostText.Size = new System.Drawing.Size(693, 117);
            this.txtPostText.TabIndex = 8;
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnShare.Location = new System.Drawing.Point(612, 386);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(123, 39);
            this.btnShare.TabIndex = 6;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(53, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPostSelectPic
            // 
            this.btnPostSelectPic.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPostSelectPic.Location = new System.Drawing.Point(337, 174);
            this.btnPostSelectPic.Name = "btnPostSelectPic";
            this.btnPostSelectPic.Size = new System.Drawing.Size(205, 60);
            this.btnPostSelectPic.TabIndex = 7;
            this.btnPostSelectPic.Text = "Select Picture";
            this.btnPostSelectPic.UseVisualStyleBackColor = true;
            this.btnPostSelectPic.Click += new System.EventHandler(this.btnPostSelectPic_Click);
            // 
            // postAddPicture
            // 
            this.postAddPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postAddPicture.Location = new System.Drawing.Point(73, 72);
            this.postAddPicture.Name = "postAddPicture";
            this.postAddPicture.Size = new System.Drawing.Size(181, 162);
            this.postAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postAddPicture.TabIndex = 9;
            this.postAddPicture.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Share a Post";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 66);
            this.panel3.TabIndex = 14;
            // 
            // PostShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.postAddPicture);
            this.Controls.Add(this.txtPostText);
            this.Controls.Add(this.btnPostSelectPic);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnBack);
            this.Name = "PostShare";
            this.Text = "PostShare";
            ((System.ComponentModel.ISupportInitialize)(this.postAddPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPostText;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPostSelectPic;
        private System.Windows.Forms.PictureBox postAddPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}