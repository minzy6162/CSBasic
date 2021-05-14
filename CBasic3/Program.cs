using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i< 1000; i++)
            {
                Console.WriteLine("출력");
            }*/

            /*//배열을 생성합니다.
            int[] intArray = { 52, 273, 32, 65, 103 };

            //배열의 길이를 출력합니다.
            Console.WriteLine(intArray.Length);*/



            /* //배열을 생성합니다.
             int[] intArray1 = new int[100];

             //배열의 처음과 마지막 요소를 출력합니다.
             Console.WriteLine(intArray1[0]);
             Console.WriteLine(intArray1[99]);*/

            //무한루프
            /*while (true)
            {
                Console.WriteLine("무한 반복");
            }*/


            /*//변수를 선언합니다.
            int i = 0;

            //반복문을 수행합니다.
            while (i < intArray.Length)
            {
                //출력합니다.
                Console.WriteLine(i + "번재 출력: " + intArray[i]);

                //탈출을 위해 변수를 더합니다.
                i++;
            }*/




            /*//do while반목문 활용하기
            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료):");
                input = Console.ReadLine();
            } while (input != "exit");*/







            /*//*for문으로 덧셈하기
            //변수를 선언합니다.
            int output = 0;

            //반복문을 수행합니다.
            for(int j =0;j<=100; j++)
            {
                output += 1;
            }

            //출력합니다.
            Console.WriteLine(output);*/






            /*//*시간을 사용한 반복문 이탈
            long start = DateTime.Now.Ticks;
            long count = 0;

            //반복을 수행합니다: 1000000Tick = 1초
            while(start +(1000000)> DateTime.Now.Ticks)
            {
                count++;
            }

            //출력합니다.
            Console.WriteLine(count + "만큼 반복했습니다.");*/




            /*//*역 for반복문
            int[] intArray2 = { 1, 2, 3, 4, 5, 6};

            //요소의 길이를 출력합니다.
            for(int k = intArray2.Length - 1; i>=0; i--)
            {
                Console.WriteLine(intArray2[i]);
            }*/



            /* //*foreach 반복문과 배열
             //변수를 선언합니다.
             string[] array = { "사과", "배", "포토", "딸기", "바나나" };

             //변수를 수행합니다.
             foreach(string item in array)
             {
                 //출력합니다.
                 Console.WriteLine(item);
             }*/










            //별 피라미드

            /* for(int i = 0; i<10; i++)
             {
                 for (int j = 0; j < i + 1; j++)
                     Console.Write("*");
                 Console.Write("\n");
             }*/



            /*for(int i = 0; i<10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }*/



            /*//goto키워드
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("외부 반복문");
                for(int j = 0; j<10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }
         doNotUse;
            Console.WriteLine("goto 키워드");*/












            /* //*continue 키워드
             for(int i = 0; i<10; i++)
             {
                 if (i % 2 == 0)
                 {
                     continue;
                 }
                 Console.WriteLine(i);
             }*/







            /*//*대문자와 소문자 올바른 예
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());*/











            /*//문자열 자르기
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }*/



            //*콘솔 제어 메서드
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }
    }
}
