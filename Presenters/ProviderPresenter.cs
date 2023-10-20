using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;

        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);

            loadAllProviderList();

            this.view.Show();
        }

        private void loadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderAddress = "";
            view.ProviderPhone = "";
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var Provider = new ProviderModel();
            Provider.Id = Convert.ToInt32(view.ProviderId);
            Provider.Name = view.ProviderName;
            Provider.Address = view.ProviderAddress;
            Provider.Phone = view.ProviderPhone;

            try
            {
                new Common.ModelDataValidation().Validate(Provider);
                if (view.IsEdit)
                {
                    repository.Edit(Provider);
                    view.Message = "Provider edited successfully";
                }
                else
                {
                    repository.Add(Provider);
                    view.Message = "Provider added successfully";
                }
                view.IsSuccessful = true;
                loadAllProviderList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;

            }
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProviderModel)providerBindingSource.Current;

                repository.Delete(provider.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProviderModel)providerBindingSource.Current;

            view.ProviderId = provider.Id.ToString();
            view.ProviderName = provider.Name;
            view.ProviderAddress = provider.Address;
            view.ProviderPhone = provider.Phone;

            view.IsEdit = true;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields();

        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }
    }
}
