using System;
using System.Collections.Generic;

namespace Models
{
    public class Event
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Address Address { get; set; }
        public Type Type { get; set; }
        public int Capacity { get; set; }
        public List<Apresentation> Apresentations { get; set; }
        public int Duration { get; set; }
        #endregion

        public override string ToString()
        {
            return "Id: " + this.Id +
                 "\nName: " + this.Name +
                 "\nTipo: " + this.Type;
        }
    }
}
