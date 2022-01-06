using System;

namespace EditorDeHtml{
    public static class Menu{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());

            HandleOption(option);
        }

        public static void DrawScreen(){
            Console.Write("+");
            for (int i = 0; i <= 35;i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int lines = 0 ; lines <= 10 ; lines ++){
                Console.Write("|");
                for(int i = 0 ; i <= 35; i++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for(int i = 0; i <= 35; i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOption(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor de HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione um opção abaixo:");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - NOVO ARQUIVO");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2 - ABRIR ");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("0- SAIR ");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("Faça sua escolha: ");
            Console.SetCursorPosition(3,9);
            Console.Write("Opção: ");
        }

        public static void HandleOption(short option){
            switch(option){
                case 1 : Editor.Show();break;
                case 2 : Viewer.Show("");break;
                case 0 : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default : Show();break;
            }
        }
    }
}