using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace YamlFilesNamesListGenerator
{
    public static class Core
    {
        public static string CurrentFolderPath
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
        }

        public static string GetYAMLOutput(string sourcePath)
        {
            sourcePath = sourcePath.Trim();
            string output = "";
            if (!string.IsNullOrEmpty(sourcePath))
            {
                
                try
                {
                    //string[] paths = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                    string[] paths = Directory
                        .EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories)
                        .Select(path => path.Replace(sourcePath, "").Replace(@"\", @"/")
                        .Remove(0, 1))
                        .ToArray<string>();
                    output = "---" + Environment.NewLine;
                    foreach (var p in paths)
                    {
                        output += "- " + Path.ChangeExtension(p, null) + Environment.NewLine;
                    }
                }
                catch (Exception e)
                {
                    output = "# Error" + Environment.NewLine + "# " + e.Message;
                }
            }
            return output;
        }

        public static void SaveFile(string output, string targetPath, string filename)
        {
            targetPath = targetPath.Trim();
            filename =  filename.Trim();
            if (!string.IsNullOrEmpty(targetPath) && !string.IsNullOrEmpty(filename))
            {
                try
                {
                    string fullPath = Path.Combine(targetPath, filename);
                    bool save = true;
                    if (File.Exists(fullPath))
                    {
                        var alert = MessageBox.Show(
                            "Overwrite [" + filename + "] file ?",
                            "Alert",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (alert != DialogResult.Yes)
                        {
                            save = false;
                        }
                    }
                    if (save) {
                        File.WriteAllText(fullPath, output, System.Text.Encoding.UTF8);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
