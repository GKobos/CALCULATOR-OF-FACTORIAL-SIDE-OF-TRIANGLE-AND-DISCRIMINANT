using System;
using System.Numerics;

class Calculator{
    static void Main(string[] args){
        Calculator p = new Calculator();
        p.Menu();
    }

    private void Menu(){
        while(true){
            Console.WriteLine("\n---MENU---");
            Console.WriteLine("Select what you want to do.");
            Console.WriteLine("0) Exit.");
            Console.WriteLine("1) Factorial Calculation.");
            Console.WriteLine("2) Calculating the Side of a Right Triangle.");
            Console.WriteLine("3) Solution of a Quadratic Equation.");
            int choice = AreNumbers();
            switch(choice){
                case 0:
                    return;
                case 1:
                    Factorial();
                    break;
                case 2:
                    RightTriangle();
                    break;
                case 3:
                    QuadraticEquation();
                    break;
                default:
                    Console.WriteLine("Wrong Choice.");
                    break;
            }
        }
    }

    private void Factorial(){
        int num;
        while(true){
            Console.WriteLine("\n---FACTORIAL CALCULATION---");
            Console.WriteLine("Give me a Number Greater than or Equal to Zero!");
            num = AreNumbers();
            BigInteger factorial=1;
            if(num>=0){
                for(int i=1; i<=num; i++){
                    factorial *= i;
                }
                Console.WriteLine($"The Factorial of {num} is : {factorial}.");
                break;
            }
            else{
                Console.WriteLine("The Number Must be Greater than or Equal to Zero!");
            }
        }
    }

    private void RightTriangle(){
        int choice;
        while(true){
            Console.WriteLine("\n---CALCULATING THE SIDE OF A RIGHT TRIANGLE---");
            Console.WriteLine("Select What you Want to Do.");
            Console.WriteLine("0) Back to Previous Menu.");
            Console.WriteLine("1) Calculate the Hypotenuse.");
            Console.WriteLine("2) Calculate the Vertical Side");
            choice = AreNumbers();
            switch(choice){
                case 0:
                    return;
                case 1:
                    Hypotenuse();
                    break;
                case 2:
                    Vertical();
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }   

    private void Hypotenuse(){
        double hypotenuse, fVertical , sVertical;
        Console.WriteLine("\n---CALCULATE THE HYPOTENUSE---");
        while(true){
            Console.WriteLine("Enter the First Vertical Side.");
            fVertical = AreNumbers();
            if(fVertical>0){
                break;
            }
            else{
                Console.WriteLine("Invalid Input");
            }
                    
        }
        while(true){
            Console.WriteLine("Enter the Second Vertical Side.");
            sVertical = AreNumbers();
            if(sVertical>0){
                break;
            }
            else{
                Console.WriteLine("Invalid Input");
            }
        }
        hypotenuse = Math.Sqrt(fVertical*fVertical + sVertical*sVertical);
        Console.WriteLine($"The Hypotenuse is: {hypotenuse}.");
    }

    private void Vertical(){
        double hypotenuse, fVertical, sVertical;
        while(true){
            Console.WriteLine("\n---CALCULATE THE VERTICAL SIDE---");
            while(true){
                Console.WriteLine("Enter the Vertical Side.");
                sVertical = AreNumbers();
                if(sVertical>0){
                    break;
                }
                else{
                    Console.WriteLine("Invalid Input.");
                }
            }
            while(true){
                Console.WriteLine("Enter the Hypotenuse.");
                hypotenuse = AreNumbers();
                if(hypotenuse>0 && hypotenuse>sVertical){
                    break;
                }
                else{
                    Console.WriteLine("Invalid Input.The Hypotenuse Side Must be Bigger Than the Vertical Side");
                }
            }
            fVertical = Math.Sqrt(hypotenuse*hypotenuse - sVertical*sVertical);
            Console.WriteLine($"The Vertical Side is: {fVertical}.");
            return;
        }
    }

    private void QuadraticEquation(){
        double numA,numB,numC,discriminant;
        Console.WriteLine("\n---SOLUTION OF A QUADRATIC EQUATION---");
        Console.WriteLine("Enter Three numbers Corresponding to A, B and C of a Quadratic Equation");
        while(true){
            Console.WriteLine("Enter the Number A.");
            numA=AreNumbers();
            if(numA>=0){
                break;
            }
            else{
                Console.WriteLine("Invalid Number.");
            }
        }
        while(true){
            Console.WriteLine("Enter the Number B.");
            numB=AreNumbers();
            if(numB>=0){
                break;
            }
            else{
                Console.WriteLine("Invalid Number.");
            }
        }
        while(true){
            Console.WriteLine("Enter the Number C");
            numC=AreNumbers();
            if(numC>=0){
                break;
            }
            else{
                Console.WriteLine("Invalid Number");
            }
        }
        if(numA>0 && numB>0 && numC>0){
            discriminant=numB*numB-4*numA*numC;
        }
        else if(numA==0 || numC==0){
            discriminant=numB*numB;
        }
        else if(numB==0){
            discriminant=4*numA*numC;
        }
        else{
            discriminant=0;
        }
        Console.WriteLine($"The Discriminant is {discriminant}.");
    }

    public int AreNumbers(){
        int input;
        while(true){
            if(!int.TryParse(Console.ReadLine(), out input)){
                Console.WriteLine("Please Enter Only Numbers.");
            }
            else{
                return input;
            }
        }
    }
}