using System.Runtime.InteropServices;
using System;
namespace Model
{
public class User : IdentityUser
{
	public string UserId {get; set;} = Guid.NewGuid().Tostring();
	public string UserName {get; set;} = string.Empty;
	public string? EmailAddress {get; set;} = string.Empty;
	public Service ServiceType {get; set;}
	public SSubsType {get; set;} = string.Empty;
	public string ServiceId {get; set;} = string.Empty;
	public string SubsId {get; set;} = string.Empty;

  }

}