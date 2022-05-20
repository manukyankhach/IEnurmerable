using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfIEnumerable
{
    public class Company : IEnumerable
    {
        public string _name { get; set; }
        List<Person> people = new List<Person>();
        public Company(string name)
        {
            if (name == "MexFac")
            {
                _name = name;
                people.Add(new Person() { FirstName = "Khachatur", LastName = "Manukyan" });
                people.Add(new Person() { FirstName = "Suren", LastName = "Avdalyan" });
                people.Add(new Person() { FirstName = "Mher", LastName = "Paronyan" });
            }
            else
                _name = name;
        }
        public Company()
        {

        }

        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(people);
        }
    }

    public class PersonEnumerator : IEnumerator
    {
        private List<Person> _people;
        public int count;
        public PersonEnumerator(List<Person> people)
        {
            _people = people;
        }

        public object Current => _people[count++].FirstName;

        public bool MoveNext()
        {
            return count < _people.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
