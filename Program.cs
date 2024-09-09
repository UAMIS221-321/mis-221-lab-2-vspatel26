const double COST_OF_SANDWHICH = 4.75;
const double COST_OF_TOPPING = .55;
const double DISCOUNT_AMOUNT = .1;


int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;

System.Console.WriteLine("Welcome to Sherlenthia's Sandwitch Shop");

System.Console.WriteLine("Please enter number of sandwitches");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("Please enter number of toppings");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter tip amount in decimals please");
tip = double.Parse(Console.ReadLine());

double totalSandwichCost = COST_OF_SANDWHICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

System.Console.WriteLine("Your order cost is:" + orderCost);