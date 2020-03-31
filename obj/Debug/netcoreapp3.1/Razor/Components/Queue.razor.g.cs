#pragma checksum "C:\src\goose2s\Components\Queue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad0712c7a513bfa8dd07129e498b67a24acd705"
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
#line 1 "C:\src\goose2s\Components\Queue.razor"
using goose2s.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\Components\Queue.razor"
using goose2s.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\Components\Queue.razor"
using goose2s.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\goose2s\Components\Queue.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class Queue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n</div>\r\n\r\n");
#nullable restore
#line 37 "C:\src\goose2s\Components\Queue.razor"
 if (_queue == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 40 "C:\src\goose2s\Components\Queue.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "core");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Image</th>\r\n                <th>Name</th>\r\n                <th>Artist</th>\r\n                <th>Popularity</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "            \r\n");
#nullable restore
#line 54 "C:\src\goose2s\Components\Queue.razor"
     foreach (var result in _queue)
    {
        string playStyle = "";
        if (result.PlayCommenced > 0L) {
            playStyle = "border: 1px solid #6f42c1";
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddAttribute(13, "style", 
#nullable restore
#line 60 "C:\src\goose2s\Components\Queue.razor"
                        playStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 61 "C:\src\goose2s\Components\Queue.razor"
                               result.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 62 "C:\src\goose2s\Components\Queue.razor"
                     result.TrackName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 63 "C:\src\goose2s\Components\Queue.razor"
                     result.ArtistName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "  \r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenComponent<goose2s.Components.Meter>(27);
            __builder.AddAttribute(28, "Level", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 65 "C:\src\goose2s\Components\Queue.razor"
                                   result.Popularity

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "      \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 68 "C:\src\goose2s\Components\Queue.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 72 "C:\src\goose2s\Components\Queue.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\src\goose2s\Components\Queue.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider spotify { get; set; }
    private long sequenceNumber { get; set; }
    private QueueItem[] _queue {get;set;}

    [Parameter]
    public Action<QueueItem> TrackChanged { get; set; }

    private void Yield(MouseEventArgs eventArgs, QueueItem item) {
        TrackChanged?.Invoke(item);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    { 
        var results = await spotify.GetQueue("static", sequenceNumber);
        if (results.Item1 != long.MinValue)
        {
            sequenceNumber = results.Item1;
            _queue = results.Item2;
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private QueueService queue { get; set; }
    }
}
#pragma warning restore 1591
