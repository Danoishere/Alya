# Alya
My personal web framework with web and mobile components.
Alya should contain everything you need to create web and mobile apps in a very short time.
The components are

## Alya.Core
  Contains the entity base class (EntityBase) that is used by all other parts to work with data.
  The EntityBase class uses Fody.PropertyChanged, an automated implementation of the observer pattern, 
  to make it easier to use in WPF and Xamarin projects.

## Alya.DataAccess
  Contains a base class for the DataContext (AlyaDbContextBase), that makes it easier to use Entity Framework.
  All Configuration should be made via the class DataAccessConfiguration. The AlyaDataContextBase gets all its configurations
  from this class. If you use the data access in a web project, configure it in the Global.asax (or at least initialize it 
  from there).
  
  Other components that are contained are the IRepository interface and the RepositoryBase class, an implementation of the
  repository pattern (that follows the IRepository interface). RepositoryBase uses the DataAccessConfiguration class as well.
  
  To create repository instance for a entity class (let's say Project), the class RepositoryFactory is what you need. 
  
  ```cs
  // Generates a generic Project Repository (RepositoryBase<Project>) that implements IRepository
  var projectRepository = RepositoryFactory.Create<Project>();
  ```
  
  If you already have a custom implementation of a ProjectRepository (should also inherit from IRepository), you can create it 
  with the RepositoryFactory as well.
  
  ```cs
  // Generates a generic Project Repository (RepositoryBase<Project>) that implements IRepository
  var projectRepository = RepositoryFactory.CreateCustom<MyProjectRepository>();
  ```
  
  
