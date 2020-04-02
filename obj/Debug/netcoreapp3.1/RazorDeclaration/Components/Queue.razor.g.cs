#pragma checksum "C:\src\goose2s\Components\Queue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1886210e520de90fd78ec910b84dbcbacd730a0f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Queue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\src\goose2s\Components\Queue.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider spotify { get; set; }
    private QueueItem[] _queue {get;set;}

    [Parameter]
    public Action<QueueItem> TrackChanged { get; set; }

    private void Yield(MouseEventArgs eventArgs, QueueItem item) {
        TrackChanged?.Invoke(item);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    { 
        var results = await spotify.GetQueue("static");
        _queue = results;
        StateHasChanged();
    }

    private void UpVote(MouseEventArgs eventArgs, QueueItem queueItem) {
        spotify.UpVoteItemInQueue("static", queueItem);
        StateHasChanged();
    }

    private void Discard(MouseEventArgs eventArgs, QueueItem queueItem) {
        spotify.DiscardEnqueued("static", queueItem);
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
