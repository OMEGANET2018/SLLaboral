﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    public class FacturacionDetalleList
    {

        public string v_FacturacionDetalleId { get; set; }
        public string v_FacturacionId { get; set; }
        public string v_ServicioId { get; set; }
        public decimal? d_Monto { get; set; }
        public DateTime? d_ServiceDate { get; set; }
        public string v_PersonId { get; set; }

        public string Trabajador { get; set; }

        public int i_IsDeleted { get; set; }
        public string v_CreationUser { get; set; }
        public string v_UpdateUser { get; set; }
        public DateTime? d_CreationDate { get; set; }
        public DateTime? d_UpdateDate { get; set; }
    }
}
