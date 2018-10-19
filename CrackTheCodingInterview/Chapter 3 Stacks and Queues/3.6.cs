using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{

    //    Animal Shelter: An animal shelter, which holds only dogs and cats, operates on a strictly"first in, first
    //out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter,
    //or they can select whether they would prefer a dog or a cat(and will receive the oldest animal of
    //that type). They cannot select which specific animal they would like.Create the data structures to
    //maintain this system and implement operations such as enqueue, dequeueAny, dequeueDog,
    //and dequeueCat. You may use the built-in Linkedlist data structure.
    public class QueueForAS
    {
        LinkedList<Dog> dogs;
        LinkedList<Cat> cats;
        int order; 

        public QueueForAS()
        {
            dogs = new LinkedList<Dog>();
            cats = new LinkedList<Cat>();
            order = 0;
        }

        public void Enqueue(Animal a)
        {
            a.SetOrder(order);

            if(a is Dog)
            {
                dogs.AddLast((Dog)a);
            }
            else if(a is Cat)
            {
                cats.AddLast((Cat)a);
            }

            order++;
        }


        public Animal DequeueAny()
        {
            if(cats.First == null)
            {
                return DequeueDog();
            }else if(dogs.First == null)
            {
                return DequeueCat();
            }

            if(dogs.First.Value._order <= cats.First.Value._order)
            {
                return DequeueDog();
            }
            else
            {
                return DequeueCat();
            }
        }

        public Animal DequeueDog()
        {
            return dogs.First.Value;
        }

        public Animal DequeueCat()
        {
            return cats.First.Value;
        }
    }

    public abstract class Animal
    {
        public int _order;

        public void SetOrder(int order)
        {
            _order = order;
        }
    }

    public class Dog : Animal
    {
    }

    public class Cat : Animal
    {
    }

}
