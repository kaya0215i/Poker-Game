using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PorkerGame {
    internal class Input {
        private int[] cardNum;
        private int maxNum = 13;

        public Input() {
            cardNum = new int[maxNum];
        }

        public void SelectInputType() {
            while (true) {
                Console.WriteLine("カードの選定方法を選択してください (1:自分で入力, 2:ランダムで生成)");

                string input = Console.ReadLine();

                if (input == "1") {
                    InputCardNum();
                    break;
                }
                else if (input == "2") {
                    RandomCardSelect();
                    break;
                }
                else {
                    Console.WriteLine("正しい値を入力してください");
                }
            }
        }

        public void InputCardNum() {
            for (int i = 0; i < 4; i++) {
                while (true) {
                    Console.Write($"{i + 1}番目のカードを入力してください > ");

                    string input = Console.ReadLine();

                    bool result = int.TryParse(input, out this.cardNum[i]);

                    if (result) {
                        if(1 <=cardNum[i] && cardNum[i] <= maxNum) {
                            break;
                        }
                        else {
                            Console.WriteLine("正しい値を入力してください");
                        }
                    }
                    else {
                        Console.WriteLine("正しい値を入力してください");
                    }
                }
            }
        }

        public void RandomCardSelect() {
            Random rnd = new Random();

            Console.WriteLine("カードをランダムに生成します");

            Console.ReadLine();

            for (int i = 0; i < 4; i++) {
                cardNum[i] = rnd.Next(1, 14);
                Console.WriteLine($"{i + 1}番目のカード > {cardNum[i]}");
            }

            Console.ReadLine();
        }

        public int OutPutCardNum(int num) {
            return cardNum[num];
        }

        public bool IsEndGame() {
            while (true) {
                Console.WriteLine("もう一度遊びますか？(y:はい, n:いいえ)");

                string input = Console.ReadLine();

                if (input == "y") {
                    return false;
                }
                else if (input == "n") {
                    return true;
                }
                else {
                    Console.WriteLine("正しい値を入力してください");
                }
            }
        }
    }
}
