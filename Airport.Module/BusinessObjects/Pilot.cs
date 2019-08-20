using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace Airport.Module.BusinessObjects.Structure
{
    [NavigationItem("Structure"), DefaultClassOptions]
    public class Pilot: BaseObject
    {
        public Pilot(Session session)
            : base(session)
        { }

        [RuleRequiredField]
        public string FirstName { get; set; }

        [RuleRequiredField]
        public string LastName { get; set; }

        private Airport _airport;

        [Association("Airport-Pilots")]
        public Airport Airport
        {
            get => _airport; 
            set => SetPropertyValue("Airport", ref _airport, value);
        }

        [Association("Aircraft-Pilot")]
        public XPCollection<Aircraft> Aircrafts => GetCollection<Aircraft>("Aircrafts");

        [NonPersistent]
        public int CountAircraft => Aircrafts.Count;

        public override string ToString() => $"{LastName} {FirstName}";
    }
}
