using System;

namespace application
{
   
    class Program
    {
      public decimal fee(double p){
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

            if(avg >=70.0 && avg <= 100){
                Console.WriteLine("Congratulations, you are eligible for scholarship \n");

                 if(avg >=70.0 && avg <79.9){
                c='a';
                }
                if(avg >=80.0 && avg <89.9){
                c='b';
                }
                if(avg >=90 && avg <=100){
                c='c';
                if(avg >100 && avg <0){
                    c='d';
                }
                }
               Program Z= new Program();
                switch(c){
                    case 'c':
                        Console.WriteLine("You will get the scholarship of $1000.\n");
                        p=20;
                        scholarship = Z.fee(p);
                        Console.WriteLine($"{name},The total amount to be paid: ${scholarship}.\n");
                           
                        
                        break;
                
                    case 'b':
                        Console.WriteLine("You will get the scholarship of $1500.");
                        p=30;
                        Console.WriteLine($"{name},The total amount to be paid: ${Z.fee(p)}.\n");
                          
                            
                        break;
                
                    case 'a':
                        Console.WriteLine("You will get the scholarship of $2000.");
                        p=50;
                        Console.WriteLine($"{name},The total amount to be paid: ${Z.fee(p)}.\n");
                        break;
                    
                        }        
            }
            else if(avg < 70){
                Console.WriteLine("Sorry, you are not eligible for scholarship \n");
            }
            else{
               Console.WriteLine("Enter CORRECT MARKS");  
            }
             Console.WriteLine(" Do you want to continue \n 1. If yes, press y\n 2. press any key to exit:\n ");
             var q=Console.ReadLine(); 
             var l =Convert.ToChar(q);
         if(l=='y'){
             QUIT=false;
         }else{
             QUIT=true;
         }
            }while(QUIT==false);
        }
    }
}
