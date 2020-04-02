using System.Net.Http;
using System.Threading.Tasks;
using goose2s.Models;
using Microsoft.AspNetCore.Components;

namespace goose2s.Services {
    public class ProfileService {
        private const string SPOTIFY_API_BASE = "https://api.spotify.com/v1";

        public async Task<UserProfile> GetUserProfile(string authToken) {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
            var response = await http.GetAsync($"{SPOTIFY_API_BASE}/me");

            if (response.IsSuccessStatusCode) {
                var resString = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<UserProfile>(resString);
            }
            return new UserProfile { Failure = true };
        } 

    }
}