using Dapper.Contrib.Extensions;
namespace CleanArchitecture.Domain.Entities;
[Table("[User]")]
public class User
{
    [Key]
    public int ID { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}