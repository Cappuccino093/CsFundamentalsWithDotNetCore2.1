using System.Xml.Serialization;

namespace CoreSchool.Models;

public enum SchoolType
{
	[XmlEnum("0")]
	Elementary,

	[XmlEnum("1")]
	Secondary,

	[XmlEnum("2")]
	Preschool
}
