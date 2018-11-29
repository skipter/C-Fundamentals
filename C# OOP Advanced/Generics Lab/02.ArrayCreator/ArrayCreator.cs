namespace GenericArrayCreator
{
    using System.Collections.Generic;

    public class ArrayCreator
    {   
        //Its a generic method "Create<T>" , else we can use ArrayCreator<T> class, but we need to set them also in 
        //StartUp class to work properly.
        public static T[] Create<T>(int lenght, T item)
        {   
            T[] array = new T[lenght];

            for (int index = 0; index < lenght; index++)
            {
                array[index] = item;
            }

            return array;
        }
    }
}
