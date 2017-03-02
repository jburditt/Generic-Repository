# Generic-Repository
Generic Repository EF and Web API

I did not write the majority of the code, I simple took 3 existing tools and smashed them together and over time I have learned a lot and work towards a more elegant solution. I have added bug fixes, merged Web API and EF to work from one repository, DTO automation and other various changes.

REFERENCES:
- Entity Framework Repository - http://www.asp.net/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
- Web API Repository - http://blog.falafel.com/generic-repository-pattern-with-entity-framework-and-web-api/
- DTO Automation - https://github.com/pcibraro/pcibraro.github.com/blob/master/images/legacy/EntitiesToDTO.zip
- Repository improvements - https://genericunitofworkandrepositories.codeplex.com/documentation
- Dapper Repository - https://github.com/Yoinbol/Dapper.DataRepositories
- Dapper Repository - http://www.nopcommerce.com/boards/t/35311/repository-for-dappernet.aspx

TODO:

- Add MockRepository
- Add a working sample project that runs out of the box
- Add unit testing that demonstrates the sample project
- Add unit of work pattern to replace 'per method call' scope of context. Context scope should be 'per request'.
- Add dependency injection and add another ORM e.g. ORMLiteRepository
- EntityFramework depencies in separate project / assembly, Dapper, ORMLite
- Evaluate scenario: Find one object that needs to be joined with another object
  e.g. SELECT u.* FROM User u JOIN Company c ON c.id = u.company_id WHERE c.company_name = @name AND u.status > 0

- - Dapper
- KeyProperty(Identity = true)] needs to be added by T4 to identity columns

- - Repository
- update multiple entities matching predicate
- repository replace filter with predicate, replace include string with include linq
- replace Repository with DataStore?

- - T4 Generate DTO's
 - Replace !(t.Name == "EFRepository" || t.Name == "WBSEntities") DtoMapper.tt
 - Add [Serializable] to each DTO
 - Add IIdentifier to each DTO or research using KeyValues
 - Add interface : IDTO<countryDTO, country> to each DTO
 - Generate Partial classes
 - Remove circular references
 - Add implicit operator for copying
 - Option for splitting each DTO in to separate files
 - Handle other reserved keywords
 - Does not import System.Int32?

DTO Automation is not 100% complete and requires manually removing circular references to serialize entities.
