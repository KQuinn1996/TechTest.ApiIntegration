﻿using ApiIntegration.Models;
using System.Threading.Tasks;

namespace ApiIntegration.Interfaces
{
    public interface ITourRepository
    {
        Task<bool> UpdateAsync(Tour tour);
        Task<Tour> GetAsync(int providerId, string tourRef);
    }
}
