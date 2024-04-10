using AutoMapper;
using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.CrossCuting.Infrastructure;
using CarteiraDoInvestidor.Domain.Carteira;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public class ArquivoExcelService : IArquivoExcelService
    {
        private readonly IArquivoExcelRepository arquivoExcelRepository;
        private readonly IMapper mapper;
        private IHttpClientFactory httpClientFactory;
        private AzureBlobStorage storage;

        public ArquivoExcelService(IArquivoExcelRepository arquivoExcelRepository, IMapper mapper, IHttpClientFactory httpClientFactory, AzureBlobStorage storage)
        {
            this.arquivoExcelRepository = arquivoExcelRepository;
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
        }

        public async Task<ArquivoExcelOutputDto> Create(ArquivoExcelInputDto dto)
        {
            var arquivoexcel = this.mapper.Map<ArquivoExcel>(dto);

            HttpClient httpClient = this.httpClientFactory.CreateClient();

            using var response = await httpClient.GetAsync(arquivoexcel.LinkExcel);

            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                var filename = $"{Guid.NewGuid()}";
                var pathStorage = await this.storage.UploadFile(filename, stream);
                arquivoexcel.LinkExcel = pathStorage;
            }
            await this.arquivoExcelRepository.Save(arquivoexcel);

            return this.mapper.Map<ArquivoExcelOutputDto>(arquivoexcel);
        }
        public async Task<List<ArquivoExcelOutputDto>> GetAll()
        {
            var arquivoExcel = await this.arquivoExcelRepository.GetAll();

            return this.mapper.Map<List<ArquivoExcelOutputDto>>(arquivoExcel);
        }
    }
}
