#pragma checksum "C:\src\goose2s\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85047a96253fa44bcb4a1b2fb00f3ee9dab69229"
// <auto-generated/>
#pragma warning disable 1591
namespace goose2s.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\goose2s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\goose2s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\goose2s\_Imports.razor"
using goose2s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\goose2s\_Imports.razor"
using goose2s.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\Pages\Index.razor"
using goose2s.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\Pages\Index.razor"
using goose2s.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 30 "C:\src\goose2s\Pages\Index.razor"
 if (SpotifyStateProvider.CurrentContext == null || !SpotifyStateProvider.CurrentContext.Success)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>You gotta log in foolz</h1>\r\n    ");
            __builder.AddMarkupContent(2, "<p>Honk honk!</p>\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 34 "C:\src\goose2s\Pages\Index.razor"
              callbackUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Join the formation");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 35 "C:\src\goose2s\Pages\Index.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<h1>Hello, world!</h1>\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\src\goose2s\Pages\Index.razor"
                                              Creep

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n        HONK\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\src\goose2s\Pages\Index.razor"
                                              Croop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n        HISS\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 44 "C:\src\goose2s\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddMarkupContent(20, "<h1>Queue</h1>\r\n");
            __builder.OpenComponent<goose2s.Components.Queue>(21);
            __builder.AddAttribute(22, "TrackChanged", new System.Action<goose2s.Models.QueueItem>(
#nullable restore
#line 47 "C:\src\goose2s\Pages\Index.razor"
                                        Honk

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.AddMarkupContent(24, "<h1>Search</h1>\r\n");
            __builder.OpenComponent<goose2s.Components.Search>(25);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\src\goose2s\Pages\Index.razor"
           
    [CascadingParameter]
    private SpotifyStateProvider SpotifyStateProvider { get; set; }

    private string callbackUri = "";

    protected override void OnInitialized() {
        var honker = AuthContants.GetAuthKeys();
        callbackUri = QueryHelpers.AddQueryString("https://accounts.spotify.com/authorize", honker);
    } 

    private async Task Creep(MouseEventArgs e) {
        await playback.Play("7zlz2IQA9D08HII7LUPrvX", SpotifyStateProvider.CurrentContext.access_token);
    }
    private async Task Croop(MouseEventArgs e) {
        await playback.Seek(30000, SpotifyStateProvider.CurrentContext.access_token);
    }

    private void Honk(Models.QueueItem item) {
        playback.Play(item.TrackId, SpotifyStateProvider.CurrentContext.access_token).Wait();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PlaybackService playback { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591