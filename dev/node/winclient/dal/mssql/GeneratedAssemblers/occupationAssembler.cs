//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2016/12/21 - 09:57:46
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Node.WinClient.DAL;

namespace Sigesoft.Node.WinClient.BE
{

    /// <summary>
    /// Assembler for <see cref="occupation"/> and <see cref="occupationDto"/>.
    /// </summary>
    public static partial class occupationAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="occupationDto"/> converted from <see cref="occupation"/>.</param>
        static partial void OnDTO(this occupation entity, occupationDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="occupation"/> converted from <see cref="occupationDto"/>.</param>
        static partial void OnEntity(this occupationDto dto, occupation entity);

        /// <summary>
        /// Converts this instance of <see cref="occupationDto"/> to an instance of <see cref="occupation"/>.
        /// </summary>
        /// <param name="dto"><see cref="occupationDto"/> to convert.</param>
        public static occupation ToEntity(this occupationDto dto)
        {
            if (dto == null) return null;

            var entity = new occupation();

            entity.v_OccupationId = dto.v_OccupationId;
            entity.v_GesId = dto.v_GesId;
            entity.v_GroupOccupationId = dto.v_GroupOccupationId;
            entity.v_Name = dto.v_Name;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="occupation"/> to an instance of <see cref="occupationDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="occupation"/> to convert.</param>
        public static occupationDto ToDTO(this occupation entity)
        {
            if (entity == null) return null;

            var dto = new occupationDto();

            dto.v_OccupationId = entity.v_OccupationId;
            dto.v_GesId = entity.v_GesId;
            dto.v_GroupOccupationId = entity.v_GroupOccupationId;
            dto.v_Name = entity.v_Name;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="occupationDto"/> to an instance of <see cref="occupation"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<occupation> ToEntities(this IEnumerable<occupationDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="occupation"/> to an instance of <see cref="occupationDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<occupationDto> ToDTOs(this IEnumerable<occupation> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
