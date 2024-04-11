namespace ProvaPAM
{
    public partial class MainPage : ContentPage
    {
        int ladosDado = 6;

        public MainPage()
        {
            InitializeComponent();
        }

        private void dadoButton_OnClicked(object sender, EventArgs e)
        {
            Random rnd = new();

            int resultDado = rnd.Next(1, ladosDado + 1);
            dadoOut.Text = resultDado.ToString();
        }

        private void dadoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ladosDado = (Int32)dadoSelect.SelectedItem;

        }
    }

}
