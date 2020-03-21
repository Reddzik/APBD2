using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cw2.Models
{
    class Student
    {
        [XmlAttribute(attributeName: "email")]
        public string Email { get; set; }
        [XmlElement(elementName: "fname")]
        public string Name { get; set; }
        //propfull + tabx2
        private string _id;
        private string _surname;
        public string SchoolMode { get; set; }
        public string FiledOfStudy { get; set; }
        public string DateOfStart { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }

        
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
            return Name +" "+ Surname + " " + Id;
        }
        public string Id
        {
            get { return _id; }
            set
            {
                if (value == null) throw new ArgumentException();
                _id = value;
            }
        }

    }
}
