using Sample.Models.Data;
using Sample.Models.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Sample.Models.Data.DTO
{

	[Serializable]
    [DataContract(Name="address", Namespace="urn:Sample/Models/Data")]
    public partial class AddressDTO : IDTO<AddressDTO, Address>
	{
            
        [DataMember(Name="id")]
        public Int32 Id
        {
            get; set;
        }
                
        [DataMember(Name="addressLine1")]
        public String AddressLine1
        {
            get; set;
        }
                
        [DataMember(Name="addressLine2")]
        public String AddressLine2
        {
            get; set;
        }
                
        [DataMember(Name="city")]
        public String City
        {
            get; set;
        }
                
        [DataMember(Name="postalCode")]
        public String PostalCode
        {
            get; set;
        }
                        
        public Address MapTo(AddressDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public AddressDTO MapFrom(Address entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public AddressMapper GetMapper()
        {
            return new AddressMapper();   
        }
        
        public partial class AddressMapper
		{
			 public AddressDTO MapTo(Address entity)
			 {
                if (entity == null) return null;
			    var dto = new AddressDTO
                {   
                    Id = entity.Id,
                    AddressLine1 = entity.AddressLine1,
                    AddressLine2 = entity.AddressLine2,
                    City = entity.City,
                    PostalCode = entity.PostalCode,
                             
                };
			    DoMapping(dto, entity);
			    return dto;
			 }
			 
			 public Address MapTo(AddressDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new Address
                {   
                    Id = dto.Id,
                    AddressLine1 = dto.AddressLine1,
                    AddressLine2 = dto.AddressLine2,
                    City = dto.City,
                    PostalCode = dto.PostalCode,
                             
                };
			    DoMapping(entity, dto);
			    return entity;
			 }
			 
			 partial void DoMapping(Address fromEntity, AddressDTO toDto);
			 partial void DoMapping(AddressDTO fromDto, Address toEntity);
		}
    }       
    
	[Serializable]
    [DataContract(Name="department", Namespace="urn:Sample/Models/Data")]
    public partial class DepartmentDTO : IDTO<DepartmentDTO, Department>
	{
            
        [DataMember(Name="id")]
        public Int32 Id
        {
            get; set;
        }
                
        [DataMember(Name="name")]
        public String Name
        {
            get; set;
        }
                        
        public Department MapTo(DepartmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public DepartmentDTO MapFrom(Department entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public DepartmentMapper GetMapper()
        {
            return new DepartmentMapper();   
        }
        
        public partial class DepartmentMapper
		{
			 public DepartmentDTO MapTo(Department entity)
			 {
                if (entity == null) return null;
			    var dto = new DepartmentDTO
                {   
                    Id = entity.Id,
                    Name = entity.Name,
                             
                };
			    DoMapping(dto, entity);
			    return dto;
			 }
			 
			 public Department MapTo(DepartmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new Department
                {   
                    Id = dto.Id,
                    Name = dto.Name,
                             
                };
			    DoMapping(entity, dto);
			    return entity;
			 }
			 
			 partial void DoMapping(Department fromEntity, DepartmentDTO toDto);
			 partial void DoMapping(DepartmentDTO fromDto, Department toEntity);
		}
    }       
    
	[Serializable]
    [DataContract(Name="user", Namespace="urn:Sample/Models/Data")]
    public partial class UserDTO : IDTO<UserDTO, User>
	{
            
        [DataMember(Name="id")]
        public Int32 Id
        {
            get; set;
        }
                
        [DataMember(Name="firstName")]
        public String FirstName
        {
            get; set;
        }
                
        [DataMember(Name="lastName")]
        public String LastName
        {
            get; set;
        }
                
        [DataMember(Name="addressId")]
        public Nullable<Int32> AddressId
        {
            get; set;
        }
                
        [DataMember(Name="address")]
        public AddressDTO Address
        {
            get; set;
        }
                        
        public User MapTo(UserDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public UserDTO MapFrom(User entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public UserMapper GetMapper()
        {
            return new UserMapper();   
        }
        
        public partial class UserMapper
		{
			 public UserDTO MapTo(User entity)
			 {
                if (entity == null) return null;
			    var dto = new UserDTO
                {   
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    AddressId = entity.AddressId,
                    Address = new AddressDTO().MapFrom(entity.Address),
                             
                };
			    DoMapping(dto, entity);
			    return dto;
			 }
			 
			 public User MapTo(UserDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new User
                {   
                    Id = dto.Id,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    AddressId = dto.AddressId,
                    Address = new AddressDTO().MapTo(dto.Address),
                             
                };
			    DoMapping(entity, dto);
			    return entity;
			 }
			 
			 partial void DoMapping(User fromEntity, UserDTO toDto);
			 partial void DoMapping(UserDTO fromDto, User toEntity);
		}
    }       
    
	[Serializable]
    [DataContract(Name="userDepartment", Namespace="urn:Sample/Models/Data")]
    public partial class UserDepartmentDTO : IDTO<UserDepartmentDTO, UserDepartment>
	{
            
        [DataMember(Name="id")]
        public Int32 Id
        {
            get; set;
        }
                
        [DataMember(Name="userId")]
        public Int32 UserId
        {
            get; set;
        }
                
        [DataMember(Name="departmentId")]
        public Int32 DepartmentId
        {
            get; set;
        }
                
        [DataMember(Name="department")]
        public DepartmentDTO Department
        {
            get; set;
        }
                
        [DataMember(Name="user")]
        public UserDTO User
        {
            get; set;
        }
                        
        public UserDepartment MapTo(UserDepartmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public UserDepartmentDTO MapFrom(UserDepartment entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public UserDepartmentMapper GetMapper()
        {
            return new UserDepartmentMapper();   
        }
        
        public partial class UserDepartmentMapper
		{
			 public UserDepartmentDTO MapTo(UserDepartment entity)
			 {
                if (entity == null) return null;
			    var dto = new UserDepartmentDTO
                {   
                    Id = entity.Id,
                    UserId = entity.UserId,
                    DepartmentId = entity.DepartmentId,
                    Department = new DepartmentDTO().MapFrom(entity.Department),
                    User = new UserDTO().MapFrom(entity.User),
                             
                };
			    DoMapping(dto, entity);
			    return dto;
			 }
			 
			 public UserDepartment MapTo(UserDepartmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new UserDepartment
                {   
                    Id = dto.Id,
                    UserId = dto.UserId,
                    DepartmentId = dto.DepartmentId,
                    Department = new DepartmentDTO().MapTo(dto.Department),
                    User = new UserDTO().MapTo(dto.User),
                             
                };
			    DoMapping(entity, dto);
			    return entity;
			 }
			 
			 partial void DoMapping(UserDepartment fromEntity, UserDepartmentDTO toDto);
			 partial void DoMapping(UserDepartmentDTO fromDto, UserDepartment toEntity);
		}
    }       
        
}
