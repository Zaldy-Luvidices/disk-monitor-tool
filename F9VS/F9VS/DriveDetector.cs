using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace F9VS
{
    public enum DriveChangedEvents
    {
        DriveAdded,
        DriveRemoved,
    }

    public delegate void DriveChangedEventHandler(object sender, DriveChangedEvents eventType, DriveInfo drive);

    public class DriveDetector
    {
        public event DriveChangedEventHandler DriveChanged;

        private bool mIsScanning = false;
        private bool mIsPaused = false;
        private Timer mTimer = null;
        private List<string> mDrives = new List<string>();

        public DriveDetector(double scanningInterval = 500.0, bool autoStart = false)
        {
            mTimer = new Timer();
            mTimer.Interval = scanningInterval;
            mTimer.Enabled = false;
            mTimer.Elapsed += OnTimedEvent;

            if (autoStart) Start();
        }

        public void Start()
        {
            mTimer.Enabled = true;
            mTimer.Start();
            mIsScanning = true;
        }

        public void Stop()
        {
            mTimer.Enabled = false;
            mTimer.Stop();
            mIsScanning = false;
        }

        public void Pause()
        {
            mIsPaused = true;
        }

        public void Resume()
        {
            mIsPaused = false;
        }

        private void OnTimedEvent(Object sender, System.Timers.ElapsedEventArgs e)
        {
            mTimer.Stop();
            checkAddedDrives();
            checkRemovedDrives();
            mTimer.Start();
        }

        private void checkAddedDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo newDrive in drives)
            {
                if (newDrive.DriveType.Equals(DriveType.Network)) continue;
                while (mIsPaused) ;
                if (!mIsScanning) return; 
                bool found = false;
                foreach(string existingDrive in mDrives)
                {
                    if (!mIsScanning) return;
                    if (existingDrive.ToLower().Equals(newDrive.RootDirectory.Name.ToLower()))
                    { // check if this drive is not yet in our list
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    mDrives.Add(newDrive.RootDirectory.Name);
                    if (DriveChanged != null) DriveChanged(this, DriveChangedEvents.DriveAdded, newDrive);
                }
            }
        }

        private void checkRemovedDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = (mDrives.Count - 1); i >= 0; --i)
            {
                if (!mIsScanning) return;
                bool found = false;
                foreach (DriveInfo drive in drives)
                {
                    if (drive.DriveType.Equals(DriveType.Network)) continue;
                    if (!mIsScanning) return;
                    if (drive.RootDirectory.Name.ToLower().Equals(mDrives[i].ToLower()))
                    { // check if this drive was still in our list
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    string drv = mDrives[i];
                    mDrives.RemoveAt(i);
                    if (DriveChanged != null)
                        DriveChanged(this, DriveChangedEvents.DriveRemoved, new DriveInfo(drv));
                }
            }
        }
    }
}
