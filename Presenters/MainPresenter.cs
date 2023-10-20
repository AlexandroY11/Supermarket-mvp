using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;


namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoryView += ShowCategoryView;
            this.mainView.ShowProviderView += ShowProviderView;
            
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowCategoryView(object? sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstance((MainView)mainView);
            ICategoryRepository repository = new CategoryRepository(sqlConnectionString);
            new CategoryPresenter(view, repository);
        }

        private void ShowProviderView(object? sender, EventArgs e)
        {
            IProviderView view = ProviderView.GetInstance((MainView)mainView);
            IProviderRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);
        }
    }
}
