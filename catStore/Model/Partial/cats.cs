using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//имя пронстранства имен проверяем
namespace catStore.Model
{
    //класс должен быть partial
    public partial class cats
    {
        public string Title
        {
            get
            {
                return title;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
        }
        public string OldPrice
        {
            get
            {
                return Convert.ToString(price) + "р.";
            }
        }
        public string NewPrice
        {
            get
            {
                return Convert.ToString(price - price * discount / 100) + "р.";
            }
        }
        public string Discount
        {
            get
            {
                return "Скидка " + Convert.ToString(discount) + "%";
            }
        }
        public string ImagePathValue
        {
            get
            {
                return "/Assets/img/catalog/" + Convert.ToString(nameImage) + ".jpeg";
            }
        }
    }
}
