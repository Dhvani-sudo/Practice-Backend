package main
import "fmt"

func AddNumbers() {
  var number1, number2, number3 int
   
   // initializing the variables
   number1 = 99
   number2 = 81
   
   // adding the numbers
   number3 = number1 + number2
   
   // printing the results
   fmt.Println("The addition of ", number1, " and ", number2, " is", number3)
}

func main() {
  AddNumbers() // call the function
}