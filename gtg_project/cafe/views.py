from django.shortcuts import render, redirect
from .models import Product, Order

def home(request):
    products = Product.objects.all()
    return render(request, "cafe/index.html", {"products": products})


def order_product(request, product_id):
    product = Product.objects.get(id=product_id)

    if request.method == "POST":
        qty = int(request.POST["quantity"])

        total = product.price * qty

        # VAT for drinks
        if product.category == "Drink":
            total = total + (total * 0.25)

        Order.objects.create(
            product=product,
            quantity=qty,
            total_price=total
        )

        return redirect("/orders")

    return render(request, "cafe/order.html", {"product": product})

def orders(request):
    orders = Order.objects.all()
    return render(request, "cafe/orders.html", {"orders": orders})
