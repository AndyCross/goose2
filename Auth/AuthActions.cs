using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace goose2s 
{
    public static class AuthActions {
        public static async Task<SpotifyAuthResponse> GetToken(string authCode) {
            var authKeys = AuthContants.GetAuthKeys();
            var header = System.Text.Encoding.UTF8.GetBytes($"{authKeys["client_id"]}:{AuthContants.GetSecret()}");

            var http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(header));
       
            var response = await http.PostAsync("https://accounts.spotify.com/api/token", 
                new FormUrlEncodedContent(new Dictionary<string,string>() {
                    { "code", authCode}, 
                    { "redirect_uri", authKeys["redirect_uri"]}, 
                    { "grant_type", "authorization_code"}
                }));
            
            if (!response.IsSuccessStatusCode) {
                return new SpotifyAuthResponse { Success = false };
            }

            return JsonConvert.DeserializeObject<SpotifyAuthResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}