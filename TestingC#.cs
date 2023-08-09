using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
        
    class Program
        {
        Imp imp = new Imp();

        public static void Main(string[] args){
            Program program = new Program();

            Console.WriteLine("Program is running");

           // program.RunImp();

           // program.tupper();
            
           // program.exes();

           // program.DeleG();

           // program.Lamby();

           // program.linQ();

           program.waiter();
        }

        public void waiter(){
            
            int y = 0;
            int b = 0;
            int tt;

            var x = Task.Run(()=>{
                Thread.Sleep(800);
                y = 3;
            });
            var u = Task.Run(()=>{                
                b = 1;
            });

            tt = y + b;
            Console.WriteLine(tt); 

            Task.WaitAny(u);

            tt = y + b;
            Console.WriteLine(tt); 

            Task.WaitAll(x, u);
            
            tt = y + b;
            Console.WriteLine(tt);        

            var r = waitForMe();
            Console.WriteLine("Middle part");
            Task.WaitAny(r);
        }

        public async Task waitForMe(){

            Console.WriteLine("First part");
            await Task.Delay(200);
            Console.WriteLine("Last part");
        }
        public void linQ(){

            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var doubledNumbers = numbers.Select(n => n * 2);   // var doubledNumbers = from n in numbers select n * 2; sql                   

            Console.WriteLine(evenNumbers.ElementAt(0));
            Console.WriteLine(doubledNumbers.ElementAt(3));

            var listy = evenNumbers.ToList();

            Console.WriteLine(listy[0]);
        }

        public void Lamby(){

            var half = (int a) => 
            {
               return a/2;
            };

            var x = half(4);

            Console.WriteLine(x);
        }
        
        public void DeleG(){

            WriteMe wToT = TextDisplay;

            wToT("im being written");

            WriteMe second = new WriteMe(TextDisplay);
            
            WriteMe together = wToT + second;

            together("We are twice ");
        }
        public void TextDisplay(string text){
            Console.WriteLine(text);
        }
        public delegate void WriteMe(string text);

        public void exes(){

                int u = 0;
                string imNothing = null;
            try{

                // int y = 1 / u;
                string fun = imNothing.ToLower();
            }
            catch(DivideByZeroException d){
                Console.WriteLine(d);
            }
            catch(NullReferenceException n){
                Console.WriteLine(n);
            }            
            finally{
                Console.WriteLine("Its over");
            }

            Model m = new Model(1, "Bubby", true);

            Console.WriteLine(m.name);

            bool validated = Validate(m);

            Console.WriteLine(validated);
            
            Model m1 = new Model();

            bool validatedM1 = Validate(m1);

            Console.WriteLine(validatedM1);
        }

        public bool Validate(Model model){
        var results = new List<ValidationResult>();
        var context = new ValidationContext(model);

        return Validator.TryValidateObject(model, context, results, true);
        }
        public void tupper(){

            var tup = Tuple.Create("hej", 3, "gange");

            (string s, int x, string st) = tup;   

            Console.WriteLine($"{s} {x} {st}");

            Console.WriteLine(tup.Item1);

            var tasty = twice("banana", 3);

            Console.WriteLine(tasty.yam);

            Model m = new Model(1, "benny", true);

            var(y, nameDrop, whoKnowsWhat) = m;

            var(_, c) = tasty;

            Console.WriteLine($"{y} {nameDrop} {whoKnowsWhat} {c}");
        }

        public (string yam, int) twice(string yum, int number){
            
            return (yam: yum, number);
        }
        public void RunImp(){

            Object ob = new Model(3, "j", true);

            var impl = 2;

            imp.CheckingObjectIsStringOrInt(impl);
            
            imp.TypeOfCheck(impl);

            string? s = null;
            string showS = s ?? "im null";
            Console.WriteLine(showS);

            List<int>? nothingList = null;
            int count = nothingList?.Count ?? 0;
            Console.WriteLine(count);
            // Console.WriteLine(nothingList.Count);

            object pattern = 22.0;

            switch(pattern){
                case int imInt:
                Console.WriteLine(imInt);
                break;

                case string imString:
                Console.WriteLine(imString);
                break;

                default:
                Console.WriteLine("unknomn object");
                break;

            }
        }




    }

