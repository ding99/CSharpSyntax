using System;

namespace cGeneric {
    public class CheckBase {

        public class GenericArray<T> {
            private T[] array;

            public GenericArray(int size) {
                array = new T[size + 1];
            }

            public T getItem(int index) {
                return array[index];
            }

            public void setItem(int index, T value) {
                array[index] = value;
            }

        }

        public void testbase() {
            int n = 5;
            #region integer
            GenericArray<int> intArray = new GenericArray<int>(n);
            for(int i = 0; i < n; i++)
                intArray.setItem(i, i * n);
            for(int i = 0; i < n; i++)
                Console.Write(intArray.getItem(i) + " ");
            Console.WriteLine();
            #endregion

            #region character
            GenericArray<char> charArray = new GenericArray<char>(n);
            for(int i = 0; i < n; i++)
                charArray.setItem(i, (char)(i + 97));
            for(int i = 0; i < n; i++)
                Console.Write(charArray.getItem(i) + " ");
            Console.WriteLine();
            #endregion
        }
    }
}
