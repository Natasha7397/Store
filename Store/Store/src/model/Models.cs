using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.src.model
{
    public class Models
    {

        public class Rootobject<T>
        {
            public T[] body { get; set; }
        }

        public class BasketProduct
        {
            [System.ComponentModel.Browsable(false)]
            public int id { get; set; }
            [System.ComponentModel.DisplayName("Название")]
            public string name { get; set; }
            [System.ComponentModel.DisplayName("Количество")]
            public int quantity { get; set; }
        }

        public class Transaction
        {

            private Businessentity bs;
            private User u;
            private Transactiontype transType;
            private Product prod;

            [System.ComponentModel.Browsable(false)]
            public int id { get; set; }

            [System.ComponentModel.DisplayName("Дата")]
            public string date { get; set; }

            [System.ComponentModel.DisplayName("Цена")]
            public int price { get; set; }

            [System.ComponentModel.Browsable(false)]
            public Businessentity businessEntity
            {
                get
                {
                    return bs;
                }
                set
                {
                    bs = value;
                    businessEntityName = value.name;
                }
            }

            [System.ComponentModel.Browsable(false)]
            public User user
            {
                get
                {
                    return u;
                }
                set
                {
                    u = value;
                    userName = value.login;
                }
            }

            [System.ComponentModel.Browsable(false)]
            public Transactiontype transactionType
            {
                get
                {
                    return transType;
                }
                set
                {
                    transType = value;
                    transactionTypeName = value.name;
                }
            }

            [System.ComponentModel.Browsable(false)]
            public Product product
            {
                get
                {
                    return prod;
                }
                set
                {
                    prod = value;
                    productName = value.name;
                }
            }

            [System.ComponentModel.DisplayName("Пользователь")]
            public string userName { get; set; }

            [System.ComponentModel.DisplayName("Клиент/Поставщик")]
            public string businessEntityName { get; set; }

            [System.ComponentModel.DisplayName("Тип операции")]
            public string transactionTypeName { get; set; }

            [System.ComponentModel.DisplayName("Товар")]
            public string productName { get; set; }
        }

        public class Businessentity
        {
            [System.ComponentModel.DisplayName("ИНН")]
            public int inn { get; set; }
            [System.ComponentModel.DisplayName("Расчетный счет")]
            public int giro { get; set; }
            [System.ComponentModel.DisplayName("Почта")]
            public string email { get; set; }
            [System.ComponentModel.DisplayName("Название")]
            public string name { get; set; }
            [System.ComponentModel.DisplayName("Адрес")]
            public string address { get; set; }
            [System.ComponentModel.DisplayName("Номер телефона")]
            public string phone { get; set; }
        }

        public class User
        {
            private Role r;

            [System.ComponentModel.Browsable(false)]
            public int id { get; set; }

            [System.ComponentModel.Browsable(false)]
            public Role role
            {
                get
                {
                    return r;
                }
                set
                {
                    r = value;
                    roleName = value.name;
                }
            }

            [System.ComponentModel.DisplayName("Логин")]
            public string login { get; set; }
            [System.ComponentModel.Browsable(false)]
            public string password { get; set; }
            [System.ComponentModel.DisplayName("Роль")]
            public string roleName { get; set; }
        }

        public class Role
        {
            [System.ComponentModel.Browsable(false)]
            public int id { get; set; }
            [System.ComponentModel.DisplayName("Название")]
            public string name { get; set; }
        }

        public class Transactiontype
        {
            [System.ComponentModel.Browsable(false)]
            public int id { get; set; }
            [System.ComponentModel.DisplayName("Название")]
            public string name { get; set; }
        }

        public class Product
        {
            [System.ComponentModel.DisplayName("ID")]
            public int id { get; set; }
            [System.ComponentModel.DisplayName("Название")]
            public string name { get; set; }
            [System.ComponentModel.DisplayName("Количество")]
            public int quantity { get; set; }
            [System.ComponentModel.DisplayName("Цена продажи за единицу")]
            public int sellPrice { get; set; }
        }
    }
}
