using System;
using System.Threading.Tasks;
using MauiWxApp.Models;

namespace MauiWxApp.Services
{
	public interface IAlertService
	{
        Task<Alert[]> GetAlerts(string stateCode);
    }
}

