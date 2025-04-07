using Microsoft.AspNetCore.Components.Authorization;
using PetApp.Models;
using System.Security.Claims;

namespace PetApp.Services
{
    public class CustomAuthProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal _user = new ClaimsPrincipal(new ClaimsIdentity());

        public void SetUser(Usuario usuario)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nombre),
                new Claim(ClaimTypes.Email, usuario.Correo),
                new Claim(ClaimTypes.Role, usuario.Rol)
            }, "custom");

            _user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
        }

        public void Logout()
        {
            _user = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(_user));
        }
    }
}
