﻿using Sigesoft.Common;
using Sigesoft.Node.WinClient.BE;
using Sigesoft.Node.WinClient.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sigesoft.Node.WinClient.UI
{
    public partial class frmAddExam : Form
    {
        #region Declarations
        public CalendarBL _calendarBL = new CalendarBL();
        public List<ServiceComponentList> _auxiliaryExams = null;    
        public string _serviceId;

        #endregion

        #region Properties

        private string MedicalExamId { get; set; }
        private string MedicalExamName { get; set; }
        private string CategoryName { get; set; }
        private string ServiceComponentConcatId { get; set; }

        #endregion

        public frmAddExam()
        {
            InitializeComponent();
        }

        private void btnAgregarExamenAuxiliar_Click(object sender, EventArgs e)
        {
            AddAuxiliaryExam();   
        }

        private void AddAuxiliaryExam()
        {
            var findResult = lvExamenesSeleccionados.FindItemWithText(MedicalExamId);

            // El examen ya esta agregado
            if (findResult != null)
            {
                MessageBox.Show("Por favor seleccione otro examen.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = new ListViewItem(new[] { MedicalExamName, MedicalExamId, ServiceComponentConcatId });

            lvExamenesSeleccionados.Items.Add(row);

            gbExamenesSeleccionados.Text = string.Format("Examenes Seleccionados {0}", lvExamenesSeleccionados.Items.Count);
        }

        private void grdDataServiceComponent_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            btnAgregarExamenAuxiliar.Enabled = (grdDataServiceComponent.Selected.Rows.Count > 0);
            lvExamenesSeleccionados.SelectedItems.Clear();

            if (grdDataServiceComponent.Selected.Rows.Count == 0)
                return;

            MedicalExamId = grdDataServiceComponent.Selected.Rows[0].Cells["v_ComponentId"].Value.ToString();
            MedicalExamName = grdDataServiceComponent.Selected.Rows[0].Cells["v_ComponentName"].Value.ToString();
            ServiceComponentConcatId = grdDataServiceComponent.Selected.Rows[0].Cells["v_ServiceComponentConcatId"].Value.ToString();

            if (grdDataServiceComponent.Selected.Rows[0].Cells["v_CategoryName"].Value != null)
            {
                CategoryName = grdDataServiceComponent.Selected.Rows[0].Cells["v_CategoryName"].Value.ToString();
            }
            else
            {
                CategoryName = string.Empty;
            }

          

        }

        private void btnRemoverExamenAuxiliar_Click(object sender, EventArgs e)
        {
            var selectedItem = lvExamenesSeleccionados.SelectedItems[0];
            var medicalExamId = selectedItem.SubItems[1].Text;

            // Eliminacion fisica
            lvExamenesSeleccionados.Items.Remove(selectedItem);
            gbExamenesSeleccionados.Text = string.Format("Examenes Seleccionados {0}", lvExamenesSeleccionados.Items.Count);

           

        }

        private void frmAddAdditionalExam_Load(object sender, EventArgs e)
        {
            ServiceBL objServiceBL = new ServiceBL();
            OperationResult objOperationResult = new OperationResult();

            var ListServiceComponent = objServiceBL.GetAllComponents(ref objOperationResult);
            grdDataServiceComponent.DataSource = ListServiceComponent;
            ultraGrid1.DataSource = ListServiceComponent;
        }

        private void lvExamenesSeleccionados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnRemoverExamenAuxiliar.Enabled = (lvExamenesSeleccionados.SelectedItems.Count > 0);
        }

        private void grdDataServiceComponent_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            AddAuxiliaryExam();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_auxiliaryExams == null)
                _auxiliaryExams = new List<ServiceComponentList>();

            // Save ListView / recorrer la lista de examenes seleccionados
            foreach (ListViewItem item in lvExamenesSeleccionados.Items)
            {
                var fields = item.SubItems;
                var serviceComponentConcatId = fields[1].Text.Split('|');
                var NombreComponente = fields[0].Text.Split('|');

                foreach (var scid in serviceComponentConcatId)
                {
                    FormPrecioComponente frm = new FormPrecioComponente(NombreComponente[0].ToString());        
                   
                    frm.ShowDialog();
                 
                    ServiceComponentList auxiliaryExam = new ServiceComponentList();
                    //auxiliaryExam.v_ServiceComponentId = scid;
                    //_auxiliaryExams.Add(auxiliaryExam);

                    servicecomponentDto objServiceComponentDto = new servicecomponentDto();
                    OperationResult objOperationResult = new OperationResult();
                    ServiceBL _ObjServiceBL = new ServiceBL();

                    objServiceComponentDto.v_ServiceId = _serviceId;
                    objServiceComponentDto.i_ExternalInternalId = (int)Common.ComponenteProcedencia.Interno;
                    objServiceComponentDto.i_ServiceComponentTypeId = 1;
                    objServiceComponentDto.i_IsVisibleId = 1;
                    objServiceComponentDto.i_IsInheritedId = (int)Common.SiNo.NO;
                    objServiceComponentDto.d_StartDate = null;
                    objServiceComponentDto.d_EndDate = null;
                    objServiceComponentDto.i_index = 1;
                    objServiceComponentDto.r_Price = frm.Precio;
                    objServiceComponentDto.v_ComponentId = scid;
                    objServiceComponentDto.i_IsInvoicedId = (int)Common.SiNo.NO;
                    objServiceComponentDto.i_ServiceComponentStatusId = (int)Common.ServiceStatus.PorIniciar;
                    objServiceComponentDto.i_QueueStatusId = (int)Common.QueueStatusId.LIBRE;
                    //objServiceComponentDto.i_IsRequiredId = (int)Common.SiNo.SI;
                    objServiceComponentDto.i_Iscalling = (int)Common.Flag_Call.NoseLlamo;
                    //objServiceComponentDto.i_Iscalling_1 = (int)Common.Flag_Call.NoseLlamo;
                    objServiceComponentDto.i_IsManuallyAddedId = (int)Common.SiNo.NO;
                    objServiceComponentDto.i_IsRequiredId = (int)Common.SiNo.SI;


                    //_calendarBL.UpdateAdditionalExam(_auxiliaryExams, _serviceId, (int?)SiNo.SI, Globals.ClientSession.GetAsList());
                    _ObjServiceBL.AddServiceComponent(ref objOperationResult, objServiceComponentDto, Globals.ClientSession.GetAsList());
                }             
            }
          
            MessageBox.Show("Se grabo correctamente", " ¡ INFORMACIÓN !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void ultraGrid1_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {

            if (ultraGrid1.Selected.Rows[0].Cells["v_ComponentId"].Value == null)
            {
                btnAgregarExamenAuxiliar.Enabled =false;

                return;
            }
            else
            {
                btnAgregarExamenAuxiliar.Enabled = true;
            }

            lvExamenesSeleccionados.SelectedItems.Clear();

            if (ultraGrid1.Selected.Rows.Count == 0)
                return;

            MedicalExamId = ultraGrid1.Selected.Rows[0].Cells["v_ComponentId"].Value.ToString();
            MedicalExamName = ultraGrid1.Selected.Rows[0].Cells["v_ComponentName"].Value.ToString();
            //ServiceComponentConcatId = ultraGrid1.Selected.Rows[0].Cells["v_ServiceComponentId"].Value.ToString();

            if (ultraGrid1.Selected.Rows[0].Cells["v_ComponentId"].Value != null)
            {
                MedicalExamName = ultraGrid1.Selected.Rows[0].Cells["v_ComponentName"].Value.ToString();
            }
            else
            {
                MedicalExamName = string.Empty;
            }
        }

       
    }
}
