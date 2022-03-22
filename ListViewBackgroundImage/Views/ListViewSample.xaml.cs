using Syncfusion.Maui.DataSource;

namespace ListViewBackgroundImage;

public partial class ListViewSample : ContentPage
{
    public ListViewSample()
    {
        InitializeComponent();
        listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
        {
            PropertyName = "ContactName",
            KeySelector = (object obj1) =>
            {
                var item = (obj1 as Contacts);
                return item.ContactName[0].ToString();
            }
        });
    }
}