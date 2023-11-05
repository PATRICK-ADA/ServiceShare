using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using System;

namespace UserModel
{
public class User : IdentityUser
{
	public string UserId {get; set;} = Guid.NewGuid().ToString();
	public override string UserName {get; set;} = string.Empty;
	public string? EmailAddress {get; set;} = string.Empty;
	
	public string ServiceId {get; set;} = string.Empty;
	
	public string SubsId {get; set;} = string.Empty;

  }

}