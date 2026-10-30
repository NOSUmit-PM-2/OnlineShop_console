using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
	public class Cart
	{
		List<CartItem> items = new List<CartItem>();

		public int Count
		{
			get
			{
				return items.Count();
			}
		}

		public void Add(Product product)
		{
			foreach (CartItem item in items)
			{
				if (item.IsProduct(product))
				{
					item.Count++;
					return;
				}
			}
			items.Add(new CartItem(product));
		}

		public void Remove(Product product)
		{
			foreach (CartItem item in items)
			{
				if (item.IsProduct(product))
				{
					items.Remove(item);
					return;
				}
			}
		}

		public void RemoveEmpty()
		{
			List<CartItem> remove = new List<CartItem>();
			foreach (CartItem item in items)
			{
				if (item.Count < 1)
				{
					remove.Add(item);
				}
			}
			foreach (CartItem item in remove)
			{
				items.Remove(item);
			}
		}

		public CartItem[] getAll()
		{
			return items.ToArray();
		}

	}
}
