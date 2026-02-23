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

// Calculate price using pattern matching 

let calculateDrinkPrice drink = 
    match drink with
    | Coffee (Espresso, Small) -> 20 
    | Coffee (Espresso, Medium) -> 30
    | Coffee (Espresso, Large) -> 40
    | Coffee (Latte, Small) -> 25
    | Coffee (Latte, Medium) -> 35
    | Coffee (Latte, Large) -> 45
    | Coffee (Cappuccino, Small) -> 30
    | Coffee (Cappuccino, Medium) -> 40
    | Coffee (Cappuccino, Large) -> 50

    | Tea (GreenTea, Small) -> 15
    | Tea (GreenTea, Medium) -> 25
    | Tea (GreenTea, Large) -> 35
    | Tea (BlackTea, Small) -> 10
    | Tea (BlackTea, Medium) -> 20
    | Tea (BlackTea, Large) -> 30
    | Tea (HerbalTea, Small) -> 12
    | Tea (HerbalTea, Medium) -> 22
    | Tea (HerbalTea, Large) -> 32

    | Juice (OrangeJuice, Small) -> 18
    | Juice (OrangeJuice, Medium) -> 28
    | Juice (OrangeJuice, Large) -> 38
    | Juice (AppleJuice, Small) -> 15   
    | Juice (AppleJuice, Medium) -> 25
    | Juice (AppleJuice, Large) -> 35
    | Juice (GrapeJuice, Small) -> 20
    | Juice (GrapeJuice, Medium) -> 30
    | Juice (GrapeJuice, Large) -> 40

let calculateFoodPrice food = 
    match food with 
    | Sandwich (ChickenSandwich, Small) -> 50
    | Sandwich (ChickenSandwich, Medium) -> 70
    | Sandwich (ChickenSandwich, Large) -> 90
    | Sandwich (VeggieSandwich, Small) -> 40
    | Sandwich (VeggieSandwich, Medium) -> 60
    | Sandwich (VeggieSandwich, Large) -> 80
    | Sandwich (BeefSandwich, Small) -> 60
    | Sandwich (BeefSandwich, Medium) -> 80
    | Sandwich (BeefSandwich, Large) -> 100

    | Salad (CaesarSalad, Small) -> 30
    | Salad (CaesarSalad, Medium) -> 50
    | Salad (CaesarSalad, Large) -> 70
    | Salad (GreekSalad, Small) -> 25
    | Salad (GreekSalad, Medium) -> 45
    | Salad (GreekSalad, Large) -> 65
    | Salad (GardenSalad, Small) -> 20
    | Salad (GardenSalad, Medium) -> 40
    | Salad (GardenSalad, Large) -> 60

    | Soup (TomatoSoup, Small) -> 20
    | Soup (TomatoSoup, Medium) -> 40
    | Soup (TomatoSoup, Large) -> 60
    | Soup (ChickenSoup, Small) -> 25
    | Soup (ChickenSoup, Medium) -> 45
    | Soup (ChickenSoup, Large) -> 65
    | Soup (VegetableSoup, Small) -> 15
    | Soup (VegetableSoup, Medium) -> 35
    | Soup (VegetableSoup, Large) -> 55 

let calculateFruitPrice fruit  =
    match fruit with 
    | Apple -> 10
    | Banana -> 8 
    | Orange -> 12

let myDrink = Coffee (Latte, Medium)
printfn "The price of my drink is: %.2fkr" (float (calculateDrinkPrice myDrink))

let myFood = Sandwich (ChickenSandwich, Large)
printfn"The price of my sandwich is: %.2fkr" (float (calculateFoodPrice myFood))

let myFruit = Orange
printfn "The price of my fruit is: %.2fkr" (float (calculateFruitPrice myFruit))