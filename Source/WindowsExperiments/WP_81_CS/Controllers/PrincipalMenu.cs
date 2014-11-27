using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_81_CS.Models;

namespace WP_81_CS.Controllers
{
    public class PrincipalMenu
    {
        private List<MenuItem> _menuItems;

        public PrincipalMenu()
        {
            InitializeComponent();
            CreateItems();
        }

        private void InitializeComponent()
        {
            this._menuItems = new List<MenuItem>();
        }

        private void CreateItems()
        {
            if (this._menuItems !=null)
            {
                this._menuItems.Add(new MenuItem() { Id = 1, Name = "WebView" });
            }
        }

        public List<MenuItem> GetItems()
        {
            return _menuItems;
        }

        public Type GetNavigationType(MenuItem selectedItem)
        {
            switch (selectedItem.Id)
            {
                case 1:
                    return typeof(WP_81_CS.Experiments.WebView.WebView2);
                default:
                    return null;
            }
        }
    }
}
