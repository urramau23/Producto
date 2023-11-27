using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Productos.Core.Entities.DTO
{
    public class SovlydWebResponse
    {
        public SOVLYD_ROOT Sovlyd { get; set; }
        public SovlydWebResponse(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SOVLYD_ROOT));
            using (StringReader reader = new StringReader(xml))
            {
                Sovlyd = (SOVLYD_ROOT)serializer.Deserialize(reader);
            }
        }
        public SovlydWebResponse()
        {
            
        }
    }

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "ROOT", Namespace = "", IsNullable = false)]
    public partial class SOVLYD_ROOT
    {

        private SOVLYD_ROOTTABLE tABLEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TABLE")]
        public SOVLYD_ROOTTABLE TABLE
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
    public partial class SOVLYD_ROOTTABLE
    {

        private SOVLYD_ROOTTABLEELEMENT eLEMENTField;

        private string nAMEField;

        /// <remarks/>
        /// 
        [System.Xml.Serialization.XmlElementAttribute("ELEMENT")]
        public SOVLYD_ROOTTABLEELEMENT ELEMENT
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
    public partial class SOVLYD_ROOTTABLEELEMENT
    {

        private byte nUMBERField;

        private byte mAPNROField;

        private uint nROCUENTAField;

        private string lIMICONTADOField;

        private string lIMICREDITOCUOTASField;

        private string lIMIADELANTOField;

        private string lIMIDISPCONTADOField;

        private string lIMIDISPCREDITOCUOTASField;

        private string lIMIDISPADELANTOField;

        private string lEYENDALIMIUNIFICADOField;

        private string aUTORIZACIONESCONTADOField;

        private string aUTORIZACIONESCUOTASField;

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
        public string LIMICONTADO
        {
            get
            {
                return this.lIMICONTADOField;
            }
            set
            {
                this.lIMICONTADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMICREDITOCUOTAS
        {
            get
            {
                return this.lIMICREDITOCUOTASField;
            }
            set
            {
                this.lIMICREDITOCUOTASField = value;
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
        public string LIMIDISPCONTADO
        {
            get
            {
                return this.lIMIDISPCONTADOField;
            }
            set
            {
                this.lIMIDISPCONTADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIDISPCREDITOCUOTAS
        {
            get
            {
                return this.lIMIDISPCREDITOCUOTASField;
            }
            set
            {
                this.lIMIDISPCREDITOCUOTASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIMIDISPADELANTO
        {
            get
            {
                return this.lIMIDISPADELANTOField;
            }
            set
            {
                this.lIMIDISPADELANTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LEYENDALIMIUNIFICADO
        {
            get
            {
                return this.lEYENDALIMIUNIFICADOField;
            }
            set
            {
                this.lEYENDALIMIUNIFICADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AUTORIZACIONESCONTADO
        {
            get
            {
                return this.aUTORIZACIONESCONTADOField;
            }
            set
            {
                this.aUTORIZACIONESCONTADOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AUTORIZACIONESCUOTAS
        {
            get
            {
                return this.aUTORIZACIONESCUOTASField;
            }
            set
            {
                this.aUTORIZACIONESCUOTASField = value;
            }
        }
    }


}
