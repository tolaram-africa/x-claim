// Copyright 2023 - 2023 Godwin peter .O (me@godwin.dev)
//
// Licensed under the MIT License;
// you may not use this file except in compliance with the License.
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.DependencyInjection;
using XClaim.Web.Components.States;

namespace XClaim.Web.Components.Extensions;

public static class ComponentClientExtensions {
    public static IServiceCollection RegisterComponentsExtensions(this IServiceCollection services) {
        services.AddSingleton<Navigation>();

        return services;
    }

    public static IServiceCollection RegisterBlazorClientState(this IServiceCollection services) {
        services.AddSingleton<AppState>();
        // services.AddSingleton<AuthState>();
        services.AddScoped<ThemeState>();

        return services;
    }
}