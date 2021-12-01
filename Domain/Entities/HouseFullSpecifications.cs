using System.Text;

namespace Domain.Entities
{
    public class HouseFullSpecifications
    {
        public string id { get; set; }
        public string date { get; set; }
        public string price { get; set; }
        public string bedrooms { get; set; }
        public string bathrooms { get; set; }
        public string sqft_living { get; set; }
        public string sqft_lot { get; set; }
        public string floors { get; set; }
        public string waterfront { get; set; }
        public string view { get; set; }
        public string condition { get; set; }
        public string grade { get; set; }
        public string sqft_above { get; set; }
        public string sqft_basement { get; set; }
        public string yr_built { get; set; }
        public string yr_renovated { get; set; }
        public string zipcode { get; set; }
        public string lat { get; set; }
        public string longt { get; set; }
        public string sqft_living15 { get; set; }
        public string sqft_lot15 { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (System.Reflection.PropertyInfo property in this.GetType().GetProperties())
            {
                //sb.Append(property.Name);
                sb.Append(" ");
                if (property.GetIndexParameters().Length > 0)
                {
                    sb.Append("Indexed Property cannot be used");
                }
                else
                {
                    sb.Append(property.GetValue(this, null));
                }

                //sb.Append(System.Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
