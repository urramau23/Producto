using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Productos.Core.Entities.DTO
{
    public class SoccytRecord1Response
    {
        public SoccytRecord1Response(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            string xmlResultado = xmlDocument.SelectSingleNode("//TABLE[@NAME='RECORD1']").OuterXml;
            //xmlResultado = xmlResultado.Replace("TABLE>", "TABLE_RECORD1>");
            XmlSerializer serializer = new XmlSerializer(typeof(TABLE_RECORD1));
            using (StringReader reader = new StringReader(xmlResultado))
            {
                Table = (TABLE_RECORD1)serializer.Deserialize(reader);
            }
        }
        public TABLE_RECORD1 Table { get; set; }
    }

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "TABLE", Namespace = "", IsNullable = false)]
    public partial class TABLE_RECORD1
    {

        private TABLEELEMENT_RECORD1[] eLEMENTField;

        private string nAMEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ELEMENT")]
        public TABLEELEMENT_RECORD1[] ELEMENT
        {
            get
            {
                return this.eLEMENTField;
            }
            set
            {
                this.eLEMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TABLEELEMENT_RECORD1
    {

        private string nUMBERField;

        private string tARJENUMEField;

        private string aPENOMBREField;

        private string tARJEESTAField;

        private string tARJEESTADESCRIField;

        private string tARJECATEField;

        private string tARJECATEDESCRIField;

        private string dOCUCODIField;

        private string dOCUCODIDESCRIField;

        private string dOCUNUMEField;

        private string nACIFECHAField;

        private string cIVILESTAField;

        private string cIVILESTADESCRIField;

        private string aCTICODIField;

        private string aCTICODIDESCRIField;

        private string pRODUCTIPOField;

        private string pRODUCTIPODESCRIField;

        private string tARJETIPOField;

        private string tARJETIPODESCRIField;

        private string iNCLUBOLETINField;

        private string rENOMARCAField;

        private string rENOMARCADESCRIField;

        private string fECHAPLASTIVENCIField;

        private string nACIONALIDADField;

        private string nACIONALIDADDESCRIField;

        private string sEXOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NUMBER
        {
            get
            {
                return this.nUMBERField;
            }
            set
            {
                this.nUMBERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJENUME
        {
            get
            {
                return this.tARJENUMEField;
            }
            set
            {
                this.tARJENUMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string APENOMBRE
        {
            get
            {
                return this.aPENOMBREField;
            }
            set
            {
                this.aPENOMBREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJEESTA
        {
            get
            {
                return this.tARJEESTAField;
            }
            set
            {
                this.tARJEESTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJEESTADESCRI
        {
            get
            {
                return this.tARJEESTADESCRIField;
            }
            set
            {
                this.tARJEESTADESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJECATE
        {
            get
            {
                return this.tARJECATEField;
            }
            set
            {
                this.tARJECATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJECATEDESCRI
        {
            get
            {
                return this.tARJECATEDESCRIField;
            }
            set
            {
                this.tARJECATEDESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DOCUCODI
        {
            get
            {
                return this.dOCUCODIField;
            }
            set
            {
                this.dOCUCODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DOCUCODIDESCRI
        {
            get
            {
                return this.dOCUCODIDESCRIField;
            }
            set
            {
                this.dOCUCODIDESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DOCUNUME
        {
            get
            {
                return this.dOCUNUMEField;
            }
            set
            {
                this.dOCUNUMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NACIFECHA
        {
            get
            {
                return this.nACIFECHAField;
            }
            set
            {
                this.nACIFECHAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CIVILESTA
        {
            get
            {
                return this.cIVILESTAField;
            }
            set
            {
                this.cIVILESTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CIVILESTADESCRI
        {
            get
            {
                return this.cIVILESTADESCRIField;
            }
            set
            {
                this.cIVILESTADESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ACTICODI
        {
            get
            {
                return this.aCTICODIField;
            }
            set
            {
                this.aCTICODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ACTICODIDESCRI
        {
            get
            {
                return this.aCTICODIDESCRIField;
            }
            set
            {
                this.aCTICODIDESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PRODUCTIPO
        {
            get
            {
                return this.pRODUCTIPOField;
            }
            set
            {
                this.pRODUCTIPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PRODUCTIPODESCRI
        {
            get
            {
                return this.pRODUCTIPODESCRIField;
            }
            set
            {
                this.pRODUCTIPODESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJETIPO
        {
            get
            {
                return this.tARJETIPOField;
            }
            set
            {
                this.tARJETIPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TARJETIPODESCRI
        {
            get
            {
                return this.tARJETIPODESCRIField;
            }
            set
            {
                this.tARJETIPODESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string INCLUBOLETIN
        {
            get
            {
                return this.iNCLUBOLETINField;
            }
            set
            {
                this.iNCLUBOLETINField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RENOMARCA
        {
            get
            {
                return this.rENOMARCAField;
            }
            set
            {
                this.rENOMARCAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RENOMARCADESCRI
        {
            get
            {
                return this.rENOMARCADESCRIField;
            }
            set
            {
                this.rENOMARCADESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAPLASTIVENCI
        {
            get
            {
                return this.fECHAPLASTIVENCIField;
            }
            set
            {
                this.fECHAPLASTIVENCIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NACIONALIDAD
        {
            get
            {
                return this.nACIONALIDADField;
            }
            set
            {
                this.nACIONALIDADField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NACIONALIDADDESCRI
        {
            get
            {
                return this.nACIONALIDADDESCRIField;
            }
            set
            {
                this.nACIONALIDADDESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SEXO
        {
            get
            {
                return this.sEXOField;
            }
            set
            {
                this.sEXOField = value;
            }
        }
    }
}
