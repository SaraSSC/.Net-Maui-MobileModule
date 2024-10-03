namespace MAUIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Var referencing the MainhaPagina page
            //Navigation pile
            var navPage = new NavigationPage(new MinhaPagina());

            //Setting the stylezation of the navigation bar
            navPage.BarBackground = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            
            //First page to be displayed
            MainPage = new NavigationPage( new AbsoluteLayoutDemo());
           
           
        }
    }
}
