namespace App.Dtos.AppUserDtos
{
    public class AppUserDto
    {
        public AppUserDto()
        {
            BookingDtos = new HashSet<BookingDto>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Relations
        public virtual ICollection<BookingDto> BookingDtos { get; set; }
    }
}