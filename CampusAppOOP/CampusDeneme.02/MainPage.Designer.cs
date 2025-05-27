namespace CampusDeneme._02
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.oKULDBDataSet = new CampusDeneme._02.OKULDBDataSet();
            this.iKCUCAMPUSappBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iKCUCAMPUSappTableAdapter = new CampusDeneme._02.OKULDBDataSetTableAdapters.IKCUCAMPUSappTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPagePostPicture = new System.Windows.Forms.PictureBox();
            this.txtMainPostText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKCUCAMPUSappBindingSource)).BeginInit();
            this.flowLayoutFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPagePostPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMain.Location = new System.Drawing.Point(192, 90);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(88, 37);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "label1";
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(13, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 37);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 66);
            this.panel3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "IKCampus";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfile.Location = new System.Drawing.Point(0, 206);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(150, 47);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnMessage.Location = new System.Drawing.Point(0, 251);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(150, 47);
            this.btnMessage.TabIndex = 14;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnContact.Location = new System.Drawing.Point(0, 294);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(150, 47);
            this.btnContact.TabIndex = 15;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // oKULDBDataSet
            // 
            this.oKULDBDataSet.DataSetName = "OKULDBDataSet";
            this.oKULDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iKCUCAMPUSappBindingSource
            // 
            this.iKCUCAMPUSappBindingSource.DataMember = "IKCUCAMPUSapp";
            this.iKCUCAMPUSappBindingSource.DataSource = this.oKULDBDataSet;
            // 
            // iKCUCAMPUSappTableAdapter
            // 
            this.iKCUCAMPUSappTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(574, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 42);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowLayoutFeed
            // 
            this.flowLayoutFeed.Controls.Add(this.mainPagePostPicture);
            this.flowLayoutFeed.Controls.Add(this.txtMainPostText);
            this.flowLayoutFeed.Location = new System.Drawing.Point(175, 145);
            this.flowLayoutFeed.Name = "flowLayoutFeed";
            this.flowLayoutFeed.Size = new System.Drawing.Size(526, 171);
            this.flowLayoutFeed.TabIndex = 19;
            this.flowLayoutFeed.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutFeed_Paint);
            // 
            // mainPagePostPicture
            // 
            this.mainPagePostPicture.Location = new System.Drawing.Point(3, 3);
            this.mainPagePostPicture.Name = "mainPagePostPicture";
            this.mainPagePostPicture.Size = new System.Drawing.Size(91, 78);
            this.mainPagePostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPagePostPicture.TabIndex = 0;
            this.mainPagePostPicture.TabStop = false;
            // 
            // txtMainPostText
            // 
            this.txtMainPostText.Location = new System.Drawing.Point(100, 3);
            this.txtMainPostText.Name = "txtMainPostText";
            this.txtMainPostText.Size = new System.Drawing.Size(416, 78);
            this.txtMainPostText.TabIndex = 1;
            this.txtMainPostText.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CampusDeneme._02.Properties.Resources.Ekran_görüntüsü_2024_12_13_132142;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.flowLayoutFeed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblMain);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oKULDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKCUCAMPUSappBindingSource)).EndInit();
            this.flowLayoutFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPagePostPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OKULDBDataSet oKULDBDataSet;
        private System.Windows.Forms.BindingSource iKCUCAMPUSappBindingSource;
        private OKULDBDataSetTableAdapters.IKCUCAMPUSappTableAdapter iKCUCAMPUSappTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFeed;
        private System.Windows.Forms.PictureBox mainPagePostPicture;
        private System.Windows.Forms.RichTextBox txtMainPostText;
    }
}