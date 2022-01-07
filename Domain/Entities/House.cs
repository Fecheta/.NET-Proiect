using Domain.Common;
using System.Text;

namespace Domain.Entities
{
    public class House : BaseEntity
    {
        public string Bedrooms { get; set; }

        public string Bathrooms { get; set; }

        public string SquareFeet { get; set; }

        public string Floors { get; set; }

        public string ZipCode { get; set; }

        public string YearBuilt { get; set; }

        public string Price { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (System.Reflection.PropertyInfo property in this.GetType().GetProperties())
            {
                sb.Append(' ');
                if (property.GetIndexParameters().Length <= 0)
                {
                    sb.Append(property.GetValue(this, null));
                }
            }

            return sb.ToString();
        }
    }
}
