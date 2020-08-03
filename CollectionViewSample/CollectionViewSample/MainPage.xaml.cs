using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CollectionViewSample
{
    public class ViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LabelTemplate { get; set; }
        public DataTemplate EntryTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((CollectionData)item).Type == 1 ? LabelTemplate : EntryTemplate;
        }
    }

    public class CollectionData
    {
        public string Name { get; set; }
        public int Type { get; set; }
    }

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
                ControlList.Add(new CollectionData {Name = $"Added at {ControlList.Count}", Type = 1});
            }
        }

        public ObservableCollection<CollectionData> ControlList { get; set; } = new ObservableCollection<CollectionData>();

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            ControlList.Add(new CollectionData {Name = $"Added at {ControlList.Count}", Type = 1});
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            ControlList.Add(new CollectionData {Name = $"Added at {ControlList.Count}", Type = 2});
        }
    }
}
