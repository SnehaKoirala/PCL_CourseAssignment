//Assignment 1 
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

// Using Record

type Coffee = {
    CoffeeType: CoffeeType
    Size: Size
}
type Tea = {
    TeaType: TeaType
    Size: Size
}
type Juice = {
    JuiceType: JuiceType
    Size: Size
}

type Drink =
    | Coffee of Coffee
    | Tea of Tea
    | Juice of Juice

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

// Using Record

type Sandwich = {
    SandwichType: SandwichType
    Size: Size
}   
type Salad = {
    SaladType: SaladType
    Size: Size
}
type Soup = {
    SoupType: SoupType
    Size: Size
}
type Food =
    | Sandwich of Sandwich
    | Salad of Salad
    | Soup of Soup

// Fruits 
type Fruit =
    | Apple
    | Banana 
    | Orange

// Calculate the price using pattern matching 

let calculateDrinkPrice drink = 
    match drink with
    | Coffee {CoffeeType = Espresso; Size = Small} -> 20.0
    | Coffee {CoffeeType = Espresso; Size = Medium} -> 30.0
    | Coffee {CoffeeType = Espresso; Size = Large} -> 40.0
    | Coffee {CoffeeType = Latte; Size = Small} -> 25.0
    | Coffee {CoffeeType = Latte; Size = Medium} -> 35.0
    | Coffee {CoffeeType = Latte; Size = Large} -> 45.0
    | Coffee {CoffeeType = Cappuccino; Size = Small} -> 30.0
    | Coffee {CoffeeType = Cappuccino; Size = Medium} -> 40.0
    | Coffee {CoffeeType = Cappuccino; Size = Large} -> 50.0

    | Tea {TeaType = GreenTea; Size = Small} -> 15.0
    | Tea {TeaType = GreenTea; Size = Medium} -> 25.0
    | Tea {TeaType = GreenTea; Size = Large} -> 35.0
    | Tea {TeaType = BlackTea; Size = Small} -> 10.0
    | Tea {TeaType = BlackTea; Size = Medium} -> 20.0
    | Tea {TeaType = BlackTea; Size = Large} -> 30.0
    | Tea {TeaType = HerbalTea; Size = Small} -> 12.0
    | Tea {TeaType = HerbalTea; Size = Medium} -> 22.0
    | Tea {TeaType = HerbalTea; Size = Large} -> 32.0

    | Juice {JuiceType = OrangeJuice; Size = Small} -> 18.0
    | Juice {JuiceType = OrangeJuice; Size = Medium} -> 28.0
    | Juice {JuiceType = OrangeJuice; Size = Large} -> 38.0
    | Juice {JuiceType = AppleJuice; Size = Small} -> 15.0   
    | Juice {JuiceType = AppleJuice; Size = Medium} -> 25.0
    | Juice {JuiceType = AppleJuice; Size = Large} -> 35.0
    | Juice {JuiceType = GrapeJuice; Size = Small} -> 20.0
    | Juice {JuiceType = GrapeJuice; Size = Medium} -> 30.0
    | Juice {JuiceType = GrapeJuice; Size = Large} -> 40.0

let calculateFoodPrice food = 
    match food with 
    | Sandwich {SandwichType = ChickenSandwich; Size = Small} -> 50.0
    | Sandwich {SandwichType = ChickenSandwich; Size = Medium} -> 70.0
    | Sandwich {SandwichType = ChickenSandwich; Size = Large} -> 90.0
    | Sandwich {SandwichType = VeggieSandwich; Size = Small} -> 40.0
    | Sandwich {SandwichType = VeggieSandwich; Size = Medium} -> 60.0
    | Sandwich {SandwichType = VeggieSandwich; Size = Large} -> 80.0
    | Sandwich {SandwichType = BeefSandwich; Size = Small} -> 60.0
    | Sandwich {SandwichType = BeefSandwich; Size = Medium} -> 80.0
    | Sandwich {SandwichType = BeefSandwich; Size = Large} -> 100.0

    | Salad {SaladType = CaesarSalad; Size = Small} -> 30.0
    | Salad {SaladType = CaesarSalad; Size = Medium} -> 50.0
    | Salad {SaladType = CaesarSalad; Size = Large} -> 70.0
    | Salad {SaladType = GreekSalad; Size = Small} -> 25.0
    | Salad {SaladType = GreekSalad; Size = Medium} -> 45.0
    | Salad {SaladType = GreekSalad; Size = Large} -> 65.0
    | Salad {SaladType = GardenSalad; Size = Small} -> 20.0
    | Salad {SaladType = GardenSalad; Size = Medium} -> 40.0
    | Salad {SaladType = GardenSalad; Size = Large} -> 60.0

    | Soup {SoupType = TomatoSoup; Size = Small} -> 20.0
    | Soup {SoupType = TomatoSoup; Size = Medium} -> 40.0
    | Soup {SoupType = TomatoSoup; Size = Large} -> 60.0
    | Soup {SoupType = ChickenSoup; Size = Small} -> 25.0
    | Soup {SoupType = ChickenSoup; Size = Medium} -> 45.0
    | Soup {SoupType = ChickenSoup; Size = Large} -> 65.0
    | Soup {SoupType = VegetableSoup; Size = Small} -> 15.0
    | Soup {SoupType = VegetableSoup; Size = Medium} -> 35.0
    | Soup {SoupType = VegetableSoup; Size = Large} -> 55.0 

let calculateFruitPrice fruit  =
    match fruit with 
    | Apple -> 10.0
    | Banana -> 8.0 
    | Orange -> 12.0

let myDrink = Coffee {CoffeeType = Latte; Size = Medium}
printfn "The price of my drink is: %.2fkr" (float (calculateDrinkPrice myDrink))

let myFood = Sandwich {SandwichType = ChickenSandwich; Size = Large}
printfn"The price of my sandwich is: %.2fkr" (float (calculateFoodPrice myFood))

let myFruit = Orange
printfn "The price of my fruit is: %.2fkr" (float (calculateFruitPrice myFruit)) 


//// Assignment 2 //////

// Customer types
type Customer = 
    | VIAStudent
    | VIAStaff
    | Guest

// Payment methods
type Payment = 
    | ViaCard
    | CreditCard
    | MobilePay

// Order record
type Order = {
    Customer : Customer
    Payment : Payment
}

// VAT function
let gtgVAT n x =
    x + (x * float n / 100.0)


// Message type for the actor
type OrderDrinkMsg =
    | OrderDrink of Drink * int
    | OrderFood of Food * int
    | LeaveComment of string


// Actor
let gtgAgent =
    MailboxProcessor.Start(fun inbox ->

        let rec loop () =
            async {

                let! msg = inbox.Receive()

                match msg with

                | OrderDrink (drink, qty) ->

                    let basePrice = calculateDrinkPrice drink
                    let totalPrice = basePrice * float qty

                    match drink with
                    | Coffee c ->

                        let finalPrice = gtgVAT 25 totalPrice

                        printfn
                          "Please pay DKK%.2f for your %d %A coffee drinks. Thanks!"
                          finalPrice qty c.CoffeeType

                    | _ ->

                        printfn
                          "Please pay DKK%.2f for your %d drinks. Thanks!"
                          totalPrice qty
                 | OrderFood (food, qty) ->
                    let basePrice = calculateFoodPrice food
                    let totalPrice = basePrice * float qty

                    match food with
                    | Sandwich s ->
                        let finalPrice = gtgVAT 25 totalPrice
                        printfn
                          "Please pay DKK%.2f for your %d %A sandwiches. Thanks!"
                          finalPrice qty s.SandwichType
                    | Salad sa ->
                        let finalPrice = gtgVAT 25 totalPrice
                        printfn
                          "Please pay DKK%.2f for your %d %A salads. Thanks!"
                          finalPrice qty sa.SaladType
                    | Soup sp ->
                        let finalPrice = gtgVAT 25 totalPrice
                        printfn
                          "Please pay DKK%.2f for your %d %A soups. Thanks!"
                          finalPrice qty sp.SoupType

                | LeaveComment comment ->

                    printfn "Thanks for your comment: \"%s\". We appreciate your feedback!" comment


                return! loop()
            }

        loop ()
    )


let myDrinkOrder =
    Coffee { CoffeeType = Latte; Size = Small }
gtgAgent.Post(OrderDrink(myDrinkOrder, 2))

let myFoodOrder = Sandwich { SandwichType = ChickenSandwich; Size = Large }
gtgAgent.Post(OrderFood(myFoodOrder, 1))

gtgAgent.Post(LeaveComment("Great coffee!"))