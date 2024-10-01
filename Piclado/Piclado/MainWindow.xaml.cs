using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
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
        public static Int16 octaves1 = 1;
        public static Int16 octaves2 = 2;
        public static List<WindowsMediaPlayer> wplayers = new List<WindowsMediaPlayer>(PLAYERS_COUNT);

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
            RefreshLabels();
        }

        

        private void InizializePlayers()
        {
            wplayers.Clear();

            for (int i = 0; i < PLAYERS_COUNT; i++) 
            { 
                wplayers.Add(new WindowsMediaPlayer());
            }
        }

        

        private void PlayNote(String note,Int16 row)
        {
            WindowsMediaPlayer wplayer = GetFreePlayer();

            int octave = octaves1;
            if(row == 1)
            {
                octave = octaves2;
            }

            wplayer.URL = Path.Combine(NOTES_PATH, note+(octave).ToString()+".mp3");
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

        private void RefreshLabels()
        {
            first_octave_label_1.Content = octaves1.ToString();
            first_octave_label_2.Content = octaves1.ToString();
            second_octave_label_1.Content = octaves2.ToString();
            second_octave_label_1.Content = octaves2.ToString();

            W_label.Content = "C" + octaves1.ToString();
            E_label.Content = "D" + octaves1.ToString();
            R_label.Content = "E" + octaves1.ToString();
            T_label.Content = "F" + octaves1.ToString();
            Y_label.Content = "G" + octaves1.ToString();
            U_label.Content = "A" + octaves1.ToString();
            I_label.Content = "B" + octaves1.ToString();

            THREE_label.Content = "Db" + octaves1.ToString();
            FOUR_label.Content = "Eb" + octaves1.ToString();
            SIX_label.Content = "Gb" + octaves1.ToString();
            SEVEN_label.Content = "Ab" + octaves1.ToString();
            EIGHT_label.Content = "Bb" + octaves1.ToString();

            Z_label.Content = "C" + octaves2.ToString();
            X_label.Content = "D" + octaves2.ToString();
            C_label.Content = "E" + octaves2.ToString();
            V_label.Content = "F" + octaves2.ToString();
            B_label.Content = "G" + octaves2.ToString();
            N_label.Content = "A" + octaves2.ToString();
            M_label.Content = "B" + octaves2.ToString();

            S_label.Content = "Db" + octaves2.ToString();
            D_label.Content = "Eb" + octaves2.ToString();
            G_label.Content = "Gb" + octaves2.ToString();
            H_label.Content = "Ab" + octaves2.ToString();
            J_label.Content = "Bb" + octaves2.ToString();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {

                case Key.D3:
                    THREE_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Db", 0);
                    break;

                case Key.D4:
                    FOUR_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Eb", 0);
                    break;

                case Key.D6:
                    SIX_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Gb", 0);
                    break;

                case Key.D7:
                    SEVEN_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Ab", 0);
                    break;

                case Key.D8:
                    EIGHT_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Bb", 0);
                    break;

                case Key.W:
                    W_key.Background = Brushes.CornflowerBlue;
                    PlayNote("C", 0);
                    break;

                case Key.E:
                    E_key.Background = Brushes.CornflowerBlue;
                    PlayNote("D", 0);
                    break;

                case Key.R:
                    R_key.Background = Brushes.CornflowerBlue;
                    PlayNote("E", 0);
                    break;

                case Key.T:
                    T_key.Background = Brushes.CornflowerBlue;
                    PlayNote("F", 0);
                    break;

                case Key.Y:
                    Y_key.Background = Brushes.CornflowerBlue;
                    PlayNote("G", 0);
                    break;

                case Key.U:
                    U_key.Background = Brushes.CornflowerBlue;
                    PlayNote("A", 0);
                    break;

                case Key.I:
                    I_key.Background = Brushes.CornflowerBlue;
                    PlayNote("B", 0);
                    break;

                case Key.S:
                    S_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Db", 1);
                    break;

                case Key.D:
                    D_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Eb", 1);
                    break;

                case Key.G:
                    G_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Gb", 1);
                    break;

                case Key.H:
                    H_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Ab", 1);
                    break;

                case Key.J:
                    J_key.Background = Brushes.CornflowerBlue;
                    PlayNote("Bb", 1);
                    break;

                case Key.Z:
                    Z_key.Background = Brushes.CornflowerBlue;
                    PlayNote("C", 1);
                    break;

                case Key.X:
                    X_key.Background = Brushes.CornflowerBlue;
                    PlayNote("D", 1);
                    break;

                case Key.C:
                    C_key.Background = Brushes.CornflowerBlue;
                    PlayNote("E", 1);
                    break;

                case Key.V:
                    V_key.Background = Brushes.CornflowerBlue;
                    PlayNote("F", 1);
                    break;

                case Key.B:
                    B_key.Background = Brushes.CornflowerBlue;
                    PlayNote("G", 1);
                    break;

                case Key.N:
                    N_key.Background = Brushes.CornflowerBlue;
                    PlayNote("A", 1);
                    break;

                case Key.M:
                    M_key.Background = Brushes.CornflowerBlue;
                    PlayNote("B", 1);
                    break;
            }
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D3:
                    THREE_key.Background = Brushes.Black;
                    break;
                case Key.D4:
                    FOUR_key.Background = Brushes.Black;
                    break;

                case Key.D6:
                    SIX_key.Background = Brushes.Black;
                    break;
                case Key.D7:
                    SEVEN_key.Background = Brushes.Black;
                    break;
                case Key.D8:
                    EIGHT_key.Background = Brushes.Black;
                    break;

                case Key.W:
                    W_key.Background = Brushes.White;
                    break;
                case Key.E:
                    E_key.Background = Brushes.White;
                    break;
                case Key.R:
                    R_key.Background = Brushes.White;
                    break;
                case Key.T:
                    T_key.Background = Brushes.White;
                    break;
                case Key.Y:
                    Y_key.Background = Brushes.White;
                    break;
                case Key.U:
                    U_key.Background = Brushes.White;
                    break;
                case Key.I:
                    I_key.Background = Brushes.White;
                    break;

                case Key.S:
                    S_key.Background = Brushes.Black;
                    break;
                case Key.D:
                    D_key.Background = Brushes.Black;
                    break;

                case Key.G:
                    G_key.Background = Brushes.Black;
                    break;
                case Key.H:
                    H_key.Background = Brushes.Black;
                    break;
                case Key.J:
                    J_key.Background = Brushes.Black;
                    break;

                case Key.Z:
                    Z_key.Background = Brushes.White;
                    break;
                case Key.X:
                    X_key.Background = Brushes.White;
                    break;
                case Key.C:
                    C_key.Background = Brushes.White;
                    break;
                case Key.V:
                    V_key.Background = Brushes.White;
                    break;
                case Key.B:
                    B_key.Background = Brushes.White;
                    break;
                case Key.N:
                    N_key.Background = Brushes.White;
                    break;
                case Key.M:
                    M_key.Background = Brushes.White;
                    break;

                case Key.Q:
                    if (octaves1 > 1)
                    {
                        octaves1--;
                    }
                    RefreshLabels();
                    break;
                case Key.P:
                    if (octaves1 < 7)
                    {
                        octaves1++;
                    }
                    RefreshLabels();
                    break;
                case Key.OemComma:
                    if (octaves2 > 1)
                    {
                        octaves2--;
                    }
                    RefreshLabels();
                    break;
                case Key.OemPeriod:
                    if (octaves2 < 7)
                    {
                        octaves2++;
                    }
                    RefreshLabels();
                    break;

                case Key.LeftShift:
                    if (octaves2 <= 6 && octaves1 <= 6)
                    {
                        octaves1++;
                        octaves2++;
                    }
                    RefreshLabels();
                    break;
                case Key.LeftCtrl:
                    if (octaves2 > 1 && octaves1 > 1)
                    {
                        octaves1--;
                        octaves2--;
                    }
                    RefreshLabels();
                    break;
            }
        }
    }
}