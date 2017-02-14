using Finale.BLL.Repository.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.BLL.Service
{
    public class service
    {
        public service()
        {

            _categoryService = new CategoryRepository();
            _productService = new ProductRepository();
            _customerService = new CustomerRepository();
            _itemService = new ItemRepository();
            _reviewService = new ReviewRepository();
            _shoppingCartService = new ShoppingCartRepository();
        }

       

        private CategoryRepository _categoryService;

        public CategoryRepository CategoryService
        {
            get { return _categoryService; }
            set { _categoryService = value; }
        }

        private ProductRepository _productService;

        public ProductRepository ProductService
        {
            get { return _productService; }
            set { _productService = value; }
        }

        private CustomerRepository _customerService;

        public CustomerRepository CustomerService
        {
            get { return _customerService; }
            set { _customerService = value; }
        }

        private ItemRepository _itemService;

        public ItemRepository ItemService
        {
            get { return _itemService; }
            set { _itemService = value; }
        }

        private ReviewRepository _reviewService;

        public ReviewRepository ReviewService
        {
            get { return _reviewService; }
            set { _reviewService = value; }
        }

        private ShoppingCartRepository _shoppingCartService;

        public ShoppingCartRepository ShoppingCartService
        {
            get { return _shoppingCartService; }
            set { _shoppingCartService = value; }
        }








    }
}
