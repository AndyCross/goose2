#pragma checksum "C:\src\goose2s\State\SpotifyStateProvider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66da96c705e256e086faf10ff77369413bf65dde"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace goose2s.State
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
#line 1 "C:\src\goose2s\State\SpotifyStateProvider.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\State\SpotifyStateProvider.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\State\SpotifyStateProvider.razor"
using goose2s.Models;

#line default
#line hidden
#nullable disable
    public partial class SpotifyStateProvider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\src\goose2s\State\SpotifyStateProvider.razor"
       
    private bool _hasLoaded;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public SpotifyContext CurrentContext { get; set; }
    private bool RefreshingAccessToken {get;set;}
    private System.Threading.Timer refreshTimer=null;

    public SpotifyStateProvider()
    {
    }
    protected override async Task OnInitializedAsync()
    {
        CurrentContext = await ProtectedSessionStore.GetAsync<SpotifyContext>("auth");
        _hasLoaded = true;
        if (!RefreshingAccessToken) {
            SetupRefresh();
        }
    }

    public async Task SaveChangesAsync()
    {
        await ProtectedSessionStore.SetAsync("auth", CurrentContext);
    }

    public void SetupRefresh() {
        InvokeAsync(async() => {
            RefreshingAccessToken = true;
            await Task.Delay((CurrentContext.Auth.expires_in-10)*1000);
            if (CurrentContext != null && !CurrentContext.Auth.Failure) {
                var newToken = await AuthActions.RefreshToken(config, CurrentContext.Auth.refresh_token);
                CurrentContext.Auth.access_token = newToken.access_token;
                CurrentContext.Auth.expires_in = newToken.expires_in;

                await SaveChangesAsync();
            }
        });
    }

    public static QueueItem[] QueueMem = new QueueItem[0];
    public QueueItem[] _queue { get => QueueMem; set => QueueMem = value;}
    public static QueueItem[] ActiveQueue { get; set; }

    public static UserProfile[] ActiveUserMem = new UserProfile[0];
    public static UserProfile[] ActiveUsers { get => ActiveUserMem; set => ActiveUserMem = value; }

    public void Login() {
        var aul = new List<UserProfile>(ActiveUsers);
        CurrentContext.User.HeartBeat = DateTime.UtcNow.Ticks;
        aul.Add(CurrentContext.User);

        ActiveUsers = aul.ToArray();
        this.StateHasChanged();
    }
    public void HeartBeat() {
        if (CurrentContext != null && CurrentContext.User != null) {
            if (ActiveUsers.Any(u => u.id == CurrentContext.User.id)) {
                ActiveUsers.First(u => u.id == CurrentContext.User.id).HeartBeat = DateTime.UtcNow.Ticks;
                this.StateHasChanged();
            }
            else {
                // not logged in or just honked
            }
        }
    }
    public void Enqueue(string flock, SpotifyItem track)
    {
        try 
        {

        var entity = new QueueItem(flock, DateTime.UtcNow)
        {
            ArtistName = string.Join(", ", track.artists.Select(a => a.name)),
            DurationMs = track.duration_ms,
            Image = track.album.images.OrderBy(i => i.height).First().url,
            Popularity = track.popularity,
            TrackId = track.id,
            TrackName = track.name,
            Votes = 0,
            EnqueuedBy = CurrentContext.User
        };

        var q = new List<QueueItem>(_queue);
        q.Add(entity);
        this._queue = q.ToArray();

        ActiveQueue = _queue
            .Where(qi => qi.PartitionKey == flock
                            && qi.PlayConcluded == 0L)
            .ToArray();
        
        this.StateHasChanged();
        }
        catch (Exception ex) 
        {

        }
    }

    public async Task<QueueItem[]> GetQueue(string flock)
    {
        return ActiveQueue;
    }

    public async Task<QueueItem> GetFirst(string flock)
    {
        if (ActiveQueue == null)
            return null;

        return ActiveQueue.Where(qi => qi.PlayConcluded  == 0L).FirstOrDefault();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
#pragma warning restore 1591
