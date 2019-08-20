using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace Airport.Module.BusinessObjects.Structure
{
    [NavigationItem("Structure"), DefaultClassOptions]
    public class Aircraft: BaseObject
    {
        public Aircraft(Session session)
            : base(session)
        { }

        [Size(200), RuleRequiredField]
        public string Name { get; set; }

        [RuleRequiredField]
        public string Code { get; set; }

        private Airport _airport;

        [Association("Airport-Aircrafts")]
        public Airport Airport
        {
            get { return _airport; }
            set { SetPropertyValue("Airport", ref _airport, value); }
        }

        [Association("Aircraft-Pilot")]
        public XPCollection<Pilot> Pilots => GetCollection<Pilot>("Pilots");
    }
}
