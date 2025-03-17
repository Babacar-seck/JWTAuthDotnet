namespace JWTAuthDotnet.Models
{
    public class TokenResponseDto
    {
        public required string Accesstoken { get; set; }   

        public required string RefreshToken { get; set; }
    }
}
