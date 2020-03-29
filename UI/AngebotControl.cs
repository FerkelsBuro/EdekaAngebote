using System.Windows.Forms;
using UI.ViewModels;

namespace UI
{
    public partial class AngebotControl : UserControl
    {
        private readonly AngebotControlViewModel _viewModel;

        public AngebotControl(AngebotControlViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            PictureBox.Load(viewModel.BildUrl);
            Box1.Text = viewModel.Titel;
            Box2.Text = viewModel.Preis.ToString();
        }
    }
}