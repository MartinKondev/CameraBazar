using CameraBazar.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CameraBazar.Models
{  
    public class Camera : IValidatableObject
    {
        public int Id { get; set; }

        public CameraMakeEnum CameraMake { get; set; }

        [Required]
        [RegularExpression(Constants.CameraModelRegex)]
        public string Model { get; set; }

        [RegularExpression(Constants.FloatingPointNumberAfterDecimalPoint)]
        public double Price { get; set; }

        [Range(0, 100)]
        public int Quantity { get; set; }

        [Range(1, 30)]
        public int MinShutterSpeed { get; set; }

        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }

        public MinISOEnum MinISO { get; set; }

        [Range(200, 409600)]
        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        [MaxLength(15)]
        public string VideoResolution { get; set; }

        public LightMeteringEnum LightMetering { get; set; }

        [MaxLength(6000)]
        public string Description { get; set; }

        public bool IsInStock { get => Quantity > 0; }

        //public int AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        [RegularExpression(Constants.ImageUrlPattern)]
        public string ImageUrl { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (MaxISO % 100 != 0)
            {
                yield return new ValidationResult("MaxISO must be devidable by 100");
            }
        }
    }
}
