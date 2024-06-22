namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollDiceButton_Clicked(object sender, EventArgs e)
        {

            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);

            int drawnNumber = new Random().Next(1, selectedSides + 1);

            ResultLabel.Text = drawnNumber.ToString();
        }
    }

}
