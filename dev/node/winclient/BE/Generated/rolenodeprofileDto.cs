//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2016/12/21 - 09:57:27
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
    public partial class rolenodeprofileDto
    {
        [DataMember()]
        public Int32 i_NodeId { get; set; }

        [DataMember()]
        public Int32 i_RoleId { get; set; }

        [DataMember()]
        public Int32 i_ApplicationHierarchyId { get; set; }

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
        public applicationhierarchyDto applicationhierarchy { get; set; }

        public rolenodeprofileDto()
        {
        }

        public rolenodeprofileDto(Int32 i_NodeId, Int32 i_RoleId, Int32 i_ApplicationHierarchyId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, applicationhierarchyDto applicationhierarchy)
        {
			this.i_NodeId = i_NodeId;
			this.i_RoleId = i_RoleId;
			this.i_ApplicationHierarchyId = i_ApplicationHierarchyId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.applicationhierarchy = applicationhierarchy;
        }
    }
}
