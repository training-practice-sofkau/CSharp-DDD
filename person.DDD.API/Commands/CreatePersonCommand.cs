namespace person.DDD.API.Commands
{
    public record CreatePersonCommand (Guid personId, string Name);
    
}
