#pragma checksum "C:\src\goose2s\Components\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f4ed8aa8199eafda3ac9886f5a0b413fe5dcfe"
// <auto-generated/>
#pragma warning disable 1591
namespace goose2s.Components
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
#line 1 "C:\src\goose2s\Components\Users.razor"
using goose2s.State;

#line default
#line hidden
#nullable disable
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 44 "C:\src\goose2s\Components\Users.razor"
     foreach (var user in SpotifyStateProvider.ActiveUsers)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "media");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "mr-3");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 47 "C:\src\goose2s\Components\Users.razor"
                                GetUrl(user)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "width", "20px");
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 47 "C:\src\goose2s\Components\Users.razor"
                                                                 user.display_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "media-body");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "mt-0 mb-1");
            __builder.AddContent(18, 
#nullable restore
#line 49 "C:\src\goose2s\Components\Users.razor"
                               user.display_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        Connection quality ");
            __builder.AddContent(20, 
#nullable restore
#line 50 "C:\src\goose2s\Components\Users.razor"
                            Ago(user.HeartBeat)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 53 "C:\src\goose2s\Components\Users.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\src\goose2s\Components\Users.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider spotify { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender) {
        spotify.HeartBeat();
    }

    private string GetDisplayName(Models.UserProfile user) {
        return string.IsNullOrEmpty(user.display_name) ? "Unknown user" : user.display_name;
    }

    private string Ago(long lastClientHeartbeatTicks) {
        var ago = TimeSpan.FromTicks(DateTime.UtcNow.Ticks - lastClientHeartbeatTicks);
        if (ago.TotalMilliseconds < 500) {
            return "***";
        }
        else if (ago.TotalMilliseconds < 2000) {
            return "**";
        }
        else if (ago.TotalMilliseconds < 10000) {
            return "*";
        }

        else if (ago.TotalMilliseconds < 30000) {
            return "Worried";
        }
        else {
            return "Disconnected";
        }
    }
    private string GetUrl(Models.UserProfile user) {
        if (!user.Failure && user.images.Any()){
            return user.images.First().url;
        }
        return "img/user.svg";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
