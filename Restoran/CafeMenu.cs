using Restoran;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class CafeMenu : Menu
    {
        private ArrayList menuItems = new ArrayList();

        public CafeMenu(ArrayList menuItems)
        {
            this.menuItems = menuItems;
        }

        public CafeMenu()
        {
            addltem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);

            addltem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69);

            addltem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacomale",
                true, 4.29);
        }

        private void addltem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
