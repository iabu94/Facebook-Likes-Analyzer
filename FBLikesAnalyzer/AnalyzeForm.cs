using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FBLikesAnalyzer
{
    public partial class AnalyzeForm : Form
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private async void buttonStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files");
                }

                OpenFileDialog ofd = new OpenFileDialog
                {
                    Title = "Open the Input File",
                    Filter = "text files|*.txt",
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxStatus.Text = ofd.FileName;
                    StreamReader reader = new StreamReader(ofd.FileName);
                    labelCountLikes.Text = (reader.ReadToEnd().Count(x => x == '\n') + 1).ToString();
                }

                StreamReader rdr = new StreamReader(textBoxStatus.Text);
                richTextBoxAnalyze.Text = await rdr.ReadToEndAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private async void buttonFriends_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files");
                }

                OpenFileDialog ofd = new OpenFileDialog
                {
                    Title = "Open the Input File",
                    Filter = "text files|*.txt",
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxFriends.Text = ofd.FileName;
                    using (StreamReader reader = new StreamReader(ofd.FileName))
                    {
                        labelCountFriends.Text = (reader.ReadToEnd().Count(x => x == '\n') + 1).ToString();
                    }
                }
                
                using (StreamReader rdr = new StreamReader(textBoxFriends.Text))
                {
                    richTextBoxAnalyze.Text = await rdr.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private async void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files");
                }

                if (textBoxFriends.Text == string.Empty)
                {
                    MessageBox.Show("Open the friends file to retrieve", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxStatus.Text == string.Empty)
                {
                    MessageBox.Show("Open the likes file to retrieve", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<string> friendList = new List<string>();
                    List<string> likesList = new List<string>();
                    List<string> toRemoveList = new List<string>();

                    using (StreamReader friendsReader = new StreamReader(textBoxFriends.Text))
                    {
                        friendList = friendsReader.ReadToEnd().Split('\n').ToList();
                    }

                    using (StreamReader likesReader = new StreamReader(textBoxStatus.Text))
                    {
                        likesList = likesReader.ReadToEnd().Split('\n').ToList();
                    }

                    toRemoveList = friendList;

                    foreach (string item in likesList)
                    {
                        toRemoveList = generateRemoveList(item, toRemoveList);
                    }

                    toRemoveList.Sort();

                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files/ToBeRemovedList.txt"))
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files/ToBeRemovedList.txt");
                    }
                    
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory.ToString()+"Files/ToBeRemovedList.txt", string.Join("\n", toRemoveList.ToArray()));

                    using (StreamReader reader = new StreamReader(textBoxFriends.Text))
                    {
                        richTextBoxAnalyze.Text = await reader.ReadToEndAsync();
                        labelToRemoveCount.Text = toRemoveList.Count().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> generateRemoveList(string item, List<string> toRemoveList)
        {
            for (int i = 0; i < toRemoveList.Count; i++)
            {
                if (toRemoveList[i] == item)
                {
                    toRemoveList.Remove(toRemoveList[i]);
                    return toRemoveList;
                }
            }
            return toRemoveList;
        }
    }
}
