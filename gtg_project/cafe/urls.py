from django.urls import path
from . import views

urlpatterns = [
    path('', views.home),
    path('order/<int:product_id>/', views.order_product),
    path('orders/', views.orders), 
]