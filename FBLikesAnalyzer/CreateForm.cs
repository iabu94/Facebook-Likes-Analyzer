using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLikesAnalyzer
{
    public partial class CreateForm : Form
    {
        private string fileName = "";
        private int fileNameNumber = 1;

        public CreateForm()
        {
            InitializeComponent();
        }
        
        private void CreateForm_Shown(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to create a FriendList ?", "Select Type", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                radioButtonFriends.Checked = true;
            }
            else
            {
                radioButtonLikes.Checked = true;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (richTextBoxInput.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Some Text to Create the File", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!(radioButtonFriends.Checked || radioButtonLikes.Checked))
            {
                MessageBox.Show("Please Check an Option ( Friends / Likes )", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBoxSaveAs.Text == string.Empty)
            {
                MessageBox.Show("Please fill the Save As field", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files\\" + textBoxSaveAs.Text;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string contentText = richTextBoxInput.Text;
                sw.WriteLineAsync(contentText);
            }

            if (MessageBox.Show("Saved File Successfully in the below Location :\n" + path, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                richTextBoxInput.Text = string.Empty;
                fileNameNumber++;
                fileName = "LikeList" + fileNameNumber.ToString() + ".txt";
                textBoxSaveAs.Text = fileName;
            }
        }

        private void radioButtonFriends_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFriends.Checked)
            {
                fileName = "AllFriendsList.txt";
                textBoxSaveAs.Text = fileName;
            }
            if (radioButtonLikes.Checked)
            {
                fileName = "LikeList" + fileNameNumber.ToString() + ".txt";
                textBoxSaveAs.Text = fileName;
            }
        }

        private void radioButtonLikes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFriends.Checked)
            {
                fileName = "AllFriendsList.txt";
                textBoxSaveAs.Text = fileName;
            }
            if (radioButtonLikes.Checked)
            {
                fileName = "LikeList" + fileNameNumber.ToString() + ".txt";
                textBoxSaveAs.Text = fileName;
            }
        }

    }
}
