//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2016/12/21 - 09:57:15
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    [DataContract()]
    public partial class nodeserviceprofileDto
    {
        [DataMember()]
        public String v_NodeServiceProfileId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NodeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ServiceTypeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_MasterServiceId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsDeleted { get; set; }

        [DataMember()]
        public Nullable<Int32> i_InsertUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_InsertDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_UpdateUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_UpdateDate { get; set; }

        [DataMember()]
        public nodeDto node { get; set; }

        public nodeserviceprofileDto()
        {
        }

        public nodeserviceprofileDto(String v_NodeServiceProfileId, Nullable<Int32> i_NodeId, Nullable<Int32> i_ServiceTypeId, Nullable<Int32> i_MasterServiceId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, nodeDto node)
        {
			this.v_NodeServiceProfileId = v_NodeServiceProfileId;
			this.i_NodeId = i_NodeId;
			this.i_ServiceTypeId = i_ServiceTypeId;
			this.i_MasterServiceId = i_MasterServiceId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.node = node;
        }
    }
}
