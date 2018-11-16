using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FBLikesAnalyzer
{
    public partial class FormFBLikes : Form
    {
        public FormFBLikes()
        {
            InitializeComponent();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var source = textBoxInput.Text;
                var regex = "";
                var target = textBoxOutput.Text;

                if (!File.Exists(source))
                {
                    MessageBox.Show("Input file not exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var text = File.ReadAllText(source);
                Regex regexExpression = null;
                MatchCollection matches = null;
                List<string> outputResult = new List<string>();

                if (comboBoxRegex.SelectedIndex == 0)
                {
                    regex = "aria-label=\"[a-z0-9A-Z\\s]{1,}\"";
                    regexExpression = new Regex(regex);
                    matches = regexExpression.Matches(text);

                    for (var i = 0; i < matches.Count; i++)
                    {
                        outputResult.Add(matches[i].Value.Remove(0, 11).Replace("\"", ""));
                    }
                }
                else if (comboBoxRegex.SelectedIndex == 1)
                {
                    regex = "_2lel\">[a-z0-9A-Z\\s]{1,}<";
                    regexExpression = new Regex(regex);
                    matches = regexExpression.Matches(text);

                    for (var i = 0; i < matches.Count; i++)
                    {
                        outputResult.Add(matches[i].Value.Remove(0, 7).Replace("<",""));
                    }
                }
                else
                {
                    MessageBox.Show("Please select a dropdown value to retrieve the results", "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (textBoxOutput.Text == string.Empty)
                {
                    MessageBox.Show("Specify a output file name tobe saved", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                outputResult.Sort();
                textBoxOutput.Text = outputResult.Count.ToString() + " people liked this post";
                
                File.WriteAllText(target, string.Join("\n", outputResult.ToArray()));

                using (StreamReader reader = new StreamReader(target))
                {
                    richTextBoxOutput.Text = await reader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private async void buttonInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString()+"/Files"))
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
                    textBoxInput.Text = ofd.FileName;

                    using (StreamReader reader = new StreamReader(ofd.FileName))
                    {
                        richTextBoxOutput.Text = await reader.ReadToEndAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Files");
            }

            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = "text.txt",
                Filter = "Text files|*.txt",
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = saveFile.FileName;
            }
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzeForm formAnalyze = new AnalyzeForm();
            formAnalyze.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.Show();
        }
    }
}
