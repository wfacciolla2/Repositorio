// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OficinasUsuario.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using OficinasUsuario.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\_Imports.razor"
using OficinasUsuario.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\Pages\FetchData.razor"
using OficinasUsuario.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "E:\Repositorio\Repositorio\UniveSP\OficinasUsuario\OficinasUsuario\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
