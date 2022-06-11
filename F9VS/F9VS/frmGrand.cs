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

namespace F9VS
{
    public partial class frmGrand : Form
    {
        private readonly Color colorFileAdded = Color.Yellow;
        private readonly Color colorFileModified = Color.Green;
        private readonly Color colorFileRemoved = Color.Red;

        public class FileLog
        {
            
        }

        private List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();
        private DriveDetector detector = new DriveDetector();

        public frmGrand()
        {
            InitializeComponent();

            detector.Start();
            detector.DriveChanged += OnDriveChanged;
        }

        private void frmGrand_Load(object sender, EventArgs e)
        {
            // change content background color
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    MdiClient client = (MdiClient)ctl;
                    client.BackColor = Color.FromArgb(20, 20, 20);
                }
                catch (InvalidCastException ex)
                {
                    // do nothing
                }
            }
        }

        private void OnDriveChanged(object sender, DriveChangedEvents eType, DriveInfo drive)
        {      
            Invoke(new MethodInvoker(() =>
            {
                detector.Pause();
                if (eType.Equals(DriveChangedEvents.DriveAdded))
                {
                    conLoggerEvents.KeyValueSeparator = "";
                    conLoggerEvents.WriteKeyValue("Drive Added: ", drive.RootDirectory.Name +
                        (String.IsNullOrEmpty(drive.VolumeLabel) ? "" : (" [" + drive.VolumeLabel + "]")) +
                        " " + drive.DriveType.ToString(),
                        Color.Cyan, Color.Black, Color.White, Color.Black, false, false);
                    watchers.Add(createNewWatcher(drive.RootDirectory.Name)); 
                }
                else if (eType.Equals(DriveChangedEvents.DriveRemoved))
                {
                    conLoggerEvents.KeyValueSeparator = "";
                    conLoggerEvents.WriteKeyValue("Drive Removed: ", drive.RootDirectory.Name,
                        Color.Red, Color.Black, Color.White, Color.Black, false, false);
                    foreach (FileSystemWatcher watcher in watchers)
                    {
                        if (watcher.Path.Equals(drive.RootDirectory.Name))
                        {
                            watcher.Changed -= file_Changed;
                            watcher.Created -= file_Created;
                            watcher.Deleted -= file_Deleted;
                            watcher.Renamed -= file_Renamed;
                            watcher.Dispose();
                            watchers.Remove(watcher);
                            break;
                        }
                    }
                }
                detector.Resume();
            }));
        }

        private FileSystemWatcher createNewWatcher(string path)
        {
            //conLoggerEvents.WriteLogNormal("Initializing watcher at " + path + "...");
            FileSystemWatcher watcher = new FileSystemWatcher(path);
            watcher.Filter = "*.*";
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName |
                NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security |
                NotifyFilters.Size;
            watcher.Changed += file_Changed;
            watcher.Created += file_Created;
            watcher.Renamed += file_Renamed;
            watcher.Deleted += file_Deleted;
            //conLoggerEvents.WriteLogNormal("Watcher created");
            return watcher;
        }

        private void file_Changed(object sender, FileSystemEventArgs e)
        {
            //Invoke(new MethodInvoker(() =>
            //{
            //    conLoggerEvents.WriteLogNormal("File changed: " + e.FullPath);
            //}));       
        }

        private void file_Created(object sender, FileSystemEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {   
                conLoggerFileEvents.KeyValueSeparator = "";
                conLoggerFileEvents.WriteKeyValue("File created: ", e.FullPath, Color.Yellow, Color.Black);
            }));
        }

        private void file_Deleted(object sender, FileSystemEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                conLoggerFileEvents.WriteLogNormal("File deleted: " + e.FullPath);
            }));
        }

        private void file_Renamed(object sender, RenamedEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                conLoggerFileEvents.WriteLogNormal("File renamed: " + e.OldFullPath);
                conLoggerFileEvents.WriteLogNormal("New filename: " + e.FullPath);
            }));
        }
    }
}
