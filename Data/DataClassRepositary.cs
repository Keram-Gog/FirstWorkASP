using System.Linq;

namespace Lab2.Data;

public class DataClassRepositary
{
    public List<DataClass> GetList()
    {
        lock (this)
        {
            var _data = System.IO.File.ReadAllLines("Data/data.txt").ToList();
            List<DataClass> lections = new List<DataClass>();
            foreach (var _Lection in _data)
            {
                if (_Lection != "  ")
                {
                    var date = _Lection.Split(new char[] { ' ' });
                    lections.Add(new DataClass
                    {
                        Id = Guid.NewGuid(),
                        Name = date[0],
                        type = date[1],
                        reiting = int.Parse(date[2])
                    });
                }
            }
            return lections.OrderBy(p => p.reiting).ToList<DataClass>();
        }
    }

        public void Add(string theme)
        {
            lock (this)
            {
                //data.Id = Guid.NewGuid();
                var lines = System.IO.File.ReadAllLines("Data/data.txt").ToList();
                lines.Add(theme);
                System.IO.File.WriteAllLines("Data/data.txt", lines.ToArray());
                // Deserialize data from file
                // Add new data
                // Save updated list to file
            }
        }

    public void Update(string theme12, string theme123)
    {
        lock (this)
        {
            if (!string.IsNullOrEmpty(theme12) && !string.IsNullOrEmpty(theme123))
            {
                var lines = System.IO.File.ReadAllLines("Data/data.txt").ToList();
                var firstWithLength3 = lines.IndexOf(theme12);
                lines.Remove(theme12);
                lines.Insert(firstWithLength3, theme123);
                System.IO.File.WriteAllLines("Data/data.txt", lines.ToArray());
            }
            // Deserialize data from file
            // Find data with same id
            // Update it's attributes
            // Save updated list to file
        }
    }

    public void Remove(string Lections)
    {
        lock (this)
        {
            var lines = System.IO.File.ReadAllLines("Data/data.txt").ToList();
            lines.Remove(Lections);
            System.IO.File.WriteAllLines("Data/data.txt", lines.ToArray());
            // Deserialize data from file
            // Find data with same id
            // Remove data row
            // Save updated list to file
        }
    }

}
