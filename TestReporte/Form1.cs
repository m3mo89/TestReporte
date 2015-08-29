using BSCFDIDataContract;
using clsRepresentacionImpresa;
using clsRepresentacionImpresa.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XTRA_RepresentacionImpresaDataModel representacionImpresa = new XTRA_RepresentacionImpresaDataModel();            
            
            representacionImpresa.factura_xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" version=\"3.2\" serie=\"H01\" folio=\"20\" fecha=\"2014-12-18T14:15:11\" sello=\"gWg1EzQzpHfSGyTyoO91lREPLMUgJqswRXVirLFSgl9HTWKcb3oHZ2ckZWKIitZTymGY+ex/FSFCympWZDMKxhN7voYGvycghRTLprbsFU8U1xQ/L8t8aMwyyQxzJaxHPu90yEIehxWYI1zyVuOcHDTIVpoLPIbye+XVcMDSuFo=\" formaDePago=\"PAGO EN UNA SOLA EXHIBICION\" noCertificado=\"00001000000203617045\" certificado=\"MIIE+jCCA+KgAwIBAgIUMDAwMDEwMDAwMDAyMDM2MTcwNDUwDQYJKoZIhvcNAQEFBQAwggGVMTgwNgYDVQQDDC9BLkMuIGRlbCBTZXJ2aWNpbyBkZSBBZG1pbmlzdHJhY2nDs24gVHJpYnV0YXJpYTEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExODA2BgNVBAsML0FkbWluaXN0cmFjacOzbiBkZSBTZWd1cmlkYWQgZGUgbGEgSW5mb3JtYWNpw7NuMSEwHwYJKoZIhvcNAQkBFhJhc2lzbmV0QHNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxFDASBgNVBAcMC0N1YXVodMOpbW9jMRUwEwYDVQQtEwxTQVQ5NzA3MDFOTjMxPjA8BgkqhkiG9w0BCQIML1Jlc3BvbnNhYmxlOiBDZWNpbGlhIEd1aWxsZXJtaW5hIEdhcmPDrWEgR3VlcnJhMB4XDTEzMDQyOTE0Mjg1MVoXDTE3MDQyOTE0MjkzMVowgeIxJTAjBgNVBAMTHEVCRVIgQUJFRCBIRVJOQU5ERVogR1JBSkFMRVMxJTAjBgNVBCkTHEVCRVIgQUJFRCBIRVJOQU5ERVogR1JBSkFMRVMxJTAjBgNVBAoTHEVCRVIgQUJFRCBIRVJOQU5ERVogR1JBSkFMRVMxCzAJBgNVBAYTAk1YMSkwJwYJKoZIhvcNAQkBFhpkZXNwYWNob2NvdXRpbm8xM0BsaXZlLmNvbTEWMBQGA1UELRMNSEVHRTgzMDkxOVNFMTEbMBkGA1UEBRMSSEVHRTgzMDkxOUhDU1JSQjAwMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCu4p/LpSy+U1Hj+8pJJ+3Stg8dSH/pPSEhArhacShioFVgzCVTGZgrOC6SRWIyzPFOj2OfRfrrEOFHkpHCJmQbiBeuR3F8rjlGDMRBno1S6+u0b++WyCr7xfinDtgrpe2M4k0kDNcwoNTgvL58o8cVisEs4L3cl76QioMn03w5iQIDAQABo3YwdDAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwID2DARBglghkgBhvhCAQEEBAMCBaAwHQYDVR0lBBYwFAYIKwYBBQUHAwQGCCsGAQUFBwMCMCUGA1UdEQQeMByBGmRlc3BhY2hvY291dGlubzEzQGxpdmUuY29tMA0GCSqGSIb3DQEBBQUAA4IBAQAFi/wQthL3RJk+qfZn55hzqTbbwL3gs7SPHOGSSPRIep8pDAHtV/VOAL/K/E0dbhLFMrtcczcUjek0U887OfmzmtB5SOv7vO9igDnVXG3T2dxSRjaW2eZ1zg8s2G5Vcw/ubIVEy8LWdM9IHBUDZri/Giaiec5AMXXMwTHlnDluJMXySZiEgXkDh3ozOcQnZn74eoa3K/QRLSm2avurfYwRM3Dqn/u3c1PpScKMtQULkM+oXCYBXZXb/SfqNWD4QD0fvHWEWQZiLUZC9p0Mj7lvWdRR4jpXBpZDqnKgWm7MX0reBV6Z9rANFegrw92p8zV1Fs34jNMPWTyzDkQBLapV\" subTotal=\"5580.00\" Moneda=\"MXN\" total=\"5022.00\" tipoDeComprobante=\"ingreso\" metodoDePago=\"No Identificado\" LugarExpedicion=\"CHIAPAS\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd\">  <cfdi:Emisor nombre=\"EBER ABED HERNANDEZ GRAJALES\" rfc=\"HEGE830919SE1\">    <cfdi:DomicilioFiscal codigoPostal=\"29030\" pais=\"MÉXICO\" estado=\"CHIAPAS\" municipio=\"TUXTLA GUTIERREZ\" localidad=\"TUXTLA GUTIERREZ\" colonia=\"FRACC. LAS ARBOLEDAS\" noInterior=\"304\" noExterior=\"232\" calle=\"CALLE 16 PONIENTE NORTE\" />    <cfdi:ExpedidoEn codigoPostal=\"29030\" pais=\"MÉXICO\" estado=\"CHIAPAS\" municipio=\"TUXTLA GUTIERREZ\" localidad=\"TUXTLA GUTIERREZ\" colonia=\"FRACC. LAS ARBOLEDAS\" noInterior=\"304\" noExterior=\"232\" calle=\"CALLE 16 PONIENTE NORTE\" />    <cfdi:RegimenFiscal Regimen=\"PERSONA FISICA CON ACTIVIDAD EMPRESARIAL Y PROFESIONAL\" />  </cfdi:Emisor>  <cfdi:Receptor nombre=\"FONDO DE GARANTIA Y FOMENTO PARA LA AGRICULTURA,GANADERIA Y AVICULTURA\" rfc=\"FGF550624CL9\">    <cfdi:Domicilio pais=\"MEXICO\" estado=\"MICHOACAN\" municipio=\"MORELIA\" noExterior=\"8555\" calle=\"ANTIGUA CARRETERA A PÁTZCUARO\" />  </cfdi:Receptor>  <cfdi:Conceptos>    <cfdi:Concepto importe=\"2070.00\" valorUnitario=\"207\" descripcion=\"SESIONES DE TERAPIA FÍSICA\" unidad=\"NO APLICA\" cantidad=\"10\" />    <cfdi:Concepto importe=\"3510.00\" valorUnitario=\"351\" descripcion=\"SESIONES DE NEURODESARROLLO\" unidad=\"NO APLICA\" cantidad=\"10\" />  </cfdi:Conceptos>  <cfdi:Impuestos totalImpuestosTrasladados=\"0.00\" totalImpuestosRetenidos=\"558.00\">    <cfdi:Retenciones>      <cfdi:Retencion importe=\"558.00\" impuesto=\"ISR\" />    </cfdi:Retenciones>    <cfdi:Traslados>      <cfdi:Traslado importe=\"0.00\" tasa=\"0\" impuesto=\"IVA\" />    </cfdi:Traslados>  </cfdi:Impuestos>  <cfdi:Complemento>    <tfd:TimbreFiscalDigital xmlns:tfd=\"http://www.sat.gob.mx/TimbreFiscalDigital\" version=\"1.0\" UUID=\"5C96FB40-3F67-41A4-A3A3-50E29985E510\" FechaTimbrado=\"2014-12-18T14:16:14\" selloCFD=\"gWg1EzQzpHfSGyTyoO91lREPLMUgJqswRXVirLFSgl9HTWKcb3oHZ2ckZWKIitZTymGY+ex/FSFCympWZDMKxhN7voYGvycghRTLprbsFU8U1xQ/L8t8aMwyyQxzJaxHPu90yEIehxWYI1zyVuOcHDTIVpoLPIbye+XVcMDSuFo=\" noCertificadoSAT=\"00001000000305452415\" selloSAT=\"nkiOb7ZLdI/j64pmmrRrJqDqGyjKGjlpNY172o/GP1TeTZF30is+tH2RqrA61S4b06U4CMWrkvENU0d6BF+oSs2iDUkl7CLgVWPJzpQ5BKylpQD3a2gORKsO1l6xzfp1SE75OKIk2Ws1TugBszkigpcVxAuVtmQPC4jzqcs866M=\" xsi:schemaLocation=\"http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/timbrefiscaldigital/TimbreFiscalDigital.xsd \" />  </cfdi:Complemento>  <cfdi:Addenda>    <az:AddendaAzurian xmlns:az=\"urn:addenda.cfdi.azurian.com\">      <az:Campos>        <az:Campo id=\"CADENA_TIMBRE\">||1.0|5C96FB40-3F67-41A4-A3A3-50E29985E510|2014-12-18T14:16:14|gWg1EzQzpHfSGyTyoO91lREPLMUgJqswRXVirLFSgl9HTWKcb3oHZ2ckZWKIitZTymGY+ex/FSFCympWZDMKxhN7voYGvycghRTLprbsFU8U1xQ/L8t8aMwyyQxzJaxHPu90yEIehxWYI1zyVuOcHDTIVpoLPIbye+XVcMDSuFo=|00001000000305452415||</az:Campo>      </az:Campos>    </az:AddendaAzurian>  </cfdi:Addenda></cfdi:Comprobante>";
            representacionImpresa.tipo_comprobante = "";
            representacionImpresa.timbrado = 1;
            representacionImpresa.cancelado = "0";
            representacionImpresa.descripcion = "";
            representacionImpresa.emisor_nombre = "";
            representacionImpresa.receptor_correo = "";
            
            RepresentacionImpresa cfdi = new RepresentacionImpresa(representacionImpresa);            
        
            SCFRRepImpCFD CrReport = new SCFRRepImpCFD();

            CrReport = cfdi.getRepresentacionImpresa("");
            crvRepresentacionImpresa.ReportSource = CrReport;                   

           
        }
    }
}
