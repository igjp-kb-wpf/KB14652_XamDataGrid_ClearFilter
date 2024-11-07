using KB14652_XamDataGrid_ClearFilter.Infrastructure;
using KB14652_XamDataGrid_ClearFilter.Model;
using System.Collections.ObjectModel;

namespace KB14652_XamDataGrid_ClearFilter;
internal class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<Person> People { get; set; }

    public MainWindowViewModel()
    {
        People = [];
        Random random = new();
        string[] departments = ["営業部", "開発部", "人事部", "総務部", "マーケティング部"];
        string[] locations = ["東京", "大阪", "名古屋", "福岡", "札幌"];

        for (int i = 1; i <= 100; i++)
        {
            Person person = new Person
            {
                ID = i,
                Name = $"名前{i}",
                HireDate = new DateTime(2020, random.Next(1, 13), random.Next(1, 29)),
                Department = departments[random.Next(departments.Length)],
                Location = locations[random.Next(locations.Length)]
            };
            People.Add(person);
        }
    }
}
