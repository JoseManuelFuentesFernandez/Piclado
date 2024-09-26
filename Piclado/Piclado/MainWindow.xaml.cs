using System.IO;
using System.Numerics;
using System.Windows;
using System.Windows.Input;
using WMPLib;

namespace Piclado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const String NOTES_PATH = @"res\piano-mp3\";
        public const int PLAYERS_COUNT = 20;
        public static List<String> notes = new List<String>();
        public static Int16 octaves = 0;
        public static List<WindowsMediaPlayer> wplayers = new List<WindowsMediaPlayer>();
        

        public MainWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
            InizializeNotes();
            InizializePlayers();

            this.PreviewKeyDown += new KeyEventHandler(Window_PreviewKeyDown);
            this.PreviewKeyUp += new KeyEventHandler(Window_PreviewKeyUp);

        }

        private void InizializeNotes()
        {
            string[] files = Directory.GetFiles(NOTES_PATH);

            foreach (string file in files)
            {
                notes.Add(Path.GetFileName(file));
            }
        }

        private void InizializePlayers()
        {
            wplayers.Clear();

            for (int i = 0; i < PLAYERS_COUNT; i++) 
            { 
                wplayers.Add(new WindowsMediaPlayer());
            }
        }

        

        private void playNote(int index)
        {
            if (index + octaves*36 >= notes.Count) return;

            WindowsMediaPlayer wplayer = GetFreePlayer();

            wplayer.URL = Path.Combine(NOTES_PATH, notes[index + octaves*36]);
            wplayer.controls.play();
        }

        private WindowsMediaPlayer GetFreePlayer()
        {
            foreach(WindowsMediaPlayer wplayer in wplayers)
            {
                if (wplayer.playState != WMPPlayState.wmppsPlaying) 
                {
                    return wplayer;
                }
            }

            return new WindowsMediaPlayer();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D1:
                    playNote(0);
                    break;
                case Key.D2:
                    playNote(1);
                    break;
                case Key.D3:
                    playNote(2);
                    break;
                case Key.D4:
                    playNote(3);
                    break;
                case Key.D5:
                    playNote(4);
                    break;
                case Key.D6:
                    playNote(5);
                    break;
                case Key.D7:
                    playNote(6);
                    break;
                case Key.D8:
                    playNote(7);
                    break;
                case Key.D9:
                    playNote(8);
                    break;
                case Key.D0:
                    playNote(9);
                    break;

                case Key.Q:
                    playNote(10);
                    break;
                case Key.W:
                    playNote(11);
                    break;
                case Key.E:
                    playNote(12);
                    break;
                case Key.R:
                    playNote(13);
                    break;
                case Key.T:
                    playNote(14);
                    break;
                case Key.Y:
                    playNote(15);
                    break;
                case Key.U:
                    playNote(16);
                    break;
                case Key.I:
                    playNote(17);
                    break;
                case Key.O:
                    playNote(18);
                    break;
                case Key.P:
                    playNote(19);
                    break;
                case Key.A:
                    playNote(20);
                    break;
                case Key.S:
                    playNote(21);
                    break;
                case Key.D:
                    playNote(22);
                    break;
                case Key.F:
                    playNote(23);
                    break;
                case Key.G:
                    playNote(24);
                    break;
                case Key.H:
                    playNote(25);
                    break;
                case Key.J:
                    playNote(26);
                    break;
                case Key.K:
                    playNote(27);
                    break;
                case Key.L:
                    playNote(28);
                    break;
                case Key.Z:
                    playNote(29);
                    break;
                case Key.X:
                    playNote(30);
                    break;
                case Key.C:
                    playNote(31);
                    break;
                case Key.V:
                    playNote(32);
                    break;
                case Key.B:
                    playNote(33);
                    break;
                case Key.N:
                    playNote(34);
                    break;
                case Key.M:
                    playNote(35);
                    break;
            }
        }


        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D1:
                    break;
                case Key.D2:
                    break;
                case Key.D3:
                    break;
                case Key.D4:
                    break;
                case Key.D5:
                    break;
                case Key.D6:
                    break;
                case Key.D7:
                    break;
                case Key.D8:
                    break;
                case Key.D9:
                    break;
                case Key.D0:
                    break;

                // Manejo de teclas de letras
                case Key.Q:
                    break;
                case Key.W:
                    break;
                case Key.E:
                    break;
                case Key.R:
                    break;
                case Key.T:
                    break;
                case Key.Y:
                    break;
                case Key.U:
                    break;
                case Key.I:
                    break;
                case Key.O:
                    break;
                case Key.P:
                    break;
                case Key.A:
                    break;
                case Key.S:
                    break;
                case Key.D:
                    break;
                case Key.F:
                    break;
                case Key.G:
                    break;
                case Key.H:
                    break;
                case Key.J:
                    break;
                case Key.K:
                    break;
                case Key.L:
                    break;
                case Key.Z:
                    break;
                case Key.X:
                    break;
                case Key.C:
                    break;
                case Key.V:
                    break;
                case Key.B:
                    break;
                case Key.N:
                    break;
                case Key.M:
                    break;

                case Key.LeftShift:
                    if (octaves < 2) octaves++;
                    break;
                case Key.LeftCtrl:
                    if(octaves > 0) octaves--;
                    break;
            }
        }
    }
}