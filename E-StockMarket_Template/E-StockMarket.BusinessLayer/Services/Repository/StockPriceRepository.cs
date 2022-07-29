using E_StockMarket.BusinessLayer.ViewModels;
using E_StockMarket.DataLayer;
using E_StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_StockMarket.BusinessLayer.Services.Repository
{
    public class StockPriceRepository : IStockPriceRepository
    {
        private readonly StockMarketDbContext _stockMarketDbContext;
        public StockPriceRepository(StockMarketDbContext stockMarketDbContext)
        {
            _stockMarketDbContext = stockMarketDbContext;
        }

        public async Task<StockPrice> FindStockPriceById(long stockPriceId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StockPrice>> GetStockPriceIndex(long componyCode, DateTime startDate, DateTime endDate)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StockPrice>> ListAllStockPrices()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<StockPrice> Register(StockPrice stockPrice)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<StockPrice> UpdateStockPrice(RegisterStockPriceViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
