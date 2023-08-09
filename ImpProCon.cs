using System;

class Imp{
    public void CheckingObjectIsStringOrInt(Object o){

        if(o is string){
            Console.WriteLine("The object is a string saying: " + o);
        }else if(o is int){
             Console.WriteLine("The object is an int with value: " + o);
        }
        else{
            Console.WriteLine("The object is not a string or an int.");
        }
    }

    public void TypeOfCheck(Object o){

        Console.WriteLine($"The object is of this type: {o.GetType()}");

    }


}