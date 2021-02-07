select p.ProductName [Ürün Adı],Sum(od.UnitPrice*od.Quantity) [Kazanılan Toplam Miktar] from
Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on od.OrderID=o.OrderID
group by p.ProductName