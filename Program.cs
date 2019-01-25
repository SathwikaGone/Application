using System;

namespace application
{
   
    class Program
    {
      public static decimal fee(double p){
                            decimal scholarship=Convert.ToDecimal(5000-((5000*p)/100));
                            return scholarship;
                }
        static void Main(string[] args)
        {
            
            var avg=0.0;
            var c='c';
            var p=0;
            var QUIT = false;
            var name="";
            var scholarship=0.0m;
            Console.WriteLine(" Welcome to CHECK SCHOLARSHIP application");


           do{
            Console.WriteLine("Enter your Name \n");
            name=Console.ReadLine();
            while(name==""){
              Console.WriteLine("Enter your Name \n");
            name=Console.ReadLine();
                }
            Console.WriteLine($"Hello {name} ");
            Console.WriteLine("Enter your marks(0-100):\n");

            Console.WriteLine("Maths:");
            var ma=Console.ReadLine();
            var maths= Convert.ToDouble(ma);

            Console.WriteLine("physics:");
            var ph=Console.ReadLine();
            var physics= Convert.ToDouble(ph);

            Console.WriteLine("Chemistry:");
            var ch=Console.ReadLine();
            var chemistry= Convert.ToDouble(ch);

             avg=((maths+physics+chemistry)/300)*100;
            Console.WriteLine($"\nYour persentage is {avg}.\n");
            if(avg >=90 && avg <=100){
                c='a';
                }
                    else if(avg >=80.0 && avg <89.9){
                c='b';
                }
                 else if(avg >=70.0 && avg <79.9){
                c='c';
                }
                  else if(avg>=0 && avg <70){
                    c='d';
                }
               else if(avg >100 && avg <0){
                    c='e';
                }
               
                switch(c){
                    case 'a':
                        Console.WriteLine("Congratulations, you are eligible for scholarship \n");
                        Console.WriteLine("You will get the scholarship of $2000.");
                        p=50;
                        scholarship = Program.fee(p);
                        Console.WriteLine($"{name},The total amount to be paid: ${scholarship}.\n");
                        break;
                    
                
                    case 'b':
                        Console.WriteLine("Congratulations, you are eligible for scholarship \n");
                        Console.WriteLine("You will get the scholarship of $1500.");
                        p=30;
                        scholarship = Program.fee(p);
                        Console.WriteLine($"{name},The total amount to be paid: ${scholarship}.\n");
                        break;
                
                    case 'c':
                        Console.WriteLine("Congratulations, you are eligible for scholarship \n");
                        Console.WriteLine("You will get the scholarship of $1000.\n");
                        p=20;
                       scholarship = Program.fee(p);
                        Console.WriteLine($"{name},The total amount to be paid: ${scholarship}.\n");
                        break;

                     case 'd':
                         p=0;
                         scholarship = Program.fee(p);
                        Console.WriteLine($"Sorry, you are not eligible for scholarship \n{name}, You need to pay ${scholarship}.\n");
                        break;
            
                    case 'e':
                        Console.WriteLine("Enter CORRECT MARKS"); 
                        break; 
            
           }
             Console.WriteLine(" Do you want to continue \n 1. If yes, press y\n 2. press any key to exit:\n ");
             var q=Console.ReadLine(); 
             var l =Convert.ToChar(q);
         if(l=='y'){
             QUIT=false;
         }else{
             Console.WriteLine("Have a nice day :)");
             QUIT=true;
         }
            }while(QUIT==false);
        }
    }
}
