using System;
using Microsoft.AspNetCore.Http;

namespace CoreWeb.API.Dtos
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; } // Photo uploading
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicID { get; set; } // Ritorna da Cloudinary
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}