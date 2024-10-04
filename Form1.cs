using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace rilo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadJSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Select a JSON file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonContent = File.ReadAllText(openFileDialog.FileName);
                    JObject jsonObject = JObject.Parse(jsonContent);
                    string name = jsonObject["manifest"]["name"].ToString();
                    string desc = jsonObject["manifest"]["desc"].ToString();
                    string author = jsonObject["manifest"]["author"].ToString();

                    manifest_window manifestWindow = new manifest_window();
                    manifestWindow.title.Text = name;
                    manifestWindow.author.Text = $"By {author}";
                    manifestWindow.description.Text = desc;

                    manifestWindow.InstallClicked += () => InstallIcons(jsonObject, manifestWindow.open.Checked, jsonObject["manifest"]["name"].ToString());

                    manifestWindow.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void InstallIcons(JObject jsonObject, bool shallOpenStudio, string themename)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Roblox Studio Beta (RobloxStudioBeta.exe)|RobloxStudioBeta.exe";
            openFileDialog.Title = "Select Roblox Studio Executable";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string robloxStudioPath = openFileDialog.FileName;
                string robloxDirectory = Path.GetDirectoryName(robloxStudioPath);
                if (string.IsNullOrEmpty(robloxDirectory))
                {
                    MessageBox.Show("Invalid Roblox Studio path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loading loadingForm = new loading();
                loadingForm.Show();
                loadingForm.UpdateLoader("Processing JSON keys...");

                foreach (var key in jsonObject["keys"])
                {
                    // fix up the json path to a legit path
                    string imageKey = key.Path.ToString().Replace("keys[", "").Replace("]", "").Replace("\\\\", "\\").Replace("'", "");
                    // construct paths
                    string imagePath = Path.Combine(robloxDirectory, "content", imageKey);
                    string backupPath = Path.ChangeExtension(imagePath, "_backup" + Path.GetExtension(imagePath));

                    // check if the original paths to the keys exist
                    if (File.Exists(imagePath))
                    {
                        loadingForm.UpdateLoader("Renaming original image to backup...");
                        File.Move(imagePath, backupPath);
                    }

                    // download keys
                    loadingForm.UpdateLoader("Downloading new image...");
                    string url = key.First.ToString();
                    using (var webClient = new WebClient())
                    {
                        await webClient.DownloadFileTaskAsync(new Uri(url), imagePath);
                    }
                }

                loadingForm.UpdateLoader("Finalizing...");
                await Task.Delay(1000);

                if (shallOpenStudio)
                {
                    loadingForm.UpdateLoader("Launching Roblox Studio...");
                    System.Diagnostics.Process.Start(robloxStudioPath);

                    while (!System.Diagnostics.Process.GetProcessesByName("RobloxStudioBeta").Any())
                    {
                        await Task.Delay(1000);
                    }
                }
                loadingForm.Close();
                MessageBox.Show($"Installation of {themename} completed successfully!", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unloadJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Select a JSON file for Uninstallation";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                JObject jsonObject;
                try
                {
                    string jsonContent = File.ReadAllText(openFileDialog.FileName);
                    jsonObject = JObject.Parse(jsonContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string themeName = jsonObject["manifest"]["name"].ToString();
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to uninstall {themeName}?", "Confirm Uninstallation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenFileDialog robloxFileDialog = new OpenFileDialog();
                    robloxFileDialog.Filter = "Roblox Studio Beta (RobloxStudioBeta.exe)|RobloxStudioBeta.exe";
                    robloxFileDialog.Title = "Select Roblox Studio Executable";

                    if (robloxFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string robloxStudioPath = robloxFileDialog.FileName;
                        string robloxDirectory = Path.GetDirectoryName(robloxStudioPath);
                        if (string.IsNullOrEmpty(robloxDirectory))
                        {
                            MessageBox.Show("Invalid Roblox Studio path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        loading loadingForm = new loading();
                        loadingForm.Show();
                        loadingForm.UpdateLoader("Processing JSON keys...");

                        foreach (var key in jsonObject["keys"])
                        {
                            string imageKey = key.Path.ToString().Replace("keys[", "").Replace("]", "").Replace("\\\\", "\\").Replace("'", "");
                            string imagePath = Path.Combine(robloxDirectory, "content", imageKey);
                            string backupPath = Path.ChangeExtension(imagePath, "_backup" + Path.GetExtension(imagePath));

                            if (File.Exists(imagePath))
                            {
                                loadingForm.UpdateLoader($"Deleting original image: {Path.GetFileName(imagePath)}...");
                                File.Delete(imagePath);
                            }

                            if (File.Exists(backupPath))
                            {
                                loadingForm.UpdateLoader($"Restoring backup image: {Path.GetFileName(backupPath)}...");
                                File.Move(backupPath, imagePath);
                            }
                        }

                        loadingForm.Close();
                        MessageBox.Show($"Uninstallation of {themeName} completed successfully!", "Uninstallation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
