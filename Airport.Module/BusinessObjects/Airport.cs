using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace Airport.Module.BusinessObjects.Structure
{
    [DefaultClassOptions, NavigationItem("Structure")]
    public class Airport : BaseObject
    {
        public Airport(Session session)
            : base(session)
        { }

        [RuleRequiredField]
        public string Name { get; set; }

        [Association("Airport-Pilots")]
        public XPCollection<Pilot> Pilots => GetCollection<Pilot>("Pilots");

        [Association("Airport-Aircrafts")]
        public XPCollection<Aircraft> Aircrafts => GetCollection<Aircraft>("Aircrafts");
    }
}
