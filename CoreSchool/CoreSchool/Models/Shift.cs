using System.Xml.Serialization;

namespace CoreSchool.Models;

public enum Shift
{
	[XmlEnum("0")]
	Morning,

	[XmlEnum("1")]
	Evening,

	[XmlEnum("2")]
	Night
}
