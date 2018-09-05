using System;

 class Clock
{
   static void Main()
   {
      while(true)
      {
         int hours;

         do
         {
             Console.Write("Enter hours (0 to 24) : ");
             hours = int.Parse(Console.ReadLine());
         }
         while (hours < 0 || hours > 24);

         if (hours > 11) hours -= 12;

         int mins;

         do
         {
             Console.Write("Enter minutes (0 to 60) : ");
             mins = int.Parse(Console.ReadLine());
         }
         while (mins < 0 || mins > 60);

         double hDegrees = (hours * 30) + (mins * 30 / 60);
         double mDegrees = mins * 6;
         double diff  = Math.Abs(hDegrees - mDegrees);
         if (diff > 180) diff = 360 - diff;
         Console.WriteLine("The angle between the hands is {0} degrees", diff);
      }
   }
}
