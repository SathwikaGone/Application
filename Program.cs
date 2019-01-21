using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            var avg=0.0;
          //  var p=false;
            var c='c';
           // var gpa=0.0;
            var scholarship=0.0m;
            var TotalFee=5000;
            Console.WriteLine("Enter your Name \n");
            var name=Console.ReadLine();
            while(name==""){
              Console.WriteLine("Enter your Name \n");
            name=Console.ReadLine();
                }
            Console.WriteLine("Enter your marks:\n");

            Console.WriteLine("Maths:");
            var m=Console.ReadLine();
            var maths= Convert.ToDouble(m);

            Console.WriteLine("physics:");
            var p=Console.ReadLine();
            var physics= Convert.ToDouble(p);

            Console.WriteLine("Chemistry:");
            var ch=Console.ReadLine();
            var chemistry= Convert.ToDouble(ch);

             avg=((maths+physics+chemistry)/300)*100;
            Console.WriteLine($"Your persentage is {avg}.");

            // Console.WriteLine("Enter your gpa:");
            // var g=Console.ReadLine();
            // gpa =Convert.ToDouble(g);

            if(avg >=70.0){
                Console.WriteLine("Congratulations, you are eligible for scholarship \n");

                 if(avg >=70.0 && avg <79.9){
                c='c';
                }
                if(avg >=80.0 && avg <89.9){
                c='b';
                }
                if(avg >=90 && avg <=100){
                c='a';
                }
                switch(c){
                    case 'c':
                        Console.WriteLine("You will get the scholarship of $1000.\n");
                        scholarship=Convert.ToDecimal(TotalFee-(TotalFee*0.2));
                        Console.WriteLine($"{name}, Total amount to be paid: ${scholarship}.\n");
                        break;
                
                    case 'b':
                        Console.WriteLine("You will get the scholarship of $1500.");
                        scholarship=Convert.ToDecimal(TotalFee-(TotalFee*0.3));
                        Console.WriteLine($"{name}, amount to be paid: ${scholarship}.\n");
                        break;
                
                    case 'a':
                        Console.WriteLine("You will get the scholarship of $2000.");
                        scholarship=Convert.ToDecimal(TotalFee-(TotalFee*0.5));
                        Console.WriteLine($"{name}, amount to be paid: ${scholarship}.\n");
                        break;
                        }        
            }
            else{
                Console.WriteLine("Sorry, you are not eligible for scholarship \n");
            }
              

          
        }
    }
}
