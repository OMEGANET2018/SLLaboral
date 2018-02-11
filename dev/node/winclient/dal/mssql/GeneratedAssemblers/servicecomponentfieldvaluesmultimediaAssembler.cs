//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2016/12/21 - 09:57:53
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
    /// Assembler for <see cref="servicecomponentfieldvaluesmultimedia"/> and <see cref="servicecomponentfieldvaluesmultimediaDto"/>.
    /// </summary>
    public static partial class servicecomponentfieldvaluesmultimediaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentfieldvaluesmultimediaDto"/> converted from <see cref="servicecomponentfieldvaluesmultimedia"/>.</param>
        static partial void OnDTO(this servicecomponentfieldvaluesmultimedia entity, servicecomponentfieldvaluesmultimediaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentfieldvaluesmultimedia"/> converted from <see cref="servicecomponentfieldvaluesmultimediaDto"/>.</param>
        static partial void OnEntity(this servicecomponentfieldvaluesmultimediaDto dto, servicecomponentfieldvaluesmultimedia entity);

        /// <summary>
        /// Converts this instance of <see cref="servicecomponentfieldvaluesmultimediaDto"/> to an instance of <see cref="servicecomponentfieldvaluesmultimedia"/>.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentfieldvaluesmultimediaDto"/> to convert.</param>
        public static servicecomponentfieldvaluesmultimedia ToEntity(this servicecomponentfieldvaluesmultimediaDto dto)
        {
            if (dto == null) return null;

            var entity = new servicecomponentfieldvaluesmultimedia();

            entity.v_ServiceComponentFieldValuesMultimediaId = dto.v_ServiceComponentFieldValuesMultimediaId;
            entity.v_MultimediaFileId = dto.v_MultimediaFileId;
            entity.v_ServiceComponentFieldValuesId = dto.v_ServiceComponentFieldValuesId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="servicecomponentfieldvaluesmultimedia"/> to an instance of <see cref="servicecomponentfieldvaluesmultimediaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentfieldvaluesmultimedia"/> to convert.</param>
        public static servicecomponentfieldvaluesmultimediaDto ToDTO(this servicecomponentfieldvaluesmultimedia entity)
        {
            if (entity == null) return null;

            var dto = new servicecomponentfieldvaluesmultimediaDto();

            dto.v_ServiceComponentFieldValuesMultimediaId = entity.v_ServiceComponentFieldValuesMultimediaId;
            dto.v_MultimediaFileId = entity.v_MultimediaFileId;
            dto.v_ServiceComponentFieldValuesId = entity.v_ServiceComponentFieldValuesId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="servicecomponentfieldvaluesmultimediaDto"/> to an instance of <see cref="servicecomponentfieldvaluesmultimedia"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<servicecomponentfieldvaluesmultimedia> ToEntities(this IEnumerable<servicecomponentfieldvaluesmultimediaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="servicecomponentfieldvaluesmultimedia"/> to an instance of <see cref="servicecomponentfieldvaluesmultimediaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<servicecomponentfieldvaluesmultimediaDto> ToDTOs(this IEnumerable<servicecomponentfieldvaluesmultimedia> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
