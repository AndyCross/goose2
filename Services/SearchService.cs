using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using goose2s.Models;
using Microsoft.AspNetCore.Components;

namespace goose2s.Services {
    public class SearchService {
        private const string SPOTIFY_API_BASE = "https://api.spotify.com/v1";

        public async Task<SearchResults> SearchTrack(string term, string authToken) {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
            var response = await http.GetJsonAsync<SearchResults>($"{SPOTIFY_API_BASE}/search?q={term}&type=track&limit=10");
            return response;
        } 

        public async Task Seek(int ms, string authToken) {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
            var response = await http.PutAsync($"{SPOTIFY_API_BASE}/me/player/seek?position_ms={ms}", null);
            var resString = response.Content.ReadAsStringAsync();
        }
    }
}