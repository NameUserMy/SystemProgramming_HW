using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace SystemProgramming_HW_7.SearchFileAndFolder.Control
{
    internal class SearchFileControl
    {

        private OpenFolderDialog _openFolder;
        private DirectoryInfo _directory;
        public void blah()
        {
            _openFolder = new OpenFolderDialog();
            _openFolder.ShowDialog();
            _directory = new DirectoryInfo(_openFolder.FolderName);
            var test= TestAsync(_directory.FullName);

        }
        public async Task TestAsync(string directory)
        {
            try
            {
                var directories = await Task.Run(() => Directory.GetDirectories(directory));
                foreach (var d in directories)
                {
                    await TestAsync(d);
                }

                var files = await Task.Run(() => Directory.GetFiles(directory, "*.package"));
                foreach (var f in files)
                {
                    MessageBox.Show(f);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            

           
            
                
        }
    }
}
