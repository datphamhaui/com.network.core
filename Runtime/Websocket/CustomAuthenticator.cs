// namespace GameFoundation.Scripts.Network.Websocket
// {
//     using System;
//     using BestHTTP.SignalRCore;
//
//     public class CustomAuthenticator : IAuthenticationProvider
//     {
//         /// <summary>
//         /// No pre-auth step required for this type of authentication
//         /// </summary>
//         public bool IsPreAuthRequired { get { return false; } }
//
// #pragma warning disable 0067
//         /// <summary>
//         /// Not used event as IsPreAuthRequired is false
//         /// </summary>
//         public event OnAuthenticationSuccededDelegate OnAuthenticationSucceded;
//
//         /// <summary>
//         /// Not used event as IsPreAuthRequired is false
//         /// </summary>
//         public event OnAuthenticationFailedDelegate OnAuthenticationFailed;
//
// #pragma warning restore 0067
//
//         private string _credentials;
//         private string _gameVersion;
//
//         public CustomAuthenticator(string credentials, string gameVersion)
//         {
//             this._credentials = credentials;
//             this._gameVersion = gameVersion;
//         }
//
//         /// <summary>
//         /// Not used as IsPreAuthRequired is false
//         /// </summary>
//         public void StartAuthentication()
//         { }
//
//         /// <summary>
//         /// Prepares the request by adding two headers to it
//         /// </summary>
//         public void PrepareRequest(BestHTTP.HTTPRequest request)
//         {
// #if !UNITY_WEBGL || UNITY_EDITOR
//             request.SetHeader("Authorization", "Bearer " + this._credentials);
//             request.AddHeader("game-version", this._gameVersion);
// #endif
//         }
//
//         public Uri PrepareUri(Uri uri)
//         {
// #if UNITY_WEBGL && !UNITY_EDITOR
//             string query = string.IsNullOrEmpty(uri.Query) ? "?" : uri.Query + "&";
//             UriBuilder uriBuilder = new UriBuilder(uri.Scheme, uri.Host, uri.Port, uri.AbsolutePath, query + "access_token=" + this._credentials);
//             return uriBuilder.Uri;
// #else
//             return uri;
// #endif
//         }
//
//         public void Cancel()
//         {
//
//         }
//     }
// }