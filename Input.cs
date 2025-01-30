using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PorkerGame {
    internal class Input {
        private int[] cardNum;

        public Input() {
            cardNum = new int[4];
        }

        public void inputCardNum() {
            for (int i = 0; i < 4; i++) {
                while (true) {
                    Console.Write($"{i + 1}番目のカードを入力してください > ");

                    string input = Console.ReadLine();

                    bool result = int.TryParse(input, out this.cardNum[i]);

                    if (result) {
                        if(1 <=cardNum[i] && cardNum[i] <= 4) {
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
    }
}
