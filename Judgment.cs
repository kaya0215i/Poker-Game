using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorkerGame {
    internal class Judgment {

        int[] num;

        public Judgment(int num1, int num2, int num3, int num4) {
            num = new int[4];
            
            num[0] = num1;
            num[1] = num2;
            num[2] = num3;
            num[3] = num4;
        }

        public void CardNumJudgment() {
            if (FourCard()) {
                Console.WriteLine("フォーカード!!");
                return;
            }
            if (ThreeCard()) {
                Console.WriteLine("スリーカード!!");
                return;
            }
            if (TwoPairs()) {
                Console.WriteLine("ツーペア!!");
                return;
            }
            if (OnePairs()) {
                Console.WriteLine("ワンペア!!");
                return;
            }
            Console.WriteLine("ノーペア");
            return;
        }

        private bool FourCard() {
            if ((num[0] == num[1]) && (num[0] == num[2]) && (num[0] == num[3])) {
                return true;
            }
            return false;
        }

        private bool ThreeCard() {
            int nPoint = 0;

            for(int i = 0; i < 4; i++) {
                nPoint = 0;
                for(int n = 0; n < 4; n++) {
                    if(num[i] == num[n]) {
                        nPoint++;
                    }
                }

                if(nPoint == 3) {
                    return true;
                }
            }
             return false;
        }

        private bool TwoPairs() {
            int nPoint = 0;
            int[] usedNum = new int[2];

            for (int i = 0; i < 4; i++) {
                if (num[i] == usedNum[0] || num[i] == usedNum[1]) {
                    continue;
                }

                for (int n = 0; n < 4; n++) {
                    if(i == n) {
                        continue;
                    }
                    if (num[i] == num[n]) {
                        nPoint++;

                        if (usedNum[0] == 0) {
                            usedNum[0] = num[i];
                        }
                        else {
                            usedNum[1] = num[i];
                        }
                        break;
                    }
                }

                if (nPoint == 2) {
                    return true;
                }
            }
            return false;
        }

        private bool OnePairs() {
            int nPoint = 0;
            int usedNum = 0;

            for (int i = 0; i < 4; i++) {
                if (num[i] == usedNum) {
                    continue;
                }

                for (int n = 0; n < 4; n++) {
                    if (i == n) {
                        continue;
                    }
                    if (num[i] == num[n]) {
                        nPoint++;

                        if (usedNum == 0) {
                            usedNum = num[i];
                        }
                        break;
                    }
                }

                if (nPoint == 1) {
                    return true;
                }
            }
            return false;
        }
    }
}
