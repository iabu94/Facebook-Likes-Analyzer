namespace FBLikesAnalyzer
{
    partial class AnalyzeForm
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelCountLikes = new System.Windows.Forms.Label();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.textBoxFriends = new System.Windows.Forms.TextBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelCountFriends = new System.Windows.Forms.Label();
            this.labelFriendCount = new System.Windows.Forms.Label();
            this.labelToRemoveCount = new System.Windows.Forms.Label();
            this.labelToRemove = new System.Windows.Forms.Label();
            this.richTextBoxAnalyze = new System.Windows.Forms.RichTextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(56, 113);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(163, 23);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status Likes File :";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(264, 109);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(864, 27);
            this.textBoxStatus.TabIndex = 6;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatus.Location = new System.Drawing.Point(1192, 106);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(118, 32);
            this.buttonStatus.TabIndex = 9;
            this.buttonStatus.Text = "Open File";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.Location = new System.Drawing.Point(56, 659);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(163, 23);
            this.labelLikes.TabIndex = 10;
            this.labelLikes.Text = "Number of Likes :";
            // 
            // labelCountLikes
            // 
            this.labelCountLikes.AutoSize = true;
            this.labelCountLikes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountLikes.Location = new System.Drawing.Point(260, 659);
            this.labelCountLikes.Name = "labelCountLikes";
            this.labelCountLikes.Size = new System.Drawing.Size(40, 23);
            this.labelCountLikes.TabIndex = 11;
            this.labelCountLikes.Text = "......";
            // 
            // buttonFriends
            // 
            this.buttonFriends.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriends.Location = new System.Drawing.Point(1192, 41);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(118, 32);
            this.buttonFriends.TabIndex = 14;
            this.buttonFriends.Text = "Open File";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // textBoxFriends
            // 
            this.textBoxFriends.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFriends.Location = new System.Drawing.Point(264, 44);
            this.textBoxFriends.Name = "textBoxFriends";
            this.textBoxFriends.ReadOnly = true;
            this.textBoxFriends.Size = new System.Drawing.Size(864, 27);
            this.textBoxFriends.TabIndex = 13;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(56, 48);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(159, 23);
            this.labelFriends.TabIndex = 12;
            this.labelFriends.Text = "Friend List          :";
            // 
            // labelCountFriends
            // 
            this.labelCountFriends.AutoSize = true;
            this.labelCountFriends.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountFriends.Location = new System.Drawing.Point(790, 659);
            this.labelCountFriends.Name = "labelCountFriends";
            this.labelCountFriends.Size = new System.Drawing.Size(40, 23);
            this.labelCountFriends.TabIndex = 15;
            this.labelCountFriends.Text = "......";
            // 
            // labelFriendCount
            // 
            this.labelFriendCount.AutoSize = true;
            this.labelFriendCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendCount.Location = new System.Drawing.Point(553, 659);
            this.labelFriendCount.Name = "labelFriendCount";
            this.labelFriendCount.Size = new System.Drawing.Size(178, 23);
            this.labelFriendCount.TabIndex = 16;
            this.labelFriendCount.Text = "Number of Friends :";
            // 
            // labelToRemoveCount
            // 
            this.labelToRemoveCount.AutoSize = true;
            this.labelToRemoveCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToRemoveCount.Location = new System.Drawing.Point(1238, 659);
            this.labelToRemoveCount.Name = "labelToRemoveCount";
            this.labelToRemoveCount.Size = new System.Drawing.Size(40, 23);
            this.labelToRemoveCount.TabIndex = 18;
            this.labelToRemoveCount.Text = "......";
            // 
            // labelToRemove
            // 
            this.labelToRemove.AutoSize = true;
            this.labelToRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToRemove.Location = new System.Drawing.Point(1034, 659);
            this.labelToRemove.Name = "labelToRemove";
            this.labelToRemove.Size = new System.Drawing.Size(155, 23);
            this.labelToRemove.TabIndex = 17;
            this.labelToRemove.Text = "To Be Removed :";
            // 
            // richTextBoxAnalyze
            // 
            this.richTextBoxAnalyze.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnalyze.Location = new System.Drawing.Point(264, 169);
            this.richTextBoxAnalyze.Name = "richTextBoxAnalyze";
            this.richTextBoxAnalyze.Size = new System.Drawing.Size(864, 450);
            this.richTextBoxAnalyze.TabIndex = 19;
            this.richTextBoxAnalyze.Text = "";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(1192, 169);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(118, 32);
            this.buttonGenerate.TabIndex = 20;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 732);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.richTextBoxAnalyze);
            this.Controls.Add(this.labelToRemoveCount);
            this.Controls.Add(this.labelToRemove);
            this.Controls.Add(this.labelFriendCount);
            this.Controls.Add(this.labelCountFriends);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.textBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelCountLikes);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Name = "Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelCountLikes;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.TextBox textBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelCountFriends;
        private System.Windows.Forms.Label labelFriendCount;
        private System.Windows.Forms.Label labelToRemoveCount;
        private System.Windows.Forms.Label labelToRemove;
        private System.Windows.Forms.RichTextBox richTextBoxAnalyze;
        private System.Windows.Forms.Button buttonGenerate;
    }
}