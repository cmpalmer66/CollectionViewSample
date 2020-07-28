using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyCollectionView.BindingContext = this;
            MyCollectionView.SetBinding(ItemsView.ItemsSourceProperty, nameof(ControlList));

            for (var x = 0; x < 20; x++)
            {
                // ControlList.Add(new Label {Text = $"Added at {ControlList.Count}"});
                MainSection.Add(new ViewCell {View = new Label {Text = $"Added at {MainSection.Count}"}});
            }
        }

        public ObservableCollection<View> ControlList { get; set; } = new ObservableCollection<View>();

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            // ControlList.Add(new Label {Text = $"Added at {ControlList.Count}"});

            MainSection.Add(new ViewCell {View = new Label {Text = $"Added at {MainSection.Count}"}});
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            // ControlList.Add(new Entry {Text = $"Added at {ControlList.Count}"});

            MainSection.Add(new ViewCell {View = new Entry {Text = $"Added at {MainSection.Count}"}});
        }
    }
}
