using System;
using System.Collections.Generic;
namespace kuyruk
{
    public class Kuyruk<T>
    {
        private Queue<T> gonderiler;

        public Kuyruk()
        {
            gonderiler = new Queue<T>();
        }

        public void Ekle(T postId)
        {
            gonderiler.Enqueue(postId); 
        }

        public T Cikar()
        {
            if (BosMu())
                throw new InvalidOperationException("Gönderi yüklenemedi.");

            return gonderiler.Dequeue(); 
        }

        public T Gozat()
        {
            if (BosMu())
                throw new InvalidOperationException("Gönderi yüklenemedi.");

            return gonderiler.Peek();    
        }

        public bool BosMu()
        {
            return gonderiler.Count == 0;
        }

        public int Uzunluk()
        {
            return gonderiler.Count;
        }
    }
}