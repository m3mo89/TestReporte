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

            representacionImpresa.factura_xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" version=\"3.2\" folio=\"74\" serie=\"A\" fecha=\"2015-08-29T13:01:26\" sello=\"aOhBwrkpbd1VxYGLAjuqKLHdn0SQvQbSuqkdQh/pmD36FI06aNMHb+WUbaCXznd3j27wTrPEITS9ntAH6SglCDZ2G0nQYfe5LF9oYZXGXIcszfpocYMlM5GLx95YZi960tfv934SrXFWBy6RY9RVtufQ474YMxgyP5KRuDwlJ2o=\" formaDePago=\"EFECTIVO\" noCertificado=\"00001000000301953856\" certificado=\"MIIEsTCCA5mgAwIBAgIUMDAwMDEwMDAwMDAzMDE5NTM4NTYwDQYJKoZIhvcNAQEFBQAwggGKMTgwNgYDVQQDDC9BLkMuIGRlbCBTZXJ2aWNpbyBkZSBBZG1pbmlzdHJhY2nDs24gVHJpYnV0YXJpYTEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExODA2BgNVBAsML0FkbWluaXN0cmFjacOzbiBkZSBTZWd1cmlkYWQgZGUgbGEgSW5mb3JtYWNpw7NuMR8wHQYJKoZIhvcNAQkBFhBhY29kc0BzYXQuZ29iLm14MSYwJAYDVQQJDB1Bdi4gSGlkYWxnbyA3NywgQ29sLiBHdWVycmVybzEOMAwGA1UEEQwFMDYzMDAxCzAJBgNVBAYTAk1YMRkwFwYDVQQIDBBEaXN0cml0byBGZWRlcmFsMRQwEgYDVQQHDAtDdWF1aHTDqW1vYzEVMBMGA1UELRMMU0FUOTcwNzAxTk4zMTUwMwYJKoZIhvcNAQkCDCZSZXNwb25zYWJsZTogQ2xhdWRpYSBDb3ZhcnJ1YmlhcyBPY2hvYTAeFw0xMzEyMjAyMzA3MDRaFw0xNzEyMjAyMzA3MDRaMIH9MTUwMwYDVQQDEyxDT05TVFJVQ0NJT05FUyBDT05ERUNPTiBERUwgU1VSRVNURSBTQSBERSBDVjE1MDMGA1UEKRMsQ09OU1RSVUNDSU9ORVMgQ09OREVDT04gREVMIFNVUkVTVEUgU0EgREUgQ1YxNTAzBgNVBAoTLENPTlNUUlVDQ0lPTkVTIENPTkRFQ09OIERFTCBTVVJFU1RFIFNBIERFIENWMSUwIwYDVQQtExxDQ1MxMjA4MjFSNDYgLyBDT0ZBNjgwODA1Ukk3MR4wHAYDVQQFExUgLyBDT0ZBNjgwODA1SENTTk5CMDQxDzANBgNVBAsTBk1BVFJJWjCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEAgkFI5+fWsF/ZhSEwD+YOEWY03V2JrYOgdO6PJSfY5KvCPveNjwH9bWGoHSDk/1Oxq7MlVZWlAoZmYC/6EH3a84ATrvqEkZrBymn9nZuQloEBxHpP88LAH5X8NObrqjWaMc03zjWUC1i47zHyHgWOaEsS+HVs3nTpNyJ1Ks5rjlcCAwEAAaMdMBswDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCBsAwDQYJKoZIhvcNAQEFBQADggEBAIgletG9zaoE6Uekj6GyXSxzo57dGLuddyakJ0ZzWW3xZ9KhgKVPlwxtYbhIBsvCFI5gptNEg3LxO87POsR4C1JNb2TyIgA9gNbu/1JPdCrmgASe2Xa/bwOSSgi/VsxSRrCqR7lMl0Q6I7exRRA6yMvy1DorLvSkqY2MwvmqjbjDwKvS822PdoeZ/3s0Je69ROoV9+qaKksF7jpWpSo8sUzQ/Ld+EvjtYMbMNycKTM6WfJeFt6kaoCbLAmNKlhk/aW8zS1A6Nu5TvNqTKrhszgazWH8LOL7cmYPrCUjZghHuRhW7bVHoKIvzUwMeUzyWgf0O5q0r/+h66BzNfuLrlV0=\" condicionesDePago=\"Pago en una sola exhibición\" subTotal=\"5250.0000\" Moneda=\"MXN\" total=\"5250.0000\" tipoDeComprobante=\"ingreso\" metodoDePago=\"NO IDENTIFICADO\" LugarExpedicion=\"Yucatán\" NumCtaPago=\"NO IDENTIFICADO\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd\"><cfdi:Emisor nombre=\"MUEBLERIA MARISOL\" rfc=\"CCS120821R46\"><cfdi:DomicilioFiscal codigoPostal=\"97860\" pais=\"México\" estado=\"Yucatán\" municipio=\"Ticul\" localidad=\"Ticul\" colonia=\"Ticul Centro\" noInterior=\"97845\" noExterior=\"97845\" calle=\"CALLE 24 X 17 Y 19,\" /><cfdi:ExpedidoEn codigoPostal=\"97860\" pais=\"México\" estado=\"Yucatán\" municipio=\"Ticul\" localidad=\"Ticul\" colonia=\"Ticul Centro\" noExterior=\"97845\" calle=\"CALLE 24 X 17 Y 19,\" /><cfdi:RegimenFiscal Regimen=\"Personas morales del régimen general.\" /></cfdi:Emisor><cfdi:Receptor nombre=\"ELVIRA DEL CARMEN RUZ MONTEJO\" rfc=\"IISD7107039J0\"><cfdi:Domicilio codigoPostal=\"29000\" pais=\"México\" estado=\"Chiapas\" municipio=\"Tuxtla Gutiérrez\" localidad=\"Tuxtla Gutiérrez\" colonia=\"Tuxtla Gutiérrez Centro\" noInterior=\"SN\" noExterior=\"847\" calle=\"AV. CENTRAL PONIENTE\" /></cfdi:Receptor><cfdi:Conceptos><cfdi:Concepto importe=\"5250.0000\" valorUnitario=\"5000.0000\" descripcion=\"FRIGOBAR FRIGOBAR MABE \" unidad=\"Pieza\" cantidad=\"1.0000\" /></cfdi:Conceptos><cfdi:Impuestos totalImpuestosTrasladados=\"0\"><cfdi:Traslados><cfdi:Traslado importe=\"0\" tasa=\"0\" impuesto=\"IVA\" /></cfdi:Traslados></cfdi:Impuestos><cfdi:Complemento><tfd:TimbreFiscalDigital xmlns:tfd=\"http://www.sat.gob.mx/TimbreFiscalDigital\" version=\"1.0\" UUID=\"BAE29793-AAC5-4A96-B51C-7DDCF20858CD\" FechaTimbrado=\"2015-08-29T16:19:13\" selloCFD=\"aOhBwrkpbd1VxYGLAjuqKLHdn0SQvQbSuqkdQh/pmD36FI06aNMHb+WUbaCXznd3j27wTrPEITS9ntAH6SglCDZ2G0nQYfe5LF9oYZXGXIcszfpocYMlM5GLx95YZi960tfv934SrXFWBy6RY9RVtufQ474YMxgyP5KRuDwlJ2o=\" noCertificadoSAT=\"20001000000300003693\" selloSAT=\"QCbs5Drm1uXJBYgXz1AVhH9PXouuV+EJKcJ0KgH7JqqiPC2AtO7ZWyUL2xhZDz7v5R+itCC7vohjxXMo4Vugfb+WAL+CaURyG08tLpFV64FQAN/G2pCtCfy6wpmfD5VGQgNjTpFZ4Cm8xpKjEVtYivwBr+RGsT9MXJ7x5zzxdl0=\" xsi:schemaLocation=\"http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/timbrefiscaldigital/TimbreFiscalDigital.xsd \" /></cfdi:Complemento><cfdi:Addenda><az:AddendaAzurian xmlns:az=\"urn:addenda.cfdi.azurian.com\"><az:Campos><az:Campo id=\"CADENA_TIMBRE\">||1.0|BAE29793-AAC5-4A96-B51C-7DDCF20858CD|2015-08-29T16:19:13|aOhBwrkpbd1VxYGLAjuqKLHdn0SQvQbSuqkdQh/pmD36FI06aNMHb+WUbaCXznd3j27wTrPEITS9ntAH6SglCDZ2G0nQYfe5LF9oYZXGXIcszfpocYMlM5GLx95YZi960tfv934SrXFWBy6RY9RVtufQ474YMxgyP5KRuDwlJ2o=|20001000000300003693||</az:Campo></az:Campos></az:AddendaAzurian></cfdi:Addenda></cfdi:Comprobante>";
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
