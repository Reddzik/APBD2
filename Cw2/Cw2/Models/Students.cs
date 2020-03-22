using System;
using System.Xml.Serialization;

namespace Cw2.Models
{
    [XmlType(Namespace ="Student")]
    public class Student
    {
        [XmlElement(elementName: "Email")]
        public string Email { get; set; }
        [XmlElement(elementName: "First_Name")]
        public string Name { get; set; }
        //propfull + tabx2

        private string _id;
        private string _surname;

        [XmlElement(elementName: "School_Mode")]
        public string SchoolMode { get; set; }

        [XmlElement(elementName: "Field_Of_Study")]
        public string FiledOfStudy { get; set; }

        [XmlElement(elementName: "Birthday")]
        public string Birthday { get; set; }

        [XmlElement(elementName: "Mothers_Name")]
        public string MothersName { get; set; }

        [XmlElement(elementName: "Fathers_Name")]
        public string FathersName { get; set; }

        [XmlElement(elementName: "Surname")]
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == null) throw new ArgumentException();
                _surname = value;
            }
        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Id;
        }
        [XmlAttribute(attributeName: "id")]
        public string Id
        {
            get { return _id; }
            set
            {
                if (value == null) throw new ArgumentException();
                _id = "s"+value;
            }
        }

    }
}
