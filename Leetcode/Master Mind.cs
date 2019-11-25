using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //    Master Mind: The G ame of Master Mind is played as follows:
    //The computer has four slots, and each slot will contain a ball that is red(R), yellow(Y), green(G) or
    //blue(B). For example, the computer might have RGGB(Slot #1 is red, Slots #2 and #3 are green, Slot
    //#4 is blue).
    //You, the user, are trying to guess the solution. You might, for example, guess YRGB.
    //When you guess the correct color for the correct slot, you get a "hit:' If you guess a color that exists
    //but is in the wrong slot, you get a "pseudo-hit:' Note that a slot that is a hit can never count as a
    //pseudo-hit.
    //For example, if the actual solution is RGBY and you guess GGRR , you have one hit and one pseudohit
    //Write a method that, given a guess and a solution, returns the number of hits and pseudo-hits.

    class Master_Mind
    {

        public Tuple<int, int> CalculateHit(string anwser, string guess)
        {

            var hit = 0;
            var pseudoHit = 0;

            var frequency = new Dictionary<char, int>();

            for (var i = 0; i < anwser.Length; i++)
            {
                if (frequency.ContainsKey(anwser[i]))
                {
                    frequency[anwser[i]]++;
                }
                else
                {
                    frequency.Add(anwser[i], 1);
                }
            }

            for (var i = 0; i < guess.Length; i++)
            {
                if (guess[i] == anwser[i])
                {
                    hit++;

                    if (anwser[guess[i]] > 1)
                    {
                        frequency[guess[i]]--;
                    }
                    else
                    {
                        frequency.Remove(guess[i]);
                    }
                }
                else if (frequency.ContainsKey(guess[i]))
                {
                    pseudoHit++;
                    if (frequency[guess[i]] > 1)
                    {
                        frequency[guess[i]]--;
                    }
                    else
                    {
                        frequency.Remove(guess[i]);
                    }
                }
            }

            return new Tuple<int, int>(hit, pseudoHit);
        }
    }
}
