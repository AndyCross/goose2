#pragma checksum "C:\src\goose2s\Components\Queue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2abfe364b3f8955d0afd0880b5c622312ceaedae"
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
#line 42 "C:\src\goose2s\Components\Queue.razor"
 if (results == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 45 "C:\src\goose2s\Components\Queue.razor"
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
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>...</th>\r\n                <th>Image</th>\r\n                <th>Name</th>\r\n                <th>Artist</th>\r\n                <th>Popularity</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "            \r\n");
#nullable restore
#line 60 "C:\src\goose2s\Components\Queue.razor"
     foreach (var result in results)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\src\goose2s\Components\Queue.razor"
                                        (e)=>Yield(e, result)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "▶️");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 64 "C:\src\goose2s\Components\Queue.razor"
                               result.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 65 "C:\src\goose2s\Components\Queue.razor"
                     result.TrackName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 66 "C:\src\goose2s\Components\Queue.razor"
                     result.ArtistName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "  \r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "width", "100%");
            __builder.AddAttribute(33, "class", "slim");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "width", (
#nullable restore
#line 70 "C:\src\goose2s\Components\Queue.razor"
                                         result.Popularity

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(39, "style", "background-color:#6f42c1");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "width", (
#nullable restore
#line 71 "C:\src\goose2s\Components\Queue.razor"
                                         100-result.Popularity

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(43, "style", "background-color:#eee");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "      \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 75 "C:\src\goose2s\Components\Queue.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 79 "C:\src\goose2s\Components\Queue.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\src\goose2s\Components\Queue.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider SpotifyStateProvider { get; set; }
    private long sequenceNumber { get; set; }
    private QueueItem[] results { get; set; }
    [Parameter]
    public Action<QueueItem> TrackChanged { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        var resultT = await queue.GetQueue("static", -1L);
        sequenceNumber = resultT.Item1;
        results = resultT.Item2;

        var timer = new Timer(new TimerCallback(async _ =>
        {
            await InvokeAsync(async () => {
                var resultsT = await queue.GetQueue("static", sequenceNumber);
                if (resultsT.Item1 != long.MinValue) {
                    results = resultsT.Item2;
                    sequenceNumber = resultsT.Item1;
                    this.StateHasChanged();
                }
            });
        }), null, 168, 168);
    }
    private void Yield(MouseEventArgs eventArgs, QueueItem item) {
        TrackChanged?.Invoke(item);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private QueueService queue { get; set; }
    }
}
#pragma warning restore 1591
