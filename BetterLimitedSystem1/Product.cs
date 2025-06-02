using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLimitedSystem1
{
    internal class Product
    {
        public String Item_ID;
        public String Item_Name;
        public String descript;
        public int stockqty;
        public double price;


        public void setItem_ID(String id) { Item_ID = id; }
        public String getItem_ID() { return Item_ID; }
        public void setItem_Name(String name) { Item_Name = name; }
        public String getItem_Name() { return Item_Name; }
        public void setdesciprt(String desc) { this.descript =  desc; }
        public String getdesc() { return descript; }
        public void setstockqty(int stock) { stockqty = stock; }
        public int getstockqty() { return stockqty; }
        public void setprice(double price) {this.price = price; }
        public double getprice() { return price; }
    }
}
