using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProviderView
    {
        String ProviderId { get; set; }
        String ProviderName { get; set; }
        String ProviderAddress { get; set; }
        String ProviderPhone { get; set; }
        String SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProviderListBildingSource(BindingSource providerList);
        void Show();
    }
}
