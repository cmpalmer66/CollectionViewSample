using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CollectionViewSample
{
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
                ControlList.Add(new Label {Text = $"Added at {ControlList.Count}"});
            }
        }

        public ObservableCollection<View> ControlList { get; set; } = new ObservableCollection<View>();

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            ControlList.Add(new Label {Text = $"Added at {ControlList.Count}"});
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            ControlList.Add(new Entry {Text = $"Added at {ControlList.Count}"});
        }
    }
}
