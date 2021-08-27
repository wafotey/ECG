using System;
using System.Collections.Generic;
using System.Text;

namespace ECG.Models
{
    public class CatalogRepository
    {
        public CatalogRepository()
        {
            Catalogs = new List<Catalog>()
            {
                new Catalog
                {
                    Id = Guid.NewGuid(),
                    Price = 2.0m,
                    Description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Quantity = 34,
                    Image = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    Name = "StrawBerry Pie"
                },
                new Catalog
                {
                    Id = Guid.NewGuid(),
                    Price = 34.0m,
                    Description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Quantity = 3,
                    Image = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                    Name = "Cheese Cake"
                }
            };
        }
        public List<Catalog> Catalogs { get; set; }

    }
}
