using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Mara.Models;

public class Item
{
    public long ID {get;set;}
    public string? Name {get;set;}
    public string? Description {get;set;}
}