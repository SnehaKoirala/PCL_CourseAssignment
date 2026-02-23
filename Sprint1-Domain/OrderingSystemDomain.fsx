type Size = 
    | Small
    | Medium
    | Large

// Drinks

type CoffeeType = 
    | Espresso
    | Latte
    | Cappuccino 

type TeaType = 
    | GreenTea
    | BlackTea
    | HerbalTea

type JuiceType = 
    | OrangeJuice
    | AppleJuice 
    | GrapeJuice 

type Drink = 
    | Coffee of CoffeeType * Size 
    | Tea of TeaType * Size
    | Juice of JuiceType  * Size

// Foods

type SandwichType = 
    | ChickenSandwich
    | VeggieSandwich
    | BeefSandwich 

type SaladType =
    | CaesarSalad
    | GreekSalad
    | GardenSalad
 
type SoupType =
    | TomatoSoup
    | ChickenSoup
    | VegetableSoup 

type Food = 
    | Sandwich of SandwichType * Size
    | Salad of SaladType * Size
    | Soup of SoupType * Size

// Fruits 
type Fruit =
    | Apple
    | Banana 
    | Orange






