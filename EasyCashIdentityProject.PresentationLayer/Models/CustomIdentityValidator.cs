using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentityProject.PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakter olmalıdır"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
            return new IdentityError()
			{
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az bir büyük harf giriniz"
            };
        }
		public override IdentityError PasswordRequiresLower()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az bir küçük harf giriniz"
            };
        }
		public override IdentityError PasswordRequiresDigit()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az bir rakam giriniz"
            };
        }
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az bir tane sembol  giriniz"
            };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError()
            {
                Code = "InvalidEmail",
                Description = $"Bu{email} adresi sistemde mevcuttur."
            };
        }
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "InvalidUserName",
                Description = $"Bu{userName} adı sistemde mevcuttur."
            };
        }
    }
}
