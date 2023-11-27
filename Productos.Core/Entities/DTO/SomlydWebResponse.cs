using System.IO;
using System.Xml.Serialization;

namespace Productos.Core.Entities.DTO
{
    public class SomlydWebResponse
    {
        public SomlydWebResponse(string xml) 
        {
            xml = xml.Replace("ROOT>", "ROOT_SOMLYD>");
            XmlSerializer serializer = new XmlSerializer(typeof(ROOT_SOMLYD));
            using (StringReader reader = new StringReader(xml))
            {
                somlyd = (ROOT_SOMLYD)serializer.Deserialize(reader);
            }
        }
        public SomlydWebResponse()
        {
            
        }
        public ROOT_SOMLYD somlyd { get; set; }
    }

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ROOT_SOMLYD
    {

        private ROOTTABLE tABLEField;

        /// <remarks/>
        public ROOTTABLE TABLE
        {
            get
            {
                return this.tABLEField;
            }
            set
            {
                this.tABLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ROOTTABLE
    {

        private ROOTTABLEELEMENT eLEMENTField;

        private string nAMEField;

        /// <remarks/>
        public ROOTTABLEELEMENT ELEMENT
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
    public partial class ROOTTABLEELEMENT
    {

        private byte nUMBERField;

        private byte mAPNROField;

        private uint nROCUENTAField;

        private string lIMIUNIFICADOField;

        private string dISPMESUNIField;

        private string rIESGOCREDIField;

        private string lIMICOMPRACONTADOField;

        private string lIMICUOTASField;

        private string lIMIADELANTOField;

        private string lIMIPRESTAMOFINANField;

        private string lIMIPRESTAMOCONSUMOField;

        private string dISPCOMPRACONTADOField;

        private string dISPCUOTASField;

        private string dISPADELANTOField;

        private string dISPPRESTAMOFINANField;

        private string dISPPRESTAMOCONSUMOField;

        private string lIMICUOTASMAXMESField;

        private string dISPCUOTASMAXMESField;

        private string dISPLIBERACIONField;

        private string mESSAGEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NUMBER
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
        public byte MAPNRO
        {
            get
            {
                return this.mAPNROField;
            }
            set
            {
                this.mAPNROField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint NROCUENTA
        {
            get
            {
                return this.nROCUENTAField;
            }
            set
            {
                this.nROCUENTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIUNIFICADO
        {
            get
            {
                return this.lIMIUNIFICADOField;
            }
            set
            {
                this.lIMIUNIFICADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPMESUNI
        {
            get
            {
                return this.dISPMESUNIField;
            }
            set
            {
                this.dISPMESUNIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RIESGOCREDI
        {
            get
            {
                return this.rIESGOCREDIField;
            }
            set
            {
                this.rIESGOCREDIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMICOMPRACONTADO
        {
            get
            {
                return this.lIMICOMPRACONTADOField;
            }
            set
            {
                this.lIMICOMPRACONTADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMICUOTAS
        {
            get
            {
                return this.lIMICUOTASField;
            }
            set
            {
                this.lIMICUOTASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIADELANTO
        {
            get
            {
                return this.lIMIADELANTOField;
            }
            set
            {
                this.lIMIADELANTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIPRESTAMOFINAN
        {
            get
            {
                return this.lIMIPRESTAMOFINANField;
            }
            set
            {
                this.lIMIPRESTAMOFINANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIPRESTAMOCONSUMO
        {
            get
            {
                return this.lIMIPRESTAMOCONSUMOField;
            }
            set
            {
                this.lIMIPRESTAMOCONSUMOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPCOMPRACONTADO
        {
            get
            {
                return this.dISPCOMPRACONTADOField;
            }
            set
            {
                this.dISPCOMPRACONTADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPCUOTAS
        {
            get
            {
                return this.dISPCUOTASField;
            }
            set
            {
                this.dISPCUOTASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPADELANTO
        {
            get
            {
                return this.dISPADELANTOField;
            }
            set
            {
                this.dISPADELANTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPPRESTAMOFINAN
        {
            get
            {
                return this.dISPPRESTAMOFINANField;
            }
            set
            {
                this.dISPPRESTAMOFINANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPPRESTAMOCONSUMO
        {
            get
            {
                return this.dISPPRESTAMOCONSUMOField;
            }
            set
            {
                this.dISPPRESTAMOCONSUMOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMICUOTASMAXMES
        {
            get
            {
                return this.lIMICUOTASMAXMESField;
            }
            set
            {
                this.lIMICUOTASMAXMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPCUOTASMAXMES
        {
            get
            {
                return this.dISPCUOTASMAXMESField;
            }
            set
            {
                this.dISPCUOTASMAXMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DISPLIBERACION
        {
            get
            {
                return this.dISPLIBERACIONField;
            }
            set
            {
                this.dISPLIBERACIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MESSAGE
        {
            get
            {
                return this.mESSAGEField;
            }
            set
            {
                this.mESSAGEField = value;
            }
        }
    }


}
