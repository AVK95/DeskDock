using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DeskDock_Form
{
    internal class MusicPlayer : DeskDock_Control
    {
        [DllImport("Winmm.dll", SetLastError = true)]
        static extern int mciSendString(string lpszCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnString, int cchReturn, IntPtr hwndCallback);

        private string _Name = "Music Player";
        private string _Description = "A simple music player that plays in the background";
        private Version _Version = new Version(0, 1);
        private Bitmap _Icon = new Bitmap(Properties.Resources.MusicPlayer);

        //Todo: add a way to remember last opened directory and default to there
        private string _DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        private string[]? _Playlist;
        private string _SavedPlaylist = string.Empty;
        
        public string Name => _Name;

        public string Description => _Description;

        public Version Version => _Version;

        public Bitmap Icon => _Icon;

        //Current implementation lets user select a single file to play. Later implementation will include multi select
        //and ability to select whole folder, maybe even a saved playlist in the future
        public void Clicked()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = _DefaultDirectory;
                ofd.Filter = "Music Files (*.mp3)|*.mp3";
                    /*"Music Files (*.mp3;*.mp4;*.m4a;*.wav;*.wma;*.aac;*.flac)|*.MP3;*.MP4;*.M4A;*.WAV;*.WMA;*.AAC;*.FLAC;|" +
                    "Playlist (*.m3u)|*.M3U|";*/
                ofd.Multiselect = true;
                ofd.RestoreDirectory = true;
                ofd.Title = "Select music files to add to current playlist";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FilterIndex == 1)
                        _Playlist = ofd.FileNames;
                    else
                    {
                        //If a playlist is selected, user must have only selected a single file
                        if (ofd.FileNames.Length > 1)
                            throw new InvalidSelectionException("While selecting a playlist please select only a single file");
                        else
                        {
                            _SavedPlaylist = ofd.FileName;
                            ExtractFilesFromPlaylist();
                        }
                    }

                    //At this point the Playlist array must be filled with audio files to be played
                    PlayFilesInSequence();
                }
            }
        }

        private void ExtractFilesFromPlaylist()
        {
            //Todo: Implement a method to extract files from the m3u playlist
        }

        private void PlayFilesInSequence()
        {
            PlayMusic(_Playlist.FirstOrDefault());
        }

        private void PlayMusic(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            //Todo: Add support for all extensions later
            string fileAlias = "MP3";
            MessageBox.Show(filePath);

            mciSendString(@"close MP3", null, 0, IntPtr.Zero);
            mciSendString("open \"" + filePath + "\" alias " + fileAlias, sb, 0, IntPtr.Zero);
            mciSendString("play MP3 repeat", null, 0, IntPtr.Zero);

            //int nRet = mciSendString("open \"" + filePath + "\" alias " + fileAlias, sb, 0, IntPtr.Zero);
            //nRet = mciSendString("play " + fileAlias, sb, 0, IntPtr.Zero);
        }
    }
}
