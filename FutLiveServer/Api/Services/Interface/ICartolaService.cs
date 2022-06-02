using Microsoft.AspNetCore.Mvc;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutLiveServer.Services.Interface
{
    [Header("Content-Type", "application/json")]
    [Header("Connection", "keep-alive")]
    [Header("Accept", "*/*")]
    [Header("User-Agent", "PostmanRuntime/7.28.4")]
    public interface ICartolaService
    {
        [Get("/partidas")]
        Task<PartidasResponse> GetPartidas();

        [Get("/partidas/{rodada}")]
        Task<PartidasResponse> GetRodada([Path] int rodada);

        [Get("/atletas/mercado")]
        Task<MercadoResponse> GetMercado();
    }
}
