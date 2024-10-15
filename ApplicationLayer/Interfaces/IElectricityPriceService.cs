﻿using ApplicationLayer.Dto;
using Domain.Entities;
using static ApplicationLayer.Services.ElectricityPriceService;

namespace ApplicationLayer.Interfaces
{
    public interface IElectricityPriceService
    {
        Task<ElectricityPriceResultDto> GetElectricityPriceDataAsync(CombinedRequestDtoIn request);

        Task<List<ElectricityPriceData>> GetElectricityPricesAsync(DateTime startDate, DateTime endDate);

    }
}
