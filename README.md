# How to load background image in .NET MAUI ListView?
This example demonstrates how to load background image in .NET MAUI ListView.

**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13075/how-to-load-the-background-image-in-net-maui-listview-sflistview)**

## Sample

```xaml
<Grid>
    <Image Source="{Binding BackgroundImage}"
            Aspect="AspectFill" />
    <syncfusion:SfListView x:Name="listView"
                            SelectionMode="None"
                            Margin="5"
                            ItemSize="70"
                            ItemsSource="{Binding contactsinfo}">

        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</Grid>

ViewModel.cs:

public ObservableCollection<Contacts> contactsinfo { get; set; }
private ImageSource backgroundImage = ImageSource.FromResource("ListViewBackgroundImage.Resources.Images.bgimage.png");

public ImageSource BackgroundImage
{
    get
    {
        return backgroundImage;
    }
    set
    {
        backgroundImage = value;
        this.OnPropertyChanged("BackgroundImage");
    }
}

public ContactsViewModel()
{
    contactsinfo = new ObservableCollection<Contacts>();
    Random r = new Random();
    for (int i = 0; i < CustomerNames.Count(); i++)
    {
        var contact = new Contacts(CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
        
        contactsinfo.Add(contact);
    }
}
```
