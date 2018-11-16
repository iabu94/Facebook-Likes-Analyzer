namespace FBLikesAnalyzer
{
    partial class CreateForm
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.radioButtonFriends = new System.Windows.Forms.RadioButton();
            this.radioButtonLikes = new System.Windows.Forms.RadioButton();
            this.textBoxSaveAs = new System.Windows.Forms.TextBox();
            this.labelSaveAs = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 44);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(891, 623);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(691, 680);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(212, 32);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // radioButtonFriends
            // 
            this.radioButtonFriends.AutoSize = true;
            this.radioButtonFriends.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFriends.Location = new System.Drawing.Point(13, 681);
            this.radioButtonFriends.Name = "radioButtonFriends";
            this.radioButtonFriends.Size = new System.Drawing.Size(123, 27);
            this.radioButtonFriends.TabIndex = 15;
            this.radioButtonFriends.TabStop = true;
            this.radioButtonFriends.Text = "Friend List";
            this.radioButtonFriends.UseVisualStyleBackColor = true;
            this.radioButtonFriends.CheckedChanged += new System.EventHandler(this.radioButtonFriends_CheckedChanged);
            // 
            // radioButtonLikes
            // 
            this.radioButtonLikes.AutoSize = true;
            this.radioButtonLikes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLikes.Location = new System.Drawing.Point(155, 681);
            this.radioButtonLikes.Name = "radioButtonLikes";
            this.radioButtonLikes.Size = new System.Drawing.Size(108, 27);
            this.radioButtonLikes.TabIndex = 16;
            this.radioButtonLikes.TabStop = true;
            this.radioButtonLikes.Text = "Like List";
            this.radioButtonLikes.UseVisualStyleBackColor = true;
            this.radioButtonLikes.CheckedChanged += new System.EventHandler(this.radioButtonLikes_CheckedChanged);
            // 
            // textBoxSaveAs
            // 
            this.textBoxSaveAs.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaveAs.Location = new System.Drawing.Point(427, 683);
            this.textBoxSaveAs.Name = "textBoxSaveAs";
            this.textBoxSaveAs.Size = new System.Drawing.Size(212, 27);
            this.textBoxSaveAs.TabIndex = 17;
            // 
            // labelSaveAs
            // 
            this.labelSaveAs.AutoSize = true;
            this.labelSaveAs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveAs.Location = new System.Drawing.Point(319, 685);
            this.labelSaveAs.Name = "labelSaveAs";
            this.labelSaveAs.Size = new System.Drawing.Size(89, 23);
            this.labelSaveAs.TabIndex = 18;
            this.labelSaveAs.Text = "Save As :";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(260, 23);
            this.labelInfo.TabIndex = 19;
            this.labelInfo.Text = "Paste Your Copied Text Here ";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 724);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelSaveAs);
            this.Controls.Add(this.textBoxSaveAs);
            this.Controls.Add(this.radioButtonLikes);
            this.Controls.Add(this.radioButtonFriends);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Form";
            this.Shown += new System.EventHandler(this.CreateForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.RadioButton radioButtonFriends;
        private System.Windows.Forms.RadioButton radioButtonLikes;
        private System.Windows.Forms.TextBox textBoxSaveAs;
        private System.Windows.Forms.Label labelSaveAs;
        private System.Windows.Forms.Label labelInfo;
    }
}