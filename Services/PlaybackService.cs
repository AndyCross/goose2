using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace goose2s.Services {
    public class PlaybackService {
        private const string SPOTIFY_API_BASE = "https://api.spotify.com/v1";

        public async Task Play(string trackId, string authToken) {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
            var response = await http.PutAsync($"{SPOTIFY_API_BASE}/me/player/play", 
                new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(
                    new {
                        uris = new [] {$"spotify:track:{trackId}"}
                    }), 
                Encoding.UTF8, 
                "application/json"));
            var resString = response.Content.ReadAsStringAsync();
        } 

        public async Task Seek(int ms, string authToken) {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
            var response = await http.PutAsync($"{SPOTIFY_API_BASE}/me/player/seek?position_ms={ms}", null);
            var resString = response.Content.ReadAsStringAsync();
        }
    }
}