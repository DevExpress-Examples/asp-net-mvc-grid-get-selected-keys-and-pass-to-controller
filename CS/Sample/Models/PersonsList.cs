using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models {
    public class PersonsList {
        public List<Person> GetPersons() {
            if(HttpContext.Current.Session["Persons"] == null) {
                List<Person> list = new List<Person>();

                list.Add(new Person(1, "David", "Jordan", "Adler"));
                list.Add(new Person(2, "Michael", "Christopher", "Alcamo"));
                list.Add(new Person(3, "Amy", "Gabrielle", "Altmann"));
                list.Add(new Person(4, "Meredith", "", "Berman"));
                list.Add(new Person(5, "Margot", "Sydney", "Atlas"));
                list.Add(new Person(6, "Eric", "Zachary", "Berkowitz"));
                list.Add(new Person(7, "Kyle", "", "Bernardo"));
                list.Add(new Person(8, "Liz", "", "Bice"));

                HttpContext.Current.Session["Persons"] = list;
            }
            return (List<Person>)HttpContext.Current.Session["Persons"];
        }

    }
}