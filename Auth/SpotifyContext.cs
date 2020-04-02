using goose2s.Models;

namespace goose2s
{
    public class SpotifyContext {
        public SpotifyAuthResponse Auth { get; set; }
        public UserProfile User { get; set; }
    }
}