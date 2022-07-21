namespace Host.Core.Exceptions;

public class EntityDoesntExistInDatabaseException : Exception
{
  public EntityDoesntExistInDatabaseException() {  }

  public EntityDoesntExistInDatabaseException(Guid id)
    : base(String.Format("Entity with id: {id} doesn't exist in database", id))
  {

  }
}