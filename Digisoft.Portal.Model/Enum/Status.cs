using System.ComponentModel;

namespace DigisoftPortal.Model;

public enum Status
{
	[Description("Success")]
	SUCCESS,
	[Description("Password is incorrect")]
	PASSWORD_INCORRECT,
	[Description("Your account is inactive.")]
	ACCOUNT_INACTIVE,
	[Description("We are not able to locate your account.")]
	NOT_FOUND
}
