using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace jamesblog.UI.Units
{
    public sealed class MenuList : ListBox
    {
        public MenuList()
        {
            this.DefaultStyleKey = typeof(MenuList);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MenuListItem();
        }
    }
}
