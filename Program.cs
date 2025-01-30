using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorkerGame {
    internal class Program {
        static void Main(string[] args) {
            Input input;
            Judgment judgment;

            while (true) {
                input = new Input();
                input.InputCardNum();

                judgment = new Judgment(input.OutPutCardNum(0),
                                        input.OutPutCardNum(1),
                                        input.OutPutCardNum(2),
                                        input.OutPutCardNum(3));
                judgment.CardNumJudgment();
            }
        }
    }
}
