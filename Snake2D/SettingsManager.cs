using System.Windows.Forms;

namespace Snake2D
{
    public static class SettingsManager
    {
        public static void Saver(int delay, int x, int y)
        {
            Properties.Settings.Default.GameDelay = delay;
            Properties.Settings.Default.sizeX = x;
            Properties.Settings.Default.sizeY = y;
            Properties.Settings.Default.Save();

            MessageBox.Show("Изменения вступят в силу при следующем запуске");
        }
    }
}
