using WBS.Models.Data;
using WBS.Models.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WBS.Models.Data.DTO
{
    [DataContract(Name="province_tax", Namespace="urn:WBS/Models/Data")]
    public partial class province_taxDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="province_id")]
        public Int32 province_id
        {
            get; set;
        }
                
        [DataMember(Name="gst_rate")]
        public Double gst_rate
        {
            get; set;
        }
                
        [DataMember(Name="pst_rate")]
        public Double pst_rate
        {
            get; set;
        }
                
        [DataMember(Name="qst_rate")]
        public Double qst_rate
        {
            get; set;
        }
                
        [DataMember(Name="hst_rate")]
        public Double hst_rate
        {
            get; set;
        }
                
        [DataMember(Name="gST")]
        public Decimal GST
        {
            get; set;
        }
                
        [DataMember(Name="pST")]
        public Decimal PST
        {
            get; set;
        }
                
        [DataMember(Name="qST")]
        public Decimal QST
        {
            get; set;
        }
                
        [DataMember(Name="hST")]
        public Decimal HST
        {
            get; set;
        }
                        
        public province_tax MapTo(province_taxDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static province_taxDTO MapFrom(province_tax entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static province_taxMapper GetMapper()
        {
            return new province_taxMapper();   
        }
        
        public partial class province_taxMapper
		{
			 public province_taxDTO MapTo(province_tax entity)
			 {
                if (entity == null) return null;
			    var dto = new province_taxDTO
                {   
                    id = entity.id,
                    province_id = entity.province_id,
                    gst_rate = entity.gst_rate,
                    pst_rate = entity.pst_rate,
                    qst_rate = entity.qst_rate,
                    hst_rate = entity.hst_rate,
                    GST = entity.GST,
                    PST = entity.PST,
                    QST = entity.QST,
                    HST = entity.HST,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public province_tax MapTo(province_taxDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new province_tax
                {   
                    id = dto.id,
                    province_id = dto.province_id,
                    gst_rate = dto.gst_rate,
                    pst_rate = dto.pst_rate,
                    qst_rate = dto.qst_rate,
                    hst_rate = dto.hst_rate,
                    GST = dto.GST,
                    PST = dto.PST,
                    QST = dto.QST,
                    HST = dto.HST,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(province_tax fromEntity, province_taxDTO toDto);
			 partial void DoMapping(province_taxDTO fromDto, province_tax toEntity);
		}
    }       
        [DataContract(Name="company_location", Namespace="urn:WBS/Models/Data")]
    public partial class company_locationDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="location_nm")]
        public String location_nm
        {
            get; set;
        }
                
        [DataMember(Name="city_nm")]
        public String city_nm
        {
            get; set;
        }
                
        [DataMember(Name="province_nm")]
        public String province_nm
        {
            get; set;
        }
                
        [DataMember(Name="country_nm")]
        public String country_nm
        {
            get; set;
        }
                
        [DataMember(Name="location_nf")]
        public String location_nf
        {
            get; set;
        }
                
        [DataMember(Name="location_ns")]
        public String location_ns
        {
            get; set;
        }
                
        [DataMember(Name="location_nr")]
        public String location_nr
        {
            get; set;
        }
                
        [DataMember(Name="location_na")]
        public String location_na
        {
            get; set;
        }
                
        [DataMember(Name="location_nj")]
        public String location_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public company_location MapTo(company_locationDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_locationDTO MapFrom(company_location entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_locationMapper GetMapper()
        {
            return new company_locationMapper();   
        }
        
        public partial class company_locationMapper
		{
			 public company_locationDTO MapTo(company_location entity)
			 {
                if (entity == null) return null;
			    var dto = new company_locationDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    location_nm = entity.location_nm,
                    city_nm = entity.city_nm,
                    province_nm = entity.province_nm,
                    country_nm = entity.country_nm,
                    location_nf = entity.location_nf,
                    location_ns = entity.location_ns,
                    location_nr = entity.location_nr,
                    location_na = entity.location_na,
                    location_nj = entity.location_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_location MapTo(company_locationDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_location
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    location_nm = dto.location_nm,
                    city_nm = dto.city_nm,
                    province_nm = dto.province_nm,
                    country_nm = dto.country_nm,
                    location_nf = dto.location_nf,
                    location_ns = dto.location_ns,
                    location_nr = dto.location_nr,
                    location_na = dto.location_na,
                    location_nj = dto.location_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_location fromEntity, company_locationDTO toDto);
			 partial void DoMapping(company_locationDTO fromDto, company_location toEntity);
		}
    }       
        [DataContract(Name="company_department", Namespace="urn:WBS/Models/Data")]
    public partial class company_departmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="department_nm")]
        public String department_nm
        {
            get; set;
        }
                
        [DataMember(Name="department_nf")]
        public String department_nf
        {
            get; set;
        }
                
        [DataMember(Name="department_ns")]
        public String department_ns
        {
            get; set;
        }
                
        [DataMember(Name="department_nr")]
        public String department_nr
        {
            get; set;
        }
                
        [DataMember(Name="department_na")]
        public String department_na
        {
            get; set;
        }
                
        [DataMember(Name="department_nj")]
        public String department_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public company_department MapTo(company_departmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_departmentDTO MapFrom(company_department entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_departmentMapper GetMapper()
        {
            return new company_departmentMapper();   
        }
        
        public partial class company_departmentMapper
		{
			 public company_departmentDTO MapTo(company_department entity)
			 {
                if (entity == null) return null;
			    var dto = new company_departmentDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    department_nm = entity.department_nm,
                    department_nf = entity.department_nf,
                    department_ns = entity.department_ns,
                    department_nr = entity.department_nr,
                    department_na = entity.department_na,
                    department_nj = entity.department_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_department MapTo(company_departmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_department
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    department_nm = dto.department_nm,
                    department_nf = dto.department_nf,
                    department_ns = dto.department_ns,
                    department_nr = dto.department_nr,
                    department_na = dto.department_na,
                    department_nj = dto.department_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_department fromEntity, company_departmentDTO toDto);
			 partial void DoMapping(company_departmentDTO fromDto, company_department toEntity);
		}
    }       
        [DataContract(Name="company_case_type", Namespace="urn:WBS/Models/Data")]
    public partial class company_case_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_id")]
        public Nullable<Int32> case_type_id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nm")]
        public String case_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nf")]
        public String case_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="case_type_ns")]
        public String case_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nr")]
        public String case_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="case_type_na")]
        public String case_type_na
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nj")]
        public String case_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public company_case_type MapTo(company_case_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_case_typeDTO MapFrom(company_case_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_case_typeMapper GetMapper()
        {
            return new company_case_typeMapper();   
        }
        
        public partial class company_case_typeMapper
		{
			 public company_case_typeDTO MapTo(company_case_type entity)
			 {
                if (entity == null) return null;
			    var dto = new company_case_typeDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    case_type_id = entity.case_type_id,
                    case_type_nm = entity.case_type_nm,
                    case_type_nf = entity.case_type_nf,
                    case_type_ns = entity.case_type_ns,
                    case_type_nr = entity.case_type_nr,
                    case_type_na = entity.case_type_na,
                    case_type_nj = entity.case_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_case_type MapTo(company_case_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_case_type
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    case_type_id = dto.case_type_id,
                    case_type_nm = dto.case_type_nm,
                    case_type_nf = dto.case_type_nf,
                    case_type_ns = dto.case_type_ns,
                    case_type_nr = dto.case_type_nr,
                    case_type_na = dto.case_type_na,
                    case_type_nj = dto.case_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_case_type fromEntity, company_case_typeDTO toDto);
			 partial void DoMapping(company_case_typeDTO fromDto, company_case_type toEntity);
		}
    }       
        [DataContract(Name="address", Namespace="urn:WBS/Models/Data")]
    public partial class addressDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="country_id")]
        public Int32 country_id
        {
            get; set;
        }
                
        [DataMember(Name="province_id")]
        public Nullable<Int32> province_id
        {
            get; set;
        }
                
        [DataMember(Name="address_line1_ds")]
        public String address_line1_ds
        {
            get; set;
        }
                
        [DataMember(Name="address_line2_ds")]
        public String address_line2_ds
        {
            get; set;
        }
                
        [DataMember(Name="city_nm")]
        public String city_nm
        {
            get; set;
        }
                
        [DataMember(Name="postal_code_cl")]
        public String postal_code_cl
        {
            get; set;
        }
                
        [DataMember(Name="home_no")]
        public String home_no
        {
            get; set;
        }
                
        [DataMember(Name="work_no")]
        public String work_no
        {
            get; set;
        }
                
        [DataMember(Name="cell_no")]
        public String cell_no
        {
            get; set;
        }
                
        [DataMember(Name="extension_no")]
        public String extension_no
        {
            get; set;
        }
                
        [DataMember(Name="facsimile_no")]
        public String facsimile_no
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="cc_email")]
        public String cc_email
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="users")]
        public ICollection<user> users
        {
            get; set;
        }
                
        [DataMember(Name="province")]
        public provinceDTO province
        {
            get; set;
        }
                
        [DataMember(Name="companies")]
        public ICollection<company> companies
        {
            get; set;
        }
                        
        public address MapTo(addressDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static addressDTO MapFrom(address entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static addressMapper GetMapper()
        {
            return new addressMapper();   
        }
        
        public partial class addressMapper
		{
			 public addressDTO MapTo(address entity)
			 {
                if (entity == null) return null;
			    var dto = new addressDTO
                {   
                    id = entity.id,
                    country_id = entity.country_id,
                    province_id = entity.province_id,
                    address_line1_ds = entity.address_line1_ds,
                    address_line2_ds = entity.address_line2_ds,
                    city_nm = entity.city_nm,
                    postal_code_cl = entity.postal_code_cl,
                    home_no = entity.home_no,
                    work_no = entity.work_no,
                    cell_no = entity.cell_no,
                    extension_no = entity.extension_no,
                    facsimile_no = entity.facsimile_no,
                    email = entity.email,
                    cc_email = entity.cc_email,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    users = entity.users,
                    province = provinceDTO.GetMapper().MapTo(entity.province),
                    companies = entity.companies,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public address MapTo(addressDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new address
                {   
                    id = dto.id,
                    country_id = dto.country_id,
                    province_id = dto.province_id,
                    address_line1_ds = dto.address_line1_ds,
                    address_line2_ds = dto.address_line2_ds,
                    city_nm = dto.city_nm,
                    postal_code_cl = dto.postal_code_cl,
                    home_no = dto.home_no,
                    work_no = dto.work_no,
                    cell_no = dto.cell_no,
                    extension_no = dto.extension_no,
                    facsimile_no = dto.facsimile_no,
                    email = dto.email,
                    cc_email = dto.cc_email,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    users = dto.users,
                    province = provinceDTO.GetMapper().MapTo(dto.province),
                    companies = dto.companies,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(address fromEntity, addressDTO toDto);
			 partial void DoMapping(addressDTO fromDto, address toEntity);
		}
    }       
        [DataContract(Name="auditor_case_type", Namespace="urn:WBS/Models/Data")]
    public partial class auditor_case_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_int")]
        public Nullable<Int32> client_int
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Nullable<Int32> company_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_id")]
        public Int32 case_type_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public auditor_case_type MapTo(auditor_case_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static auditor_case_typeDTO MapFrom(auditor_case_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static auditor_case_typeMapper GetMapper()
        {
            return new auditor_case_typeMapper();   
        }
        
        public partial class auditor_case_typeMapper
		{
			 public auditor_case_typeDTO MapTo(auditor_case_type entity)
			 {
                if (entity == null) return null;
			    var dto = new auditor_case_typeDTO
                {   
                    id = entity.id,
                    client_int = entity.client_int,
                    company_id = entity.company_id,
                    auditor_id = entity.auditor_id,
                    case_type_id = entity.case_type_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public auditor_case_type MapTo(auditor_case_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new auditor_case_type
                {   
                    id = dto.id,
                    client_int = dto.client_int,
                    company_id = dto.company_id,
                    auditor_id = dto.auditor_id,
                    case_type_id = dto.case_type_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(auditor_case_type fromEntity, auditor_case_typeDTO toDto);
			 partial void DoMapping(auditor_case_typeDTO fromDto, auditor_case_type toEntity);
		}
    }       
        [DataContract(Name="auditor_incident_type", Namespace="urn:WBS/Models/Data")]
    public partial class auditor_incident_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_int")]
        public Nullable<Int32> client_int
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Nullable<Int32> company_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_id")]
        public Int32 incident_type_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public auditor_incident_type MapTo(auditor_incident_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static auditor_incident_typeDTO MapFrom(auditor_incident_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static auditor_incident_typeMapper GetMapper()
        {
            return new auditor_incident_typeMapper();   
        }
        
        public partial class auditor_incident_typeMapper
		{
			 public auditor_incident_typeDTO MapTo(auditor_incident_type entity)
			 {
                if (entity == null) return null;
			    var dto = new auditor_incident_typeDTO
                {   
                    id = entity.id,
                    client_int = entity.client_int,
                    company_id = entity.company_id,
                    auditor_id = entity.auditor_id,
                    incident_type_id = entity.incident_type_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public auditor_incident_type MapTo(auditor_incident_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new auditor_incident_type
                {   
                    id = dto.id,
                    client_int = dto.client_int,
                    company_id = dto.company_id,
                    auditor_id = dto.auditor_id,
                    incident_type_id = dto.incident_type_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(auditor_incident_type fromEntity, auditor_incident_typeDTO toDto);
			 partial void DoMapping(auditor_incident_typeDTO fromDto, auditor_incident_type toEntity);
		}
    }       
        [DataContract(Name="billing_info", Namespace="urn:WBS/Models/Data")]
    public partial class billing_infoDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="address_id")]
        public Int32 address_id
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_id")]
        public Nullable<Int32> billing_option_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="billing_info_nm")]
        public String billing_info_nm
        {
            get; set;
        }
                
        [DataMember(Name="business_type_nm")]
        public String business_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="principle_nm")]
        public String principle_nm
        {
            get; set;
        }
                
        [DataMember(Name="contact_nm")]
        public String contact_nm
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="bank_nm")]
        public String bank_nm
        {
            get; set;
        }
                
        [DataMember(Name="bank_work_no")]
        public String bank_work_no
        {
            get; set;
        }
                
        [DataMember(Name="branch_nm")]
        public String branch_nm
        {
            get; set;
        }
                
        [DataMember(Name="reference_nm")]
        public String reference_nm
        {
            get; set;
        }
                
        [DataMember(Name="reference_work_no")]
        public String reference_work_no
        {
            get; set;
        }
                
        [DataMember(Name="credit_level_id")]
        public Int32 credit_level_id
        {
            get; set;
        }
                
        [DataMember(Name="card_no")]
        public String card_no
        {
            get; set;
        }
                
        [DataMember(Name="verify_no")]
        public String verify_no
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public String expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public billing_info MapTo(billing_infoDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static billing_infoDTO MapFrom(billing_info entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static billing_infoMapper GetMapper()
        {
            return new billing_infoMapper();   
        }
        
        public partial class billing_infoMapper
		{
			 public billing_infoDTO MapTo(billing_info entity)
			 {
                if (entity == null) return null;
			    var dto = new billing_infoDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    address_id = entity.address_id,
                    billing_option_id = entity.billing_option_id,
                    status_id = entity.status_id,
                    billing_info_nm = entity.billing_info_nm,
                    business_type_nm = entity.business_type_nm,
                    principle_nm = entity.principle_nm,
                    contact_nm = entity.contact_nm,
                    email = entity.email,
                    bank_nm = entity.bank_nm,
                    bank_work_no = entity.bank_work_no,
                    branch_nm = entity.branch_nm,
                    reference_nm = entity.reference_nm,
                    reference_work_no = entity.reference_work_no,
                    credit_level_id = entity.credit_level_id,
                    card_no = entity.card_no,
                    verify_no = entity.verify_no,
                    expiry_dt = entity.expiry_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public billing_info MapTo(billing_infoDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new billing_info
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    address_id = dto.address_id,
                    billing_option_id = dto.billing_option_id,
                    status_id = dto.status_id,
                    billing_info_nm = dto.billing_info_nm,
                    business_type_nm = dto.business_type_nm,
                    principle_nm = dto.principle_nm,
                    contact_nm = dto.contact_nm,
                    email = dto.email,
                    bank_nm = dto.bank_nm,
                    bank_work_no = dto.bank_work_no,
                    branch_nm = dto.branch_nm,
                    reference_nm = dto.reference_nm,
                    reference_work_no = dto.reference_work_no,
                    credit_level_id = dto.credit_level_id,
                    card_no = dto.card_no,
                    verify_no = dto.verify_no,
                    expiry_dt = dto.expiry_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(billing_info fromEntity, billing_infoDTO toDto);
			 partial void DoMapping(billing_infoDTO fromDto, billing_info toEntity);
		}
    }       
        [DataContract(Name="billing_option", Namespace="urn:WBS/Models/Data")]
    public partial class billing_optionDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_nm")]
        public String billing_option_nm
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_nf")]
        public String billing_option_nf
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_ns")]
        public String billing_option_ns
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_nr")]
        public String billing_option_nr
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_na")]
        public String billing_option_na
        {
            get; set;
        }
                
        [DataMember(Name="billing_option_nj")]
        public String billing_option_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public billing_option MapTo(billing_optionDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static billing_optionDTO MapFrom(billing_option entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static billing_optionMapper GetMapper()
        {
            return new billing_optionMapper();   
        }
        
        public partial class billing_optionMapper
		{
			 public billing_optionDTO MapTo(billing_option entity)
			 {
                if (entity == null) return null;
			    var dto = new billing_optionDTO
                {   
                    id = entity.id,
                    billing_option_nm = entity.billing_option_nm,
                    billing_option_nf = entity.billing_option_nf,
                    billing_option_ns = entity.billing_option_ns,
                    billing_option_nr = entity.billing_option_nr,
                    billing_option_na = entity.billing_option_na,
                    billing_option_nj = entity.billing_option_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public billing_option MapTo(billing_optionDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new billing_option
                {   
                    id = dto.id,
                    billing_option_nm = dto.billing_option_nm,
                    billing_option_nf = dto.billing_option_nf,
                    billing_option_ns = dto.billing_option_ns,
                    billing_option_nr = dto.billing_option_nr,
                    billing_option_na = dto.billing_option_na,
                    billing_option_nj = dto.billing_option_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(billing_option fromEntity, billing_optionDTO toDto);
			 partial void DoMapping(billing_optionDTO fromDto, billing_option toEntity);
		}
    }       
        [DataContract(Name="case", Namespace="urn:WBS/Models/Data")]
    public partial class caseDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Nullable<Int32> auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="case_nm")]
        public String case_nm
        {
            get; set;
        }
                
        [DataMember(Name="assigned_dt")]
        public Nullable<DateTime> assigned_dt
        {
            get; set;
        }
                
        [DataMember(Name="opened_dt")]
        public Nullable<DateTime> opened_dt
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_id")]
        public Nullable<Int32> case_priority_id
        {
            get; set;
        }
                
        [DataMember(Name="reported_dt")]
        public DateTime reported_dt
        {
            get; set;
        }
                
        [DataMember(Name="case_from_dt")]
        public DateTime case_from_dt
        {
            get; set;
        }
                
        [DataMember(Name="case_to_dt")]
        public DateTime case_to_dt
        {
            get; set;
        }
                
        [DataMember(Name="reported_in")]
        public Byte reported_in
        {
            get; set;
        }
                
        [DataMember(Name="location_nm")]
        public String location_nm
        {
            get; set;
        }
                
        [DataMember(Name="department_nm")]
        public String department_nm
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_id")]
        public Int32 case_anonymity_id
        {
            get; set;
        }
                
        [DataMember(Name="phone_no")]
        public String phone_no
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="best_way_ds")]
        public String best_way_ds
        {
            get; set;
        }
                
        [DataMember(Name="implicated_in")]
        public Byte implicated_in
        {
            get; set;
        }
                
        [DataMember(Name="case_ds")]
        public String case_ds
        {
            get; set;
        }
                
        [DataMember(Name="involved_ds")]
        public String involved_ds
        {
            get; set;
        }
                
        [DataMember(Name="supervisor_in")]
        public Nullable<Int32> supervisor_in
        {
            get; set;
        }
                
        [DataMember(Name="supervisor_ds")]
        public String supervisor_ds
        {
            get; set;
        }
                
        [DataMember(Name="employee_in")]
        public Nullable<Byte> employee_in
        {
            get; set;
        }
                
        [DataMember(Name="employee_ds")]
        public String employee_ds
        {
            get; set;
        }
                
        [DataMember(Name="outside_witness_in")]
        public Nullable<Byte> outside_witness_in
        {
            get; set;
        }
                
        [DataMember(Name="to_whom_ds")]
        public String to_whom_ds
        {
            get; set;
        }
                
        [DataMember(Name="further_ds")]
        public String further_ds
        {
            get; set;
        }
                
        [DataMember(Name="source_type_id")]
        public Int32 source_type_id
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_id")]
        public Int32 validation_type_id
        {
            get; set;
        }
                
        [DataMember(Name="action_type_id")]
        public Nullable<Int32> action_type_id
        {
            get; set;
        }
                
        [DataMember(Name="outcome_action_ds")]
        public String outcome_action_ds
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="ongoing_in")]
        public Nullable<Int32> ongoing_in
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="case_reporter")]
        public ICollection<case_reporter> case_reporter
        {
            get; set;
        }
                
        [DataMember(Name="client")]
        public clientDTO client
        {
            get; set;
        }
                
        [DataMember(Name="company")]
        public companyDTO company
        {
            get; set;
        }
                        
        public @case MapTo(caseDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static caseDTO MapFrom(@case entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static caseMapper GetMapper()
        {
            return new caseMapper();   
        }
        
        public partial class caseMapper
		{
			 public caseDTO MapTo(@case entity)
			 {
                if (entity == null) return null;
			    var dto = new caseDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    auditor_id = entity.auditor_id,
                    case_nm = entity.case_nm,
                    assigned_dt = entity.assigned_dt,
                    opened_dt = entity.opened_dt,
                    case_priority_id = entity.case_priority_id,
                    reported_dt = entity.reported_dt,
                    case_from_dt = entity.case_from_dt,
                    case_to_dt = entity.case_to_dt,
                    reported_in = entity.reported_in,
                    location_nm = entity.location_nm,
                    department_nm = entity.department_nm,
                    case_anonymity_id = entity.case_anonymity_id,
                    phone_no = entity.phone_no,
                    email = entity.email,
                    best_way_ds = entity.best_way_ds,
                    implicated_in = entity.implicated_in,
                    case_ds = entity.case_ds,
                    involved_ds = entity.involved_ds,
                    supervisor_in = entity.supervisor_in,
                    supervisor_ds = entity.supervisor_ds,
                    employee_in = entity.employee_in,
                    employee_ds = entity.employee_ds,
                    outside_witness_in = entity.outside_witness_in,
                    to_whom_ds = entity.to_whom_ds,
                    further_ds = entity.further_ds,
                    source_type_id = entity.source_type_id,
                    validation_type_id = entity.validation_type_id,
                    action_type_id = entity.action_type_id,
                    outcome_action_ds = entity.outcome_action_ds,
                    notepad_tx = entity.notepad_tx,
                    ongoing_in = entity.ongoing_in,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    case_reporter = entity.case_reporter,
                    client = clientDTO.GetMapper().MapTo(entity.client),
                    company = companyDTO.GetMapper().MapTo(entity.company),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public @case MapTo(caseDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new @case
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    auditor_id = dto.auditor_id,
                    case_nm = dto.case_nm,
                    assigned_dt = dto.assigned_dt,
                    opened_dt = dto.opened_dt,
                    case_priority_id = dto.case_priority_id,
                    reported_dt = dto.reported_dt,
                    case_from_dt = dto.case_from_dt,
                    case_to_dt = dto.case_to_dt,
                    reported_in = dto.reported_in,
                    location_nm = dto.location_nm,
                    department_nm = dto.department_nm,
                    case_anonymity_id = dto.case_anonymity_id,
                    phone_no = dto.phone_no,
                    email = dto.email,
                    best_way_ds = dto.best_way_ds,
                    implicated_in = dto.implicated_in,
                    case_ds = dto.case_ds,
                    involved_ds = dto.involved_ds,
                    supervisor_in = dto.supervisor_in,
                    supervisor_ds = dto.supervisor_ds,
                    employee_in = dto.employee_in,
                    employee_ds = dto.employee_ds,
                    outside_witness_in = dto.outside_witness_in,
                    to_whom_ds = dto.to_whom_ds,
                    further_ds = dto.further_ds,
                    source_type_id = dto.source_type_id,
                    validation_type_id = dto.validation_type_id,
                    action_type_id = dto.action_type_id,
                    outcome_action_ds = dto.outcome_action_ds,
                    notepad_tx = dto.notepad_tx,
                    ongoing_in = dto.ongoing_in,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    case_reporter = dto.case_reporter,
                    client = clientDTO.GetMapper().MapTo(dto.client),
                    company = companyDTO.GetMapper().MapTo(dto.company),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(@case fromEntity, caseDTO toDto);
			 partial void DoMapping(caseDTO fromDto, @case toEntity);
		}
    }       
        [DataContract(Name="case_action_type", Namespace="urn:WBS/Models/Data")]
    public partial class case_action_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="action_type_nm")]
        public String action_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="action_type_nf")]
        public String action_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="action_type_ns")]
        public String action_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="action_type_nr")]
        public String action_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="action_type_na")]
        public String action_type_na
        {
            get; set;
        }
                
        [DataMember(Name="action_type_nj")]
        public String action_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_action_type MapTo(case_action_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_action_typeDTO MapFrom(case_action_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_action_typeMapper GetMapper()
        {
            return new case_action_typeMapper();   
        }
        
        public partial class case_action_typeMapper
		{
			 public case_action_typeDTO MapTo(case_action_type entity)
			 {
                if (entity == null) return null;
			    var dto = new case_action_typeDTO
                {   
                    id = entity.id,
                    action_type_nm = entity.action_type_nm,
                    action_type_nf = entity.action_type_nf,
                    action_type_ns = entity.action_type_ns,
                    action_type_nr = entity.action_type_nr,
                    action_type_na = entity.action_type_na,
                    action_type_nj = entity.action_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_action_type MapTo(case_action_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_action_type
                {   
                    id = dto.id,
                    action_type_nm = dto.action_type_nm,
                    action_type_nf = dto.action_type_nf,
                    action_type_ns = dto.action_type_ns,
                    action_type_nr = dto.action_type_nr,
                    action_type_na = dto.action_type_na,
                    action_type_nj = dto.action_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_action_type fromEntity, case_action_typeDTO toDto);
			 partial void DoMapping(case_action_typeDTO fromDto, case_action_type toEntity);
		}
    }       
        [DataContract(Name="case_anonymity", Namespace="urn:WBS/Models/Data")]
    public partial class case_anonymityDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_nm")]
        public String case_anonymity_nm
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_nf")]
        public String case_anonymity_nf
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_ns")]
        public String case_anonymity_ns
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_nr")]
        public String case_anonymity_nr
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_na")]
        public String case_anonymity_na
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_nj")]
        public String case_anonymity_nj
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_ds")]
        public String case_anonymity_ds
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_df")]
        public String case_anonymity_df
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_dp")]
        public String case_anonymity_dp
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_dr")]
        public String case_anonymity_dr
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_da")]
        public String case_anonymity_da
        {
            get; set;
        }
                
        [DataMember(Name="case_anonymity_dj")]
        public String case_anonymity_dj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_anonymity MapTo(case_anonymityDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_anonymityDTO MapFrom(case_anonymity entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_anonymityMapper GetMapper()
        {
            return new case_anonymityMapper();   
        }
        
        public partial class case_anonymityMapper
		{
			 public case_anonymityDTO MapTo(case_anonymity entity)
			 {
                if (entity == null) return null;
			    var dto = new case_anonymityDTO
                {   
                    id = entity.id,
                    case_anonymity_nm = entity.case_anonymity_nm,
                    case_anonymity_nf = entity.case_anonymity_nf,
                    case_anonymity_ns = entity.case_anonymity_ns,
                    case_anonymity_nr = entity.case_anonymity_nr,
                    case_anonymity_na = entity.case_anonymity_na,
                    case_anonymity_nj = entity.case_anonymity_nj,
                    case_anonymity_ds = entity.case_anonymity_ds,
                    case_anonymity_df = entity.case_anonymity_df,
                    case_anonymity_dp = entity.case_anonymity_dp,
                    case_anonymity_dr = entity.case_anonymity_dr,
                    case_anonymity_da = entity.case_anonymity_da,
                    case_anonymity_dj = entity.case_anonymity_dj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_anonymity MapTo(case_anonymityDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_anonymity
                {   
                    id = dto.id,
                    case_anonymity_nm = dto.case_anonymity_nm,
                    case_anonymity_nf = dto.case_anonymity_nf,
                    case_anonymity_ns = dto.case_anonymity_ns,
                    case_anonymity_nr = dto.case_anonymity_nr,
                    case_anonymity_na = dto.case_anonymity_na,
                    case_anonymity_nj = dto.case_anonymity_nj,
                    case_anonymity_ds = dto.case_anonymity_ds,
                    case_anonymity_df = dto.case_anonymity_df,
                    case_anonymity_dp = dto.case_anonymity_dp,
                    case_anonymity_dr = dto.case_anonymity_dr,
                    case_anonymity_da = dto.case_anonymity_da,
                    case_anonymity_dj = dto.case_anonymity_dj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_anonymity fromEntity, case_anonymityDTO toDto);
			 partial void DoMapping(case_anonymityDTO fromDto, case_anonymity toEntity);
		}
    }       
        [DataContract(Name="case_answer", Namespace="urn:WBS/Models/Data")]
    public partial class case_answerDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Nullable<Int32> case_id
        {
            get; set;
        }
                
        [DataMember(Name="case_question_id")]
        public Nullable<Int32> case_question_id
        {
            get; set;
        }
                
        [DataMember(Name="answer_no")]
        public Nullable<Int32> answer_no
        {
            get; set;
        }
                
        [DataMember(Name="answer_ds")]
        public String answer_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public case_answer MapTo(case_answerDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_answerDTO MapFrom(case_answer entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_answerMapper GetMapper()
        {
            return new case_answerMapper();   
        }
        
        public partial class case_answerMapper
		{
			 public case_answerDTO MapTo(case_answer entity)
			 {
                if (entity == null) return null;
			    var dto = new case_answerDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    case_question_id = entity.case_question_id,
                    answer_no = entity.answer_no,
                    answer_ds = entity.answer_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_answer MapTo(case_answerDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_answer
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    case_question_id = dto.case_question_id,
                    answer_no = dto.answer_no,
                    answer_ds = dto.answer_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_answer fromEntity, case_answerDTO toDto);
			 partial void DoMapping(case_answerDTO fromDto, case_answer toEntity);
		}
    }       
        [DataContract(Name="case_attachment", Namespace="urn:WBS/Models/Data")]
    public partial class case_attachmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="path_nm")]
        public String path_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_nm")]
        public String file_nm
        {
            get; set;
        }
                
        [DataMember(Name="extension_nm")]
        public String extension_nm
        {
            get; set;
        }
                
        [DataMember(Name="effective_dt")]
        public DateTime effective_dt
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public DateTime expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_attachment MapTo(case_attachmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_attachmentDTO MapFrom(case_attachment entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_attachmentMapper GetMapper()
        {
            return new case_attachmentMapper();   
        }
        
        public partial class case_attachmentMapper
		{
			 public case_attachmentDTO MapTo(case_attachment entity)
			 {
                if (entity == null) return null;
			    var dto = new case_attachmentDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    status_id = entity.status_id,
                    path_nm = entity.path_nm,
                    file_nm = entity.file_nm,
                    extension_nm = entity.extension_nm,
                    effective_dt = entity.effective_dt,
                    expiry_dt = entity.expiry_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_attachment MapTo(case_attachmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_attachment
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    status_id = dto.status_id,
                    path_nm = dto.path_nm,
                    file_nm = dto.file_nm,
                    extension_nm = dto.extension_nm,
                    effective_dt = dto.effective_dt,
                    expiry_dt = dto.expiry_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_attachment fromEntity, case_attachmentDTO toDto);
			 partial void DoMapping(case_attachmentDTO fromDto, case_attachment toEntity);
		}
    }       
        [DataContract(Name="case_auditor", Namespace="urn:WBS/Models/Data")]
    public partial class case_auditorDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="assigned_dt")]
        public DateTime assigned_dt
        {
            get; set;
        }
                
        [DataMember(Name="notification_in")]
        public Int32 notification_in
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_auditor MapTo(case_auditorDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_auditorDTO MapFrom(case_auditor entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_auditorMapper GetMapper()
        {
            return new case_auditorMapper();   
        }
        
        public partial class case_auditorMapper
		{
			 public case_auditorDTO MapTo(case_auditor entity)
			 {
                if (entity == null) return null;
			    var dto = new case_auditorDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    auditor_id = entity.auditor_id,
                    assigned_dt = entity.assigned_dt,
                    notification_in = entity.notification_in,
                    status_id = entity.status_id,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_auditor MapTo(case_auditorDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_auditor
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    auditor_id = dto.auditor_id,
                    assigned_dt = dto.assigned_dt,
                    notification_in = dto.notification_in,
                    status_id = dto.status_id,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_auditor fromEntity, case_auditorDTO toDto);
			 partial void DoMapping(case_auditorDTO fromDto, case_auditor toEntity);
		}
    }       
        [DataContract(Name="case_implicated", Namespace="urn:WBS/Models/Data")]
    public partial class case_implicatedDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_implicated MapTo(case_implicatedDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_implicatedDTO MapFrom(case_implicated entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_implicatedMapper GetMapper()
        {
            return new case_implicatedMapper();   
        }
        
        public partial class case_implicatedMapper
		{
			 public case_implicatedDTO MapTo(case_implicated entity)
			 {
                if (entity == null) return null;
			    var dto = new case_implicatedDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    auditor_id = entity.auditor_id,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_implicated MapTo(case_implicatedDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_implicated
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    auditor_id = dto.auditor_id,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_implicated fromEntity, case_implicatedDTO toDto);
			 partial void DoMapping(case_implicatedDTO fromDto, case_implicated toEntity);
		}
    }       
        [DataContract(Name="case_message", Namespace="urn:WBS/Models/Data")]
    public partial class case_messageDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="message_nm")]
        public String message_nm
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="subject_ds")]
        public String subject_ds
        {
            get; set;
        }
                
        [DataMember(Name="body_tx")]
        public String body_tx
        {
            get; set;
        }
                
        [DataMember(Name="reply_to_id")]
        public Nullable<Int32> reply_to_id
        {
            get; set;
        }
                
        [DataMember(Name="posted_dt")]
        public Nullable<DateTime> posted_dt
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="total_replies_no")]
        public Int32 total_replies_no
        {
            get; set;
        }
                
        [DataMember(Name="thread_id")]
        public Nullable<Int32> thread_id
        {
            get; set;
        }
                
        [DataMember(Name="ip_ds")]
        public String ip_ds
        {
            get; set;
        }
                
        [DataMember(Name="emailed_in")]
        public Int32 emailed_in
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="locked_in")]
        public Int32 locked_in
        {
            get; set;
        }
                
        [DataMember(Name="private_in")]
        public Int32 private_in
        {
            get; set;
        }
                
        [DataMember(Name="action_ds")]
        public String action_ds
        {
            get; set;
        }
                
        [DataMember(Name="action_dt")]
        public Nullable<DateTime> action_dt
        {
            get; set;
        }
                
        [DataMember(Name="case_question_in")]
        public Int32 case_question_in
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_message MapTo(case_messageDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_messageDTO MapFrom(case_message entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_messageMapper GetMapper()
        {
            return new case_messageMapper();   
        }
        
        public partial class case_messageMapper
		{
			 public case_messageDTO MapTo(case_message entity)
			 {
                if (entity == null) return null;
			    var dto = new case_messageDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    message_nm = entity.message_nm,
                    email = entity.email,
                    subject_ds = entity.subject_ds,
                    body_tx = entity.body_tx,
                    reply_to_id = entity.reply_to_id,
                    posted_dt = entity.posted_dt,
                    auditor_id = entity.auditor_id,
                    total_replies_no = entity.total_replies_no,
                    thread_id = entity.thread_id,
                    ip_ds = entity.ip_ds,
                    emailed_in = entity.emailed_in,
                    status_id = entity.status_id,
                    locked_in = entity.locked_in,
                    private_in = entity.private_in,
                    action_ds = entity.action_ds,
                    action_dt = entity.action_dt,
                    case_question_in = entity.case_question_in,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_message MapTo(case_messageDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_message
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    message_nm = dto.message_nm,
                    email = dto.email,
                    subject_ds = dto.subject_ds,
                    body_tx = dto.body_tx,
                    reply_to_id = dto.reply_to_id,
                    posted_dt = dto.posted_dt,
                    auditor_id = dto.auditor_id,
                    total_replies_no = dto.total_replies_no,
                    thread_id = dto.thread_id,
                    ip_ds = dto.ip_ds,
                    emailed_in = dto.emailed_in,
                    status_id = dto.status_id,
                    locked_in = dto.locked_in,
                    private_in = dto.private_in,
                    action_ds = dto.action_ds,
                    action_dt = dto.action_dt,
                    case_question_in = dto.case_question_in,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_message fromEntity, case_messageDTO toDto);
			 partial void DoMapping(case_messageDTO fromDto, case_message toEntity);
		}
    }       
        [DataContract(Name="case_message_attachment", Namespace="urn:WBS/Models/Data")]
    public partial class case_message_attachmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_message_id")]
        public Int32 case_message_id
        {
            get; set;
        }
                
        [DataMember(Name="path_nm")]
        public String path_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_nm")]
        public String file_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_extension_nm")]
        public String file_extension_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_stream")]
        public Byte[] file_stream
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_message_attachment MapTo(case_message_attachmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_message_attachmentDTO MapFrom(case_message_attachment entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_message_attachmentMapper GetMapper()
        {
            return new case_message_attachmentMapper();   
        }
        
        public partial class case_message_attachmentMapper
		{
			 public case_message_attachmentDTO MapTo(case_message_attachment entity)
			 {
                if (entity == null) return null;
			    var dto = new case_message_attachmentDTO
                {   
                    id = entity.id,
                    case_message_id = entity.case_message_id,
                    path_nm = entity.path_nm,
                    file_nm = entity.file_nm,
                    file_extension_nm = entity.file_extension_nm,
                    file_stream = entity.file_stream,
                    status_id = entity.status_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_message_attachment MapTo(case_message_attachmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_message_attachment
                {   
                    id = dto.id,
                    case_message_id = dto.case_message_id,
                    path_nm = dto.path_nm,
                    file_nm = dto.file_nm,
                    file_extension_nm = dto.file_extension_nm,
                    file_stream = dto.file_stream,
                    status_id = dto.status_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_message_attachment fromEntity, case_message_attachmentDTO toDto);
			 partial void DoMapping(case_message_attachmentDTO fromDto, case_message_attachment toEntity);
		}
    }       
        [DataContract(Name="case_monitor", Namespace="urn:WBS/Models/Data")]
    public partial class case_monitorDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="review_dt")]
        public DateTime review_dt
        {
            get; set;
        }
                
        [DataMember(Name="action_ds")]
        public String action_ds
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_id")]
        public Int32 privilege_level_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_monitor MapTo(case_monitorDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_monitorDTO MapFrom(case_monitor entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_monitorMapper GetMapper()
        {
            return new case_monitorMapper();   
        }
        
        public partial class case_monitorMapper
		{
			 public case_monitorDTO MapTo(case_monitor entity)
			 {
                if (entity == null) return null;
			    var dto = new case_monitorDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    review_dt = entity.review_dt,
                    action_ds = entity.action_ds,
                    privilege_level_id = entity.privilege_level_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_monitor MapTo(case_monitorDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_monitor
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    review_dt = dto.review_dt,
                    action_ds = dto.action_ds,
                    privilege_level_id = dto.privilege_level_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_monitor fromEntity, case_monitorDTO toDto);
			 partial void DoMapping(case_monitorDTO fromDto, case_monitor toEntity);
		}
    }       
        [DataContract(Name="case_priority", Namespace="urn:WBS/Models/Data")]
    public partial class case_priorityDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_nm")]
        public String case_priority_nm
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_nf")]
        public String case_priority_nf
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_ns")]
        public String case_priority_ns
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_nr")]
        public String case_priority_nr
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_na")]
        public String case_priority_na
        {
            get; set;
        }
                
        [DataMember(Name="case_priority_nj")]
        public String case_priority_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_priority MapTo(case_priorityDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_priorityDTO MapFrom(case_priority entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_priorityMapper GetMapper()
        {
            return new case_priorityMapper();   
        }
        
        public partial class case_priorityMapper
		{
			 public case_priorityDTO MapTo(case_priority entity)
			 {
                if (entity == null) return null;
			    var dto = new case_priorityDTO
                {   
                    id = entity.id,
                    case_priority_nm = entity.case_priority_nm,
                    case_priority_nf = entity.case_priority_nf,
                    case_priority_ns = entity.case_priority_ns,
                    case_priority_nr = entity.case_priority_nr,
                    case_priority_na = entity.case_priority_na,
                    case_priority_nj = entity.case_priority_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_priority MapTo(case_priorityDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_priority
                {   
                    id = dto.id,
                    case_priority_nm = dto.case_priority_nm,
                    case_priority_nf = dto.case_priority_nf,
                    case_priority_ns = dto.case_priority_ns,
                    case_priority_nr = dto.case_priority_nr,
                    case_priority_na = dto.case_priority_na,
                    case_priority_nj = dto.case_priority_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_priority fromEntity, case_priorityDTO toDto);
			 partial void DoMapping(case_priorityDTO fromDto, case_priority toEntity);
		}
    }       
        [DataContract(Name="case_question", Namespace="urn:WBS/Models/Data")]
    public partial class case_questionDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Nullable<Int32> case_id
        {
            get; set;
        }
                
        [DataMember(Name="question_id")]
        public Nullable<Int32> question_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public case_question MapTo(case_questionDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_questionDTO MapFrom(case_question entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_questionMapper GetMapper()
        {
            return new case_questionMapper();   
        }
        
        public partial class case_questionMapper
		{
			 public case_questionDTO MapTo(case_question entity)
			 {
                if (entity == null) return null;
			    var dto = new case_questionDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    question_id = entity.question_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_question MapTo(case_questionDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_question
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    question_id = dto.question_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_question fromEntity, case_questionDTO toDto);
			 partial void DoMapping(case_questionDTO fromDto, case_question toEntity);
		}
    }       
        [DataContract(Name="case_reminder", Namespace="urn:WBS/Models/Data")]
    public partial class case_reminderDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="reminder_dt")]
        public DateTime reminder_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_reminder MapTo(case_reminderDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_reminderDTO MapFrom(case_reminder entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_reminderMapper GetMapper()
        {
            return new case_reminderMapper();   
        }
        
        public partial class case_reminderMapper
		{
			 public case_reminderDTO MapTo(case_reminder entity)
			 {
                if (entity == null) return null;
			    var dto = new case_reminderDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    reminder_dt = entity.reminder_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_reminder MapTo(case_reminderDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_reminder
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    reminder_dt = dto.reminder_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_reminder fromEntity, case_reminderDTO toDto);
			 partial void DoMapping(case_reminderDTO fromDto, case_reminder toEntity);
		}
    }       
        
    [DataContract(Name="case_reporter", Namespace="urn:WBS/Models/Data")]
    public partial class case_reporterDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="login_nm")]
        public String login_nm
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_login_nm")]
        public Byte[] encrypted_login_nm
        {
            get; set;
        }
                
        [DataMember(Name="password")]
        public String password
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_password")]
        public Byte[] encrypted_password
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_id")]
        public Nullable<Int32> privilege_level_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="registration_dt")]
        public Nullable<DateTime> registration_dt
        {
            get; set;
        }
                
        [DataMember(Name="effective_dt")]
        public DateTime effective_dt
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public DateTime expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="notification_in")]
        public Int32 notification_in
        {
            get; set;
        }
                
        [DataMember(Name="question_ds")]
        public String question_ds
        {
            get; set;
        }
                
        [DataMember(Name="answer_ds")]
        public String answer_ds
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_login_dt")]
        public Nullable<DateTime> last_login_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="case")]
        public caseDTO case
        {
            get; set;
        }
                        
        public case_reporter MapTo(case_reporterDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_reporterDTO MapFrom(case_reporter entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_reporterMapper GetMapper()
        {
            return new case_reporterMapper();   
        }
        
        public partial class case_reporterMapper
		{
			 public case_reporterDTO MapTo(case_reporter entity)
			 {
                if (entity == null) return null;
			    var dto = new case_reporterDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    login_nm = entity.login_nm,
                    encrypted_login_nm = entity.encrypted_login_nm,
                    password = entity.password,
                    encrypted_password = entity.encrypted_password,
                    privilege_level_id = entity.privilege_level_id,
                    status_id = entity.status_id,
                    registration_dt = entity.registration_dt,
                    effective_dt = entity.effective_dt,
                    expiry_dt = entity.expiry_dt,
                    notification_in = entity.notification_in,
                    question_ds = entity.question_ds,
                    answer_ds = entity.answer_ds,
                    email = entity.email,
                    notepad_tx = entity.notepad_tx,
                    last_login_dt = entity.last_login_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    case = caseDTO.GetMapper().MapTo(entity.case),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_reporter MapTo(case_reporterDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_reporter
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    login_nm = dto.login_nm,
                    encrypted_login_nm = dto.encrypted_login_nm,
                    password = dto.password,
                    encrypted_password = dto.encrypted_password,
                    privilege_level_id = dto.privilege_level_id,
                    status_id = dto.status_id,
                    registration_dt = dto.registration_dt,
                    effective_dt = dto.effective_dt,
                    expiry_dt = dto.expiry_dt,
                    notification_in = dto.notification_in,
                    question_ds = dto.question_ds,
                    answer_ds = dto.answer_ds,
                    email = dto.email,
                    notepad_tx = dto.notepad_tx,
                    last_login_dt = dto.last_login_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    case = caseDTO.GetMapper().MapTo(dto.case),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_reporter fromEntity, case_reporterDTO toDto);
			 partial void DoMapping(case_reporterDTO fromDto, case_reporter toEntity);
		}
    }       
        [DataContract(Name="case_source_type", Namespace="urn:WBS/Models/Data")]
    public partial class case_source_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="source_type_nm")]
        public String source_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="source_type_nf")]
        public String source_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="source_type_ns")]
        public String source_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="source_type_nr")]
        public String source_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="source_type_na")]
        public String source_type_na
        {
            get; set;
        }
                
        [DataMember(Name="source_type_nj")]
        public String source_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_source_type MapTo(case_source_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_source_typeDTO MapFrom(case_source_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_source_typeMapper GetMapper()
        {
            return new case_source_typeMapper();   
        }
        
        public partial class case_source_typeMapper
		{
			 public case_source_typeDTO MapTo(case_source_type entity)
			 {
                if (entity == null) return null;
			    var dto = new case_source_typeDTO
                {   
                    id = entity.id,
                    source_type_nm = entity.source_type_nm,
                    source_type_nf = entity.source_type_nf,
                    source_type_ns = entity.source_type_ns,
                    source_type_nr = entity.source_type_nr,
                    source_type_na = entity.source_type_na,
                    source_type_nj = entity.source_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_source_type MapTo(case_source_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_source_type
                {   
                    id = dto.id,
                    source_type_nm = dto.source_type_nm,
                    source_type_nf = dto.source_type_nf,
                    source_type_ns = dto.source_type_ns,
                    source_type_nr = dto.source_type_nr,
                    source_type_na = dto.source_type_na,
                    source_type_nj = dto.source_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_source_type fromEntity, case_source_typeDTO toDto);
			 partial void DoMapping(case_source_typeDTO fromDto, case_source_type toEntity);
		}
    }       
        [DataContract(Name="case_type", Namespace="urn:WBS/Models/Data")]
    public partial class case_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="negative_in")]
        public Int32 negative_in
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nm")]
        public String case_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nf")]
        public String case_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="case_type_ns")]
        public String case_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nr")]
        public String case_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="case_type_na")]
        public String case_type_na
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nj")]
        public String case_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_type MapTo(case_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_typeDTO MapFrom(case_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_typeMapper GetMapper()
        {
            return new case_typeMapper();   
        }
        
        public partial class case_typeMapper
		{
			 public case_typeDTO MapTo(case_type entity)
			 {
                if (entity == null) return null;
			    var dto = new case_typeDTO
                {   
                    id = entity.id,
                    status_id = entity.status_id,
                    negative_in = entity.negative_in,
                    case_type_nm = entity.case_type_nm,
                    case_type_nf = entity.case_type_nf,
                    case_type_ns = entity.case_type_ns,
                    case_type_nr = entity.case_type_nr,
                    case_type_na = entity.case_type_na,
                    case_type_nj = entity.case_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_type MapTo(case_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_type
                {   
                    id = dto.id,
                    status_id = dto.status_id,
                    negative_in = dto.negative_in,
                    case_type_nm = dto.case_type_nm,
                    case_type_nf = dto.case_type_nf,
                    case_type_ns = dto.case_type_ns,
                    case_type_nr = dto.case_type_nr,
                    case_type_na = dto.case_type_na,
                    case_type_nj = dto.case_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_type fromEntity, case_typeDTO toDto);
			 partial void DoMapping(case_typeDTO fromDto, case_type toEntity);
		}
    }       
        [DataContract(Name="case_type_detail", Namespace="urn:WBS/Models/Data")]
    public partial class case_type_detailDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_id")]
        public Int32 case_id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_id")]
        public Int32 case_type_id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_nm")]
        public String case_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_type_detail MapTo(case_type_detailDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_type_detailDTO MapFrom(case_type_detail entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_type_detailMapper GetMapper()
        {
            return new case_type_detailMapper();   
        }
        
        public partial class case_type_detailMapper
		{
			 public case_type_detailDTO MapTo(case_type_detail entity)
			 {
                if (entity == null) return null;
			    var dto = new case_type_detailDTO
                {   
                    id = entity.id,
                    case_id = entity.case_id,
                    case_type_id = entity.case_type_id,
                    case_type_nm = entity.case_type_nm,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_type_detail MapTo(case_type_detailDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_type_detail
                {   
                    id = dto.id,
                    case_id = dto.case_id,
                    case_type_id = dto.case_type_id,
                    case_type_nm = dto.case_type_nm,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_type_detail fromEntity, case_type_detailDTO toDto);
			 partial void DoMapping(case_type_detailDTO fromDto, case_type_detail toEntity);
		}
    }       
        [DataContract(Name="case_validation_type", Namespace="urn:WBS/Models/Data")]
    public partial class case_validation_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_nm")]
        public String validation_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_nf")]
        public String validation_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_ns")]
        public String validation_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_nr")]
        public String validation_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_na")]
        public String validation_type_na
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_nj")]
        public String validation_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public case_validation_type MapTo(case_validation_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static case_validation_typeDTO MapFrom(case_validation_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static case_validation_typeMapper GetMapper()
        {
            return new case_validation_typeMapper();   
        }
        
        public partial class case_validation_typeMapper
		{
			 public case_validation_typeDTO MapTo(case_validation_type entity)
			 {
                if (entity == null) return null;
			    var dto = new case_validation_typeDTO
                {   
                    id = entity.id,
                    validation_type_nm = entity.validation_type_nm,
                    validation_type_nf = entity.validation_type_nf,
                    validation_type_ns = entity.validation_type_ns,
                    validation_type_nr = entity.validation_type_nr,
                    validation_type_na = entity.validation_type_na,
                    validation_type_nj = entity.validation_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public case_validation_type MapTo(case_validation_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new case_validation_type
                {   
                    id = dto.id,
                    validation_type_nm = dto.validation_type_nm,
                    validation_type_nf = dto.validation_type_nf,
                    validation_type_ns = dto.validation_type_ns,
                    validation_type_nr = dto.validation_type_nr,
                    validation_type_na = dto.validation_type_na,
                    validation_type_nj = dto.validation_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(case_validation_type fromEntity, case_validation_typeDTO toDto);
			 partial void DoMapping(case_validation_typeDTO fromDto, case_validation_type toEntity);
		}
    }       
        [DataContract(Name="client", Namespace="urn:WBS/Models/Data")]
    public partial class clientDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="address_id")]
        public Int32 address_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="client_nm")]
        public String client_nm
        {
            get; set;
        }
                
        [DataMember(Name="client_ds")]
        public String client_ds
        {
            get; set;
        }
                
        [DataMember(Name="registration_dt")]
        public DateTime registration_dt
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="companies")]
        public ICollection<company> companies
        {
            get; set;
        }
                
        [DataMember(Name="cases")]
        public ICollection<@case> cases
        {
            get; set;
        }
                        
        public client MapTo(clientDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static clientDTO MapFrom(client entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static clientMapper GetMapper()
        {
            return new clientMapper();   
        }
        
        public partial class clientMapper
		{
			 public clientDTO MapTo(client entity)
			 {
                if (entity == null) return null;
			    var dto = new clientDTO
                {   
                    id = entity.id,
                    address_id = entity.address_id,
                    status_id = entity.status_id,
                    client_nm = entity.client_nm,
                    client_ds = entity.client_ds,
                    registration_dt = entity.registration_dt,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    companies = entity.companies,
                    cases = entity.cases,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public client MapTo(clientDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new client
                {   
                    id = dto.id,
                    address_id = dto.address_id,
                    status_id = dto.status_id,
                    client_nm = dto.client_nm,
                    client_ds = dto.client_ds,
                    registration_dt = dto.registration_dt,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    companies = dto.companies,
                    cases = dto.cases,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(client fromEntity, clientDTO toDto);
			 partial void DoMapping(clientDTO fromDto, client toEntity);
		}
    }       
        [DataContract(Name="client_marketing_material", Namespace="urn:WBS/Models/Data")]
    public partial class client_marketing_materialDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_id")]
        public Int32 marketing_material_type_id
        {
            get; set;
        }
                
        [DataMember(Name="order_dt")]
        public DateTime order_dt
        {
            get; set;
        }
                
        [DataMember(Name="official_language_id")]
        public Int32 official_language_id
        {
            get; set;
        }
                
        [DataMember(Name="language_nm")]
        public String language_nm
        {
            get; set;
        }
                
        [DataMember(Name="quantity")]
        public Int32 quantity
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public client_marketing_material MapTo(client_marketing_materialDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static client_marketing_materialDTO MapFrom(client_marketing_material entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static client_marketing_materialMapper GetMapper()
        {
            return new client_marketing_materialMapper();   
        }
        
        public partial class client_marketing_materialMapper
		{
			 public client_marketing_materialDTO MapTo(client_marketing_material entity)
			 {
                if (entity == null) return null;
			    var dto = new client_marketing_materialDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    marketing_material_type_id = entity.marketing_material_type_id,
                    order_dt = entity.order_dt,
                    official_language_id = entity.official_language_id,
                    language_nm = entity.language_nm,
                    quantity = entity.quantity,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public client_marketing_material MapTo(client_marketing_materialDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new client_marketing_material
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    marketing_material_type_id = dto.marketing_material_type_id,
                    order_dt = dto.order_dt,
                    official_language_id = dto.official_language_id,
                    language_nm = dto.language_nm,
                    quantity = dto.quantity,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(client_marketing_material fromEntity, client_marketing_materialDTO toDto);
			 partial void DoMapping(client_marketing_materialDTO fromDto, client_marketing_material toEntity);
		}
    }       
        [DataContract(Name="company", Namespace="urn:WBS/Models/Data")]
    public partial class companyDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="address_id")]
        public Int32 address_id
        {
            get; set;
        }
                
        [DataMember(Name="billing_info_id")]
        public Int32 billing_info_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="company_nm")]
        public String company_nm
        {
            get; set;
        }
                
        [DataMember(Name="registration_dt")]
        public Nullable<DateTime> registration_dt
        {
            get; set;
        }
                
        [DataMember(Name="contact_nm")]
        public String contact_nm
        {
            get; set;
        }
                
        [DataMember(Name="official_language_id")]
        public Nullable<Int32> official_language_id
        {
            get; set;
        }
                
        [DataMember(Name="employee_qy")]
        public Nullable<Int32> employee_qy
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tf")]
        public String notepad_tf
        {
            get; set;
        }
                
        [DataMember(Name="notepad_ts")]
        public String notepad_ts
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tr")]
        public String notepad_tr
        {
            get; set;
        }
                
        [DataMember(Name="notepad_ta")]
        public String notepad_ta
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tj")]
        public String notepad_tj
        {
            get; set;
        }
                
        [DataMember(Name="path_ds")]
        public String path_ds
        {
            get; set;
        }
                
        [DataMember(Name="path_df")]
        public String path_df
        {
            get; set;
        }
                
        [DataMember(Name="path_de")]
        public String path_de
        {
            get; set;
        }
                
        [DataMember(Name="path_dr")]
        public String path_dr
        {
            get; set;
        }
                
        [DataMember(Name="path_da")]
        public String path_da
        {
            get; set;
        }
                
        [DataMember(Name="path_dj")]
        public String path_dj
        {
            get; set;
        }
                
        [DataMember(Name="alert_ds")]
        public String alert_ds
        {
            get; set;
        }
                
        [DataMember(Name="alert_df")]
        public String alert_df
        {
            get; set;
        }
                
        [DataMember(Name="alert_de")]
        public String alert_de
        {
            get; set;
        }
                
        [DataMember(Name="alert_dr")]
        public String alert_dr
        {
            get; set;
        }
                
        [DataMember(Name="alert_da")]
        public String alert_da
        {
            get; set;
        }
                
        [DataMember(Name="alert_dj")]
        public String alert_dj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="code_file_nm")]
        public String code_file_nm
        {
            get; set;
        }
                
        [DataMember(Name="client")]
        public clientDTO client
        {
            get; set;
        }
                
        [DataMember(Name="users")]
        public ICollection<user> users
        {
            get; set;
        }
                
        [DataMember(Name="cases")]
        public ICollection<@case> cases
        {
            get; set;
        }
                
        [DataMember(Name="incidents")]
        public ICollection<incident> incidents
        {
            get; set;
        }
                
        [DataMember(Name="invoices")]
        public ICollection<invoice> invoices
        {
            get; set;
        }
                
        [DataMember(Name="address")]
        public addressDTO address
        {
            get; set;
        }
                        
        public company MapTo(companyDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static companyDTO MapFrom(company entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static companyMapper GetMapper()
        {
            return new companyMapper();   
        }
        
        public partial class companyMapper
		{
			 public companyDTO MapTo(company entity)
			 {
                if (entity == null) return null;
			    var dto = new companyDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    address_id = entity.address_id,
                    billing_info_id = entity.billing_info_id,
                    status_id = entity.status_id,
                    company_nm = entity.company_nm,
                    registration_dt = entity.registration_dt,
                    contact_nm = entity.contact_nm,
                    official_language_id = entity.official_language_id,
                    employee_qy = entity.employee_qy,
                    notepad_tx = entity.notepad_tx,
                    notepad_tf = entity.notepad_tf,
                    notepad_ts = entity.notepad_ts,
                    notepad_tr = entity.notepad_tr,
                    notepad_ta = entity.notepad_ta,
                    notepad_tj = entity.notepad_tj,
                    path_ds = entity.path_ds,
                    path_df = entity.path_df,
                    path_de = entity.path_de,
                    path_dr = entity.path_dr,
                    path_da = entity.path_da,
                    path_dj = entity.path_dj,
                    alert_ds = entity.alert_ds,
                    alert_df = entity.alert_df,
                    alert_de = entity.alert_de,
                    alert_dr = entity.alert_dr,
                    alert_da = entity.alert_da,
                    alert_dj = entity.alert_dj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    code_file_nm = entity.code_file_nm,
                    client = clientDTO.GetMapper().MapTo(entity.client),
                    users = entity.users,
                    cases = entity.cases,
                    incidents = entity.incidents,
                    invoices = entity.invoices,
                    address = addressDTO.GetMapper().MapTo(entity.address),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company MapTo(companyDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    address_id = dto.address_id,
                    billing_info_id = dto.billing_info_id,
                    status_id = dto.status_id,
                    company_nm = dto.company_nm,
                    registration_dt = dto.registration_dt,
                    contact_nm = dto.contact_nm,
                    official_language_id = dto.official_language_id,
                    employee_qy = dto.employee_qy,
                    notepad_tx = dto.notepad_tx,
                    notepad_tf = dto.notepad_tf,
                    notepad_ts = dto.notepad_ts,
                    notepad_tr = dto.notepad_tr,
                    notepad_ta = dto.notepad_ta,
                    notepad_tj = dto.notepad_tj,
                    path_ds = dto.path_ds,
                    path_df = dto.path_df,
                    path_de = dto.path_de,
                    path_dr = dto.path_dr,
                    path_da = dto.path_da,
                    path_dj = dto.path_dj,
                    alert_ds = dto.alert_ds,
                    alert_df = dto.alert_df,
                    alert_de = dto.alert_de,
                    alert_dr = dto.alert_dr,
                    alert_da = dto.alert_da,
                    alert_dj = dto.alert_dj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    code_file_nm = dto.code_file_nm,
                    client = clientDTO.GetMapper().MapTo(dto.client),
                    users = dto.users,
                    cases = dto.cases,
                    incidents = dto.incidents,
                    invoices = dto.invoices,
                    address = addressDTO.GetMapper().MapTo(dto.address),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company fromEntity, companyDTO toDto);
			 partial void DoMapping(companyDTO fromDto, company toEntity);
		}
    }       
        [DataContract(Name="company_auditor", Namespace="urn:WBS/Models/Data")]
    public partial class company_auditorDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public company_auditor MapTo(company_auditorDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_auditorDTO MapFrom(company_auditor entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_auditorMapper GetMapper()
        {
            return new company_auditorMapper();   
        }
        
        public partial class company_auditorMapper
		{
			 public company_auditorDTO MapTo(company_auditor entity)
			 {
                if (entity == null) return null;
			    var dto = new company_auditorDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    auditor_id = entity.auditor_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_auditor MapTo(company_auditorDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_auditor
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    auditor_id = dto.auditor_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_auditor fromEntity, company_auditorDTO toDto);
			 partial void DoMapping(company_auditorDTO fromDto, company_auditor toEntity);
		}
    }       
        [DataContract(Name="company_code", Namespace="urn:WBS/Models/Data")]
    public partial class company_codeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="address_id")]
        public Nullable<Int32> address_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Nullable<Int32> company_id
        {
            get; set;
        }
                
        [DataMember(Name="company_nm")]
        public String company_nm
        {
            get; set;
        }
                
        [DataMember(Name="code")]
        public String code
        {
            get; set;
        }
                
        [DataMember(Name="employee_qy")]
        public Nullable<Int32> employee_qy
        {
            get; set;
        }
                
        [DataMember(Name="activation_dt")]
        public Nullable<DateTime> activation_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public company_code MapTo(company_codeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_codeDTO MapFrom(company_code entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_codeMapper GetMapper()
        {
            return new company_codeMapper();   
        }
        
        public partial class company_codeMapper
		{
			 public company_codeDTO MapTo(company_code entity)
			 {
                if (entity == null) return null;
			    var dto = new company_codeDTO
                {   
                    id = entity.id,
                    address_id = entity.address_id,
                    status_id = entity.status_id,
                    company_id = entity.company_id,
                    company_nm = entity.company_nm,
                    code = entity.code,
                    employee_qy = entity.employee_qy,
                    activation_dt = entity.activation_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_code MapTo(company_codeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_code
                {   
                    id = dto.id,
                    address_id = dto.address_id,
                    status_id = dto.status_id,
                    company_id = dto.company_id,
                    company_nm = dto.company_nm,
                    code = dto.code,
                    employee_qy = dto.employee_qy,
                    activation_dt = dto.activation_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_code fromEntity, company_codeDTO toDto);
			 partial void DoMapping(company_codeDTO fromDto, company_code toEntity);
		}
    }       
        [DataContract(Name="company_incident_type", Namespace="urn:WBS/Models/Data")]
    public partial class company_incident_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nm")]
        public String incident_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nf")]
        public String incident_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_ns")]
        public String incident_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nr")]
        public String incident_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_na")]
        public String incident_type_na
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nj")]
        public String incident_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public company_incident_type MapTo(company_incident_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static company_incident_typeDTO MapFrom(company_incident_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static company_incident_typeMapper GetMapper()
        {
            return new company_incident_typeMapper();   
        }
        
        public partial class company_incident_typeMapper
		{
			 public company_incident_typeDTO MapTo(company_incident_type entity)
			 {
                if (entity == null) return null;
			    var dto = new company_incident_typeDTO
                {   
                    id = entity.id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    incident_type_nm = entity.incident_type_nm,
                    incident_type_nf = entity.incident_type_nf,
                    incident_type_ns = entity.incident_type_ns,
                    incident_type_nr = entity.incident_type_nr,
                    incident_type_na = entity.incident_type_na,
                    incident_type_nj = entity.incident_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public company_incident_type MapTo(company_incident_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new company_incident_type
                {   
                    id = dto.id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    incident_type_nm = dto.incident_type_nm,
                    incident_type_nf = dto.incident_type_nf,
                    incident_type_ns = dto.incident_type_ns,
                    incident_type_nr = dto.incident_type_nr,
                    incident_type_na = dto.incident_type_na,
                    incident_type_nj = dto.incident_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(company_incident_type fromEntity, company_incident_typeDTO toDto);
			 partial void DoMapping(company_incident_typeDTO fromDto, company_incident_type toEntity);
		}
    }       
        [DataContract(Name="country", Namespace="urn:WBS/Models/Data")]
    public partial class countryDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="country_cl")]
        public String country_cl
        {
            get; set;
        }
                
        [DataMember(Name="country_nm")]
        public String country_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public country MapTo(countryDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static countryDTO MapFrom(country entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static countryMapper GetMapper()
        {
            return new countryMapper();   
        }
        
        public partial class countryMapper
		{
			 public countryDTO MapTo(country entity)
			 {
                if (entity == null) return null;
			    var dto = new countryDTO
                {   
                    id = entity.id,
                    status_id = entity.status_id,
                    country_cl = entity.country_cl,
                    country_nm = entity.country_nm,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public country MapTo(countryDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new country
                {   
                    id = dto.id,
                    status_id = dto.status_id,
                    country_cl = dto.country_cl,
                    country_nm = dto.country_nm,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(country fromEntity, countryDTO toDto);
			 partial void DoMapping(countryDTO fromDto, country toEntity);
		}
    }       
        [DataContract(Name="department", Namespace="urn:WBS/Models/Data")]
    public partial class departmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="department_nm")]
        public String department_nm
        {
            get; set;
        }
                
        [DataMember(Name="department_nf")]
        public String department_nf
        {
            get; set;
        }
                
        [DataMember(Name="department_ns")]
        public String department_ns
        {
            get; set;
        }
                
        [DataMember(Name="department_nr")]
        public String department_nr
        {
            get; set;
        }
                
        [DataMember(Name="department_na")]
        public String department_na
        {
            get; set;
        }
                
        [DataMember(Name="department_nj")]
        public String department_nj
        {
            get; set;
        }
                
        [DataMember(Name="department_ds")]
        public String department_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public department MapTo(departmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static departmentDTO MapFrom(department entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static departmentMapper GetMapper()
        {
            return new departmentMapper();   
        }
        
        public partial class departmentMapper
		{
			 public departmentDTO MapTo(department entity)
			 {
                if (entity == null) return null;
			    var dto = new departmentDTO
                {   
                    id = entity.id,
                    department_nm = entity.department_nm,
                    department_nf = entity.department_nf,
                    department_ns = entity.department_ns,
                    department_nr = entity.department_nr,
                    department_na = entity.department_na,
                    department_nj = entity.department_nj,
                    department_ds = entity.department_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public department MapTo(departmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new department
                {   
                    id = dto.id,
                    department_nm = dto.department_nm,
                    department_nf = dto.department_nf,
                    department_ns = dto.department_ns,
                    department_nr = dto.department_nr,
                    department_na = dto.department_na,
                    department_nj = dto.department_nj,
                    department_ds = dto.department_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(department fromEntity, departmentDTO toDto);
			 partial void DoMapping(departmentDTO fromDto, department toEntity);
		}
    }       
        [DataContract(Name="department_wpa", Namespace="urn:WBS/Models/Data")]
    public partial class department_wpaDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="department_nm")]
        public String department_nm
        {
            get; set;
        }
                
        [DataMember(Name="department_nf")]
        public String department_nf
        {
            get; set;
        }
                
        [DataMember(Name="department_ns")]
        public String department_ns
        {
            get; set;
        }
                
        [DataMember(Name="department_nr")]
        public String department_nr
        {
            get; set;
        }
                
        [DataMember(Name="department_na")]
        public String department_na
        {
            get; set;
        }
                
        [DataMember(Name="department_ds")]
        public String department_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public department_wpa MapTo(department_wpaDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static department_wpaDTO MapFrom(department_wpa entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static department_wpaMapper GetMapper()
        {
            return new department_wpaMapper();   
        }
        
        public partial class department_wpaMapper
		{
			 public department_wpaDTO MapTo(department_wpa entity)
			 {
                if (entity == null) return null;
			    var dto = new department_wpaDTO
                {   
                    id = entity.id,
                    department_nm = entity.department_nm,
                    department_nf = entity.department_nf,
                    department_ns = entity.department_ns,
                    department_nr = entity.department_nr,
                    department_na = entity.department_na,
                    department_ds = entity.department_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public department_wpa MapTo(department_wpaDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new department_wpa
                {   
                    id = dto.id,
                    department_nm = dto.department_nm,
                    department_nf = dto.department_nf,
                    department_ns = dto.department_ns,
                    department_nr = dto.department_nr,
                    department_na = dto.department_na,
                    department_ds = dto.department_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(department_wpa fromEntity, department_wpaDTO toDto);
			 partial void DoMapping(department_wpaDTO fromDto, department_wpa toEntity);
		}
    }       
        [DataContract(Name="incident", Namespace="urn:WBS/Models/Data")]
    public partial class incidentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Nullable<Int32> auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_nm")]
        public String incident_nm
        {
            get; set;
        }
                
        [DataMember(Name="assigned_dt")]
        public Nullable<DateTime> assigned_dt
        {
            get; set;
        }
                
        [DataMember(Name="opened_dt")]
        public Nullable<DateTime> opened_dt
        {
            get; set;
        }
                
        [DataMember(Name="incident_priority_id")]
        public Int32 incident_priority_id
        {
            get; set;
        }
                
        [DataMember(Name="reported_dt")]
        public DateTime reported_dt
        {
            get; set;
        }
                
        [DataMember(Name="incident_dt")]
        public DateTime incident_dt
        {
            get; set;
        }
                
        [DataMember(Name="reported_in")]
        public Int32 reported_in
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="location_nm")]
        public String location_nm
        {
            get; set;
        }
                
        [DataMember(Name="department_nm")]
        public String department_nm
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_id")]
        public Nullable<Int32> incident_type_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nm")]
        public String incident_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="incident_ds")]
        public String incident_ds
        {
            get; set;
        }
                
        [DataMember(Name="occurred_ds")]
        public String occurred_ds
        {
            get; set;
        }
                
        [DataMember(Name="witnessed_ds")]
        public String witnessed_ds
        {
            get; set;
        }
                
        [DataMember(Name="involved_ds")]
        public String involved_ds
        {
            get; set;
        }
                
        [DataMember(Name="initiated_ds")]
        public String initiated_ds
        {
            get; set;
        }
                
        [DataMember(Name="injury_ds")]
        public String injury_ds
        {
            get; set;
        }
                
        [DataMember(Name="damage_ds")]
        public String damage_ds
        {
            get; set;
        }
                
        [DataMember(Name="supervisor_ds")]
        public String supervisor_ds
        {
            get; set;
        }
                
        [DataMember(Name="supervisor_action_ds")]
        public String supervisor_action_ds
        {
            get; set;
        }
                
        [DataMember(Name="reportedto_ds")]
        public String reportedto_ds
        {
            get; set;
        }
                
        [DataMember(Name="employee_ds")]
        public String employee_ds
        {
            get; set;
        }
                
        [DataMember(Name="outside_witness_in")]
        public Nullable<Int32> outside_witness_in
        {
            get; set;
        }
                
        [DataMember(Name="to_whom_ds")]
        public String to_whom_ds
        {
            get; set;
        }
                
        [DataMember(Name="who_made_ds")]
        public String who_made_ds
        {
            get; set;
        }
                
        [DataMember(Name="witness_in")]
        public Nullable<Int32> witness_in
        {
            get; set;
        }
                
        [DataMember(Name="witness_ds")]
        public String witness_ds
        {
            get; set;
        }
                
        [DataMember(Name="cooperative_ds")]
        public String cooperative_ds
        {
            get; set;
        }
                
        [DataMember(Name="contacted_ds")]
        public String contacted_ds
        {
            get; set;
        }
                
        [DataMember(Name="best_means_ds")]
        public String best_means_ds
        {
            get; set;
        }
                
        [DataMember(Name="further_ds")]
        public String further_ds
        {
            get; set;
        }
                
        [DataMember(Name="individuals_ds")]
        public String individuals_ds
        {
            get; set;
        }
                
        [DataMember(Name="incident_anonymity_id")]
        public Int32 incident_anonymity_id
        {
            get; set;
        }
                
        [DataMember(Name="work_no")]
        public String work_no
        {
            get; set;
        }
                
        [DataMember(Name="home_no")]
        public String home_no
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="willing_ds")]
        public String willing_ds
        {
            get; set;
        }
                
        [DataMember(Name="best_way_ds")]
        public String best_way_ds
        {
            get; set;
        }
                
        [DataMember(Name="comments_ds")]
        public String comments_ds
        {
            get; set;
        }
                
        [DataMember(Name="implicated_in")]
        public Int32 implicated_in
        {
            get; set;
        }
                
        [DataMember(Name="source_type_id")]
        public Nullable<Int32> source_type_id
        {
            get; set;
        }
                
        [DataMember(Name="validation_type_id")]
        public Nullable<Int32> validation_type_id
        {
            get; set;
        }
                
        [DataMember(Name="action_type_id")]
        public Nullable<Int32> action_type_id
        {
            get; set;
        }
                
        [DataMember(Name="outcome_action_ds")]
        public String outcome_action_ds
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="ongoing_in")]
        public Nullable<Int32> ongoing_in
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_reporter")]
        public ICollection<incident_reporter> incident_reporter
        {
            get; set;
        }
                
        [DataMember(Name="company")]
        public companyDTO company
        {
            get; set;
        }
                        
        public incident MapTo(incidentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incidentDTO MapFrom(incident entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incidentMapper GetMapper()
        {
            return new incidentMapper();   
        }
        
        public partial class incidentMapper
		{
			 public incidentDTO MapTo(incident entity)
			 {
                if (entity == null) return null;
			    var dto = new incidentDTO
                {   
                    id = entity.id,
                    company_id = entity.company_id,
                    status_id = entity.status_id,
                    auditor_id = entity.auditor_id,
                    incident_nm = entity.incident_nm,
                    assigned_dt = entity.assigned_dt,
                    opened_dt = entity.opened_dt,
                    incident_priority_id = entity.incident_priority_id,
                    reported_dt = entity.reported_dt,
                    incident_dt = entity.incident_dt,
                    reported_in = entity.reported_in,
                    client_id = entity.client_id,
                    location_nm = entity.location_nm,
                    department_nm = entity.department_nm,
                    incident_type_id = entity.incident_type_id,
                    incident_type_nm = entity.incident_type_nm,
                    incident_ds = entity.incident_ds,
                    occurred_ds = entity.occurred_ds,
                    witnessed_ds = entity.witnessed_ds,
                    involved_ds = entity.involved_ds,
                    initiated_ds = entity.initiated_ds,
                    injury_ds = entity.injury_ds,
                    damage_ds = entity.damage_ds,
                    supervisor_ds = entity.supervisor_ds,
                    supervisor_action_ds = entity.supervisor_action_ds,
                    reportedto_ds = entity.reportedto_ds,
                    employee_ds = entity.employee_ds,
                    outside_witness_in = entity.outside_witness_in,
                    to_whom_ds = entity.to_whom_ds,
                    who_made_ds = entity.who_made_ds,
                    witness_in = entity.witness_in,
                    witness_ds = entity.witness_ds,
                    cooperative_ds = entity.cooperative_ds,
                    contacted_ds = entity.contacted_ds,
                    best_means_ds = entity.best_means_ds,
                    further_ds = entity.further_ds,
                    individuals_ds = entity.individuals_ds,
                    incident_anonymity_id = entity.incident_anonymity_id,
                    work_no = entity.work_no,
                    home_no = entity.home_no,
                    email = entity.email,
                    willing_ds = entity.willing_ds,
                    best_way_ds = entity.best_way_ds,
                    comments_ds = entity.comments_ds,
                    implicated_in = entity.implicated_in,
                    source_type_id = entity.source_type_id,
                    validation_type_id = entity.validation_type_id,
                    action_type_id = entity.action_type_id,
                    outcome_action_ds = entity.outcome_action_ds,
                    notepad_tx = entity.notepad_tx,
                    ongoing_in = entity.ongoing_in,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    incident_reporter = entity.incident_reporter,
                    company = companyDTO.GetMapper().MapTo(entity.company),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident MapTo(incidentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident
                {   
                    id = dto.id,
                    company_id = dto.company_id,
                    status_id = dto.status_id,
                    auditor_id = dto.auditor_id,
                    incident_nm = dto.incident_nm,
                    assigned_dt = dto.assigned_dt,
                    opened_dt = dto.opened_dt,
                    incident_priority_id = dto.incident_priority_id,
                    reported_dt = dto.reported_dt,
                    incident_dt = dto.incident_dt,
                    reported_in = dto.reported_in,
                    client_id = dto.client_id,
                    location_nm = dto.location_nm,
                    department_nm = dto.department_nm,
                    incident_type_id = dto.incident_type_id,
                    incident_type_nm = dto.incident_type_nm,
                    incident_ds = dto.incident_ds,
                    occurred_ds = dto.occurred_ds,
                    witnessed_ds = dto.witnessed_ds,
                    involved_ds = dto.involved_ds,
                    initiated_ds = dto.initiated_ds,
                    injury_ds = dto.injury_ds,
                    damage_ds = dto.damage_ds,
                    supervisor_ds = dto.supervisor_ds,
                    supervisor_action_ds = dto.supervisor_action_ds,
                    reportedto_ds = dto.reportedto_ds,
                    employee_ds = dto.employee_ds,
                    outside_witness_in = dto.outside_witness_in,
                    to_whom_ds = dto.to_whom_ds,
                    who_made_ds = dto.who_made_ds,
                    witness_in = dto.witness_in,
                    witness_ds = dto.witness_ds,
                    cooperative_ds = dto.cooperative_ds,
                    contacted_ds = dto.contacted_ds,
                    best_means_ds = dto.best_means_ds,
                    further_ds = dto.further_ds,
                    individuals_ds = dto.individuals_ds,
                    incident_anonymity_id = dto.incident_anonymity_id,
                    work_no = dto.work_no,
                    home_no = dto.home_no,
                    email = dto.email,
                    willing_ds = dto.willing_ds,
                    best_way_ds = dto.best_way_ds,
                    comments_ds = dto.comments_ds,
                    implicated_in = dto.implicated_in,
                    source_type_id = dto.source_type_id,
                    validation_type_id = dto.validation_type_id,
                    action_type_id = dto.action_type_id,
                    outcome_action_ds = dto.outcome_action_ds,
                    notepad_tx = dto.notepad_tx,
                    ongoing_in = dto.ongoing_in,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    incident_reporter = dto.incident_reporter,
                    company = companyDTO.GetMapper().MapTo(dto.company),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident fromEntity, incidentDTO toDto);
			 partial void DoMapping(incidentDTO fromDto, incident toEntity);
		}
    }       
        [DataContract(Name="incident_attachment", Namespace="urn:WBS/Models/Data")]
    public partial class incident_attachmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="path_nm")]
        public String path_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_nm")]
        public String file_nm
        {
            get; set;
        }
                
        [DataMember(Name="extension_nm")]
        public String extension_nm
        {
            get; set;
        }
                
        [DataMember(Name="effective_dt")]
        public DateTime effective_dt
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public DateTime expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_attachment MapTo(incident_attachmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_attachmentDTO MapFrom(incident_attachment entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_attachmentMapper GetMapper()
        {
            return new incident_attachmentMapper();   
        }
        
        public partial class incident_attachmentMapper
		{
			 public incident_attachmentDTO MapTo(incident_attachment entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_attachmentDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    status_id = entity.status_id,
                    path_nm = entity.path_nm,
                    file_nm = entity.file_nm,
                    extension_nm = entity.extension_nm,
                    effective_dt = entity.effective_dt,
                    expiry_dt = entity.expiry_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_attachment MapTo(incident_attachmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_attachment
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    status_id = dto.status_id,
                    path_nm = dto.path_nm,
                    file_nm = dto.file_nm,
                    extension_nm = dto.extension_nm,
                    effective_dt = dto.effective_dt,
                    expiry_dt = dto.expiry_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_attachment fromEntity, incident_attachmentDTO toDto);
			 partial void DoMapping(incident_attachmentDTO fromDto, incident_attachment toEntity);
		}
    }       
        [DataContract(Name="incident_auditor", Namespace="urn:WBS/Models/Data")]
    public partial class incident_auditorDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="assigned_dt")]
        public DateTime assigned_dt
        {
            get; set;
        }
                
        [DataMember(Name="notification_in")]
        public Int32 notification_in
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_auditor MapTo(incident_auditorDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_auditorDTO MapFrom(incident_auditor entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_auditorMapper GetMapper()
        {
            return new incident_auditorMapper();   
        }
        
        public partial class incident_auditorMapper
		{
			 public incident_auditorDTO MapTo(incident_auditor entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_auditorDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    auditor_id = entity.auditor_id,
                    assigned_dt = entity.assigned_dt,
                    notification_in = entity.notification_in,
                    status_id = entity.status_id,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_auditor MapTo(incident_auditorDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_auditor
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    auditor_id = dto.auditor_id,
                    assigned_dt = dto.assigned_dt,
                    notification_in = dto.notification_in,
                    status_id = dto.status_id,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_auditor fromEntity, incident_auditorDTO toDto);
			 partial void DoMapping(incident_auditorDTO fromDto, incident_auditor toEntity);
		}
    }       
        [DataContract(Name="incident_implicated", Namespace="urn:WBS/Models/Data")]
    public partial class incident_implicatedDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="client_id")]
        public Int32 client_id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_implicated MapTo(incident_implicatedDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_implicatedDTO MapFrom(incident_implicated entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_implicatedMapper GetMapper()
        {
            return new incident_implicatedMapper();   
        }
        
        public partial class incident_implicatedMapper
		{
			 public incident_implicatedDTO MapTo(incident_implicated entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_implicatedDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    client_id = entity.client_id,
                    company_id = entity.company_id,
                    auditor_id = entity.auditor_id,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_implicated MapTo(incident_implicatedDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_implicated
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    client_id = dto.client_id,
                    company_id = dto.company_id,
                    auditor_id = dto.auditor_id,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_implicated fromEntity, incident_implicatedDTO toDto);
			 partial void DoMapping(incident_implicatedDTO fromDto, incident_implicated toEntity);
		}
    }       
        [DataContract(Name="incident_message", Namespace="urn:WBS/Models/Data")]
    public partial class incident_messageDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="message_nm")]
        public String message_nm
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="subject_ds")]
        public String subject_ds
        {
            get; set;
        }
                
        [DataMember(Name="body_tx")]
        public String body_tx
        {
            get; set;
        }
                
        [DataMember(Name="reply_to_id")]
        public Nullable<Int32> reply_to_id
        {
            get; set;
        }
                
        [DataMember(Name="posted_dt")]
        public Nullable<DateTime> posted_dt
        {
            get; set;
        }
                
        [DataMember(Name="auditor_id")]
        public Int32 auditor_id
        {
            get; set;
        }
                
        [DataMember(Name="total_replies_no")]
        public Int32 total_replies_no
        {
            get; set;
        }
                
        [DataMember(Name="thread_id")]
        public Nullable<Int32> thread_id
        {
            get; set;
        }
                
        [DataMember(Name="ip_ds")]
        public String ip_ds
        {
            get; set;
        }
                
        [DataMember(Name="emailed_in")]
        public Int32 emailed_in
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="locked_in")]
        public Int32 locked_in
        {
            get; set;
        }
                
        [DataMember(Name="private_in")]
        public Int32 private_in
        {
            get; set;
        }
                
        [DataMember(Name="action_ds")]
        public String action_ds
        {
            get; set;
        }
                
        [DataMember(Name="action_dt")]
        public Nullable<DateTime> action_dt
        {
            get; set;
        }
                
        [DataMember(Name="incident_question_in")]
        public Int32 incident_question_in
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_message MapTo(incident_messageDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_messageDTO MapFrom(incident_message entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_messageMapper GetMapper()
        {
            return new incident_messageMapper();   
        }
        
        public partial class incident_messageMapper
		{
			 public incident_messageDTO MapTo(incident_message entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_messageDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    message_nm = entity.message_nm,
                    email = entity.email,
                    subject_ds = entity.subject_ds,
                    body_tx = entity.body_tx,
                    reply_to_id = entity.reply_to_id,
                    posted_dt = entity.posted_dt,
                    auditor_id = entity.auditor_id,
                    total_replies_no = entity.total_replies_no,
                    thread_id = entity.thread_id,
                    ip_ds = entity.ip_ds,
                    emailed_in = entity.emailed_in,
                    status_id = entity.status_id,
                    locked_in = entity.locked_in,
                    private_in = entity.private_in,
                    action_ds = entity.action_ds,
                    action_dt = entity.action_dt,
                    incident_question_in = entity.incident_question_in,
                    notepad_tx = entity.notepad_tx,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_message MapTo(incident_messageDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_message
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    message_nm = dto.message_nm,
                    email = dto.email,
                    subject_ds = dto.subject_ds,
                    body_tx = dto.body_tx,
                    reply_to_id = dto.reply_to_id,
                    posted_dt = dto.posted_dt,
                    auditor_id = dto.auditor_id,
                    total_replies_no = dto.total_replies_no,
                    thread_id = dto.thread_id,
                    ip_ds = dto.ip_ds,
                    emailed_in = dto.emailed_in,
                    status_id = dto.status_id,
                    locked_in = dto.locked_in,
                    private_in = dto.private_in,
                    action_ds = dto.action_ds,
                    action_dt = dto.action_dt,
                    incident_question_in = dto.incident_question_in,
                    notepad_tx = dto.notepad_tx,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_message fromEntity, incident_messageDTO toDto);
			 partial void DoMapping(incident_messageDTO fromDto, incident_message toEntity);
		}
    }       
        [DataContract(Name="incident_message_attachment", Namespace="urn:WBS/Models/Data")]
    public partial class incident_message_attachmentDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_message_id")]
        public Int32 incident_message_id
        {
            get; set;
        }
                
        [DataMember(Name="path_nm")]
        public String path_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_nm")]
        public String file_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_extension_nm")]
        public String file_extension_nm
        {
            get; set;
        }
                
        [DataMember(Name="file_stream")]
        public Byte[] file_stream
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_message_attachment MapTo(incident_message_attachmentDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_message_attachmentDTO MapFrom(incident_message_attachment entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_message_attachmentMapper GetMapper()
        {
            return new incident_message_attachmentMapper();   
        }
        
        public partial class incident_message_attachmentMapper
		{
			 public incident_message_attachmentDTO MapTo(incident_message_attachment entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_message_attachmentDTO
                {   
                    id = entity.id,
                    incident_message_id = entity.incident_message_id,
                    path_nm = entity.path_nm,
                    file_nm = entity.file_nm,
                    file_extension_nm = entity.file_extension_nm,
                    file_stream = entity.file_stream,
                    status_id = entity.status_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_message_attachment MapTo(incident_message_attachmentDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_message_attachment
                {   
                    id = dto.id,
                    incident_message_id = dto.incident_message_id,
                    path_nm = dto.path_nm,
                    file_nm = dto.file_nm,
                    file_extension_nm = dto.file_extension_nm,
                    file_stream = dto.file_stream,
                    status_id = dto.status_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_message_attachment fromEntity, incident_message_attachmentDTO toDto);
			 partial void DoMapping(incident_message_attachmentDTO fromDto, incident_message_attachment toEntity);
		}
    }       
        [DataContract(Name="incident_monitor", Namespace="urn:WBS/Models/Data")]
    public partial class incident_monitorDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="review_dt")]
        public DateTime review_dt
        {
            get; set;
        }
                
        [DataMember(Name="action_ds")]
        public String action_ds
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_id")]
        public Int32 privilege_level_id
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_monitor MapTo(incident_monitorDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_monitorDTO MapFrom(incident_monitor entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_monitorMapper GetMapper()
        {
            return new incident_monitorMapper();   
        }
        
        public partial class incident_monitorMapper
		{
			 public incident_monitorDTO MapTo(incident_monitor entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_monitorDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    review_dt = entity.review_dt,
                    action_ds = entity.action_ds,
                    privilege_level_id = entity.privilege_level_id,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_monitor MapTo(incident_monitorDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_monitor
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    review_dt = dto.review_dt,
                    action_ds = dto.action_ds,
                    privilege_level_id = dto.privilege_level_id,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_monitor fromEntity, incident_monitorDTO toDto);
			 partial void DoMapping(incident_monitorDTO fromDto, incident_monitor toEntity);
		}
    }       
        [DataContract(Name="incident_reminder", Namespace="urn:WBS/Models/Data")]
    public partial class incident_reminderDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="reminder_dt")]
        public DateTime reminder_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_reminder MapTo(incident_reminderDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_reminderDTO MapFrom(incident_reminder entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_reminderMapper GetMapper()
        {
            return new incident_reminderMapper();   
        }
        
        public partial class incident_reminderMapper
		{
			 public incident_reminderDTO MapTo(incident_reminder entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_reminderDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    reminder_dt = entity.reminder_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_reminder MapTo(incident_reminderDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_reminder
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    reminder_dt = dto.reminder_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_reminder fromEntity, incident_reminderDTO toDto);
			 partial void DoMapping(incident_reminderDTO fromDto, incident_reminder toEntity);
		}
    }       
        [DataContract(Name="incident_reporter", Namespace="urn:WBS/Models/Data")]
    public partial class incident_reporterDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="login_nm")]
        public String login_nm
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_login_nm")]
        public Byte[] encrypted_login_nm
        {
            get; set;
        }
                
        [DataMember(Name="password")]
        public String password
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_password")]
        public Byte[] encrypted_password
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_id")]
        public Nullable<Int32> privilege_level_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="registration_dt")]
        public Nullable<DateTime> registration_dt
        {
            get; set;
        }
                
        [DataMember(Name="effective_dt")]
        public DateTime effective_dt
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public DateTime expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="notification_in")]
        public Int32 notification_in
        {
            get; set;
        }
                
        [DataMember(Name="question_ds")]
        public String question_ds
        {
            get; set;
        }
                
        [DataMember(Name="answer_ds")]
        public String answer_ds
        {
            get; set;
        }
                
        [DataMember(Name="email")]
        public String email
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="last_login_dt")]
        public Nullable<DateTime> last_login_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="incident")]
        public incidentDTO incident
        {
            get; set;
        }
                        
        public incident_reporter MapTo(incident_reporterDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_reporterDTO MapFrom(incident_reporter entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_reporterMapper GetMapper()
        {
            return new incident_reporterMapper();   
        }
        
        public partial class incident_reporterMapper
		{
			 public incident_reporterDTO MapTo(incident_reporter entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_reporterDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    login_nm = entity.login_nm,
                    encrypted_login_nm = entity.encrypted_login_nm,
                    password = entity.password,
                    encrypted_password = entity.encrypted_password,
                    privilege_level_id = entity.privilege_level_id,
                    status_id = entity.status_id,
                    registration_dt = entity.registration_dt,
                    effective_dt = entity.effective_dt,
                    expiry_dt = entity.expiry_dt,
                    notification_in = entity.notification_in,
                    question_ds = entity.question_ds,
                    answer_ds = entity.answer_ds,
                    email = entity.email,
                    notepad_tx = entity.notepad_tx,
                    last_login_dt = entity.last_login_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    incident = incidentDTO.GetMapper().MapTo(entity.incident),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_reporter MapTo(incident_reporterDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_reporter
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    login_nm = dto.login_nm,
                    encrypted_login_nm = dto.encrypted_login_nm,
                    password = dto.password,
                    encrypted_password = dto.encrypted_password,
                    privilege_level_id = dto.privilege_level_id,
                    status_id = dto.status_id,
                    registration_dt = dto.registration_dt,
                    effective_dt = dto.effective_dt,
                    expiry_dt = dto.expiry_dt,
                    notification_in = dto.notification_in,
                    question_ds = dto.question_ds,
                    answer_ds = dto.answer_ds,
                    email = dto.email,
                    notepad_tx = dto.notepad_tx,
                    last_login_dt = dto.last_login_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    incident = incidentDTO.GetMapper().MapTo(dto.incident),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_reporter fromEntity, incident_reporterDTO toDto);
			 partial void DoMapping(incident_reporterDTO fromDto, incident_reporter toEntity);
		}
    }       
        [DataContract(Name="incident_type", Namespace="urn:WBS/Models/Data")]
    public partial class incident_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nm")]
        public String incident_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nf")]
        public String incident_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_ns")]
        public String incident_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nr")]
        public String incident_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_na")]
        public String incident_type_na
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nj")]
        public String incident_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_type MapTo(incident_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_typeDTO MapFrom(incident_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_typeMapper GetMapper()
        {
            return new incident_typeMapper();   
        }
        
        public partial class incident_typeMapper
		{
			 public incident_typeDTO MapTo(incident_type entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_typeDTO
                {   
                    id = entity.id,
                    incident_type_nm = entity.incident_type_nm,
                    incident_type_nf = entity.incident_type_nf,
                    incident_type_ns = entity.incident_type_ns,
                    incident_type_nr = entity.incident_type_nr,
                    incident_type_na = entity.incident_type_na,
                    incident_type_nj = entity.incident_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_type MapTo(incident_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_type
                {   
                    id = dto.id,
                    incident_type_nm = dto.incident_type_nm,
                    incident_type_nf = dto.incident_type_nf,
                    incident_type_ns = dto.incident_type_ns,
                    incident_type_nr = dto.incident_type_nr,
                    incident_type_na = dto.incident_type_na,
                    incident_type_nj = dto.incident_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_type fromEntity, incident_typeDTO toDto);
			 partial void DoMapping(incident_typeDTO fromDto, incident_type toEntity);
		}
    }       
        [DataContract(Name="incident_type_detail", Namespace="urn:WBS/Models/Data")]
    public partial class incident_type_detailDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="incident_id")]
        public Int32 incident_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_id")]
        public Int32 incident_type_id
        {
            get; set;
        }
                
        [DataMember(Name="incident_type_nm")]
        public String incident_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public incident_type_detail MapTo(incident_type_detailDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static incident_type_detailDTO MapFrom(incident_type_detail entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static incident_type_detailMapper GetMapper()
        {
            return new incident_type_detailMapper();   
        }
        
        public partial class incident_type_detailMapper
		{
			 public incident_type_detailDTO MapTo(incident_type_detail entity)
			 {
                if (entity == null) return null;
			    var dto = new incident_type_detailDTO
                {   
                    id = entity.id,
                    incident_id = entity.incident_id,
                    incident_type_id = entity.incident_type_id,
                    incident_type_nm = entity.incident_type_nm,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public incident_type_detail MapTo(incident_type_detailDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new incident_type_detail
                {   
                    id = dto.id,
                    incident_id = dto.incident_id,
                    incident_type_id = dto.incident_type_id,
                    incident_type_nm = dto.incident_type_nm,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(incident_type_detail fromEntity, incident_type_detailDTO toDto);
			 partial void DoMapping(incident_type_detailDTO fromDto, incident_type_detail toEntity);
		}
    }       
        [DataContract(Name="intl_dict", Namespace="urn:WBS/Models/Data")]
    public partial class intl_dictDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="intl_phrase_id")]
        public Int32 intl_phrase_id
        {
            get; set;
        }
                
        [DataMember(Name="intl_lang_id")]
        public Int32 intl_lang_id
        {
            get; set;
        }
                
        [DataMember(Name="translation")]
        public String translation
        {
            get; set;
        }
                
        [DataMember(Name="intl_phrase")]
        public intl_phraseDTO intl_phrase
        {
            get; set;
        }
                
        [DataMember(Name="intl_lang")]
        public intl_langDTO intl_lang
        {
            get; set;
        }
                        
        public intl_dict MapTo(intl_dictDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static intl_dictDTO MapFrom(intl_dict entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static intl_dictMapper GetMapper()
        {
            return new intl_dictMapper();   
        }
        
        public partial class intl_dictMapper
		{
			 public intl_dictDTO MapTo(intl_dict entity)
			 {
                if (entity == null) return null;
			    var dto = new intl_dictDTO
                {   
                    id = entity.id,
                    intl_phrase_id = entity.intl_phrase_id,
                    intl_lang_id = entity.intl_lang_id,
                    translation = entity.translation,
                    intl_phrase = intl_phraseDTO.GetMapper().MapTo(entity.intl_phrase),
                    intl_lang = intl_langDTO.GetMapper().MapTo(entity.intl_lang),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public intl_dict MapTo(intl_dictDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new intl_dict
                {   
                    id = dto.id,
                    intl_phrase_id = dto.intl_phrase_id,
                    intl_lang_id = dto.intl_lang_id,
                    translation = dto.translation,
                    intl_phrase = intl_phraseDTO.GetMapper().MapTo(dto.intl_phrase),
                    intl_lang = intl_langDTO.GetMapper().MapTo(dto.intl_lang),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(intl_dict fromEntity, intl_dictDTO toDto);
			 partial void DoMapping(intl_dictDTO fromDto, intl_dict toEntity);
		}
    }       
        [DataContract(Name="intl_lang", Namespace="urn:WBS/Models/Data")]
    public partial class intl_langDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="code")]
        public String code
        {
            get; set;
        }
                
        [DataMember(Name="locale")]
        public String locale
        {
            get; set;
        }
                
        [DataMember(Name="intl_dict")]
        public ICollection<intl_dict> intl_dict
        {
            get; set;
        }
                        
        public intl_lang MapTo(intl_langDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static intl_langDTO MapFrom(intl_lang entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static intl_langMapper GetMapper()
        {
            return new intl_langMapper();   
        }
        
        public partial class intl_langMapper
		{
			 public intl_langDTO MapTo(intl_lang entity)
			 {
                if (entity == null) return null;
			    var dto = new intl_langDTO
                {   
                    id = entity.id,
                    code = entity.code,
                    locale = entity.locale,
                    intl_dict = entity.intl_dict,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public intl_lang MapTo(intl_langDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new intl_lang
                {   
                    id = dto.id,
                    code = dto.code,
                    locale = dto.locale,
                    intl_dict = dto.intl_dict,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(intl_lang fromEntity, intl_langDTO toDto);
			 partial void DoMapping(intl_langDTO fromDto, intl_lang toEntity);
		}
    }       
        [DataContract(Name="intl_phrase", Namespace="urn:WBS/Models/Data")]
    public partial class intl_phraseDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="intl_dict")]
        public ICollection<intl_dict> intl_dict
        {
            get; set;
        }
                        
        public intl_phrase MapTo(intl_phraseDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static intl_phraseDTO MapFrom(intl_phrase entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static intl_phraseMapper GetMapper()
        {
            return new intl_phraseMapper();   
        }
        
        public partial class intl_phraseMapper
		{
			 public intl_phraseDTO MapTo(intl_phrase entity)
			 {
                if (entity == null) return null;
			    var dto = new intl_phraseDTO
                {   
                    id = entity.id,
                    intl_dict = entity.intl_dict,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public intl_phrase MapTo(intl_phraseDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new intl_phrase
                {   
                    id = dto.id,
                    intl_dict = dto.intl_dict,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(intl_phrase fromEntity, intl_phraseDTO toDto);
			 partial void DoMapping(intl_phraseDTO fromDto, intl_phrase toEntity);
		}
    }       
        [DataContract(Name="invoice", Namespace="urn:WBS/Models/Data")]
    public partial class invoiceDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                
        [DataMember(Name="paid_in")]
        public Boolean paid_in
        {
            get; set;
        }
                
        [DataMember(Name="date_created")]
        public DateTime date_created
        {
            get; set;
        }
                
        [DataMember(Name="date_paid")]
        public Nullable<DateTime> date_paid
        {
            get; set;
        }
                
        [DataMember(Name="employee_qy")]
        public Int32 employee_qy
        {
            get; set;
        }
                
        [DataMember(Name="confirmation_no")]
        public String confirmation_no
        {
            get; set;
        }
                
        [DataMember(Name="amount_paid")]
        public Decimal amount_paid
        {
            get; set;
        }
                
        [DataMember(Name="currency")]
        public String currency
        {
            get; set;
        }
                
        [DataMember(Name="company")]
        public companyDTO company
        {
            get; set;
        }
                
        [DataMember(Name="user")]
        public userDTO user
        {
            get; set;
        }
                        
        public invoice MapTo(invoiceDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static invoiceDTO MapFrom(invoice entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static invoiceMapper GetMapper()
        {
            return new invoiceMapper();   
        }
        
        public partial class invoiceMapper
		{
			 public invoiceDTO MapTo(invoice entity)
			 {
                if (entity == null) return null;
			    var dto = new invoiceDTO
                {   
                    id = entity.id,
                    company_id = entity.company_id,
                    user_id = entity.user_id,
                    paid_in = entity.paid_in,
                    date_created = entity.date_created,
                    date_paid = entity.date_paid,
                    employee_qy = entity.employee_qy,
                    confirmation_no = entity.confirmation_no,
                    amount_paid = entity.amount_paid,
                    currency = entity.currency,
                    company = companyDTO.GetMapper().MapTo(entity.company),
                    user = userDTO.GetMapper().MapTo(entity.user),
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public invoice MapTo(invoiceDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new invoice
                {   
                    id = dto.id,
                    company_id = dto.company_id,
                    user_id = dto.user_id,
                    paid_in = dto.paid_in,
                    date_created = dto.date_created,
                    date_paid = dto.date_paid,
                    employee_qy = dto.employee_qy,
                    confirmation_no = dto.confirmation_no,
                    amount_paid = dto.amount_paid,
                    currency = dto.currency,
                    company = companyDTO.GetMapper().MapTo(dto.company),
                    user = userDTO.GetMapper().MapTo(dto.user),
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(invoice fromEntity, invoiceDTO toDto);
			 partial void DoMapping(invoiceDTO fromDto, invoice toEntity);
		}
    }       
        [DataContract(Name="language", Namespace="urn:WBS/Models/Data")]
    public partial class languageDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="name")]
        public String name
        {
            get; set;
        }
                        
        public language MapTo(languageDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static languageDTO MapFrom(language entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static languageMapper GetMapper()
        {
            return new languageMapper();   
        }
        
        public partial class languageMapper
		{
			 public languageDTO MapTo(language entity)
			 {
                if (entity == null) return null;
			    var dto = new languageDTO
                {   
                    id = entity.id,
                    name = entity.name,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public language MapTo(languageDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new language
                {   
                    id = dto.id,
                    name = dto.name,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(language fromEntity, languageDTO toDto);
			 partial void DoMapping(languageDTO fromDto, language toEntity);
		}
    }       
        [DataContract(Name="language1", Namespace="urn:WBS/Models/Data")]
    public partial class language1DTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="language_cl")]
        public String language_cl
        {
            get; set;
        }
                
        [DataMember(Name="language_nm")]
        public String language_nm
        {
            get; set;
        }
                
        [DataMember(Name="native_nm")]
        public String native_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public language1 MapTo(language1DTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static language1DTO MapFrom(language1 entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static language1Mapper GetMapper()
        {
            return new language1Mapper();   
        }
        
        public partial class language1Mapper
		{
			 public language1DTO MapTo(language1 entity)
			 {
                if (entity == null) return null;
			    var dto = new language1DTO
                {   
                    id = entity.id,
                    language_cl = entity.language_cl,
                    language_nm = entity.language_nm,
                    native_nm = entity.native_nm,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public language1 MapTo(language1DTO dto)
			 {
                if (dto == null) return null;
			    var entity = new language1
                {   
                    id = dto.id,
                    language_cl = dto.language_cl,
                    language_nm = dto.language_nm,
                    native_nm = dto.native_nm,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(language1 fromEntity, language1DTO toDto);
			 partial void DoMapping(language1DTO fromDto, language1 toEntity);
		}
    }       
        [DataContract(Name="language_label", Namespace="urn:WBS/Models/Data")]
    public partial class language_labelDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="table_name")]
        public String table_name
        {
            get; set;
        }
                
        [DataMember(Name="column_name")]
        public String column_name
        {
            get; set;
        }
                
        [DataMember(Name="label")]
        public String label
        {
            get; set;
        }
                
        [DataMember(Name="language_id")]
        public Int32 language_id
        {
            get; set;
        }
                
        [DataMember(Name="translation")]
        public String translation
        {
            get; set;
        }
                        
        public language_label MapTo(language_labelDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static language_labelDTO MapFrom(language_label entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static language_labelMapper GetMapper()
        {
            return new language_labelMapper();   
        }
        
        public partial class language_labelMapper
		{
			 public language_labelDTO MapTo(language_label entity)
			 {
                if (entity == null) return null;
			    var dto = new language_labelDTO
                {   
                    id = entity.id,
                    table_name = entity.table_name,
                    column_name = entity.column_name,
                    label = entity.label,
                    language_id = entity.language_id,
                    translation = entity.translation,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public language_label MapTo(language_labelDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new language_label
                {   
                    id = dto.id,
                    table_name = dto.table_name,
                    column_name = dto.column_name,
                    label = dto.label,
                    language_id = dto.language_id,
                    translation = dto.translation,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(language_label fromEntity, language_labelDTO toDto);
			 partial void DoMapping(language_labelDTO fromDto, language_label toEntity);
		}
    }       
        [DataContract(Name="marketing_material_type", Namespace="urn:WBS/Models/Data")]
    public partial class marketing_material_typeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_nm")]
        public String marketing_material_type_nm
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_nf")]
        public String marketing_material_type_nf
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_ns")]
        public String marketing_material_type_ns
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_nr")]
        public String marketing_material_type_nr
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_na")]
        public String marketing_material_type_na
        {
            get; set;
        }
                
        [DataMember(Name="marketing_material_type_nj")]
        public String marketing_material_type_nj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public marketing_material_type MapTo(marketing_material_typeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static marketing_material_typeDTO MapFrom(marketing_material_type entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static marketing_material_typeMapper GetMapper()
        {
            return new marketing_material_typeMapper();   
        }
        
        public partial class marketing_material_typeMapper
		{
			 public marketing_material_typeDTO MapTo(marketing_material_type entity)
			 {
                if (entity == null) return null;
			    var dto = new marketing_material_typeDTO
                {   
                    id = entity.id,
                    marketing_material_type_nm = entity.marketing_material_type_nm,
                    marketing_material_type_nf = entity.marketing_material_type_nf,
                    marketing_material_type_ns = entity.marketing_material_type_ns,
                    marketing_material_type_nr = entity.marketing_material_type_nr,
                    marketing_material_type_na = entity.marketing_material_type_na,
                    marketing_material_type_nj = entity.marketing_material_type_nj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public marketing_material_type MapTo(marketing_material_typeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new marketing_material_type
                {   
                    id = dto.id,
                    marketing_material_type_nm = dto.marketing_material_type_nm,
                    marketing_material_type_nf = dto.marketing_material_type_nf,
                    marketing_material_type_ns = dto.marketing_material_type_ns,
                    marketing_material_type_nr = dto.marketing_material_type_nr,
                    marketing_material_type_na = dto.marketing_material_type_na,
                    marketing_material_type_nj = dto.marketing_material_type_nj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(marketing_material_type fromEntity, marketing_material_typeDTO toDto);
			 partial void DoMapping(marketing_material_typeDTO fromDto, marketing_material_type toEntity);
		}
    }       
        [DataContract(Name="official_language", Namespace="urn:WBS/Models/Data")]
    public partial class official_languageDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="language_cl")]
        public String language_cl
        {
            get; set;
        }
                
        [DataMember(Name="language_ds")]
        public String language_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public official_language MapTo(official_languageDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static official_languageDTO MapFrom(official_language entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static official_languageMapper GetMapper()
        {
            return new official_languageMapper();   
        }
        
        public partial class official_languageMapper
		{
			 public official_languageDTO MapTo(official_language entity)
			 {
                if (entity == null) return null;
			    var dto = new official_languageDTO
                {   
                    id = entity.id,
                    language_cl = entity.language_cl,
                    language_ds = entity.language_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public official_language MapTo(official_languageDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new official_language
                {   
                    id = dto.id,
                    language_cl = dto.language_cl,
                    language_ds = dto.language_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(official_language fromEntity, official_languageDTO toDto);
			 partial void DoMapping(official_languageDTO fromDto, official_language toEntity);
		}
    }       
        [DataContract(Name="postal_code", Namespace="urn:WBS/Models/Data")]
    public partial class postal_codeDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="postal_code_cl")]
        public String postal_code_cl
        {
            get; set;
        }
                
        [DataMember(Name="city_type_cl")]
        public String city_type_cl
        {
            get; set;
        }
                
        [DataMember(Name="city_nm")]
        public String city_nm
        {
            get; set;
        }
                
        [DataMember(Name="province_nm")]
        public String province_nm
        {
            get; set;
        }
                
        [DataMember(Name="province_cl")]
        public String province_cl
        {
            get; set;
        }
                
        [DataMember(Name="area_code_cl")]
        public String area_code_cl
        {
            get; set;
        }
                
        [DataMember(Name="province_id")]
        public Nullable<Int32> province_id
        {
            get; set;
        }
                
        [DataMember(Name="country_id")]
        public Int32 country_id
        {
            get; set;
        }
                
        [DataMember(Name="time_zone_nm")]
        public String time_zone_nm
        {
            get; set;
        }
                
        [DataMember(Name="utc_no")]
        public Nullable<Int32> utc_no
        {
            get; set;
        }
                
        [DataMember(Name="dst_in")]
        public String dst_in
        {
            get; set;
        }
                
        [DataMember(Name="latitude")]
        public Nullable<Double> latitude
        {
            get; set;
        }
                
        [DataMember(Name="longitude")]
        public Nullable<Double> longitude
        {
            get; set;
        }
                        
        public postal_code MapTo(postal_codeDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static postal_codeDTO MapFrom(postal_code entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static postal_codeMapper GetMapper()
        {
            return new postal_codeMapper();   
        }
        
        public partial class postal_codeMapper
		{
			 public postal_codeDTO MapTo(postal_code entity)
			 {
                if (entity == null) return null;
			    var dto = new postal_codeDTO
                {   
                    id = entity.id,
                    postal_code_cl = entity.postal_code_cl,
                    city_type_cl = entity.city_type_cl,
                    city_nm = entity.city_nm,
                    province_nm = entity.province_nm,
                    province_cl = entity.province_cl,
                    area_code_cl = entity.area_code_cl,
                    province_id = entity.province_id,
                    country_id = entity.country_id,
                    time_zone_nm = entity.time_zone_nm,
                    utc_no = entity.utc_no,
                    dst_in = entity.dst_in,
                    latitude = entity.latitude,
                    longitude = entity.longitude,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public postal_code MapTo(postal_codeDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new postal_code
                {   
                    id = dto.id,
                    postal_code_cl = dto.postal_code_cl,
                    city_type_cl = dto.city_type_cl,
                    city_nm = dto.city_nm,
                    province_nm = dto.province_nm,
                    province_cl = dto.province_cl,
                    area_code_cl = dto.area_code_cl,
                    province_id = dto.province_id,
                    country_id = dto.country_id,
                    time_zone_nm = dto.time_zone_nm,
                    utc_no = dto.utc_no,
                    dst_in = dto.dst_in,
                    latitude = dto.latitude,
                    longitude = dto.longitude,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(postal_code fromEntity, postal_codeDTO toDto);
			 partial void DoMapping(postal_codeDTO fromDto, postal_code toEntity);
		}
    }       
        [DataContract(Name="privilege_level", Namespace="urn:WBS/Models/Data")]
    public partial class privilege_levelDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_nm")]
        public String privilege_level_nm
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_nf")]
        public String privilege_level_nf
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_ns")]
        public String privilege_level_ns
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_nr")]
        public String privilege_level_nr
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_na")]
        public String privilege_level_na
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_nj")]
        public String privilege_level_nj
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_ds")]
        public String privilege_level_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public privilege_level MapTo(privilege_levelDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static privilege_levelDTO MapFrom(privilege_level entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static privilege_levelMapper GetMapper()
        {
            return new privilege_levelMapper();   
        }
        
        public partial class privilege_levelMapper
		{
			 public privilege_levelDTO MapTo(privilege_level entity)
			 {
                if (entity == null) return null;
			    var dto = new privilege_levelDTO
                {   
                    id = entity.id,
                    privilege_level_nm = entity.privilege_level_nm,
                    privilege_level_nf = entity.privilege_level_nf,
                    privilege_level_ns = entity.privilege_level_ns,
                    privilege_level_nr = entity.privilege_level_nr,
                    privilege_level_na = entity.privilege_level_na,
                    privilege_level_nj = entity.privilege_level_nj,
                    privilege_level_ds = entity.privilege_level_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public privilege_level MapTo(privilege_levelDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new privilege_level
                {   
                    id = dto.id,
                    privilege_level_nm = dto.privilege_level_nm,
                    privilege_level_nf = dto.privilege_level_nf,
                    privilege_level_ns = dto.privilege_level_ns,
                    privilege_level_nr = dto.privilege_level_nr,
                    privilege_level_na = dto.privilege_level_na,
                    privilege_level_nj = dto.privilege_level_nj,
                    privilege_level_ds = dto.privilege_level_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(privilege_level fromEntity, privilege_levelDTO toDto);
			 partial void DoMapping(privilege_levelDTO fromDto, privilege_level toEntity);
		}
    }       
        [DataContract(Name="province", Namespace="urn:WBS/Models/Data")]
    public partial class provinceDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="country_id")]
        public Int32 country_id
        {
            get; set;
        }
                
        [DataMember(Name="province_cl")]
        public String province_cl
        {
            get; set;
        }
                
        [DataMember(Name="province_nm")]
        public String province_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="addresses")]
        public ICollection<address> addresses
        {
            get; set;
        }
                        
        public province MapTo(provinceDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static provinceDTO MapFrom(province entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static provinceMapper GetMapper()
        {
            return new provinceMapper();   
        }
        
        public partial class provinceMapper
		{
			 public provinceDTO MapTo(province entity)
			 {
                if (entity == null) return null;
			    var dto = new provinceDTO
                {   
                    id = entity.id,
                    country_id = entity.country_id,
                    province_cl = entity.province_cl,
                    province_nm = entity.province_nm,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    addresses = entity.addresses,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public province MapTo(provinceDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new province
                {   
                    id = dto.id,
                    country_id = dto.country_id,
                    province_cl = dto.province_cl,
                    province_nm = dto.province_nm,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    addresses = dto.addresses,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(province fromEntity, provinceDTO toDto);
			 partial void DoMapping(provinceDTO fromDto, province toEntity);
		}
    }       
        [DataContract(Name="question", Namespace="urn:WBS/Models/Data")]
    public partial class questionDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="case_type_id")]
        public Nullable<Int32> case_type_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Nullable<Int32> status_id
        {
            get; set;
        }
                
        [DataMember(Name="effective_dt")]
        public Nullable<DateTime> effective_dt
        {
            get; set;
        }
                
        [DataMember(Name="expiry_dt")]
        public Nullable<DateTime> expiry_dt
        {
            get; set;
        }
                
        [DataMember(Name="answer_cl")]
        public String answer_cl
        {
            get; set;
        }
                
        [DataMember(Name="header_in")]
        public Nullable<Byte> header_in
        {
            get; set;
        }
                
        [DataMember(Name="question_ds")]
        public String question_ds
        {
            get; set;
        }
                
        [DataMember(Name="question_df")]
        public String question_df
        {
            get; set;
        }
                
        [DataMember(Name="question_de")]
        public String question_de
        {
            get; set;
        }
                
        [DataMember(Name="question_dr")]
        public String question_dr
        {
            get; set;
        }
                
        [DataMember(Name="question_da")]
        public String question_da
        {
            get; set;
        }
                
        [DataMember(Name="question_dj")]
        public String question_dj
        {
            get; set;
        }
                
        [DataMember(Name="tip_ds")]
        public String tip_ds
        {
            get; set;
        }
                
        [DataMember(Name="tip_df")]
        public String tip_df
        {
            get; set;
        }
                
        [DataMember(Name="tip_de")]
        public String tip_de
        {
            get; set;
        }
                
        [DataMember(Name="tip_dr")]
        public String tip_dr
        {
            get; set;
        }
                
        [DataMember(Name="tip_da")]
        public String tip_da
        {
            get; set;
        }
                
        [DataMember(Name="tip_dj")]
        public String tip_dj
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public question MapTo(questionDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static questionDTO MapFrom(question entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static questionMapper GetMapper()
        {
            return new questionMapper();   
        }
        
        public partial class questionMapper
		{
			 public questionDTO MapTo(question entity)
			 {
                if (entity == null) return null;
			    var dto = new questionDTO
                {   
                    id = entity.id,
                    case_type_id = entity.case_type_id,
                    status_id = entity.status_id,
                    effective_dt = entity.effective_dt,
                    expiry_dt = entity.expiry_dt,
                    answer_cl = entity.answer_cl,
                    header_in = entity.header_in,
                    question_ds = entity.question_ds,
                    question_df = entity.question_df,
                    question_de = entity.question_de,
                    question_dr = entity.question_dr,
                    question_da = entity.question_da,
                    question_dj = entity.question_dj,
                    tip_ds = entity.tip_ds,
                    tip_df = entity.tip_df,
                    tip_de = entity.tip_de,
                    tip_dr = entity.tip_dr,
                    tip_da = entity.tip_da,
                    tip_dj = entity.tip_dj,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public question MapTo(questionDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new question
                {   
                    id = dto.id,
                    case_type_id = dto.case_type_id,
                    status_id = dto.status_id,
                    effective_dt = dto.effective_dt,
                    expiry_dt = dto.expiry_dt,
                    answer_cl = dto.answer_cl,
                    header_in = dto.header_in,
                    question_ds = dto.question_ds,
                    question_df = dto.question_df,
                    question_de = dto.question_de,
                    question_dr = dto.question_dr,
                    question_da = dto.question_da,
                    question_dj = dto.question_dj,
                    tip_ds = dto.tip_ds,
                    tip_df = dto.tip_df,
                    tip_de = dto.tip_de,
                    tip_dr = dto.tip_dr,
                    tip_da = dto.tip_da,
                    tip_dj = dto.tip_dj,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(question fromEntity, questionDTO toDto);
			 partial void DoMapping(questionDTO fromDto, question toEntity);
		}
    }       
        [DataContract(Name="resource", Namespace="urn:WBS/Models/Data")]
    public partial class resourceDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="project_nm")]
        public String project_nm
        {
            get; set;
        }
                
        [DataMember(Name="folder_nm")]
        public String folder_nm
        {
            get; set;
        }
                
        [DataMember(Name="page_nm")]
        public String page_nm
        {
            get; set;
        }
                
        [DataMember(Name="data_nm")]
        public String data_nm
        {
            get; set;
        }
                
        [DataMember(Name="value_en")]
        public String value_en
        {
            get; set;
        }
                
        [DataMember(Name="value_fr")]
        public String value_fr
        {
            get; set;
        }
                
        [DataMember(Name="value_sp")]
        public String value_sp
        {
            get; set;
        }
                
        [DataMember(Name="value_ru")]
        public String value_ru
        {
            get; set;
        }
                
        [DataMember(Name="value_ar")]
        public String value_ar
        {
            get; set;
        }
                
        [DataMember(Name="value_ja")]
        public String value_ja
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public Nullable<DateTime> last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Nullable<Int32> user_id
        {
            get; set;
        }
                        
        public resource MapTo(resourceDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static resourceDTO MapFrom(resource entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static resourceMapper GetMapper()
        {
            return new resourceMapper();   
        }
        
        public partial class resourceMapper
		{
			 public resourceDTO MapTo(resource entity)
			 {
                if (entity == null) return null;
			    var dto = new resourceDTO
                {   
                    id = entity.id,
                    project_nm = entity.project_nm,
                    folder_nm = entity.folder_nm,
                    page_nm = entity.page_nm,
                    data_nm = entity.data_nm,
                    value_en = entity.value_en,
                    value_fr = entity.value_fr,
                    value_sp = entity.value_sp,
                    value_ru = entity.value_ru,
                    value_ar = entity.value_ar,
                    value_ja = entity.value_ja,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public resource MapTo(resourceDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new resource
                {   
                    id = dto.id,
                    project_nm = dto.project_nm,
                    folder_nm = dto.folder_nm,
                    page_nm = dto.page_nm,
                    data_nm = dto.data_nm,
                    value_en = dto.value_en,
                    value_fr = dto.value_fr,
                    value_sp = dto.value_sp,
                    value_ru = dto.value_ru,
                    value_ar = dto.value_ar,
                    value_ja = dto.value_ja,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(resource fromEntity, resourceDTO toDto);
			 partial void DoMapping(resourceDTO fromDto, resource toEntity);
		}
    }       
        [DataContract(Name="status", Namespace="urn:WBS/Models/Data")]
    public partial class statusDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="module_cl")]
        public String module_cl
        {
            get; set;
        }
                
        [DataMember(Name="status_nm")]
        public String status_nm
        {
            get; set;
        }
                
        [DataMember(Name="status_nf")]
        public String status_nf
        {
            get; set;
        }
                
        [DataMember(Name="status_ns")]
        public String status_ns
        {
            get; set;
        }
                
        [DataMember(Name="status_nr")]
        public String status_nr
        {
            get; set;
        }
                
        [DataMember(Name="status_na")]
        public String status_na
        {
            get; set;
        }
                
        [DataMember(Name="status_nj")]
        public String status_nj
        {
            get; set;
        }
                
        [DataMember(Name="status_ds")]
        public String status_ds
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                        
        public status MapTo(statusDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static statusDTO MapFrom(status entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static statusMapper GetMapper()
        {
            return new statusMapper();   
        }
        
        public partial class statusMapper
		{
			 public statusDTO MapTo(status entity)
			 {
                if (entity == null) return null;
			    var dto = new statusDTO
                {   
                    id = entity.id,
                    module_cl = entity.module_cl,
                    status_nm = entity.status_nm,
                    status_nf = entity.status_nf,
                    status_ns = entity.status_ns,
                    status_nr = entity.status_nr,
                    status_na = entity.status_na,
                    status_nj = entity.status_nj,
                    status_ds = entity.status_ds,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public status MapTo(statusDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new status
                {   
                    id = dto.id,
                    module_cl = dto.module_cl,
                    status_nm = dto.status_nm,
                    status_nf = dto.status_nf,
                    status_ns = dto.status_ns,
                    status_nr = dto.status_nr,
                    status_na = dto.status_na,
                    status_nj = dto.status_nj,
                    status_ds = dto.status_ds,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(status fromEntity, statusDTO toDto);
			 partial void DoMapping(statusDTO fromDto, status toEntity);
		}
    }       
        [DataContract(Name="user", Namespace="urn:WBS/Models/Data")]
    public partial class userDTO     {
            
        [DataMember(Name="id")]
        public Int32 id
        {
            get; set;
        }
                
        [DataMember(Name="company_id")]
        public Int32 company_id
        {
            get; set;
        }
                
        [DataMember(Name="address_id")]
        public Int32 address_id
        {
            get; set;
        }
                
        [DataMember(Name="privilege_level_id")]
        public Int32 privilege_level_id
        {
            get; set;
        }
                
        [DataMember(Name="status_id")]
        public Int32 status_id
        {
            get; set;
        }
                
        [DataMember(Name="first_nm")]
        public String first_nm
        {
            get; set;
        }
                
        [DataMember(Name="last_nm")]
        public String last_nm
        {
            get; set;
        }
                
        [DataMember(Name="login_nm")]
        public String login_nm
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_login_nm")]
        public Byte[] encrypted_login_nm
        {
            get; set;
        }
                
        [DataMember(Name="password")]
        public String password
        {
            get; set;
        }
                
        [DataMember(Name="encrypted_password")]
        public Byte[] encrypted_password
        {
            get; set;
        }
                
        [DataMember(Name="title_ds")]
        public String title_ds
        {
            get; set;
        }
                
        [DataMember(Name="employee_no")]
        public String employee_no
        {
            get; set;
        }
                
        [DataMember(Name="preffered_ds")]
        public String preffered_ds
        {
            get; set;
        }
                
        [DataMember(Name="notepad_tx")]
        public String notepad_tx
        {
            get; set;
        }
                
        [DataMember(Name="question_ds")]
        public String question_ds
        {
            get; set;
        }
                
        [DataMember(Name="answer_ds")]
        public String answer_ds
        {
            get; set;
        }
                
        [DataMember(Name="primary_admin_in")]
        public Int32 primary_admin_in
        {
            get; set;
        }
                
        [DataMember(Name="last_login_dt")]
        public Nullable<DateTime> last_login_dt
        {
            get; set;
        }
                
        [DataMember(Name="last_update_dt")]
        public DateTime last_update_dt
        {
            get; set;
        }
                
        [DataMember(Name="user_id")]
        public Int32 user_id
        {
            get; set;
        }
                
        [DataMember(Name="multiple_company_flag")]
        public Nullable<Boolean> multiple_company_flag
        {
            get; set;
        }
                
        [DataMember(Name="hashcode")]
        public String hashcode
        {
            get; set;
        }
                
        [DataMember(Name="hashcode_generated_on")]
        public Nullable<DateTime> hashcode_generated_on
        {
            get; set;
        }
                
        [DataMember(Name="wizard_step")]
        public Nullable<Int32> wizard_step
        {
            get; set;
        }
                
        [DataMember(Name="address")]
        public addressDTO address
        {
            get; set;
        }
                
        [DataMember(Name="company")]
        public companyDTO company
        {
            get; set;
        }
                
        [DataMember(Name="invoices")]
        public ICollection<invoice> invoices
        {
            get; set;
        }
                        
        public user MapTo(userDTO dto)
		{
			return GetMapper().MapTo(dto);
		}

		public static userDTO MapFrom(user entity)
		{
			return GetMapper().MapTo(entity);
		}
		
        public static userMapper GetMapper()
        {
            return new userMapper();   
        }
        
        public partial class userMapper
		{
			 public userDTO MapTo(user entity)
			 {
                if (entity == null) return null;
			    var dto = new userDTO
                {   
                    id = entity.id,
                    company_id = entity.company_id,
                    address_id = entity.address_id,
                    privilege_level_id = entity.privilege_level_id,
                    status_id = entity.status_id,
                    first_nm = entity.first_nm,
                    last_nm = entity.last_nm,
                    login_nm = entity.login_nm,
                    encrypted_login_nm = entity.encrypted_login_nm,
                    password = entity.password,
                    encrypted_password = entity.encrypted_password,
                    title_ds = entity.title_ds,
                    employee_no = entity.employee_no,
                    preffered_ds = entity.preffered_ds,
                    notepad_tx = entity.notepad_tx,
                    question_ds = entity.question_ds,
                    answer_ds = entity.answer_ds,
                    primary_admin_in = entity.primary_admin_in,
                    last_login_dt = entity.last_login_dt,
                    last_update_dt = entity.last_update_dt,
                    user_id = entity.user_id,
                    multiple_company_flag = entity.multiple_company_flag,
                    hashcode = entity.hashcode,
                    hashcode_generated_on = entity.hashcode_generated_on,
                    wizard_step = entity.wizard_step,
                    address = addressDTO.GetMapper().MapTo(entity.address),
                    company = companyDTO.GetMapper().MapTo(entity.company),
                    invoices = entity.invoices,
                             
                };
			    
			    			    
			    DoMapping(dto, entity);
			    
			    return dto;
			 }
			 
			 public user MapTo(userDTO dto)
			 {
                if (dto == null) return null;
			    var entity = new user
                {   
                    id = dto.id,
                    company_id = dto.company_id,
                    address_id = dto.address_id,
                    privilege_level_id = dto.privilege_level_id,
                    status_id = dto.status_id,
                    first_nm = dto.first_nm,
                    last_nm = dto.last_nm,
                    login_nm = dto.login_nm,
                    encrypted_login_nm = dto.encrypted_login_nm,
                    password = dto.password,
                    encrypted_password = dto.encrypted_password,
                    title_ds = dto.title_ds,
                    employee_no = dto.employee_no,
                    preffered_ds = dto.preffered_ds,
                    notepad_tx = dto.notepad_tx,
                    question_ds = dto.question_ds,
                    answer_ds = dto.answer_ds,
                    primary_admin_in = dto.primary_admin_in,
                    last_login_dt = dto.last_login_dt,
                    last_update_dt = dto.last_update_dt,
                    user_id = dto.user_id,
                    multiple_company_flag = dto.multiple_company_flag,
                    hashcode = dto.hashcode,
                    hashcode_generated_on = dto.hashcode_generated_on,
                    wizard_step = dto.wizard_step,
                    address = addressDTO.GetMapper().MapTo(dto.address),
                    company = companyDTO.GetMapper().MapTo(dto.company),
                    invoices = dto.invoices,
                             
                };
			    
			                    
			    DoMapping(entity, dto);
			    
			    return entity;
			 }
			 
			 partial void DoMapping(user fromEntity, userDTO toDto);
			 partial void DoMapping(userDTO fromDto, user toEntity);
		}
    }       
        
}
