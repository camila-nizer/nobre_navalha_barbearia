using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Status
    {
        private Guid _userId;
        private bool _statusItem; 
        private DateTime _statusDate;

        public Guid UserId {
            get {return _userId;}
            set {_userId=value;}
        }
        public bool StatusItem {
            get {return _statusItem;}
            set {_statusItem = value;}
        }
        public DateTime StatusDate {
            get {return _statusDate;}
            set {_statusDate = value;}
        }

        public Status(Guid userId, bool status, DateTime statusDate)
        {
            this.UserId = userId;
            this.StatusItem = status;
            this.StatusDate = statusDate;
        }
    }
}