using MetroFramework;
using MetroFramework.Forms;

namespace STLx
{
    public partial class MainMenuForm : MetroForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            metroTileAuto.TileTextFontSize = MetroTileTextSize.Tall;
        }

        private void metroTileWith_Click(object sender, System.EventArgs e)
        {
            var withbank = new WBank();
            withbank.Show();
            //FormProvider.MainMenu.Hide();
        }

        private void metroTileWithout_Click(object sender, System.EventArgs e)
        {
            var wobank = new WithoutBank();
            wobank.Show();
            //FormProvider.MainMenu.Hide();
        }

        private void metroTileAuto_Click(object sender, System.EventArgs e)
        {
            var fAuto = new FormAuto();
            fAuto.Show();
            //FormProvider.MainMenu.Hide();
        }
    }
}
