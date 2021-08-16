using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Core.Models
{
    public class Wine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public int ProductionYear { get; set; }
        public string CountryName { get; set; }
        public string Color { get; set; }
        public string Taste { get; set; }
        public float AlcoholContent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public Wine()
        {

        }
        public Wine(Guid id, string name, string producerName, int productionYear, string countryName, string color, string taste, float alcoholContent)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetProducerName(producerName);
            SetProductionYear(productionYear);
            SetCountryName(countryName);
            SetColor(color);
            SetTaste(taste);
            SetAlcoholContent(alcoholContent);
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Pole nie może być puste dla wina z id: '{Id}'");
            }
            Name = name;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetProducerName(string producerName)
        {
            if (string.IsNullOrWhiteSpace(producerName))
            {
                throw new Exception($"Pole nie może być puste dla wina z id: '{Id}'");
            }
            ProducerName = producerName;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetProductionYear(int productionYear)
        {
            if (productionYear < 0)
            {
                throw new Exception($"Wartość nie może być mniejsza niż 0 dla wina z id: '{Id}'");
            }
            ProductionYear = productionYear;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetCountryName(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
            {
                throw new Exception($"Pole nie może być puste dla wina z id: '{Id}'");
            }
            CountryName = countryName;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                throw new Exception($"Pole nie może być puste dla wina z id: '{Id}'");
            }
            Color = color;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetTaste(string taste)
        {
            if (string.IsNullOrWhiteSpace(taste))
            {
                throw new Exception($"Pole nie może być puste dla wina z id: '{Id}'");
            }
            Taste = taste;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetAlcoholContent(float alcoholContent)
        {
            if (alcoholContent < 0)
            {
                throw new Exception($"Wartość nie może być mniejsza niż 0 dla wina z id: '{Id}'");
            }
            AlcoholContent = alcoholContent;
            UpdateTime = DateTime.UtcNow;
        }

    }
}
