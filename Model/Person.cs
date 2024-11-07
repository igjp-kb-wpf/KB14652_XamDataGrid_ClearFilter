using KB14652_XamDataGrid_ClearFilter.Infrastructure;

namespace KB14652_XamDataGrid_ClearFilter.Model;
internal class Person : ObservableObject
{
    private int _id;
    public int ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }

    private string _name = string.Empty;
    public string Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(); }
    }

    private DateTime _hireDate;
    public DateTime HireDate
    {
        get { return _hireDate; }
        set { _hireDate = value; OnPropertyChanged(); }
    }

    private string _department = string.Empty;
    public string Department
    {
        get { return _department; }
        set { _department = value; OnPropertyChanged(); }
    }
    private string _location = string.Empty;
    public string Location
    {
        get { return _location; }
        set { _location = value; OnPropertyChanged(); }
    }

    public Person()
    {
    }
}
