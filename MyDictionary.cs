using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<P, C>
    {
        P[] Plate;
        C[] City;
        public MyDictionary()
        {
            Plate = new P[0];
            City = new C[0];
        }
        public void Add(P item1, C item2)
        {
            P[] tempKeyArray =  Plate;
            Plate = new P[Plate.Length + 1];

            C[] tempValueArray = City;
            City = new C[City.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                Plate[i] = tempKeyArray[i];
                City[i] = tempValueArray[i];
            }
            Plate[Plate.Length - 1] = item1;
            City[City.Length - 1] = item2;

        }
        public void List()
        {
            for (int i = 0; i < Plate.Length; i++)
            {
                Console.WriteLine(Plate[i] + " is " + City[i]); ;
            }
        }
    } }
