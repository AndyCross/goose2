namespace goose2s
{
    public class SpotifyAuthResponse
    {
        public SpotifyAuthResponse()
        {}
        public bool Failure { get; set; }
        public string access_token { get;set; }
        public int expires_in { get;set; }
        public string refresh_token {get;set;}
        public string state { get; set; }
    }
}