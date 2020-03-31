#pragma checksum "C:\src\goose2s\Components\NowPlaying.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7399e982b09543b0934a663ec0d33ec9a5d880"
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
#line 1 "C:\src\goose2s\Components\NowPlaying.razor"
using goose2s.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\Components\NowPlaying.razor"
using goose2s.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\Components\NowPlaying.razor"
using goose2s.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\goose2s\Components\NowPlaying.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class NowPlaying : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 84 "C:\src\goose2s\Components\NowPlaying.razor"
             nowPlaying?.TrackName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 86 "C:\src\goose2s\Components\NowPlaying.razor"
     if (SecondsLeft > 0) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "text-nowrap");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddContent(11, 
#nullable restore
#line 88 "C:\src\goose2s\Components\NowPlaying.razor"
             Humanize(SecondsLeft)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 90 "C:\src\goose2s\Components\NowPlaying.razor"
         if (!Playing) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.AddMarkupContent(15, "<span class=\"text-nowrap\">Nothing playing yet, add something to the queue or wait while we catch up... honk</span>\r\n");
#nullable restore
#line 92 "C:\src\goose2s\Components\NowPlaying.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenComponent<goose2s.Components.Meter>(17);
            __builder.AddAttribute(18, "Level", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 93 "C:\src\goose2s\Components\NowPlaying.razor"
                                          Percentage

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 94 "C:\src\goose2s\Components\NowPlaying.razor"
    }
    else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.AddMarkupContent(21, "<span>Stopped</span>\r\n");
#nullable restore
#line 97 "C:\src\goose2s\Components\NowPlaying.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\src\goose2s\Components\NowPlaying.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider spotify { get; set; }
    private long sequenceNumber {get;set;}
    public double SecondsLeft = 0D;
    public double Position = 0D;
    public int Percentage = 0;
    public bool Playing = false;
    private Models.QueueItem nowPlaying = default(Models.QueueItem);
    public async Task<QueueItem> Tick()
    {
        if (nowPlaying == null || nowPlaying.PlayConcluded > 0L)
        {
            return await SetupNextTrack();
        }
        else if (nowPlaying.PlayCommenced != 0L && (nowPlaying.PlayConcluded == 0L && (nowPlaying.PlayCommenced + (nowPlaying.DurationMs * 10000L) < DateTime.UtcNow.Ticks)))
        {
            nowPlaying.PlayConcluded = DateTime.UtcNow.Ticks;
            return await SetupNextTrack();
        }
        return nowPlaying;
    }
    private async Task<QueueItem> SetupNextTrack()
    {
        var currentQueue = await spotify.GetFirst("static", -1);
        if (currentQueue.Item1 != long.MinValue)
        {
            sequenceNumber = currentQueue.Item1;
            if (currentQueue.Item2 != null && nowPlaying != currentQueue.Item2)
            {
                nowPlaying = currentQueue.Item2;
                if (nowPlaying.PlayCommenced == 0L) {
                    nowPlaying.PlayCommenced = DateTime.UtcNow.Ticks;
                    await TrackChanged(nowPlaying);
                }
            }
        }
        return nowPlaying;
    }
    private async Task TrackChanged(QueueItem track) {
        await playbackService.Play(track.TrackId, spotify.CurrentContext.access_token);
        Playing = true;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    { 
        nowPlaying = await Tick();
        if (nowPlaying != null) 
        {
            Position = (DateTime.UtcNow - new DateTime(nowPlaying.PlayCommenced, DateTimeKind.Utc)).TotalSeconds;
            SecondsLeft = (new DateTime(nowPlaying.PlayCommenced, DateTimeKind.Utc).AddMilliseconds(nowPlaying.DurationMs) - DateTime.UtcNow).TotalSeconds;
            Percentage = (int)Math.Round((Position/(nowPlaying.DurationMs/1000))*100);

            if (!Playing)//catchup ketchup catsup 
            {
                var Position = (DateTime.UtcNow - new DateTime(nowPlaying.PlayCommenced, DateTimeKind.Utc)).TotalSeconds;
                await playbackService.Play(nowPlaying.TrackId, spotify.CurrentContext.access_token);
                await playbackService.Seek((int)Position * 1000, spotify.CurrentContext.access_token);
                
                Playing = true;
            }
            StateHasChanged();
        }       
    }

    private string Humanize(double secondsLeft)
    {
        if (secondsLeft < 60D)
        {
            return $"{secondsLeft:0.##} seconds left";
        }
        return $"{secondsLeft / 60d:0} minutes left";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PlaybackService playbackService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NowPlayingService nowPlayingService { get; set; }
    }
}
#pragma warning restore 1591