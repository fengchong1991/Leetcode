using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _950_Reveal_Cards_In_Increasing_Order
    {

        // Running time: O(NLogN), sorting
        // Space: O(N), need to create a queue to store index
        public int[] DeckRevealedIncreasing(int[] deck)
        {

            Array.Sort(deck);

            var result = new int[deck.Length];

            var indexQueue = new Queue<int>();

            for (var i = 0; i < deck.Length; i++)
            {
                indexQueue.Enqueue(i);
            }

            foreach (var card in deck)
            {
                result[indexQueue.Dequeue()] = card;

                if (indexQueue.Count > 0)
                {
                    indexQueue.Enqueue(indexQueue.Dequeue());
                }
            }

            return result;
        }
    }
}
