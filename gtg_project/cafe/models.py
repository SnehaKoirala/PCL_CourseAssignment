from django.db import models

class Product(models.Model):
    CATEGORY_CHOICES = [
        ('Drink', 'Drink'),
        ('Food', 'Food'),
        ('Fruit', 'Fruit'),
    ]

    name = models.CharField(max_length=100)
    price = models.FloatField()
    category = models.CharField(max_length=10, choices=CATEGORY_CHOICES)

    def __str__(self):
        return self.name


class Order(models.Model):
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    quantity = models.IntegerField()
    total_price = models.FloatField()

    def __str__(self):
        return f"{self.product.name} x {self.quantity}"