using System;

namespace BlogOdevi.Models.Abstract
{
    public enum Status { Active = 1, Modified, Passive}
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate 
        { 
            get => _createdDate; 
            set => _createdDate = value; 
        }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        Status _status = Status.Active;
        public Status Status 
        {
            get => _status;
            set => _status=value;
        }

    }
}
