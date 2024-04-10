using AutoMapper;
using CarteiraDoInvestidor.Application.Conta.Dto;
using CarteiraDoInvestidor.Domain.Conta;
using CarteiraDoInvestidor.Domain.Conta.Repository;

namespace CarteiraDoInvestidor.Application.Conta.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public async Task<UsuarioOutputDto> Create(UsuarioInputDto dto)
        {
            var usuario = mapper.Map<Usuario>(dto);

            usuario.Validate();
            usuario.SetPassword();

            await usuarioRepository.Save(usuario);

            return mapper.Map<UsuarioOutputDto>(usuario);
        }

        public async Task<UsuarioOutputDto> Edit(Guid id, UsuarioInputDto dto)
        {
            var usuario = this.mapper.Map<Usuario>(dto);

            usuario.Validate();
            usuario.SetPassword();

            await this.usuarioRepository.Update(usuario);

            return this.mapper.Map<UsuarioOutputDto>(usuario);
        }

        public async Task<UsuarioOutputDto> Delete(Guid id)
        {
            var usuario = await this.usuarioRepository.Get(id);

            await this.usuarioRepository.Delete(usuario);

            return this.mapper.Map<UsuarioOutputDto>(usuario);
        }

        public async Task<List<UsuarioOutputDto>> GetAll()
        {
            var result = await usuarioRepository.GetAll();

            return mapper.Map<List<UsuarioOutputDto>>(result);
        }

        public async Task<UsuarioOutputDto> GetId(Guid id)
        {
            var result = await usuarioRepository.Get(id);

            return mapper.Map<UsuarioOutputDto>(result);
        }

    }
}
