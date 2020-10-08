using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private HashSet<Person> members { get; set; }
        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public HashSet<Person> GetOldestMember()
        {
            return members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToHashSet();
        }
        
    }
}
