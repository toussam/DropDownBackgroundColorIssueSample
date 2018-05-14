using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropDownBackgroundColorIssueSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AutoComplete.DataSource = new List<string>
            {
                "test1 ",
                "test2 ",
                "test3 ",
                "test4 ",
                "test5 ",
            };
        }
    }
}