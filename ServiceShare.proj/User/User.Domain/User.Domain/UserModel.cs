using System.Runtime.InteropServices;
using System;
namespace Model
{
public class User : IdentityUser
{
	public string UserId {get; set;} = Guid.NewGuid().Tostring();
	public string UserName {get; set;} = string.Empty;
	public string? EmailAddress {get; set;} = string.Empty;
	public string ServiceTypeId {get; set;} = string.Empty;
	public string SubsTypeId {get; set;} = string.Empty;
	public string Password {get; set;} = string.Empty;
  }

}