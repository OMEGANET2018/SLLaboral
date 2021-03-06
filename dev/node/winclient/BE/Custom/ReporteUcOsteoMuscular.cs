﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigesoft.Node.WinClient.BE.Custom
{
    public class ReporteUcOsteoMuscular
    {
            public string ServiceId { get; set; }
            public string ServiceComponentId { get; set; }
            public DateTime? FechaServicio { get; set; }
            public string Nombres { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string NombreCompleto { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public int Edad { get; set; }
            public int TipoDocumentoId { get; set; }
            public string TipoDocumento { get; set; }
            public string NroDocumento { get; set; }
            public string EmpresaCliente { get; set; }
            public string EmpresaTrabajo { get; set; }
            public string EmpresaEmpleadora { get; set; }
            public string Puesto { get; set; }
            public int GeneroId { get; set; }
            public string Genero { get; set; }
            public string LugarNacimiento { get; set; }
            public string LugarProcedencia { get; set; }
            public byte[] FirmaTrabajador { get; set; }
            public byte[] HuellaTrabajador { get; set; }
            public byte[] FirmaUsuarioGraba { get; set; }
            public byte[] FirmaMedicina { get; set; }

            public string txtAnamnesis { get; set; }// { get; set; }//"N009-OTM00000001";//System.Windows.Forms.TextBox();
            public string cboCondiAmbEspacio { get; set; }// { get; set; }//"N009-OTM00000002";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbTemperatura { get; set; }// { get; set; }//"N009-OTM00000003";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbVibraciones { get; set; }//"N009-OTM00000004";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbSueloInestable { get; set; }//"N009-OTM00000005";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbDesniveles { get; set; }//"N009-OTM00000006";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbAltura { get; set; }//"N009-OTM00000007";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbPostura { get; set; }//"N009-OTM00000008";//System.Windows.Forms.ComboBox();
            public string cboCondiAmbSuelo { get; set; }//"N009-OTM00000009";//System.Windows.Forms.ComboBox();
            public string cboExigRitmo { get; set; }//"N009-OTM00000010";//System.Windows.Forms.ComboBox();
            public string cboExigDistancias { get; set; }//"N009-OTM00000011";//System.Windows.Forms.ComboBox();
            public string cboExigPeriodo { get; set; }//"N009-OTM00000012";//System.Windows.Forms.ComboBox();
            public string cboExigEsfuerzo { get; set; }//"N009-OTM00000013";//System.Windows.Forms.ComboBox();
            public string cboEsfFisAlzar { get; set; }//"N009-OTM00000014";//System.Windows.Forms.ComboBox();
            public string cboEsfFisExiste { get; set; }//"N009-OTM00000015";//System.Windows.Forms.ComboBox();
            public string cboEsfFisCuerpo { get; set; }//"N009-OTM00000016";//System.Windows.Forms.ComboBox();
            public string cboEsfFisExige { get; set; }//"N009-OTM00000017";//System.Windows.Forms.ComboBox();
            public string cboCarCargaPeso { get; set; }//"N009-OTM00000018";//System.Windows.Forms.ComboBox();
            public string cboCarCargaManipulacion { get; set; }//"N009-OTM00000019";//System.Windows.Forms.ComboBox();
            public string cboCarCargaEquilibrio { get; set; }//"N009-OTM00000020";//System.Windows.Forms.ComboBox();
            public string cboCarCargaVolumen { get; set; }//"N009-OTM00000021";//System.Windows.Forms.ComboBox();
            public string cboExpToxCadmio { get; set; }//"N009-OTM00000022";//System.Windows.Forms.ComboBox();
            public string cboExpToxMercurio { get; set; }//"N009-OTM00000023";//System.Windows.Forms.ComboBox();
            public string cboExpToxMagneso { get; set; }//"N009-OTM00000024";//System.Windows.Forms.ComboBox();
            public string txt2Exposicion { get; set; }//"N009-OTM00000025";//System.Windows.Forms.TextBox();
            public string txt2DiasSemana { get; set; }//"N009-OTM00000026";//System.Windows.Forms.TextBox();
            public string txt2HorasSentado { get; set; }//"N009-OTM00000027";//System.Windows.Forms.TextBox();
            public string txt2Repetitivo { get; set; }//"N009-OTM00000028";//System.Windows.Forms.TextBox();
            public string txt2Anios { get; set; }//"N009-OTM00000029";//System.Windows.Forms.TextBox();
            public string txt2Horas { get; set; }//"N009-OTM00000030";//System.Windows.Forms.TextBox();
            public string cbo2RiesgoLevanta { get; set; }//"N009-OTM00000031";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoDesplaza { get; set; }//"N009-OTM00000032";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoSentado { get; set; }//"N009-OTM00000033";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoPie { get; set; }//"N009-OTM00000034";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoTracciona { get; set; }//"N009-OTM00000035";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoEmpuja { get; set; }//"N009-OTM00000036";//System.Windows.Forms.ComboBox();
            public string cbo2RiesgoColoca { get; set; }//"N009-OTM00000037";//System.Windows.Forms.ComboBox();
            public string cboEjeLordosisCervical { get; set; }//"N009-OTM00000038";//System.Windows.Forms.ComboBox();
            public string cboEjeCifosisDorsal { get; set; }//"N009-OTM00000039";//System.Windows.Forms.ComboBox();
            public string cboEjeLordosisLumbar { get; set; }//"N009-OTM00000040";//System.Windows.Forms.ComboBox();
            public string cboRotacionExt { get; set; }//"N009-OTM00000041";//System.Windows.Forms.ComboBox();
            public string cboRotacionInt { get; set; }//"N009-OTM00000042";//System.Windows.Forms.ComboBox();
            public string cboInversion { get; set; }//"N009-OTM00000043";//System.Windows.Forms.ComboBox();
            public string cboPlantiflexion { get; set; }//"N009-OTM00000044";//System.Windows.Forms.ComboBox();
            public string cboEversion { get; set; }//"N009-OTM00000045";//System.Windows.Forms.ComboBox();
            public string cboDorsoflexion { get; set; }//"N009-OTM00000046";//System.Windows.Forms.ComboBox();
            public string cboMmiiFlexion { get; set; }//"N009-OTM00000047";//System.Windows.Forms.ComboBox();
            public string cboMmiiExtension { get; set; }//"N009-OTM00000048";//System.Windows.Forms.ComboBox();
            public string cboMmiiContraResistencia { get; set; }//"N009-OTM00000049";//System.Windows.Forms.ComboBox();
            public string cboCircunduccion { get; set; }//"N009-OTM00000050";//System.Windows.Forms.ComboBox();
            public string cboDesviacionRadial { get; set; }//"N009-OTM00000051";//System.Windows.Forms.ComboBox();
            public string cboExtension { get; set; }//"N009-OTM00000052";//System.Windows.Forms.ComboBox();
            public string cboDesviacionCubital { get; set; }//"N009-OTM00000053";//System.Windows.Forms.ComboBox();
            public string cboFlexion { get; set; }//"N009-OTM00000054";//System.Windows.Forms.ComboBox();
            public string cboGenuvaro { get; set; }//"N009-OTM00000055";//System.Windows.Forms.ComboBox();
            public string cboGenuvalgo { get; set; }//"N009-OTM00000056";//System.Windows.Forms.ComboBox();
            public string cboPieCavo { get; set; }//"N009-OTM00000057";//System.Windows.Forms.ComboBox();
            public string cboPiePlano { get; set; }//"N009-OTM00000058";//System.Windows.Forms.ComboBox();
            public string cboEvaPropicepcion { get; set; }//"N009-OTM00000059";//System.Windows.Forms.ComboBox();
            public string cboPruebaMancuerda { get; set; }//"N009-OTM00000060";//System.Windows.Forms.ComboBox();
            public string cboRotulianoIzq { get; set; }//"N009-OTM00000061";//System.Windows.Forms.ComboBox();
            public string cboRotulianoDer { get; set; }//"N009-OTM00000062";//System.Windows.Forms.ComboBox();
            public string cboLasegueIzq { get; set; }//"N009-OTM00000063";//System.Windows.Forms.ComboBox();
            public string cboSchoverIzq { get; set; }//"N009-OTM00000064";//System.Windows.Forms.ComboBox();
            public string cboSchoverDer { get; set; }//"N009-OTM00000065";//System.Windows.Forms.ComboBox();
            public string cboLasegueDer { get; set; }//"N009-OTM00000066";//System.Windows.Forms.ComboBox();
            public string cboPhalenIzq { get; set; }//"N009-OTM00000067";//System.Windows.Forms.ComboBox();
            public string cboTinelIzq { get; set; }//"N009-OTM00000068";//System.Windows.Forms.ComboBox();
            public string cboTinelDer { get; set; }//"N009-OTM00000069";//System.Windows.Forms.ComboBox();
            public string cboPhalenDer { get; set; }//"N009-OTM00000070";//System.Windows.Forms.ComboBox();
            public string cboPalpacionDolor { get; set; }//"N009-OTM00000071";//System.Windows.Forms.ComboBox();
            public string cboPalpacionContractura { get; set; }//"N009-OTM00000072";//System.Windows.Forms.ComboBox();
            public string cboPalpacionApofisis { get; set; }//"N009-OTM00000073";//System.Windows.Forms.ComboBox();
            public string txtPalpacionDolor { get; set; }//"N009-OTM00000074";//System.Windows.Forms.TextBox();
            public string txtPalpacionContractura { get; set; }//"N009-OTM00000075";//System.Windows.Forms.TextBox();
            public string txtPalpacionApofisis { get; set; }//"N009-OTM00000076";//System.Windows.Forms.TextBox();
            public string cboLumbatExtension { get; set; }//"N009-OTM00000077";//System.Windows.Forms.ComboBox();
            public string cboLumbatFlexion { get; set; }//"N009-OTM00000078";//System.Windows.Forms.ComboBox();
            public string cboCervicalExtension { get; set; }//"N009-OTM00000079";//System.Windows.Forms.ComboBox();
            public string cboCervicalFlexion { get; set; }//"N009-OTM00000080";//System.Windows.Forms.ComboBox();
            public string cboLumbatLateIzquierda { get; set; }//"N009-OTM00000081";//System.Windows.Forms.ComboBox();
            public string LumbatLateDerecha { get; set; }//"N009-OTM00000082";//System.Windows.Forms.ComboBox();
            public string LumbatRotacionIzquierda { get; set; }//"N009-OTM00000083";//System.Windows.Forms.ComboBox();
            public string LumbatRotacionDerecha { get; set; }//"N009-OTM00000084";//System.Windows.Forms.ComboBox();
            public string CervicalLateIzquierda { get; set; }//"N009-OTM00000085";//System.Windows.Forms.ComboBox();
            public string CervicalLateDerecha { get; set; }//"N009-OTM00000086";//System.Windows.Forms.ComboBox();
            public string CervicalRotaIzquierda { get; set; }//"N009-OTM00000087";//System.Windows.Forms.ComboBox();
            public string CervicalRotaDerecha { get; set; }//"N009-OTM00000088";//System.Windows.Forms.ComboBox();
            public string LumbatIrradiacion { get; set; }//"N009-OTM00000089";//System.Windows.Forms.ComboBox();
            public string CervicalIrradiacion { get; set; }//"N009-OTM00000090";//System.Windows.Forms.ComboBox();
            public string AsimetriaEscoliosis { get; set; }//"N009-OTM00000091";//System.Windows.Forms.ComboBox();
            public string AsimetriaHombros { get; set; }//"N009-OTM00000092";//System.Windows.Forms.ComboBox();
            public string AsimetriaLumbar { get; set; }//"N009-OTM00000093";//System.Windows.Forms.ComboBox();
            public string AsimetriaCaderas { get; set; }//"N009-OTM00000094";//System.Windows.Forms.ComboBox();
            public string AsimetriaHipercifocis { get; set; }//"N009-OTM00000095";//System.Windows.Forms.ComboBox();
            public string AsimetriaRodillas { get; set; }//"N009-OTM00000096";//System.Windows.Forms.ComboBox();
            public string EquilibrioLateralIzquierdo { get; set; }//"N009-OTM00000097";//System.Windows.Forms.ComboBox();
            public string EquilibrioLateralDerecho { get; set; }//"N009-OTM00000098";//System.Windows.Forms.ComboBox();
            public string EquilibrioPosterior { get; set; }//"N009-OTM00000099";//System.Windows.Forms.ComboBox();
            public string EquilibrioAnterior { get; set; }//"N009-OTM00000100";//System.Windows.Forms.ComboBox();
            public string MarchaClaudicacion { get; set; }//"N009-OTM00000101";//System.Windows.Forms.ComboBox();
            public string TobilloIzqRotInt { get; set; }//"N009-OTM00000102";//System.Windows.Forms.ComboBox();
            public string RodillaIzqRotInt { get; set; }//"N009-OTM00000103";//System.Windows.Forms.ComboBox();
            public string CaderaIzqRotInt { get; set; }//"N009-OTM00000104";//System.Windows.Forms.ComboBox();
            public string MunecaIzqRotInt { get; set; }//"N009-OTM00000105";//System.Windows.Forms.ComboBox();
            public string CodoIzqRotInt { get; set; }//"N009-OTM00000106";//System.Windows.Forms.ComboBox();
            public string HombroIzqRotInt { get; set; }//"N009-OTM00000107";//System.Windows.Forms.ComboBox();
            public string TobilloIzqExtension { get; set; }//"N009-OTM00000108";//System.Windows.Forms.ComboBox();
            public string RodillaIzqExtension { get; set; }//"N009-OTM00000109";//System.Windows.Forms.ComboBox();
            public string CaderaIzqExtension { get; set; }//"N009-OTM00000110";//System.Windows.Forms.ComboBox();
            public string MunecaIzqExtension { get; set; }//"N009-OTM00000111";//System.Windows.Forms.ComboBox();
            public string CodoIzqExtension { get; set; }//"N009-OTM00000112";//System.Windows.Forms.ComboBox();
            public string TobilloIzqFlexion { get; set; }//"N009-OTM00000113";//System.Windows.Forms.ComboBox();
            public string RodillaIzqFlexion { get; set; }//"N009-OTM00000114";//System.Windows.Forms.ComboBox();
            public string CaderaIzqFlexion { get; set; }//"N009-OTM00000115";//System.Windows.Forms.ComboBox();
            public string MunecaIzqFlexion { get; set; }//"N009-OTM00000116";//System.Windows.Forms.ComboBox();
            public string HombroIzqExtension { get; set; }//"N009-OTM00000117";//System.Windows.Forms.ComboBox();
            public string CodoIzqFlexion { get; set; }//"N009-OTM00000118";//System.Windows.Forms.ComboBox();
            public string TobilloDerRotInt { get; set; }//"N009-OTM00000119";//System.Windows.Forms.ComboBox();
            public string RodillaDerRotInt { get; set; }//"N009-OTM00000120";//System.Windows.Forms.ComboBox();
            public string CaderaDerRotInt { get; set; }//"N009-OTM00000121";//System.Windows.Forms.ComboBox();
            public string MunecaDerRotInt { get; set; }//"N009-OTM00000122";//System.Windows.Forms.ComboBox();
            public string HombroIzqFlexion { get; set; }//"N009-OTM00000123";//System.Windows.Forms.ComboBox();
            public string CodoDerRotInt { get; set; }//"N009-OTM00000124";//System.Windows.Forms.ComboBox();
            public string TobilloDerExtension { get; set; }//"N009-OTM00000125";//System.Windows.Forms.ComboBox();
            public string RodillaDerExtension { get; set; }//"N009-OTM00000126";//System.Windows.Forms.ComboBox();
            public string CaderaDerExtension { get; set; }//"N009-OTM00000127";//System.Windows.Forms.ComboBox();
            public string MunecaDerExtension { get; set; }//"N009-OTM00000128";//System.Windows.Forms.ComboBox();
            public string HombroDerRotInt { get; set; }//"N009-OTM00000129";//System.Windows.Forms.ComboBox();
            public string CodoDerExtension { get; set; }//"N009-OTM00000130";//System.Windows.Forms.ComboBox();
            public string TobilloDerFlexion { get; set; }//"N009-OTM00000131";//System.Windows.Forms.ComboBox();
            public string RodillaDerFlexion { get; set; }//"N009-OTM00000132";//System.Windows.Forms.ComboBox();
            public string CaderaDerFlexion { get; set; }//"N009-OTM00000133";//System.Windows.Forms.ComboBox();
            public string MunecaDerFlexion { get; set; }//"N009-OTM00000134";//System.Windows.Forms.ComboBox();
            public string HombroDerExtension { get; set; }//"N009-OTM00000135";//System.Windows.Forms.ComboBox();
            public string CodoDerFlexion { get; set; }//"N009-OTM00000136";//System.Windows.Forms.ComboBox();
            public string HombroDerFlexion { get; set; }//"N009-OTM00000137";//System.Windows.Forms.ComboBox();
            public string TobilloIzqTono { get; set; }//"N009-OTM00000138";//System.Windows.Forms.ComboBox();
            public string RodillaIzqTono { get; set; }//"N009-OTM00000139";//System.Windows.Forms.ComboBox();
            public string CaderaIzqTono { get; set; }//"N009-OTM00000140";//System.Windows.Forms.ComboBox();
            public string TobilloIzqFuerza { get; set; }//"N009-OTM00000141";//System.Windows.Forms.ComboBox();
            public string MunecaIzqTono { get; set; }//"N009-OTM00000142";//System.Windows.Forms.ComboBox();
            public string RodillaIzqFuerza { get; set; }//"N009-OTM00000143";//System.Windows.Forms.ComboBox();
            public string CaderaIzqFuerza { get; set; }//"N009-OTM00000144";//System.Windows.Forms.ComboBox();
            public string CodoIzqTono { get; set; }//"N009-OTM00000145";//System.Windows.Forms.ComboBox();
            public string TobilloIzqAbduccion { get; set; }//"N009-OTM00000146";//System.Windows.Forms.ComboBox();
            public string MunecaIzqFuerza { get; set; }//"N009-OTM00000147";//System.Windows.Forms.ComboBox();
            public string RodillaIzqAbduccion { get; set; }//"N009-OTM00000148";//System.Windows.Forms.ComboBox();
            public string CaderaIzqAbduccion { get; set; }//"N009-OTM00000149";//System.Windows.Forms.ComboBox();
            public string CodoIzqFuerza { get; set; }//"N009-OTM00000150";//System.Windows.Forms.ComboBox();
            public string TobilloIzqAduccion { get; set; }//"N009-OTM00000151";//System.Windows.Forms.ComboBox();
            public string MunecaIzqAbduccion { get; set; }//"N009-OTM00000152";//System.Windows.Forms.ComboBox();
            public string RodillaIzqAduccion { get; set; }//"N009-OTM00000153";//System.Windows.Forms.ComboBox();
            public string HombroIzqTono { get; set; }//"N009-OTM00000154";//System.Windows.Forms.ComboBox();
            public string CaderaIzqAduccion { get; set; }//"N009-OTM00000155";//System.Windows.Forms.ComboBox();
            public string CodoIzqAbduccion { get; set; }//"N009-OTM00000156";//System.Windows.Forms.ComboBox();
            public string TobilloIzqRotExt { get; set; }//"N009-OTM00000157";//System.Windows.Forms.ComboBox();
            public string MunecaIzqAduccion { get; set; }//"N009-OTM00000158";//System.Windows.Forms.ComboBox();
            public string RodillaIzqRotExt { get; set; }//"N009-OTM00000159";//System.Windows.Forms.ComboBox();
            public string HombroIzqFuerza { get; set; }//"N009-OTM00000160";//System.Windows.Forms.ComboBox();
            public string CaderaIzqRotExt { get; set; }//"N009-OTM00000161";//System.Windows.Forms.ComboBox();
            public string CodoIzqAduccion { get; set; }//"N009-OTM00000162";//System.Windows.Forms.ComboBox();
            public string TobilloDerTono { get; set; }//"N009-OTM00000163";//System.Windows.Forms.ComboBox();
            public string MunecaIzqRotExt { get; set; }//"N009-OTM00000164";//System.Windows.Forms.ComboBox();
            public string RodillaDerTono { get; set; }//"N009-OTM00000165";//System.Windows.Forms.ComboBox();
            public string HombroIzqAbduccion { get; set; }//"N009-OTM00000166";//System.Windows.Forms.ComboBox();
            public string CaderaDerTono { get; set; }//"N009-OTM00000167";//System.Windows.Forms.ComboBox();
            public string CodoIzqRotExt { get; set; }//"N009-OTM00000168";//System.Windows.Forms.ComboBox();
            public string TobilloDerFuerza { get; set; }//"N009-OTM00000169";//System.Windows.Forms.ComboBox();
            public string MunecaDerTono { get; set; }//"N009-OTM00000170";//System.Windows.Forms.ComboBox();
            public string RodillaDerFuerza { get; set; }//"N009-OTM00000171";//System.Windows.Forms.ComboBox();
            public string HombroIzqAduccion { get; set; }//"N009-OTM00000172";//System.Windows.Forms.ComboBox();
            public string CaderaDerFuerza { get; set; }//"N009-OTM00000173";//System.Windows.Forms.ComboBox();
            public string CodoDerTono { get; set; }//"N009-OTM00000174";//System.Windows.Forms.ComboBox();
            public string TobilloDerAbduccion { get; set; }//"N009-OTM00000175";//System.Windows.Forms.ComboBox();
            public string MunecaDerFuerza { get; set; }//"N009-OTM00000176";//System.Windows.Forms.ComboBox();
            public string RodillaDerAbduccion { get; set; }//"N009-OTM00000177";//System.Windows.Forms.ComboBox();
            public string HombroIzqRotExt { get; set; }//"N009-OTM00000178";//System.Windows.Forms.ComboBox();
            public string CaderaDerAbduccion { get; set; }//"N009-OTM00000179";//System.Windows.Forms.ComboBox();
            public string CodoDerFuerza { get; set; }//"N009-OTM00000180";//System.Windows.Forms.ComboBox();
            public string TobilloDerAduccion { get; set; }//"N009-OTM00000181";//System.Windows.Forms.ComboBox();
            public string MunecaDerAbduccion { get; set; }//"N009-OTM00000182";//System.Windows.Forms.ComboBox();
            public string RodillaDerAduccion { get; set; }//"N009-OTM00000183";//System.Windows.Forms.ComboBox();
            public string HombroDerTono { get; set; }//"N009-OTM00000184";//System.Windows.Forms.ComboBox();
            public string CaderaDerAduccion { get; set; }//"N009-OTM00000185";//System.Windows.Forms.ComboBox();
            public string CodoDerAbduccion { get; set; }//"N009-OTM00000186";//System.Windows.Forms.ComboBox();
            public string TobilloDerRotExt { get; set; }//"N009-OTM00000187";//System.Windows.Forms.ComboBox();
            public string MunecaDerAduccion { get; set; }//"N009-OTM00000189";//System.Windows.Forms.ComboBox();
            public string RodillaDerRotExt { get; set; }//"N009-OTM00000190";//System.Windows.Forms.ComboBox();
            public string HombroDerFuerza { get; set; }//"N009-OTM00000191";//System.Windows.Forms.ComboBox();
            public string CaderaDerRotExt { get; set; }//"N009-OTM00000192";//System.Windows.Forms.ComboBox();
            public string CodoDerAduccion { get; set; }//"N009-OTM00000193";//System.Windows.Forms.ComboBox();
            public string TobilloIzqDolor { get; set; }//"N009-OTM00000194";//System.Windows.Forms.ComboBox();
            public string MunecaDerRotExt { get; set; }//"N009-OTM00000195";//System.Windows.Forms.ComboBox();
            public string RodillaIzqDolor { get; set; }//"N009-OTM00000196";//System.Windows.Forms.ComboBox();
            public string HombroDerAbduccion { get; set; }//"N009-OTM00000197";//System.Windows.Forms.ComboBox();
            public string CaderaIzqDolor { get; set; }//"N009-OTM00000198";//System.Windows.Forms.ComboBox();
            public string CodoDerRotExt { get; set; }//"N009-OTM00000199";//System.Windows.Forms.ComboBox();
            public string TobilloDerDolor { get; set; }//"N009-OTM00000200";//System.Windows.Forms.ComboBox();
            public string MunecaIzqDolor { get; set; }//"N009-OTM00000201";//System.Windows.Forms.ComboBox();
            public string RodillaDerDolor { get; set; }//"N009-OTM00000202";//System.Windows.Forms.ComboBox();
            public string HombroDerAduccion { get; set; }//"N009-OTM00000203";//System.Windows.Forms.ComboBox();
            public string CaderaDerDolor { get; set; }//"N009-OTM00000204";//System.Windows.Forms.ComboBox();
            public string CodoIzqDolor { get; set; }//"N009-OTM00000205";//System.Windows.Forms.ComboBox();
            public string MunecaDerDolor { get; set; }//"N009-OTM00000206";//System.Windows.Forms.ComboBox();
            public string HombroDerRotExt { get; set; }//"N009-OTM00000207";//System.Windows.Forms.ComboBox();
            public string CodoDerDolor { get; set; }//"N009-OTM00000208";//System.Windows.Forms.ComboBox();
            public string HombroIzqDolor { get; set; }//"N009-OTM00000209";//System.Windows.Forms.ComboBox();
            public string HombroDerDolor { get; set; }//"N009-OTM00000210";//System.Windows.Forms.ComboBox();
            public string CodoIzqSupinacion { get; set; }//"N009-OTM00000211";//System.Windows.Forms.ComboBox();
            public string CodoIzqPronacion { get; set; }//"N009-OTM00000212";//System.Windows.Forms.ComboBox();
            public string CodoDerSupinacion { get; set; }//"N009-OTM00000213";//System.Windows.Forms.ComboBox();
            public string CodoDerPronacion { get; set; }//"N009-OTM00000214";//System.Windows.Forms.ComboBox();
            public string MunecaIzqRadial { get; set; }//"N009-OTM00000215";//System.Windows.Forms.ComboBox();
            public string MunecaIzqCubital { get; set; }//"N009-OTM00000216";//System.Windows.Forms.ComboBox();
            public string MunecaDerRadial { get; set; }//"N009-OTM00000217";//System.Windows.Forms.ComboBox();
            public string MunecaDerCubital { get; set; }//"N009-OTM00000218";//System.Windows.Forms.ComboBox();
            public string MunecaIzqInversion { get; set; }//"N009-OTM00000219";//System.Windows.Forms.ComboBox();
            public string MunecaIzqEversion { get; set; }//"N009-OTM00000220";//System.Windows.Forms.ComboBox();
            public string MunecaDerInversion { get; set; }//"N009-OTM00000221";//System.Windows.Forms.ComboBox();
            public string MunecaDerEversion { get; set; }//"N009-OTM00000222";//System.Windows.Forms.ComboBox();
            public string txtDescripcionHallazgos { get; set; }//"N009-OTM00000223";//System.Windows.Forms.TextBox();
            public string Conclusiones { get; set; }//"N009-OTM00000224";//System.Windows.Forms.ComboBox();


            public string rbAbdomenExcelente { get; set; }//"N009-OTM00000225";
            public string rbAbdomenPromedio { get; set; }//"N009-OTM00000225";
            public string rbAbdomenRegular { get; set; }//"N009-OTM00000226";
            public string rbAbdomenPobre { get; set; }//"N009-OTM00000227";
            public string txtAbdomenPuntos { get; set; }//"N009-OTM00000228";
            public string txtAbdomenObservaciones { get; set; }//"N009-OTM00000229";

            public string rbCaderaExcelente { get; set; }//"N009-OTM00000230";
            public string rbCaderaPromedio { get; set; }//"N009-OTM00000231";
            public string rbCaderaRegular { get; set; }//"N009-OTM00000232";
            public string rbCaderaPobre { get; set; }//"N009-OTM00000233";
            public string txtCaderaPuntos { get; set; }//"N009-OTM00000234";
            public string txtCaderaOnservaciones { get; set; }//"N009-OTM00000235";

            public string rbMusloExcelente { get; set; }//"N009-OTM00000236";
            public string rbMusloPromedio { get; set; }//"N009-OTM00000237";
            public string rbMusloRegular { get; set; }//"N009-OTM00000238";
            public string rbMusloPobre { get; set; }//"N009-OTM00000239";
            public string txtMusloPuntos { get; set; }//"N009-OTM00000240";
            public string txtMusloObservaciones { get; set; }//"N009-OTM00000241";

            public string rbAbdomenLateralExcelente { get; set; }//"N009-OTM00000242";
            public string rbAbdomenLateralPromedio { get; set; }//"N009-OTM00000243";
            public string rbAbdomenLateralRegular { get; set; }//"N009-OTM00000244";
            public string rbAbdomenLateralPobre { get; set; }//"N009-OTM00000245";
            public string txtAbdomenLateralPuntos { get; set; }//"N009-OTM00000246";
            public string txtAbdomenLateralObservaciones { get; set; }//"N009-OTM00000247";

            public string rbAbduccion180Optimo { get; set; }//"N009-OTM00000248";
            public string rbAbduccion180Limitado { get; set; }//"N009-OTM00000249";
            public string rbAbduccion180MuyLimitado { get; set; }//"N009-OTM00000250";
            public string txtAbduccion180Puntos { get; set; }//"N009-OTM00000251";
            public string rbAbduccion180DolorSI { get; set; }//"N009-OTM00000252";
            public string rbAbduccion180DolorNO { get; set; }//"N009-OTM00000253";

            public string rbAbduccion60Optimo { get; set; }//"N009-OTM00000254";
            public string rbAbduccion60Limitado { get; set; }//"N009-OTM00000255";
            public string rbAbduccion60MuyLimitado { get; set; }//"N009-OTM00000256";
            public string txtAbduccion60Puntos { get; set; }//"N009-OTM00000257";
            public string rbAbduccion60DolorSI { get; set; }//"N009-OTM00000258";
            public string rbAbduccion60DolorNO { get; set; }//"N009-OTM00000259";

            public string rbRotacion090Optimo { get; set; }//"N009-OTM00000260";
            public string rbRotacion090Limitado { get; set; }//"N009-OTM00000261";
            public string rbRotacion090MuyLimitado { get; set; }//"N009-OTM00000262";
            public string txtRotacion090Puntos { get; set; }//"N009-OTM00000263";
            public string rbRotacion090DolorSI { get; set; }//"N009-OTM00000264";
            public string rbRotacion090DolorNO { get; set; }//"N009-OTM00000265";

            public string rbRotacionExtIntOptimo { get; set; }//"N009-OTM00000266";
            public string rbRotacionExtIntLimitado { get; set; }//"N009-OTM00000267";
            public string rbRotacionExtIntMuyLimitado { get; set; }//"N009-OTM00000268";
            public string txtRotacionExtIntPuntos { get; set; }//"N009-OTM00000269";
            public string rbRotacionExtIntDolorSI { get; set; }//"N009-OTM00000270";
            public string rbRotacionExtIntDolorNO { get; set; }//"N009-OTM00000271";
            public string txtTotalAptitudEspalda { get; set; }//"N009-OTM00000272";
            public string txtTotalRangos { get; set; }//"N009-OTM00000273";
    }
}
