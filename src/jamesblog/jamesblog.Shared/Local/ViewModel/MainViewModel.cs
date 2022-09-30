using jamesblog.Local.Model;
using System.Collections.Generic;

namespace jamesblog.Local.ViewModel
{
    public class MainViewModel
    {
        public List<MenuModel> Menus { get; private set; }

        public MainViewModel()
        {
            Menus = GetMenus();
        }        

        private List<MenuModel> GetMenus()
        {
            var source = new List<MenuModel>();
            source.Add(new MenuModel { Name = "James" });
            source.Add(new MenuModel { Name = "GitHub" });
            return source;
        }
    }
}
