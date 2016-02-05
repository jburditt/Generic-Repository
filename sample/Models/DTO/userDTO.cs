using System;
using System.Runtime.Serialization;
using WBS.Models.Interfaces;

namespace WBS.Models.Data.DTO
{
    public partial class userDTO
    {
        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        public partial class userMapper
        {
            partial void DoMapping(user fromEntity, userDTO toDto)
            {
                toDto.FullName = fromEntity.first_nm + " " + fromEntity.last_nm;
            }
        }
    }
}
