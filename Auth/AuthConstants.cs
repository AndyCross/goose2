
using System;
using System.Collections.Generic;

namespace goose2s
{
    public static class AuthContants {
        private static string generateRandomString(int length) {
            var text = "";
            var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (var i = 0; i < length; i++) {
                text += possible[new Random().Next(0, possible.Length)];
            }
            return text;
        }

        public static Dictionary<string,string> GetAuthKeys() {
                return new Dictionary<string,string> {
                    { "response_type", "code" },
                    { "client_id", "149df1959bb94b4e8d324fb611d39445" },
                    { "scope", "user-read-playback-state user-modify-playback-state" },
                    { "redirect_uri", "https://localhost:5001/auth/callback" },
                    { "state", generateRandomString(16) }
                };
        }

        public static string GetSecret() {
            return "8d1af8b6685a40f0a7c60fe7dbabcd64";
        }
    }
}