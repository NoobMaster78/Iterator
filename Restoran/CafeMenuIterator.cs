using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Restoran
{
    public class CafeMenuIterator : Iterator
    {
        List<MenuItem> items;
        int position = 0;

        public ArrayList MenuItems { get; }

        public CafeMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public CafeMenuIterator(ArrayList menuItems)
        {
            MenuItems = menuItems;
        }

        public MenuItem next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
        public bool hasNext()
        {
            if (position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
