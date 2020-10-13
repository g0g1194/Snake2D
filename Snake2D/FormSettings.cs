using System.Windows.Forms;

namespace Snake2D
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            trackBarGameDelay.Value = Properties.Settings.Default.GameDelay;
            numericUpDownSizeX.Value = Properties.Settings.Default.sizeX;
            numericUpDownSizeY.Value = Properties.Settings.Default.sizeY;
        }

        private void buttonSaveSettings_Click(object sender, System.EventArgs e)
        {
            SettingsManager.Saver(trackBarGameDelay.Value, (int)numericUpDownSizeX.Value, (int)numericUpDownSizeY.Value);
        }

        private void buttonRemove_Click(object sender, System.EventArgs e)
        {
            SettingsManager.Saver(200, 16, 12);
        }
    }
}
