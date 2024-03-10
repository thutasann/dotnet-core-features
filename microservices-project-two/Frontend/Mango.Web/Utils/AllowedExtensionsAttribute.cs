using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Utils
{
    /// <summary>
    /// Allowed Image Extension Attribute
    /// </summary>
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;

        public AllowedExtensionsAttribute(string[] extension)
        {
            _extensions = extension;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult("This photo extension is not allowed");
                }
            }
            return ValidationResult.Success;
        }
    }
}