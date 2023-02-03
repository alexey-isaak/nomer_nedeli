using System;
 
namespace nomer_dnya_nedeli
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер дня недели: ");
            int dayindex = int.Parse(Console.ReadLine());
             
    switch ( dayindex ) {
        
        case 6 :
            Console.WriteLine( "Выходной (Суббота)" );
            break;
        case 7 :
            Console.WriteLine( "Выходной (Воскресенье)" );
            break;
        default :
            Console.WriteLine( "Будний день." );
            break;
      
        }
    }
}
}

