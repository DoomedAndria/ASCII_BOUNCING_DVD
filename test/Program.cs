using System;

namespace test
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int width = 200;
            int height = 40;
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height);

            DVD dvd = new DVD(width, height);
            
            while (true)
            {
                Console.Clear();
                dvd.draw();
                dvd.update();
                System.Threading.Thread.Sleep(50);
            }
        }
    }
    class DVD
    {
        String str = @"      %%%%%%%%%%%%%%%%%%%%%#          &%%%%%%%%%%%%(        
     &&&%&&&&&&&%&&&&&&&%&&&.       &&&&%&&&&&&&%&&&&&&&%&% 
    (&&&%&       &&&%&& %&&&%     &&%&&& &&&%&&       &&%&&&
    &&&&%&       &&&&&&  &&&&&  #&&&&&   &&&&&        &&%&&&
   &%&%&%      (%&%&%&    %&%&%&%&%%    %&%&%&      &&%&%&# 
   &&&&&%&&&&&&&%&&       .&&&&&%*     (%&&&&&&&%&&&&&&(    
                           (%&&                             
                            &                               
    .%&%%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%/#%%%%%%%&/       
 &&&&&&&%&&&& ( &&&&  &&% .&% &&%   #&&. &&&  &&%&&&&&&&&   
        .#&&%&&&%&&&%&&&%&&&%&&&%&&&%&&&%&&&%&&&* ";

        int width = 60;
        int height = 11;
        int x = 0;
        int y = 0;
        int speed_x = 2;
        int speed_y = -1;
        int border_x;
        int border_y;

        public DVD(int border_x, int border_y)
        {
            this.border_x = border_x;
            this.border_y = border_y;
        }
        public void draw()
        {
            string[] lines = str.Split(
                new string[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            for(int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(lines[i]);
            }
                
        }
        public void update()
        {
            if (x+speed_x <=0 || x + speed_x >= border_x-width)
            {
                speed_x *= -1;
            }
            else
            {
                x += speed_x;
            }
            if (y + speed_y <= 0 || y + speed_y >= border_y-height)
            {
                speed_y *= -1;
            }
            else
            {
                y += speed_y;
            }
        }
    }

}
