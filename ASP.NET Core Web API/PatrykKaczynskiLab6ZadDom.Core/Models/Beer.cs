using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Core.Models
{
    public class Beer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public string Style { get; set; }
        public float ExtractContent { get; set; }
        public float AlcoholContent { get; set; }
        public int BitternessContent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public Beer()
        {

        }

        public Beer (Guid id, string name, string producerName, string style, float extractContent, float alcoholContent, int bitternessContent)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetProducerName(producerName);
            SetStyle(style);
            SetExtractContent(extractContent);
            SetAlcoholContent(alcoholContent);
            SetBitternessContent(bitternessContent);
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Pole nie może być puste dla piwa z id: '{Id}'");
            }
            Name = name;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetProducerName(string producerName)
        {
            if (string.IsNullOrWhiteSpace(producerName))
            {
                throw new Exception($"Pole nie może być puste dla piwa z id: '{Id}'");
            }
            ProducerName = producerName;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetStyle(string style)
        {
            if (string.IsNullOrWhiteSpace(style))
            {
                throw new Exception($"Pole nie może być puste dla piwa z id: '{Id}'");
            }
            Style = style;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetExtractContent(float extractContent)
        {
            if (extractContent < 0)
            {
                throw new Exception($"Wartość nie może być mniejsza niż 0 dla piwa z id: '{Id}'");
            }
            ExtractContent = extractContent;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetAlcoholContent(float alcoholContent)
        {
            if (alcoholContent < 0)
            {
                throw new Exception($"Wartość nie może być mniejsza niż 0 dla piwa z id: '{Id}'");
            }
            AlcoholContent = alcoholContent;
            UpdateTime = DateTime.UtcNow;
        }

        public void SetBitternessContent(int bitternessContent)
        {
            if (bitternessContent < 0)
            {
                throw new Exception($"Wartość nie może być mniejsza niż 0 dla piwa z id: '{Id}'");
            }
            BitternessContent = bitternessContent;
            UpdateTime = DateTime.UtcNow;
        }
    }
}
