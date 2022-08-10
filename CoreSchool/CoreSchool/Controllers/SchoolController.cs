using System.Xml.Serialization;
using CoreSchool.Models;

namespace CoreSchool.Controllers;

internal class SchoolController
{
	public School[] Schools { get; set; }

	public SchoolController()
	{
		XmlSerializer xmlSerializer = new(typeof(School[]), new XmlRootAttribute("Schools"));
		FileStream fileStream = new(Path.Combine("Data", "Schools.xml"), FileMode.Open);
		Schools = (School[]?)xmlSerializer.Deserialize(fileStream) ?? Array.Empty<School>();
		fileStream.Close();
	}
}