using Microsoft.EntityFrameworkCore;
using PetApp.Data;
using PetApp.Models;

namespace PetApp.Services
{
    public interface IAuthService
    {
        Task<Usuario?> LoginAsync(string correo, string contrasena);
        Task RegistrarUsuarioAsync(Usuario usuario);
    }

    public class AuthService : IAuthService
    {
        private readonly PetServicesContext _context;

        public AuthService(PetServicesContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> LoginAsync(string correo, string contrasena)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Correo == correo && u.Contrasena == contrasena);
        }

        public async Task RegistrarUsuarioAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
