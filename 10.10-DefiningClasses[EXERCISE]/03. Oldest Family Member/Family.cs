using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }
        public void AddMember(Person familyMember)
        {
            this.familyMembers.Add(familyMember);
        }

        public Person GetOldestMember()
        {
            var person = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }
    }
}
