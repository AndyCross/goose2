namespace goose2s {
    public class SpotifyAuthResponse
    {
        public SpotifyAuthResponse()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string access_token { get;set; }
        public string expires_in { get;set; }
        public string refresh_token {get;set;}
        public string state { get; set; }
    }
}