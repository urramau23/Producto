using System.IO;
using System.Xml.Serialization;

namespace Productos.Core.Entities.DTO
{
    public class SocdoxResponse
    {
        public SocdoxResponse(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ROOT_SOCDOX));
            using (StringReader reader = new StringReader(xml))
            {
                Root = (ROOT_SOCDOX)serializer.Deserialize(reader);
            }

        }
        public SocdoxResponse()
        {
            Root = new ROOT_SOCDOX();
        }

        public ROOT_SOCDOX Root { get; set; }
        // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(ElementName = "ROOT", Namespace = "", IsNullable = false)]
        public  class ROOT_SOCDOX
        {

            private ROOT_SOCDOXELEMENT[] eLEMENTField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ELEMENT")]
            public ROOT_SOCDOXELEMENT[] ELEMENT
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public  class ROOT_SOCDOXELEMENT
        {

            private string nUMBERField;

            private string mARCACODIField;

            private string mARCADESCRIPField;

            private string eNTINUMEField;

            private string eNTIOBSERField;

            private string cUENTAField;

            private string tIPOTARJEField;

            private string gRUPOCODIField;

            private string aTRASOField;

            private string sALPESField;

            private string sALDOLField;

            private string pAGMINField;

            private string fECCIEField;

            private string fECVTOField;

            private string lIMITEField;

            private string mODAUTField;

            private string fECNORESField;

            private string tARJETIPOField;

            private string mODELOLIQUIField;

            private string mOTIVOField;

            private string eMPRESAField;

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
            public string MARCACODI
            {
                get
                {
                    return this.mARCACODIField;
                }
                set
                {
                    this.mARCACODIField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MARCADESCRIP
            {
                get
                {
                    return this.mARCADESCRIPField;
                }
                set
                {
                    this.mARCADESCRIPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ENTINUME
            {
                get
                {
                    return this.eNTINUMEField;
                }
                set
                {
                    this.eNTINUMEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ENTIOBSER
            {
                get
                {
                    return this.eNTIOBSERField;
                }
                set
                {
                    this.eNTIOBSERField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CUENTA
            {
                get
                {
                    return this.cUENTAField;
                }
                set
                {
                    this.cUENTAField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TIPOTARJE
            {
                get
                {
                    return this.tIPOTARJEField;
                }
                set
                {
                    this.tIPOTARJEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string GRUPOCODI
            {
                get
                {
                    return this.gRUPOCODIField;
                }
                set
                {
                    this.gRUPOCODIField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ATRASO
            {
                get
                {
                    return this.aTRASOField;
                }
                set
                {
                    this.aTRASOField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string SALPES
            {
                get
                {
                    return this.sALPESField;
                }
                set
                {
                    this.sALPESField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string SALDOL
            {
                get
                {
                    return this.sALDOLField;
                }
                set
                {
                    this.sALDOLField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PAGMIN
            {
                get
                {
                    return this.pAGMINField;
                }
                set
                {
                    this.pAGMINField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FECCIE
            {
                get
                {
                    return this.fECCIEField;
                }
                set
                {
                    this.fECCIEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FECVTO
            {
                get
                {
                    return this.fECVTOField;
                }
                set
                {
                    this.fECVTOField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string LIMITE
            {
                get
                {
                    return this.lIMITEField;
                }
                set
                {
                    this.lIMITEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MODAUT
            {
                get
                {
                    return this.mODAUTField;
                }
                set
                {
                    this.mODAUTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FECNORES
            {
                get
                {
                    return this.fECNORESField;
                }
                set
                {
                    this.fECNORESField = value;
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
            public string MODELOLIQUI
            {
                get
                {
                    return this.mODELOLIQUIField;
                }
                set
                {
                    this.mODELOLIQUIField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MOTIVO
            {
                get
                {
                    return this.mOTIVOField;
                }
                set
                {
                    this.mOTIVOField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string EMPRESA
            {
                get
                {
                    return this.eMPRESAField;
                }
                set
                {
                    this.eMPRESAField = value;
                }
            }

        }
    }

}
