using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Productos.Core.Entities.DTO
{
    public class SoccytResultadoResponse
    {
        public SoccytResultadoResponse(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            string xmlResultado = xmlDocument.SelectSingleNode("//TABLE[@NAME='RESULTADO']").OuterXml;

            XmlSerializer serializer = new XmlSerializer(typeof(TABLE));
            using (StringReader reader = new StringReader(xmlResultado))
            {
                TableResultado = (TABLE)serializer.Deserialize(reader);
            }
        }
        public TABLE TableResultado { get; set; }
    }

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TABLE
    {

        private TABLEELEMENT eLEMENTField;

        private string nAMEField;

        /// <remarks/>
        public TABLEELEMENT ELEMENT
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
    public partial class TABLEELEMENT
    {

        private string nUMBERField;

        private string cODRETField;

        private string dESCODRETField;

        private string cUENTADENOField;

        private string cUENTATIPOField;

        private string cUENTATIPODESCRIField;

        private string cONDICIONIVAField;

        private string cUITField;

        private string cOMPRALIMILETRAField;

        private string cOMPRALIMICOEFField;

        private string cOMPRALIMILETRA_PField;

        private string cOMPRALIMICOEF_PField;

        private string lIQMODECODIField;

        private string lIQMODESUBCARGOSField;

        private string lIQMODESUBTASASField;

        private string lIQMODESUBPARAMField;

        private string aFIGRUPOField;

        private string aFIGRUPODESCRIField;

        private string cUENTAESTAField;

        private string cUENTAESTADESCRIField;

        private string fINANLIMIField;

        private string cOMPRACUOLIMIField;

        private string eMPRECUENTANUMEField;

        private string sEGVIDACODIField;

        private string sEGVIDADESCRIField;

        private string sEGDESEMCODIField;

        private string sEGDESEMDESCRIField;

        private string nOEMIFECHAField;

        private string sALDOACTUALPESOSField;

        private string sALDOACTUALDOLARField;

        private string pAGOMINIMOField;

        private string cARTERAField;

        private string sUCURSALField;

        private string fECHACIERREField;

        private string fECHAVENCIMIENTOField;

        private string fECHAPROXICIERREField;

        private string fECHAPROXIVTOField;

        private string eNTIDADField;

        private string fECHAALTACUENTAField;

        private string fECHAINICIOMORAField;

        private string cALLEField;

        private string nUMEField;

        private string pISOField;

        private string dEPTOField;

        private string lOCAField;

        private string cpField;

        private string pROVINCIAField;

        private string pROVINCODIField;

        private string gEOCODIField;

        private string tELEField;

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
        public string CODRET
        {
            get
            {
                return this.cODRETField;
            }
            set
            {
                this.cODRETField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DESCODRET
        {
            get
            {
                return this.dESCODRETField;
            }
            set
            {
                this.dESCODRETField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUENTADENO
        {
            get
            {
                return this.cUENTADENOField;
            }
            set
            {
                this.cUENTADENOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUENTATIPO
        {
            get
            {
                return this.cUENTATIPOField;
            }
            set
            {
                this.cUENTATIPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUENTATIPODESCRI
        {
            get
            {
                return this.cUENTATIPODESCRIField;
            }
            set
            {
                this.cUENTATIPODESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CONDICIONIVA
        {
            get
            {
                return this.cONDICIONIVAField;
            }
            set
            {
                this.cONDICIONIVAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUIT
        {
            get
            {
                return this.cUITField;
            }
            set
            {
                this.cUITField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPRALIMILETRA
        {
            get
            {
                return this.cOMPRALIMILETRAField;
            }
            set
            {
                this.cOMPRALIMILETRAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPRALIMICOEF
        {
            get
            {
                return this.cOMPRALIMICOEFField;
            }
            set
            {
                this.cOMPRALIMICOEFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPRALIMILETRA_P
        {
            get
            {
                return this.cOMPRALIMILETRA_PField;
            }
            set
            {
                this.cOMPRALIMILETRA_PField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPRALIMICOEF_P
        {
            get
            {
                return this.cOMPRALIMICOEF_PField;
            }
            set
            {
                this.cOMPRALIMICOEF_PField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIQMODECODI
        {
            get
            {
                return this.lIQMODECODIField;
            }
            set
            {
                this.lIQMODECODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIQMODESUBCARGOS
        {
            get
            {
                return this.lIQMODESUBCARGOSField;
            }
            set
            {
                this.lIQMODESUBCARGOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIQMODESUBTASAS
        {
            get
            {
                return this.lIQMODESUBTASASField;
            }
            set
            {
                this.lIQMODESUBTASASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LIQMODESUBPARAM
        {
            get
            {
                return this.lIQMODESUBPARAMField;
            }
            set
            {
                this.lIQMODESUBPARAMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AFIGRUPO
        {
            get
            {
                return this.aFIGRUPOField;
            }
            set
            {
                this.aFIGRUPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AFIGRUPODESCRI
        {
            get
            {
                return this.aFIGRUPODESCRIField;
            }
            set
            {
                this.aFIGRUPODESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUENTAESTA
        {
            get
            {
                return this.cUENTAESTAField;
            }
            set
            {
                this.cUENTAESTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CUENTAESTADESCRI
        {
            get
            {
                return this.cUENTAESTADESCRIField;
            }
            set
            {
                this.cUENTAESTADESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FINANLIMI
        {
            get
            {
                return this.fINANLIMIField;
            }
            set
            {
                this.fINANLIMIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPRACUOLIMI
        {
            get
            {
                return this.cOMPRACUOLIMIField;
            }
            set
            {
                this.cOMPRACUOLIMIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EMPRECUENTANUME
        {
            get
            {
                return this.eMPRECUENTANUMEField;
            }
            set
            {
                this.eMPRECUENTANUMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SEGVIDACODI
        {
            get
            {
                return this.sEGVIDACODIField;
            }
            set
            {
                this.sEGVIDACODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SEGVIDADESCRI
        {
            get
            {
                return this.sEGVIDADESCRIField;
            }
            set
            {
                this.sEGVIDADESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SEGDESEMCODI
        {
            get
            {
                return this.sEGDESEMCODIField;
            }
            set
            {
                this.sEGDESEMCODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SEGDESEMDESCRI
        {
            get
            {
                return this.sEGDESEMDESCRIField;
            }
            set
            {
                this.sEGDESEMDESCRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NOEMIFECHA
        {
            get
            {
                return this.nOEMIFECHAField;
            }
            set
            {
                this.nOEMIFECHAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SALDOACTUALPESOS
        {
            get
            {
                return this.sALDOACTUALPESOSField;
            }
            set
            {
                this.sALDOACTUALPESOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SALDOACTUALDOLAR
        {
            get
            {
                return this.sALDOACTUALDOLARField;
            }
            set
            {
                this.sALDOACTUALDOLARField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PAGOMINIMO
        {
            get
            {
                return this.pAGOMINIMOField;
            }
            set
            {
                this.pAGOMINIMOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CARTERA
        {
            get
            {
                return this.cARTERAField;
            }
            set
            {
                this.cARTERAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SUCURSAL
        {
            get
            {
                return this.sUCURSALField;
            }
            set
            {
                this.sUCURSALField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHACIERRE
        {
            get
            {
                return this.fECHACIERREField;
            }
            set
            {
                this.fECHACIERREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAVENCIMIENTO
        {
            get
            {
                return this.fECHAVENCIMIENTOField;
            }
            set
            {
                this.fECHAVENCIMIENTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAPROXICIERRE
        {
            get
            {
                return this.fECHAPROXICIERREField;
            }
            set
            {
                this.fECHAPROXICIERREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAPROXIVTO
        {
            get
            {
                return this.fECHAPROXIVTOField;
            }
            set
            {
                this.fECHAPROXIVTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ENTIDAD
        {
            get
            {
                return this.eNTIDADField;
            }
            set
            {
                this.eNTIDADField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAALTACUENTA
        {
            get
            {
                return this.fECHAALTACUENTAField;
            }
            set
            {
                this.fECHAALTACUENTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FECHAINICIOMORA
        {
            get
            {
                return this.fECHAINICIOMORAField;
            }
            set
            {
                this.fECHAINICIOMORAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CALLE
        {
            get
            {
                return this.cALLEField;
            }
            set
            {
                this.cALLEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NUME
        {
            get
            {
                return this.nUMEField;
            }
            set
            {
                this.nUMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PISO
        {
            get
            {
                return this.pISOField;
            }
            set
            {
                this.pISOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DEPTO
        {
            get
            {
                return this.dEPTOField;
            }
            set
            {
                this.dEPTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LOCA
        {
            get
            {
                return this.lOCAField;
            }
            set
            {
                this.lOCAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CP
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PROVINCIA
        {
            get
            {
                return this.pROVINCIAField;
            }
            set
            {
                this.pROVINCIAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PROVINCODI
        {
            get
            {
                return this.pROVINCODIField;
            }
            set
            {
                this.pROVINCODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GEOCODI
        {
            get
            {
                return this.gEOCODIField;
            }
            set
            {
                this.gEOCODIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TELE
        {
            get
            {
                return this.tELEField;
            }
            set
            {
                this.tELEField = value;
            }
        }
    }


}
