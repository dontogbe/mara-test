using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Mara.Models;

public class Item
{
    public long Id {get;set;}
    public string? Name {get;set;}
    public string? Description {get;set;}
}